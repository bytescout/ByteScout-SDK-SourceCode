//*******************************************************************
//       ByteScout PDF Renderer SDK		                                     
//                                                                   
//       Copyright © 2016 ByteScout - http://www.bytescout.com       
//       ALL RIGHTS RESERVED                                         
//                                                                   
//*******************************************************************

using System;
using System.Drawing;
using System.Drawing.Imaging;
using System.IO;
using System.Runtime.InteropServices;

namespace PDF2BMP
{
	public class OneBitImageConverter
	{
		public static void ConvertTo1BitBayerOrderedDithering(ref Bitmap image)
		{
			float hRes = image.HorizontalResolution;
			float vRes = image.VerticalResolution;

			ConvertToGrayScale(ref image);

			Bitmap bw = new Bitmap(image.Width, image.Height, PixelFormat.Format1bppIndexed);
			bw.SetResolution(hRes, vRes);

			BitmapData orig = image.LockBits(new Rectangle(0, 0, image.Width, image.Height), ImageLockMode.ReadOnly, image.PixelFormat);
			BitmapData dest = bw.LockBits(new Rectangle(0, 0, bw.Width, bw.Height), ImageLockMode.ReadWrite, PixelFormat.Format1bppIndexed);

			int bytes = Image.GetPixelFormatSize(image.PixelFormat) / 8;
			const int order = 4;

			//create Bayer matrix
			const int size = (1 << (2 * order));
			byte[] Bmatrix = new byte[size];

			for (int i = 0; i < size; i++)
			{
				int n = order;
				int x = i / n;
				int y = i % n;
				int dither = 0;

				while (n-- > 0)
				{
					dither = (((dither << 1) | ((x & 1) ^ (y & 1))) << 1) | (y & 1);
					x >>= 1;
					y >>= 1;
				}

				Bmatrix[i] = (byte) dither;
			}

			int height = orig.Height;
			int width = orig.Width;
			int o_stride = orig.Stride;
			IntPtr o_scan0 = orig.Scan0;
			int d_stride = dest.Stride;
			IntPtr d_scan0 = dest.Scan0;

			int scale = Math.Max(0, (8 - 2 * order));
			int level;

 			for (int y = 0; y < height; y++)
 			{
 				for (int x = 0; x < width; x++)
 				{
 					level = Marshal.ReadByte(o_scan0, y * o_stride + x * bytes) >> scale;
 
 					if (level > Bmatrix[(x % order) + order * (y % order)])
 					{
 						SetIndexedPixel(dest, x, y, true);
 					}
 					else
 					{
 						//SetIndexedPixel(dest, x, y, false);
 					}
 				}
 			}

			//unsafe (faster) version
//			unsafe
//			{
//				byte* origByte = (byte*) (void*) o_scan0;
//				int origOffset = o_stride - width * bytes;
//				byte* destStart = (byte*) (void*) d_scan0;
//				byte* destByte = null;
//				Byte mask;
//
//				for (int y = 0; y < height; ++y)
//				{
//					for (int x = 0; x < width; ++x)
//					{
//						level = *origByte >> scale;
//
//						if (level > Bmatrix[(x % order) + order * (y % order)])
//						{
//							mask = (Byte) (0x80 >> (x & 0x7));
//							destByte = destStart + y * d_stride + (x >> 3);
//							*destByte |= mask;
//						}
//
//						origByte += bytes;
//					}
//
//					origByte += origOffset;
//				}
//			}


			bw.UnlockBits(dest);
			image.UnlockBits(orig);

			image.Dispose();
			image = bw;
		}

		public static void ConvertTo1BitRough(ref Bitmap image)
		{
			float hRes = image.HorizontalResolution;
			float vRes = image.VerticalResolution;

			Bitmap bw = new Bitmap(image.Width, image.Height, PixelFormat.Format1bppIndexed);
			bw.SetResolution(hRes, vRes);

			BitmapData orig = image.LockBits(new Rectangle(0, 0, image.Width, image.Height), ImageLockMode.ReadOnly, image.PixelFormat);
			BitmapData dest = bw.LockBits(new Rectangle(0, 0, bw.Width, bw.Height), ImageLockMode.ReadWrite, PixelFormat.Format1bppIndexed);

			const float luminance = 0.8f;

			int bytes = Image.GetPixelFormatSize(image.PixelFormat) / 8;

			for (int y = 0; y < image.Height; y++)
			{
				for (int x = 0; x < image.Width; x++)
				{
					int index = y * orig.Stride + x * bytes;

					if (Color.FromArgb(Marshal.ReadByte(orig.Scan0, index + 2),
									   Marshal.ReadByte(orig.Scan0, index + 1),
									   Marshal.ReadByte(orig.Scan0, index)).GetBrightness() > luminance)
					{
						SetIndexedPixel(dest, x, y, true);
					}
				}
			}

			bw.UnlockBits(dest);
			image.UnlockBits(orig);

			image.Dispose();
			image = bw;
		}

		public static void ConvertTo1BitOrderedDithering4x4(ref Bitmap image)
		{
			float hRes = image.HorizontalResolution;
			float vRes = image.VerticalResolution;

			ConvertToGrayScale(ref image);

			Bitmap bw = new Bitmap(image.Width, image.Height, PixelFormat.Format1bppIndexed);
			bw.SetResolution(hRes, vRes);

			BitmapData orig = image.LockBits(new Rectangle(0, 0, image.Width, image.Height), ImageLockMode.ReadOnly, image.PixelFormat);
			BitmapData dest = bw.LockBits(new Rectangle(0, 0, bw.Width, bw.Height), ImageLockMode.ReadWrite, PixelFormat.Format1bppIndexed);

			int bytes = Image.GetPixelFormatSize(image.PixelFormat) / 8;

			const int dth_NumRows = 4;
			const int dth_NumCols = 4;
			const int dth_MaxIntensityVal = 255;
			const int dth_NumIntensityLevels = 2;
			int[,] DitherMatrix = new int[dth_NumRows, dth_NumCols] { { 0, 8, 2, 10 }, { 12, 4, 14, 6 }, { 3, 11, 1, 9 }, { 15, 7, 13, 5 } };
			int[] Intensity = new int[dth_NumIntensityLevels] { 0, 1 }; // 2 LEVELS B/W
			int DitherValue;

			for (int y = 0; y < image.Height; y++)
			{
				for (int x = 0; x < image.Width; x++)
				{
					int DeviceIntensity = Marshal.ReadByte(orig.Scan0, y * orig.Stride + x * bytes);
					int DitherIntensity = DeviceIntensity * (dth_NumRows * dth_NumCols * (dth_NumIntensityLevels - 1)) / dth_MaxIntensityVal;
					int DitherMatrixIntensity = DitherIntensity % (dth_NumRows * dth_NumCols);
					int Offset = DitherIntensity / (dth_NumRows * dth_NumCols);

					if (DitherMatrix[y & (dth_NumRows - 1), x & (dth_NumCols - 1)] < DitherMatrixIntensity)
					{
						DitherValue = Intensity[1 + Offset];
					}
					else
					{
						DitherValue = Intensity[0 + Offset];
					}

					if (DitherValue > 0)
					{
						SetIndexedPixel(dest, x, y, true);
					}
				}
			}

			bw.UnlockBits(dest);
			image.UnlockBits(orig);

			image.Dispose();
			image = bw;
		}

		public static void ConvertToGrayScale(ref Bitmap image)
		{
			float hRes = image.HorizontalResolution;
			float vRes = image.VerticalResolution;

			int bytesCount = 3 * image.Width * image.Height;

			if (bytesCount < 50000000) // the file is not too big, use memory routine
			{
				// get image pixels:

				byte[] pixels = new Byte[bytesCount];

				for (int y = 0, count = 0; y < image.Height; y++)
				{
					for (int x = 0; x < image.Width; x++)
					{
						Color color = image.GetPixel(x, y);
						pixels[count] = color.R;
						count++;
						pixels[count] = color.G;
						count++;
						pixels[count] = color.B;
						count++;
					}
				}

				// create gray palette

				// Since it's impossible to create new ColorPalette object, we'll create temporary bitmap
				// and store the reference to it's palette. After image disposed, we still have the reference 
				// to the write-enabled ColorPalette object.
				Bitmap temp = new Bitmap(1, 1, PixelFormat.Format8bppIndexed);
				ColorPalette grayPalette = temp.Palette;
				temp.Dispose();

				for (int i = 0; i < 256; i++)
				{
					grayPalette.Entries[i] = Color.FromArgb(255, i, i, i);
				}

				// quantize image colors:

				int nPix = bytesCount / 3;
				byte[] indexedPixels = new byte[nPix];

				// create indexed bitmap pixels buffer
				for (int i = 0, k = 0; i < nPix; i++)
				{
					int index = (((pixels[k++] & 0xff) * 117 + (pixels[k++] & 0xff) * 601 + (pixels[k++] & 0xff) * 306) >> 10);
					indexedPixels[i] = (byte) index;
				}

				pixels = null;

				Bitmap grayImage = new Bitmap(image.Width, image.Height, PixelFormat.Format8bppIndexed);

				// assign new palette to the destination bitmap
				grayImage.Palette = grayPalette;

				// write indexed bitmap data to the destination bitmap:

				BitmapData data = grayImage.LockBits(new Rectangle(0, 0, image.Width, image.Height), ImageLockMode.WriteOnly, PixelFormat.Format8bppIndexed);
				int addrStart = data.Scan0.ToInt32();

				for (int i = 0; i < image.Height; i++)
				{
					IntPtr realByteAddr = new IntPtr(addrStart + Convert.ToInt32(i * data.Stride));
					Marshal.Copy(indexedPixels, i * image.Width, realByteAddr, image.Width);
				}

				grayImage.UnlockBits(data);

				// set original resolution
				grayImage.SetResolution(hRes, vRes);

				// replace the source image with new quantized bitmap
				image.Dispose();
				image = grayImage;
			}
			else // file is huge! use temp file routine
			{
				// get image pixels:
				String tempFileName = Path.GetTempFileName();
				FileStream pixels = new FileStream(tempFileName, FileMode.Create);

				for (int y = 0; y < image.Height; y++)
				{
					for (int x = 0; x < image.Width; x++)
					{
						Color color = image.GetPixel(x, y);
						pixels.WriteByte(color.R);
						pixels.WriteByte(color.G);
						pixels.WriteByte(color.B);
					}
				}

				pixels.Flush();
				pixels.Position = 0;

				// create gray palette

				// Since it's impossible to create new ColorPalette object, we'll create temporary bitmap
				// and store the reference to it's palette. After image disposed, we still have the reference 
				// to the write-enabled ColorPalette object.
				Bitmap temp = new Bitmap(1, 1, PixelFormat.Format8bppIndexed);
				ColorPalette grayPalette = temp.Palette;
				temp.Dispose();

				for (int i = 0; i < 256; i++)
				{
					grayPalette.Entries[i] = Color.FromArgb(255, i, i, i);
				}

				// quantize image colors:

				int nPix = bytesCount / 3;

				String tempFileName2 = Path.GetTempFileName();
				FileStream indexedPixels = new FileStream(tempFileName2, FileMode.Create);

				for (int i = 0; i < nPix; i++)
				{
					int index = (((pixels.ReadByte() & 0xff) * 117 + (pixels.ReadByte() & 0xff) * 601 + (pixels.ReadByte() & 0xff) * 306) >> 10);
					indexedPixels.WriteByte((byte) index);
				}

				pixels.Close();

				try
				{
					File.Delete(tempFileName);
				}
				catch
				{
				}

				indexedPixels.Flush();
				indexedPixels.Position = 0;

				Bitmap grayImage = new Bitmap(image.Width, image.Height, PixelFormat.Format8bppIndexed);

				// assign new palette to the destination bitmap
				grayImage.Palette = grayPalette;

				// write indexed bitmap data to the destination bitmap:

				BitmapData data = grayImage.LockBits(new Rectangle(0, 0, image.Width, image.Height), ImageLockMode.WriteOnly, PixelFormat.Format8bppIndexed);
				int addrStart = data.Scan0.ToInt32();

				byte[] bytes = new byte[image.Width];

				for (int i = 0; i < image.Height; i++)
				{
					IntPtr realByteAddr = new IntPtr(addrStart + Convert.ToInt32(i * data.Stride));
					indexedPixels.Read(bytes, 0, image.Width);
					Marshal.Copy(bytes, 0, realByteAddr, image.Width);
				}

				indexedPixels.Close();

				try
				{
					File.Delete(tempFileName2);
				}
				catch
				{
				}

				grayImage.UnlockBits(data);

				// set original resolution
				grayImage.SetResolution(hRes, vRes);

				// replace the source image with new quantized bitmap
				image.Dispose();
				image = grayImage;
			}
		}

		private static void SetIndexedPixel(BitmapData data, int x, int y, bool pixel)
		{
			int index = y * data.Stride + (x >> 3);
			Byte p = Marshal.ReadByte(data.Scan0, index);
			Byte mask = (Byte) (0x80 >> (x & 0x7));

			if (pixel)
			{
				p |= mask;
			}
			else
			{
				p &= (Byte) (mask ^ 0xFF);
			}

			Marshal.WriteByte(data.Scan0, index, p);
		}
	}
}
