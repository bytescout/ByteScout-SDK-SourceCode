//*****************************************************************************************//
//                                                                                         //
// Download offline evaluation version (DLL): https://bytescout.com/download/web-installer //
//                                                                                         //
// Signup Web API free trial: https://secure.bytescout.com/users/sign_up                   //
//                                                                                         //
// Copyright © 2017-2018 ByteScout Inc. All rights reserved.                               //
// http://www.bytescout.com                                                                //
//                                                                                         //
//*****************************************************************************************//


using System.Drawing;
using System.Drawing.Drawing2D;
using System.Drawing.Imaging;
using System.IO;
using System.Windows.Forms;

namespace ScreenCapturing
{
    public sealed class RegionSelector : Form
    {
        private Bitmap _bmpScreenshot;
        private Rectangle _selectedRectangle = Rectangle.Empty;
    	private bool _selecting = false;
		private readonly Cursor _cursor1;
		private readonly Cursor _cursor2;

        public RegionSelector()
        {
			_cursor1 = new Cursor(Path.Combine(Application.StartupPath, "cursor1.cur"));
			_cursor2 = new Cursor(Path.Combine(Application.StartupPath, "cursor2.cur"));

        	Cursor = _cursor1;

            SetStyle(ControlStyles.AllPaintingInWmPaint | ControlStyles.UserPaint | ControlStyles.OptimizedDoubleBuffer, true);

            ControlBox = false;
            FormBorderStyle = FormBorderStyle.None;
            Name = "Region Selector";
            StartPosition = FormStartPosition.Manual;
            Location = new Point(0, 0);
            Size = SystemInformation.PrimaryMonitorSize;
            TopMost = true;

            _bmpScreenshot = new Bitmap(Screen.PrimaryScreen.Bounds.Width, 
                Screen.PrimaryScreen.Bounds.Height, PixelFormat.Format32bppArgb);
            
            using (Graphics g = Graphics.FromImage(_bmpScreenshot))
            {
                g.CopyFromScreen(Screen.PrimaryScreen.Bounds.X, Screen.PrimaryScreen.Bounds.Y, 0, 0, 
                    Screen.PrimaryScreen.Bounds.Size, CopyPixelOperation.SourceCopy);
            }
        }

        public Rectangle SelectedRectangle
        {
            get { return NormalizeRectangle(_selectedRectangle); }
            set { _selectedRectangle = value; }
        }

        protected override void OnPaint(PaintEventArgs e)
        {
            e.Graphics.DrawImage(_bmpScreenshot, new Rectangle(0, 0, _bmpScreenshot.Width, _bmpScreenshot.Height));

            Region region = new Region(new Rectangle(0, 0, _bmpScreenshot.Width, _bmpScreenshot.Height));
            Rectangle rectangle = SelectedRectangle;

            region.Exclude(rectangle);

            using (Brush brush = new SolidBrush(Color.FromArgb(174, Color.White)))
            {
                e.Graphics.FillRegion(brush, region);
            }

            if (!rectangle.IsEmpty)
            {
                using (Pen pen = new Pen(Color.Red, 1))
                {
                    pen.Alignment = PenAlignment.Outset;
                    e.Graphics.DrawRectangle(pen, rectangle);
                }
            }
        }

        public static Rectangle NormalizeRectangle(Rectangle r)
        {
            Rectangle result = r;

            if (result.Left > result.Right)
            {
                int width = result.Left - result.Right;
                result.X = result.Right;
                result.Width = System.Math.Abs(width);
            }
            
            if (result.Top > result.Bottom)
            {
                int height = result.Top - result.Bottom;
                result.Y = result.Bottom;
                result.Height = System.Math.Abs(height);
            }

            return result;
        }

        protected override void OnMouseMove(MouseEventArgs e)
        {
            if (_selecting)
            {
                _selectedRectangle.Width = e.X - _selectedRectangle.X;
                _selectedRectangle.Height = e.Y - _selectedRectangle.Y;

				Invalidate();
            }
        }

        protected override void OnMouseUp(MouseEventArgs e)
        {
			if (!_selecting)
			{
				_selecting = true;
				_selectedRectangle.Location = e.Location;
				Cursor = _cursor2;
			}
			else
			{
				_selecting = false;

				_selectedRectangle.Width = e.X - _selectedRectangle.X;
				_selectedRectangle.Height = e.Y - _selectedRectangle.Y;

				Close();
			}
        }

		protected override void OnKeyDown(KeyEventArgs e)
		{
			if (e.KeyCode == Keys.Escape)
			{
				DialogResult = DialogResult.Abort;
			}

			Close();
		}
    }
}
