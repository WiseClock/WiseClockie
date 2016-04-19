using System;
using System.Windows.Forms;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.ComponentModel;
using System.Text.RegularExpressions;

namespace WiseClockie.Forms
{
    public class WiseListBox : ListBox
    {
        // properties
        private Color _solidHighlight = Color.FromArgb(255, 12, 73, 149);
        private Color _gradientHighlight1 = Color.FromArgb(255, 44, 138, 255);
        private Color _gradientHighlight2 = Color.FromArgb(255, 12, 73, 149);
        private Color _solidStrip = Color.FromArgb(255, 228, 235, 241);
        private Color _gradientStrip1 = Color.FromArgb(255, 228, 235, 241);
        private Color _gradientStrip2 = Color.FromArgb(255, 228, 235, 255);
        private Color _fontHighlightColor = Color.White;

        private bool _isStripGradient = false;
        private bool _isHighlightGradient = true;

        [Description("Font color when highlighted"), Category("WiseClockie"), DefaultValue(typeof(Color), "White")]
        public Color FontColorHighlight
        {
            get
            {
                return _fontHighlightColor;
            }
            set
            {
                _fontHighlightColor = value;
            }
        }

        [Description(""), Category("WiseClockie"), DefaultValue(typeof(Color), "255, 228, 235, 241")]
        public Color SolidColorStrip
        {
            get
            {
                return _solidStrip;
            }
            set
            {
                _solidStrip = value;
            }
        }

        [Description(""), Category("WiseClockie"), DefaultValue(typeof(Color), "255, 12, 73, 149")]
        public Color SolidColorHighlight
        {
            get
            {
                return _solidHighlight;
            }
            set
            {
                _solidHighlight = value;
            }
        }

        [Description(""), Category("WiseClockie"), DefaultValue(typeof(Color), "255, 44, 138, 255")]
        public Color GradientColorHighlight1
        {
            get
            {
                return _gradientHighlight1;
            }
            set
            {
                _gradientHighlight1 = value;
            }
        }

        [Description(""), Category("WiseClockie"), DefaultValue(typeof(Color), "255, 12, 73, 149")]
        public Color GradientColorHighlight2
        {
            get
            {
                return _gradientHighlight2;
            }
            set
            {
                _gradientHighlight2 = value;
            }
        }

        [Description(""), Category("WiseClockie"), DefaultValue(typeof(Color), "255, 228, 235, 241")]
        public Color GradientColorStrip1
        {
            get
            {
                return _gradientStrip1;
            }
            set
            {
                _gradientStrip1 = value;
            }
        }

        [Description(""), Category("WiseClockie"), DefaultValue(typeof(Color), "255, 228, 235, 255")]
        public Color GradientColorStrip2
        {
            get
            {
                return _gradientStrip2;
            }
            set
            {
                _gradientStrip2 = value;
            }
        }

        [Description("Is strip color drawn in gradient."), Category("WiseClockie"), DefaultValue(false)]
        public bool GradientStrip
        {
            get
            {
                return _isStripGradient;
            }
            set
            {
                _isStripGradient = value;
            }
        }

        [Description("Is highlight color drawn in gradient."), Category("WiseClockie"), DefaultValue(true)]
        public bool GradientHighlight
        {
            get
            {
                return _isHighlightGradient;
            }
            set
            {
                _isHighlightGradient = value;
            }
        }

        public WiseListBox()
        {
            SetStyle(ControlStyles.AllPaintingInWmPaint | ControlStyles.OptimizedDoubleBuffer | ControlStyles.ResizeRedraw, true);
            DrawMode = DrawMode.OwnerDrawVariable;
        }

        protected override void OnFontChanged(EventArgs e)
        {
            base.OnFontChanged(e);
            this.RecreateHandle();
        }

        protected override void OnMeasureItem(MeasureItemEventArgs e)
        {
            if (e.Index < 0 || Items.Count < 1)
                return;
            e.ItemHeight = Items[e.Index].ToString().Split('\n').Length * (Font.Height + 6);
        }

        protected override void OnDrawItem(DrawItemEventArgs e)
        {
            if (e.Index < 0 || Items.Count < 1)
                return;

            e.DrawBackground();
            e.Graphics.SmoothingMode = SmoothingMode.HighQuality;

            Rectangle stringRect = new Rectangle(e.Bounds.X, e.Bounds.Y + 3, e.Bounds.Width, e.Bounds.Height - 6);

            if (e.State.HasFlag(DrawItemState.Grayed))
            {
                e.Graphics.FillRectangle(Brushes.White, e.Bounds);
                e.Graphics.DrawString(this.Items[e.Index].ToString(), e.Font, new SolidBrush(Color.LightGray), stringRect, StringFormat.GenericDefault);
            }
            else
            {
                if (e.State.HasFlag(DrawItemState.Selected))
                {
                    if (GradientHighlight)
                        e.Graphics.FillRectangle(new LinearGradientBrush(e.Bounds, GradientColorHighlight1, GradientColorHighlight2, LinearGradientMode.Vertical), new Rectangle(e.Bounds.X, e.Bounds.Y, e.Bounds.Width, e.Bounds.Height - 1));
                    else
                        e.Graphics.FillRectangle(new SolidBrush(SolidColorHighlight), new Rectangle(e.Bounds.X, e.Bounds.Y, e.Bounds.Width, e.Bounds.Height - 1));
                    e.Graphics.DrawString(this.Items[e.Index].ToString(), e.Font, new SolidBrush(FontColorHighlight), stringRect, StringFormat.GenericDefault);
                }
                else
                {
                    if (e.Index % 2 == 0)
                        e.Graphics.FillRectangle(new SolidBrush(BackColor), e.Bounds);
                    else
                        if (GradientStrip)
                            e.Graphics.FillRectangle(new LinearGradientBrush(e.Bounds, GradientColorStrip1, GradientColorStrip2, LinearGradientMode.Vertical), e.Bounds);
                        else
                            e.Graphics.FillRectangle(new SolidBrush(SolidColorStrip), e.Bounds);
                    e.Graphics.DrawString(this.Items[e.Index].ToString(), e.Font, new SolidBrush(ForeColor), stringRect, StringFormat.GenericDefault);
                }
            }
        }
    }
}
