using System;
using System.Drawing;
using System.Windows.Forms;

namespace WiseClockie.Forms
{
    public class WiseCheckBox : CheckBox
    {
        private Color _borderColorNormal = Color.LightBlue;
        private Color _borderColorHover = Color.DarkBlue;
        private Color _fillColorNormal = Color.LightBlue;
        private Color _fillColorChecked = Color.DarkBlue;

        public WiseCheckBox()
        {
            this.SetStyle(ControlStyles.UserPaint, true);
            this.SetStyle(ControlStyles.AllPaintingInWmPaint, true);
        }

        protected override void OnPaint(PaintEventArgs pevent)
        {
            base.OnPaint(pevent);

            if (this.Appearance == global::System.Windows.Forms.Appearance.Normal)
            {
                if (this.Checked)
                {
                    pevent.Graphics.FillRectangle(new SolidBrush(Color.Blue), new Rectangle(0, this.Height / 2 - 7, 14, 14));
                }
                else
                {
                    pevent.Graphics.FillRectangle(new SolidBrush(Color.Red), new Rectangle(0, this.Height / 2 - 7, 14, 14));
                }
            }
        }
    }
}
