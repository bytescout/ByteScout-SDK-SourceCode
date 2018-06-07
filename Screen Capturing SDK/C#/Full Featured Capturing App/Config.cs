//*******************************************************************************************//
//                                                                                           //
// Download Free Evaluation Version From: https://bytescout.com/download/web-installer       //
//                                                                                           //
// Also available as Web API! Free Trial Sign Up: https://secure.bytescout.com/users/sign_up //
//                                                                                           //
// Copyright © 2017-2018 ByteScout Inc. All rights reserved.                                 //
// http://www.bytescout.com                                                                  //
//                                                                                           //
//*******************************************************************************************//


using System;
using System.Collections.Generic;
using System.Text;
using System.Drawing;
using System.ComponentModel;
using System.Diagnostics;
using System.Globalization;
using Microsoft.Win32;
using BytescoutScreenCapturingLib;

// NOTE: if you are getting error like "invalid image" related to loading the SDK's dll then 
// try to do the following:
// 1) remove the reference to the SDK by View - Solution Explorer
// then click on References, select Bytescout... reference name and right-click it and select Remove
// 2) To re-add click on the menu: Project - Add Reference
// 3) In "Add Reference" dialog switch to "COM" tab and find Bytescout...
// 4) Select it and click "Add" 
// 5) Recompile the application 
// Note: if you need to run on both x64 and x86 then please make sure you have set "Embed Interop Types" to True for this reference


namespace ScreenCapturing
{
	public class Config
	{
		public int[] CustomColors { get { return Get<int[]>("CustomColors", null); } set { Options["CustomColors"] = value; } }
		public Point WindowLocation { get { return Get<Point>("WindowLocation", Point.Empty); } set { Options["WindowLocation"] = value; } }
		public string AudioDevice { get { return Get<string>("AudioDevice", ""); } set { Options["AudioDevice"] = value; } }
		public string AudioLine { get { return Get<string>("AudioLine", ""); } set { Options["AudioLine"] = value; } }
		public string AviAudioCodec { get { return Get<string>("AviAudioCodec", "PCM"); } set { Options["AviAudioCodec"] = value; } }
		public string AviVideoCodec { get { return Get<string>("AviVideoCodec", "Bytescout Lossless Video Codec"); } set { Options["AviVideoCodec"] = value; } }
		public string WmvAudioCodec { get { return Get<string>("WmvAudioCodec", "Windows Media Audio 9"); } set { Options["WmvAudioCodec"] = value; } }
		public int WmvAudioFormat { get { return Get<int>("WmvAudioFormat", 28); } set { Options["WmvAudioFormat"] = value; } } // 28 is 128 kbps audio format for WMV
		public string WmvVideoCodec { get { return Get<string>("WmvVideoCodec", "Windows Media Video 9"); } set { Options["WmvVideoCodec"] = value; } }
        public bool EnableAudio { get { return Get<bool>("EnableAudio", false); } set { Options["EnableAudio"] = value; } }
        public bool ResizeOutputVideo { get { return Get<bool>("ResizeOutputVideo", true); } set { Options["ResizeOutputVideo"] = value; } }
        public int OutputWidth { get { return Get<int>("OutputWidth", 640); } set { Options["OutputWidth"] = value; } }
        public int OutputHeight { get { return Get<int>("OutputHeight", 480); } set { Options["OutputHeight"] = value; } }
        public bool KeepAspectRatio { get { return Get<bool>("KeepAspectRatio", true); } set { Options["KeepAspectRatio"] = value; } }
        public float FPS { get { return Get<float>("FPS", 14.985f); } set { Options["FPS"] = value; } }
        public bool WriteLog { get { return Get<bool>("WriteLog", false); } set { Options["WriteLog"] = value; } }
        public bool DoNotShowMessage1 { get { return Get<bool>("DoNotShowMessage1", false); } set { Options["DoNotShowMessage1"] = value; } }
        public string LastUsedFolder { get { return Get<string>("LastUsedFolder", ""); } set { Options["LastUsedFolder"] = value; } }
		public int SelectedVideoCodecTab { get { return Get<int>("SelectedVideoCodecTab", 0); } set { Options["SelectedVideoCodecTab"] = value; } }
		public string WebCameraDevice { get { return Get<string>("WebCameraDevice", ""); } set { Options["WebCameraDevice"] = value; } }
		public int WebCameraWindowX { get { return Get<int>("WebCameraWindowX", 10); } set { Options["WebCameraWindowX"] = value; } }
		public int WebCameraWindowY { get { return Get<int>("WebCameraWindowY", 10); } set { Options["WebCameraWindowY"] = value; } }
		public int WebCameraWindowWidth { get { return Get<int>("WebCameraWindowWidth", 160); } set { Options["WebCameraWindowWidth"] = value; } }
		public int WebCameraWindowHeight { get { return Get<int>("WebCameraWindowHeight", 120); } set { Options["WebCameraWindowHeight"] = value; } }
		public bool ShowMouseHotSpot { get { return Get<bool>("ShowMouseHotSpot", true); } set { Options["ShowMouseHotSpot"] = value; } }
		public bool CaptureMouseCursor { get { return Get<bool>("CaptureMouseCursor", true); } set { Options["CaptureMouseCursor"] = value; } }
		public bool AnimateMouseClicks { get { return Get<bool>("AnimateMouseClicks", true); } set { Options["AnimateMouseClicks"] = value; } }
		public bool AnimateMouseButtons { get { return Get<bool>("AnimateMouseButtons", false); } set { Options["AnimateMouseButtons"] = value; } }
		public int MouseAnimationDuration { get { return Get<int>("MouseAnimationDuration", 600); } set { Options["MouseAnimationDuration"] = value; } }
		public int MouseSpotRadius { get { return Get<int>("MouseSpotRadius", 60); } set { Options["MouseSpotRadius"] = value; } }
		public Color MouseHotSpotColor { get { return Get<Color>("MouseHotSpotColor", Color.FromArgb(255, 255, 0)); } set { Options["MouseHotSpotColor"] = value; } }
		public Color MouseCursorLeftClickAnimationColor { get { return Get<Color>("MouseCursorLeftClickAnimationColor", Color.FromArgb(0, 0, 255)); } set { Options["MouseCursorLeftClickAnimationColor"] = value; } }
		public Color MouseCursorRightClickAnimationColor { get { return Get<Color>("MouseCursorRightClickAnimationColor", Color.FromArgb(0, 255, 0)); } set { Options["MouseCursorRightClickAnimationColor"] = value; } }
		public CaptureAreaBorderType CaptureAreaBorderType { get { return Get<CaptureAreaBorderType>("CaptureAreaBorderType", CaptureAreaBorderType.cabtSolid); } set { Options["CaptureAreaBorderType"] = value; } }
		public Color CaptureAreaBorderColor { get { return Get<Color>("CaptureAreaBorderColor", Color.Red); } set { Options["CaptureAreaBorderColor"] = value; } }
		public int CaptureAreaBorderWidth { get { return Get<int>("CaptureAreaBorderWidth", 2); } set { Options["CaptureAreaBorderWidth"] = value; } }

		private readonly String _strKey;
		public Dictionary<string, object> Options = new Dictionary<string, object>();
		public bool Subsection;
		
		public Config()
		{
			_strKey = Program.RegistryKey;
		}

		public Config(String section)
		{
			Debug.Assert(!String.IsNullOrEmpty(section));

			Subsection = true;
			_strKey = Program.RegistryKey + "\\" + section;
		}

		public T Get<T>(String optionName, Object defaultValue)
		{
			Debug.Assert(!String.IsNullOrEmpty(optionName));

		    object value;

			if (Options.TryGetValue(optionName, out value))
			{
				return (T) value;
			}
			else
			{
				String s = (String) Registry.GetValue("HKEY_CURRENT_USER\\" + _strKey, optionName, null);

				if (s == null)
				{
					return (T) defaultValue;
				}
				else
				{
					TypeConverter tc;

					if (typeof(T) == typeof(int[]))
					{
						tc = new IntegerArrayConverter();
					}
					else
					{
						tc = TypeDescriptor.GetConverter(typeof(T));
					}

					try
				    {
				        value = tc.ConvertFromString(s);
				    }
				    catch (Exception)
				    {
                        value = defaultValue;
				    }

					Options.Add(optionName, value);

					return (T) value;
				}
			}
		}

		public void Set(String optionName, Object value)
		{
			Debug.Assert(!String.IsNullOrEmpty(optionName));

			Options[optionName] = value;
		}

		public void Save()
		{
			RegistryKey key = Registry.CurrentUser.CreateSubKey(_strKey);

            if (key != null)
		    {
		        foreach (KeyValuePair<string, object> de in Options)
		        {
		            TypeConverter tc;
		            String s;

		            if (de.Value == null)
		            {
		                s = "";
		            }
		            else
		            {
		                if (de.Value is int[])
		                {
		                    tc = new IntegerArrayConverter();
		                }
		                else
		                {
		                    tc = TypeDescriptor.GetConverter(de.Value);
		                }

		                s = tc.ConvertToString(de.Value);
		            }

		            key.SetValue(de.Key, s);
		        }

		        key.Flush();
		    }
		}
	}

	public class IntegerArrayConverter : TypeConverter
	{
		public override bool CanConvertFrom(ITypeDescriptorContext context, Type sourceType)
		{
			if (sourceType == typeof(string))
			{
				return true;
			}

			return base.CanConvertFrom(context, sourceType);
		}

		public override object ConvertFrom(ITypeDescriptorContext context, CultureInfo culture, object value)
		{
			if (value is string)
			{
				string[] ss = ((string) value).Split(new char[] { ';' });
				List<int> list = new List<int>();

				foreach (string s in ss)
				{
					if (!String.IsNullOrEmpty(s))
					{
						list.Add(Int32.Parse(s));
					}
				}

				return list.ToArray();
			}

			return base.ConvertFrom(context, culture, value);
		}

		public override bool CanConvertTo(ITypeDescriptorContext context, Type destinationType)
		{
			if (destinationType == typeof(string))
			{
				return true;
			}

			return base.CanConvertTo(context, destinationType);
		}

		public override object ConvertTo(ITypeDescriptorContext context, CultureInfo culture, object value, Type destinationType)
		{
			if (destinationType == typeof(string) && value is int[])
			{
				StringBuilder sb = new StringBuilder();

				foreach (int x in (int[]) value)
				{
					if (sb.Length > 0)
					{
						sb.Append(";");
					}

					sb.Append(x.ToString());
				}

				return sb.ToString();
			}

			return base.ConvertTo(context, culture, value, destinationType);
		}
	}
}
