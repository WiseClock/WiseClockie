using System;
using System.Windows.Forms;

namespace WiseClockie.Forms
{
    public class WiseListView : ListView
    {
        public WiseListView()
            : base()
        {
            this.FullRowSelect = true;
        }

        protected override void OnHandleCreated(EventArgs e)
        {
            base.OnHandleCreated(e);
            if (!this.DesignMode && Environment.OSVersion.Platform == PlatformID.Win32NT && Environment.OSVersion.Version.Major >= 6)
            {
                NativeMethod.SetWindowTheme(this.Handle, "explorer", null);
            }
        }
    }
}
