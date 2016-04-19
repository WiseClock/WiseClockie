using System;
using System.ComponentModel;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Windows.Forms;

namespace WiseClockie.Forms
{
    public class WiseCheckBox : CheckBox
    {
        private WiseCorner _corners = new WiseCorner(0, 0, 0, 0);

        private Color _colorNormal = Color.FromArgb(255, 180, 180, 180);
        private Color _colorChecked = Color.FromArgb(255, 44, 138, 255);
        private Color _colorCheckmark = Color.White;

        private bool _isHovered = false;
        private bool _isDown = false;

        [Description("The border radius of the checkmark."), DefaultValue(typeof(WiseCorner), "0, 0, 0, 0"), Category("WiseClockie")]
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

        [Description("Color when in normal state."), Category("WiseClockie"), DefaultValue(typeof(Color), "255, 180, 180, 180")]
        public Color ColorNormal
        {
            get
            {
                return _colorNormal;
            }
            set
            {
                _colorNormal = value;
            }
        }

        [Description("Color when in checked state."), Category("WiseClockie"), DefaultValue(typeof(Color), "255, 44, 138, 255")]
        public Color ColorChecked
        {
            get
            {
                return _colorChecked;
            }
            set
            {
                _colorChecked = value;
            }
        }

        [Description("Color for checkmark."), Category("WiseClockie"), DefaultValue(typeof(Color), "White")]
        public Color ColorCheckmark
        {
            get
            {
                return _colorCheckmark;
            }
            set
            {
                _colorCheckmark = value;
            }
        }

        public WiseCheckBox()
        {
            SetStyle(ControlStyles.AllPaintingInWmPaint | ControlStyles.UserPaint | ControlStyles.OptimizedDoubleBuffer | ControlStyles.ResizeRedraw, true);
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
            if (!PointInRect(mevent.X, mevent.Y))
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

        private bool PointInRect(int x, int y)
        {
            if (x >= 0 && y >= 0 && x <= this.Width && y <= this.Height)
            {
                return true;
            }
            return false;
        }

        protected override void OnPaint(PaintEventArgs e)
        {
            // over drawn checkbox area
            base.OnPaint(e);
            e.Graphics.FillRectangle(new SolidBrush(BackColor), new Rectangle(0, 0, 16, this.Height));

            e.Graphics.SmoothingMode = SmoothingMode.HighQuality;
            Rectangle checkRect = new Rectangle(0, this.Height / 2 - 7, 14, 14);

            if (Appearance == Appearance.Normal)
            {
                if (Checked)
                {
                    if (CheckState == CheckState.Checked)
                    {
                        Color fillColor = ColorChecked;
                        if (_isHovered)
                            fillColor = ControlPaint.Light(fillColor);

                        e.Graphics.FillPath(new SolidBrush(fillColor), GetRoundedRectPath(checkRect, CornerRadius));
                        e.Graphics.DrawPath(new Pen(fillColor), GetRoundedRectPath(checkRect, CornerRadius));
                        e.Graphics.FillPath(new SolidBrush(ColorCheckmark), GetCheckmarkPath(-1, this.Height / 2 - 9));
                    }
                    else if (CheckState == CheckState.Indeterminate)
                    {
                        Color fillColorNormal = ColorNormal;
                        if (_isHovered)
                            fillColorNormal = ControlPaint.Light(fillColorNormal);
                        Color fillColor = ColorChecked;
                        if (_isHovered)
                            fillColor = ControlPaint.Light(fillColor);

                        e.Graphics.FillPath(new SolidBrush(fillColorNormal), GetRoundedRectPath(checkRect, CornerRadius));
                        e.Graphics.DrawPath(new Pen(fillColorNormal), GetRoundedRectPath(checkRect, CornerRadius));
                        e.Graphics.FillRectangle(new SolidBrush(fillColor), new Rectangle(2, this.Height / 2 - 5, 9, 9));
                    }
                }
                else
                {
                    Color fillColorNormal = ColorNormal;
                    if (_isHovered)
                        fillColorNormal = ControlPaint.Light(fillColorNormal);

                    e.Graphics.FillPath(new SolidBrush(fillColorNormal), GetRoundedRectPath(checkRect, CornerRadius));
                    e.Graphics.DrawPath(new Pen(fillColorNormal), GetRoundedRectPath(checkRect, CornerRadius));
                }

                if (_isDown)
                {
                    e.Graphics.FillPath(new SolidBrush(Color.FromArgb(30, 0, 0, 0)), GetRoundedRectPath(checkRect, CornerRadius));
                    e.Graphics.DrawPath(new Pen(Color.FromArgb(30, 0, 0, 0)), GetRoundedRectPath(checkRect, CornerRadius));
                }
            }
        }

        private GraphicsPath GetCheckmarkPath(int offsetX, int offsetY)
        {
            GraphicsPath gp = new GraphicsPath();
            gp.StartFigure();
            gp.AddLine(offsetX + 4, offsetY + 7, offsetX + 6, offsetY + 9);
            gp.AddLine(offsetX + 6, offsetY + 9, offsetX + 11, offsetY + 3);
            gp.AddLine(offsetX + 11, offsetY + 3, offsetX + 13, offsetY + 5);
            gp.AddLine(offsetX + 13, offsetY + 5, offsetX + 6, offsetY + 13);
            gp.AddLine(offsetX + 6, offsetY + 13, offsetX + 2, offsetY + 9);
            gp.AddLine(offsetX + 2, offsetY + 9, offsetX + 4, offsetY + 7);
            gp.CloseFigure();
            return gp;
        }

        private GraphicsPath GetRoundedRectPath(Rectangle rect, WiseCorner radius)
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
