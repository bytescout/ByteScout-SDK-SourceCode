//*******************************************************************************************//
//                                                                                           //
// Get Your API Key: https://app.pdf.co/signup                                               //
// API Documentation: https://developer.pdf.co/api/index.html                                //
//                                                                                           //
// Note: Replace placeholder values in the code with your API Key                            //
// and file paths (if applicable)                                                            //
//                                                                                           //
//*******************************************************************************************//


using System;
using System.Drawing;
using System.Windows.Forms;
using System.ComponentModel;

namespace ScreenCapturing
{
	public enum CustomBorderStyle { None, Dashed, Dotted, Bump, Etched, Flat, Raised, Sunken };

	public class ColorControl : Control
	{
		private CustomBorderStyle _borderStyle = CustomBorderStyle.None;
		
		private ToolTip _toolTip;
		private IContainer components;
		
		[DefaultValue(CustomBorderStyle.None)]
		public CustomBorderStyle BorderStyle
		{
			get { return _borderStyle; }
			set 
			{ 
				_borderStyle = value;
				Refresh();
			}
		}
		
		public ColorControl()
		{
			InitializeComponent();

			SetStyle(ControlStyles.AllPaintingInWmPaint, true);
			SetStyle(ControlStyles.UserPaint, true);
			SetStyle(ControlStyles.OptimizedDoubleBuffer, true);
			UpdateStyles();

			AutoSize = false;
		}

		protected override void OnPaint(PaintEventArgs e)
		{
			base.OnPaint(e);

			e.Graphics.FillRectangle(new SolidBrush(ForeColor), ClientRectangle);

			if (BorderStyle == CustomBorderStyle.Dotted)
			{
				ControlPaint.DrawBorder(e.Graphics, ClientRectangle, SystemColors.ControlDarkDark, ButtonBorderStyle.Dotted);
			}
			else if (BorderStyle == CustomBorderStyle.Dashed)
			{
				ControlPaint.DrawBorder(e.Graphics, ClientRectangle, SystemColors.ControlDarkDark, ButtonBorderStyle.Dashed);
			}
			else if (BorderStyle != CustomBorderStyle.None)
			{
				Border3DStyle style;

				switch (BorderStyle)
				{
					case CustomBorderStyle.Bump: style = Border3DStyle.Bump; break;
					case CustomBorderStyle.Etched: style = Border3DStyle.Etched; break;
					case CustomBorderStyle.Raised: style = Border3DStyle.Raised; break;
					case CustomBorderStyle.Sunken: style = Border3DStyle.Sunken; break;
					default: style = Border3DStyle.Flat; break;
				}

				ControlPaint.DrawBorder3D(e.Graphics, ClientRectangle, style);
			}

			if (Focused)
			{
				Rectangle focusRect = new Rectangle(ClientRectangle.X + 2, ClientRectangle.Y + 2, ClientRectangle.Width - 4, ClientRectangle.Height - 4);
				ControlPaint.DrawFocusRectangle(e.Graphics, focusRect);
			}
		}

		protected override void OnGotFocus(EventArgs e)
		{
			base.OnGotFocus(e);

			Invalidate();
		}

		protected override void OnLostFocus(EventArgs e)
		{
			base.OnLostFocus(e);

			Invalidate();
		}

		protected override void OnMouseClick(MouseEventArgs e)
		{
			base.OnMouseClick(e);

			Focus();

			if (e.Button == MouseButtons.Left)
			{
				using (ColorDialog fd = new ColorDialog())
				{
					fd.AnyColor = true;
					fd.FullOpen = true;
					fd.Color = Color.FromArgb(255, ForeColor);

					int[] customColors = Program.Cfg.CustomColors;

					if (customColors != null && customColors.Length > 0)
					{
						fd.CustomColors = customColors;
					}

					if (fd.ShowDialog() == DialogResult.OK)
					{
						ForeColor = fd.Color;
						Program.Cfg.CustomColors = fd.CustomColors;
					}
				}
			}
			else if (e.Button == MouseButtons.Right)
			{
				ContextMenu menu = new ContextMenu();
				menu.MenuItems.Add(new MenuItem("Select Transparent Color", menu_Click));
				
				menu.Show(this, e.Location);
			}
		}

		void menu_Click(object sender, EventArgs e)
		{
			ForeColor = Color.Transparent;
		}

		protected override void OnKeyDown(KeyEventArgs e)
		{
			using (ColorDialog fd = new ColorDialog())
			{
				fd.AnyColor = true;
				fd.FullOpen = true;
				fd.Color = ForeColor;

				int[] customColors = Program.Cfg.CustomColors;

				if (customColors != null && customColors.Length > 0)
				{
					fd.CustomColors = customColors;
				}

				if (fd.ShowDialog() == DialogResult.OK)
				{
					ForeColor = fd.Color;
					Program.Cfg.CustomColors = fd.CustomColors;
				}
			}

			base.OnKeyDown(e);
		}

		protected override void OnForeColorChanged(EventArgs e)
		{
			String colorName = String.Empty, rgb, tooltip;
			
			if (ForeColor.ToKnownColor() != 0)
			{
				colorName = ForeColor.ToKnownColor().ToString();
			}
			else if (ForeColor.IsNamedColor)
			{
				colorName = ForeColor.ToString();
			}

			rgb = String.Format("R={0}; G={1}; B={2}", ForeColor.R, ForeColor.G, ForeColor.B);
			
			if (colorName.Length > 0)
			{
				tooltip = String.Format("{0} ({1})", colorName, rgb);
			}
			else
			{
				tooltip = rgb;
			}

			_toolTip.SetToolTip(this, tooltip);

			base.OnForeColorChanged(e);
		}

		private void InitializeComponent()
		{
			components = new Container();
			_toolTip = new ToolTip(components);
			SuspendLayout();
			// 
			// ColorControl
			// 
			_toolTip.SetToolTip(this, "Color");
			ResumeLayout(false);

		}
	}
}
