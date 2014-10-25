using System.Windows.Forms;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.ComponentModel;
using System;

namespace WiseClockie.Forms
{
    public class WiseProgressBar : ProgressBar
    {
        private Timer _animTimer;
        private float _animOffset = 0;
        private Pen _animPen = new Pen(Color.FromArgb(128, 255, 255, 255), 10);
        private float _animLineGap = 30;

        private Color _borderColor = Color.LightBlue;
        private Color _solidColor = Color.LightBlue;
        private Color _gradient1 = Color.LightBlue;
        private Color _gradient2 = Color.DarkBlue;
        private int _borderSize = 1;
        private bool _isGradient = false;
        private bool _drawBorder = true;
        private bool _isAnimated = false;

        // default properties values
        private Color _backColor = Color.White;

        // override default properties
        [Description("The back color of the progress bar."), DefaultValue(typeof(Color), "White"), Category("WiseClockie")]
        new public Color BackColor
        {
            get
            {
                return _backColor;
            }
            set
            {
                _backColor = value;
            }
        }

        // new properties
        [Description("The border color of the progress bar."), DefaultValue(typeof(Color), "LightBlue"), Category("WiseClockie")]
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

        [Description("The color of the progress bar if not using gradient."), DefaultValue(typeof(Color), "LightBlue"), Category("WiseClockie")]
        public Color SolidColor
        {
            get
            {
                return _solidColor;
            }
            set
            {
                _solidColor = value;
            }
        }

        [Description("The beggining color of the progress bar if using gradient."), DefaultValue(typeof(Color), "LightBlue"), Category("WiseClockie")]
        public Color Gradient1
        {
            get
            {
                return _gradient1;
            }
            set
            {
                _gradient1 = value;
            }
        }

        [Description("The ending color of the progress bar if using gradient."), DefaultValue(typeof(Color), "DarkBlue"), Category("WiseClockie")]
        public Color Gradient2
        {
            get
            {
                return _gradient2;
            }
            set
            {
                _gradient2 = value;
            }
        }

        [Description("The border thickness."), DefaultValue(1), Category("WiseClockie")]
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

        [Description("Set if the progress bar is drawn using gradient."), DefaultValue(false), Category("WiseClockie")]
        public bool Gradient
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

        [Description("Set if the border is drawn."), DefaultValue(true), Category("WiseClockie")]
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

        [Description("Set if the progress bar is animated."), DefaultValue(false), Category("WiseClockie")]
        public bool Animated
        {
            get
            {
                return _isAnimated;
            }
            set
            {
                if (!DesignMode)
                {
                    if (value)
                    {
                        _animTimer = new Timer();
                        _animTimer.Tick += new EventHandler(timerTick);
                        _animTimer.Enabled = true;
                        _animTimer.Start();
                    }
                    else
                    {
                        _animTimer.Stop();
                        _animTimer.Dispose();
                    }
                }
                _isAnimated = value;
            }
        }

        public WiseProgressBar()
        {
            SetStyle(ControlStyles.AllPaintingInWmPaint | ControlStyles.UserPaint | ControlStyles.OptimizedDoubleBuffer | ControlStyles.ResizeRedraw, true);
            this.Size = new Size(200, 5);
        }

        protected override void OnPaint(PaintEventArgs e)
        {
            e.Graphics.InterpolationMode = InterpolationMode.HighQualityBicubic;
            e.Graphics.PixelOffsetMode = PixelOffsetMode.HighQuality;
            e.Graphics.SmoothingMode = SmoothingMode.HighQuality;

            Pen borderPen = new Pen(this.BorderColor, this.BorderSize);
            borderPen.Alignment = PenAlignment.Inset;
            Brush backBrush = new SolidBrush(this.BackColor);
            Brush solidBrush = new SolidBrush(this.SolidColor);

            // int offset = (this.BorderSize == 1) ? 1 : 0;
            Rectangle rect = new Rectangle(0, 0, this.Width, this.Height);
            Rectangle rectInner = rect;
            Rectangle rectOuter = new Rectangle(0, 0, this.Width/* - offset */, this.Height/* - offset*/);

            // draw background.
            e.Graphics.FillRectangle(backBrush, rect);

            // draw border
            if (this.DrawBorder)
            {
                e.Graphics.DrawRectangle(borderPen, rectOuter);
                rectInner = new Rectangle(this.BorderSize + 1, this.BorderSize + 1, this.Width - (this.BorderSize + 1) * 2, this.Height - (this.BorderSize + 1) * 2);
            }

            // draw progress
            rectInner.Width = (int)(rectInner.Width * ((double)Value / Maximum));
            e.Graphics.FillRectangle(solidBrush, rectInner);

            using (Bitmap bmp = new Bitmap(this.Width, this.Height))
            {
                using (Graphics g = Graphics.FromImage(bmp))
                {
                    g.InterpolationMode = InterpolationMode.HighQualityBicubic;
                    g.PixelOffsetMode = PixelOffsetMode.HighQuality;
                    g.SmoothingMode = SmoothingMode.HighQuality;

                    if (Animated)
                    {
                        for (float i = -_animLineGap; i < this.Width; i += _animLineGap)
                        {
                            g.DrawLine(_animPen, _animOffset + i, this.Height + _animPen.Width / 2, _animOffset + _animLineGap + i, 0 - _animPen.Width / 2);
                        }
                    }
                    e.Graphics.DrawImage(bmp, rectInner, rectInner, GraphicsUnit.Pixel);
                }
            }

            // draw original progress bar back image
            // ProgressBarRenderer.DrawHorizontalBar(e.Graphics, rect);
        }

        private void timerTick(object sender, EventArgs e)
        {
            _animOffset += 0.8F;
            if (_animOffset >= _animLineGap)
            {
                _animOffset = 0;
            }
            this.Invalidate();
        }

        protected override void OnSizeChanged(EventArgs e)
        {
            base.OnSizeChanged(e);
            this._animPen.Width = this.Size.Height;
            this._animLineGap = this._animPen.Width * 3;
            this.Invalidate();
        }
    }
}
