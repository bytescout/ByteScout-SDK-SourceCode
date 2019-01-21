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

namespace ScreenCapturingClient
{
    public class Overlay
    {
        int _left = 0;
        int _top = 0;
        bool _visible = true;

        public int Left { get{return _left;}set{_left = value;}}
        public int Top { get { return _top; } set { _top = value; } }
        public bool Visible { get { return _visible; } set { _visible = value; } }
    }

    public class TextOverlay : Overlay
    {
        string _text = string.Empty;
        Font _font = new Font("Arial", 10f);
        Color _color = Color.Red;
        Color _backColor = Color.Transparent;

        public string Text { get { return _text; } set { _text = value; } }
        public Font Font { get { return _font; } set { _font = value; } }
        public Color Color { get { return _color; } set { _color = value; } }
        public Color BackColor { get { return _backColor; } set { _backColor = value; } }

        public override string ToString()
        {
            return string.Format("Text Overlay. Location: {0}, Text: {1}, Font: {2}", new Point(Left, Top), Text, Font);
        }
    }

    public class ImageOverlay : Overlay
    {
        string _fileName = string.Empty;

        public string FileName { get { return _fileName; } set { _fileName = value; } }

        public override string ToString()
        {
            return string.Format("Image Overlay. Location: {0}, File Name: {1}", new Point(Left, Top), FileName);
        }
    }
}
