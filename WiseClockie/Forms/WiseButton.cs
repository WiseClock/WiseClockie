using System;
using System.Windows.Forms;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.ComponentModel;
using System.Text.RegularExpressions;

namespace WiseClockie.Forms
{
    public class WiseButton : Button
    {
        // properties
        private WiseCorner _corners = new WiseCorner(0, 0, 0, 0);

        private Color _borderColor = Color.FromArgb(255, 104, 139, 177);
        private Color _subTextColor = Color.Gray;
        private Color _solidColorNormal = Color.FromArgb(255, 227, 243, 255);
        private Color _solidColorDown = Color.FromArgb(255, 145, 174, 199);
        private Color _solidColorHovered = Color.FromArgb(255, 189, 196, 203);
        private Color _gradientNormal1 = Color.FromArgb(255, 227, 243, 255);
        private Color _gradientNormal2 = Color.FromArgb(255, 145, 174, 199);
        private Color _gradientDown1 = Color.FromArgb(255, 145, 174, 199);
        private Color _gradientDown2 = Color.FromArgb(255, 227, 243, 255);
        private Color _gradientHovered1 = Color.FromArgb(255, 245, 249, 255);
        private Color _gradientHovered2 = Color.FromArgb(255, 189, 196, 203);

        private Font _subTextFont = new Font("Arial", 9, GraphicsUnit.Point);

        private string _subText = "";

        private int _borderSize = 1;
        private bool _isGradient = true;
        private bool _drawBorder = true;

        // local use
        private bool _isHovered = false;
        private bool _isDown = false;
        private bool _isAltDown = false;

        // properties
        [Description(""), Category("WiseClockie"), DefaultValue(typeof(Color), "227, 243, 255")]
        public Color SolidColorNormal
        {
            get
            {
                return _solidColorNormal;
            }
            set
            {
                _solidColorNormal = value;
            }
        }

        [Description(""), Category("WiseClockie"), DefaultValue(typeof(Color), "189, 196, 203")]
        public Color SolidColorHover
        {
            get
            {
                return _solidColorHovered;
            }
            set
            {
                _solidColorHovered = value;
            }
        }

        [Description(""), Category("WiseClockie"), DefaultValue(typeof(Color), "145, 174, 199")]
        public Color SolidColorDown
        {
            get
            {
                return _solidColorDown;
            }
            set
            {
                _solidColorDown = value;
            }
        }

        [Description(""), Category("WiseClockie"), DefaultValue(typeof(Color), "227, 243, 255")]
        public Color GradientColorNormal1
        {
            get
            {
                return _gradientNormal1;
            }
            set
            {
                _gradientNormal1 = value;
            }
        }

        [Description(""), Category("WiseClockie"), DefaultValue(typeof(Color), "245, 249, 255")]
        public Color GradientColorHover1
        {
            get
            {
                return _gradientHovered1;
            }
            set
            {
                _gradientHovered1 = value;
            }
        }

        [Description(""), Category("WiseClockie"), DefaultValue(typeof(Color), "145, 174, 199")]
        public Color GradientColorDown1
        {
            get
            {
                return _gradientDown1;
            }
            set
            {
                _gradientDown1 = value;
            }
        }

        [Description(""), Category("WiseClockie"), DefaultValue(typeof(Color), "145, 174, 199")]
        public Color GradientColorNormal2
        {
            get
            {
                return _gradientNormal2;
            }
            set
            {
                _gradientNormal2 = value;
            }
        }

        [Description(""), Category("WiseClockie"), DefaultValue(typeof(Color), "189, 196, 203")]
        public Color GradientColorHover2
        {
            get
            {
                return _gradientHovered2;
            }
            set
            {
                _gradientHovered2 = value;
            }
        }

        [Description(""), Category("WiseClockie"), DefaultValue(typeof(Color), "227, 243, 255")]
        public Color GradientColorDown2
        {
            get
            {
                return _gradientDown2;
            }
            set
            {
                _gradientDown2 = value;
            }
        }

        [Description(""), Category("WiseClockie"), DefaultValue(typeof(Color), "104, 139, 177")]
        public Color BorderColor
        {
            get
            {
                return _borderColor;
            }
            set
            {
                _borderColor = value;
            }
        }

        [Description(""), Category("WiseClockie"), DefaultValue(typeof(Color), "Gray")]
        public Color SubTextColor
        {
            get
            {
                return _subTextColor;
            }
            set
            {
                _subTextColor = value;
            }
        }

        [Description("Is the button drawn in gradient colors."), Category("WiseClockie"), DefaultValue(true)]
        public bool IsGradient
        {
            get
            {
                return _isGradient;
            }
            set
            {
                _isGradient = value;
            }
        }

        [Description("Is the border drawn."), Category("WiseClockie"), DefaultValue(true)]
        public bool DrawBorder
        {
            get
            {
                return _drawBorder;
            }
            set
            {
                _drawBorder = value;
            }
        }

        [Description("The thickness of the button's border."), Category("WiseClockie"), DefaultValue(1)]
        public int BorderSize
        {
            get
            {
                return _borderSize;
            }
            set
            {
                _borderSize = value;
            }
        }


        [Description("The border radius of the button."), DefaultValue(typeof(WiseCorner), "0, 0, 0, 0"), Category("WiseClockie")]
        public WiseCorner CornerRadius
        {
            get
            {
                return _corners;
            }
            set
            {
                _corners = value;
                this.Invalidate();
            }
        }

        [Description("The sub caption of the button."), DefaultValue(""), Category("WiseClockie")]
        public string SubText
        {
            get
            {
                return _subText;
            }
            set
            {
                _subText = value;
            }
        }

        [Description("The sub caption's font."), DefaultValue("Arial, 9pt"), Category("WiseClockie")]
        public Font SubTextFont
        {
            get
            {
                return this._subTextFont;
            }
            set
            {
                this._subTextFont = value;
            }
        }

        public WiseButton()
        {
            SetStyle(ControlStyles.AllPaintingInWmPaint | ControlStyles.UserPaint | ControlStyles.OptimizedDoubleBuffer | ControlStyles.ResizeRedraw, true);
        }

        protected override void OnKeyDown(KeyEventArgs kevent)
        {
            base.OnKeyDown(kevent);
            if (kevent.KeyValue == 18 || kevent.Alt || kevent.KeyData == Keys.Alt || kevent.KeyCode == Keys.Alt)
            {
                kevent.Handled = true;
                _isAltDown = true;
                this.Invalidate();
            }
        }

        protected override void OnKeyUp(KeyEventArgs kevent)
        {
            base.OnKeyUp(kevent);
            _isAltDown = false;
            this.Invalidate();
        }

        protected override void OnMouseDown(MouseEventArgs mevent)
        {
            base.OnMouseDown(mevent);
            if (mevent.Button == MouseButtons.Left)
            {
                _isDown = true;
                this.Invalidate();
            }
        }

        protected override void OnMouseUp(MouseEventArgs mevent)
        {
            base.OnMouseUp(mevent);
            if (mevent.Button == MouseButtons.Left)
            {
                _isDown = false;
                this.Invalidate();
            }
        }

        protected override void OnMouseMove(MouseEventArgs mevent)
        {
            base.OnMouseMove(mevent);
            if (!pointInRect(mevent.X, mevent.Y))
            {
                _isDown = false;
                this.Invalidate();
            }
            else
            {
                if (mevent.Button == MouseButtons.Left)
                {
                    _isDown = true;
                    this.Invalidate();
                }
            }
        }

        protected override void OnMouseEnter(EventArgs e)
        {
            base.OnMouseEnter(e);
            _isHovered = true;
            this.Invalidate();
        }

        protected override void OnMouseLeave(EventArgs e)
        {
            base.OnMouseLeave(e);
            _isHovered = false;
            this.Invalidate();
        }

        protected override void OnLostFocus(EventArgs e)
        {
            base.OnLostFocus(e);
            _isHovered = false;
            _isDown = false;
        }

        protected override void OnPaint(PaintEventArgs e)
        {
            // base.OnPaint(pevent);

            // brushes and pens
            Pen borderPenOuter = new Pen(_borderColor, _borderSize);
            Pen borderPenInner = new Pen(Color.White, _borderSize + 1);
            borderPenOuter.Alignment = PenAlignment.Center;
            borderPenInner.Alignment = PenAlignment.Center;
            // Brush textBrush = new SolidBrush(Color.FromArgb(255, 31, 53, 78));
            Brush textBrush = new SolidBrush(this.ForeColor);
            Brush subTextBrush = new SolidBrush(this._subTextColor);
            Brush backBrush = new SolidBrush(this.BackColor);
            Brush solidBrushNormal = new SolidBrush(_solidColorNormal);
            Brush solidBrushDown = new SolidBrush(_solidColorDown);
            Brush solidBrushHovered = new SolidBrush(_solidColorHovered);
            LinearGradientBrush gradientBrushNormal = new LinearGradientBrush(new Point(0, 0), new Point(0, this.Height), _gradientNormal1, _gradientNormal2);
            LinearGradientBrush gradientBrushDown = new LinearGradientBrush(new Point(0, 0), new Point(0, this.Height), _gradientDown1, _gradientDown2);
            LinearGradientBrush gradientBrushHovered = new LinearGradientBrush(new Point(0, 0), new Point(0, this.Height), _gradientHovered1, _gradientHovered2);


            Rectangle rect = new Rectangle(0, 0, this.Width, this.Height);
            e.Graphics.FillRectangle(backBrush, rect);

            e.Graphics.InterpolationMode = InterpolationMode.HighQualityBicubic;
            e.Graphics.PixelOffsetMode = PixelOffsetMode.None;
            e.Graphics.SmoothingMode = SmoothingMode.HighQuality;

            if (_isDown)
            {
                e.Graphics.FillPath(_isGradient ? gradientBrushDown : solidBrushDown, getRoundedRectPath(rect, CornerRadius));
            }
            else if (_isHovered)
            {
                e.Graphics.FillPath(_isGradient ? gradientBrushHovered : solidBrushHovered, getRoundedRectPath(rect, CornerRadius));
            }
            else
            {
                e.Graphics.FillPath(_isGradient ? gradientBrushNormal : solidBrushNormal, getRoundedRectPath(rect, CornerRadius));
            }

            if (_drawBorder)
            {
                e.Graphics.DrawPath(borderPenInner, getRoundedRectPath(rect, CornerRadius));
                e.Graphics.DrawPath(borderPenOuter, getRoundedRectPath(rect, CornerRadius));
            }

            Regex regex = new Regex("([^&])&([^&])", RegexOptions.IgnorePatternWhitespace);
            string labelText = regex.Replace("!" + this.Text + "!", "${1}${2}").Trim('!');
            if (labelText.Length > 0 && labelText[labelText.Length - 1] == '&')
            {
                labelText = labelText.Remove(labelText.Length - 1);
            }
            labelText = labelText.Replace("&&", "&");

            string tmpText = this.Text.TrimEnd('&');
            tmpText = tmpText.Replace("&&", "x");
            string[] arr = tmpText.Split('&');
            int arrLen = arr.Length;
            int offset = 0;
            foreach (string str in arr)
            {
                offset += str.Length;
            }
            offset -= arr[arrLen - 1].Length;

            RectangleF charUnderlineRect = new RectangleF(0, 0, 0, 0);
            bool underline = false;
            if (labelText.Length > 0)
            {
                charUnderlineRect = measureString(e.Graphics, labelText, this.Font, offset);
                underline = ((this.Text[0] == '&' && labelText[0] != '&' && offset == 0) || offset > 0) && (_isAltDown || DesignMode);
            }

            float startY = (this.Height - e.Graphics.MeasureString(labelText, this.Font).Height) / 2;
            float startX = (this.Width - e.Graphics.MeasureString(labelText, this.Font).Width) / 2;

            float subStartX = 0;
            float subStartY = 0;

            bool hasSubText = !this.SubText.Equals("");

            if (hasSubText)
            {
                float subTextHeight = e.Graphics.MeasureString(this.SubText, this._subTextFont).Height;
                float subTextWidth = e.Graphics.MeasureString(this.SubText, this._subTextFont).Width;

                startY -= subTextHeight / 2 + 2;

                subStartX = (this.Width - subTextWidth) / 2;
                subStartY = startY + e.Graphics.MeasureString(labelText, this.Font).Height + 2;
            }

            e.Graphics.SmoothingMode = SmoothingMode.None;

            if (_isDown)
            {
                e.Graphics.DrawString(labelText, this.Font, textBrush, startX + 1, startY + 1);
                
                if (underline)
                {
                    e.Graphics.DrawLine(Pens.Black, startX + 1 + charUnderlineRect.Left, startY + 1 + charUnderlineRect.Bottom, startX + 1 + charUnderlineRect.Right, startY + 1 + charUnderlineRect.Bottom);
                }

                if (hasSubText)
                {
                    e.Graphics.DrawString(SubText, this._subTextFont, subTextBrush, subStartX + 1, subStartY + 1);
                }
            }
            else
            {
                e.Graphics.DrawString(labelText, this.Font, textBrush, startX, startY);

                if (underline)
                {
                    e.Graphics.DrawLine(Pens.Black, startX + charUnderlineRect.Left, startY + charUnderlineRect.Bottom, startX + charUnderlineRect.Right, startY + charUnderlineRect.Bottom);
                }

                if (hasSubText)
                {
                    e.Graphics.DrawString(SubText, this._subTextFont, subTextBrush, subStartX, subStartY);
                }
            }
        }

        private RectangleF measureString(Graphics g, string text, Font font, int offset)
        {
            RectangleF ret = new RectangleF(0, 0, 0, 0);
            if (offset >= 0)
            {
                try
                {
                    CharacterRange[] characterRanges = new CharacterRange[text.Length];
                    for (int i = 0; i < text.Length; i++)
                    {
                        characterRanges[i] = new CharacterRange(i, 1);
                    }

                    StringFormat stringFormat = new StringFormat();
                    stringFormat.FormatFlags = StringFormatFlags.NoClip;
                    stringFormat.SetMeasurableCharacterRanges(characterRanges);

                    Region[] region = new Region[text.Length];

                    SizeF size = g.MeasureString(text, font);
                    RectangleF layoutRect = new RectangleF(0, 0, size.Width, size.Height);

                    region = g.MeasureCharacterRanges(text, font, layoutRect, stringFormat);
                    ret = region[offset].GetBounds(g);
                    ret.Offset(-0.5F, -2);
                }
                catch (Exception e)
                {
                    Console.WriteLine(e);
                    ret = new RectangleF(0, 0, 0, 0);
                }
                return ret;
            }
            return ret;
        }

        private bool pointInRect(int x, int y)
        {
            if (x >= 0 && y >= 0 && x <= this.Width && y <= this.Height)
            {
                return true;
            }
            return false;
        }

        private GraphicsPath getRoundedRectPath(Rectangle rect, WiseCorner radius)
        {
            radius = new WiseCorner(radius.TopLeft + 2, radius.TopRight + 2, radius.BottomRight + 2, radius.BottomLeft + 2);

            Rectangle topLeft = new Rectangle(rect.Location, new Size(radius.TopLeft - 1, radius.TopLeft - 1));
            Rectangle topRight = new Rectangle(rect.Location, new Size(radius.TopRight - 1, radius.TopRight - 1));
            Rectangle bottomRight = new Rectangle(rect.Location, new Size(radius.BottomRight - 1, radius.BottomRight - 1));
            Rectangle bottomLeft = new Rectangle(rect.Location, new Size(radius.BottomLeft - 1, radius.BottomLeft - 1));

            GraphicsPath path = new GraphicsPath();

            //左上角
            if (radius.TopLeft > 2)
            {
                path.AddArc(topLeft, 180, 90);
            }
            else
            {
                path.AddLine(new Point(rect.X, rect.Y), new Point(rect.X, rect.Y));
            }

            //右上角
            if (radius.TopRight > 2)
            {
                topRight.X = rect.Right - radius.TopRight;
                path.AddArc(topRight, 270, 90);
            }
            else
            {
                path.AddLine(new Point(rect.Right - 1, rect.Y), new Point(rect.Right - 1, rect.Y));
            }

            //右下角
            if (radius.BottomRight > 2)
            {
                bottomRight.X = rect.Right - radius.BottomRight;
                bottomRight.Y = rect.Bottom - radius.BottomRight;
                path.AddArc(bottomRight, 0, 90);
            }
            else
            {
                path.AddLine(new Point(rect.Right - 1, rect.Bottom - 1), new Point(rect.Right - 1, rect.Bottom - 1));
            }

            //左下角
            if (radius.BottomLeft > 2)
            {
                bottomLeft.X = rect.Left;
                bottomLeft.Y = rect.Bottom - radius.BottomLeft;
                path.AddArc(bottomLeft, 90, 90);
            }
            else
            {
                path.AddLine(new Point(rect.X, rect.Bottom - 1), new Point(rect.X, rect.Bottom - 1));
            }

            path.CloseFigure();
            return path;
        }
    }
}
