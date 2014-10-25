using System;
using System.Windows.Forms;

namespace WiseClockie.Forms
{
    public class WiseTreeView : TreeView
    {
        public WiseTreeView()
            : base()
        {
            this.HotTracking = true;
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
