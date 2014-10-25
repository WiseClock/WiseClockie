//Copyright (c) 2011 Josip Medved <jmedved@jmedved.com>  http://www.jmedved.com

using System;
using System.IO;
using System.Runtime.InteropServices;
using System.Windows.Forms;

namespace WiseClockie.System
{
    public class OpenDirectoryDialog
    {
        /// <summary>
        /// Gets/sets folder in which dialog will be open.
        /// </summary>
        public string InitialFolder { get; set; }

        /// <summary>
        /// Gets/sets directory in which dialog will be open if there is no recent directory available.
        /// </summary>
        public string DefaultFolder { get; set; }

        /// <summary>
        /// Gets selected folder.
        /// </summary>
        public string Folder { get; private set; }

        public DialogResult ShowDialog()
        {
            Form f = new Form();
            DialogResult ret = ShowDialog(f);
            f.Dispose();
            f = null;
            return ret;
        }

        public DialogResult ShowDialog(IWin32Window owner)
        {
            if (Environment.OSVersion.Version.Major >= 6)
            {
                return ShowVistaDialog(owner);
            }
            else
            {
                return ShowLegacyDialog(owner);
            }
        }

        private DialogResult ShowVistaDialog(IWin32Window owner)
        {
            var frm = (NativeMethod.IFileDialog)(new NativeMethod.FileOpenDialogRCW());
            uint options;
            frm.GetOptions(out options);
            options |= NativeMethod.FOS_PICKFOLDERS | NativeMethod.FOS_FORCEFILESYSTEM | NativeMethod.FOS_NOVALIDATE | NativeMethod.FOS_NOTESTFILECREATE | NativeMethod.FOS_DONTADDTORECENT;
            frm.SetOptions(options);
            if (this.InitialFolder != null)
            {
                NativeMethod.IShellItem directoryShellItem;
                var riid = new Guid("43826D1E-E718-42EE-BC55-A1E261C37BFE"); //IShellItem
                if (NativeMethod.SHCreateItemFromParsingName(this.InitialFolder, IntPtr.Zero, ref riid, out directoryShellItem) == NativeMethod.S_OK)
                {
                    frm.SetFolder(directoryShellItem);
                }
            }
            if (this.DefaultFolder != null)
            {
                NativeMethod.IShellItem directoryShellItem;
                var riid = new Guid("43826D1E-E718-42EE-BC55-A1E261C37BFE"); //IShellItem
                if (NativeMethod.SHCreateItemFromParsingName(this.DefaultFolder, IntPtr.Zero, ref riid, out directoryShellItem) == NativeMethod.S_OK)
                {
                    frm.SetDefaultFolder(directoryShellItem);
                }
            }

            if (frm.Show(owner.Handle) == NativeMethod.S_OK)
            {
                NativeMethod.IShellItem shellItem;
                if (frm.GetResult(out shellItem) == NativeMethod.S_OK)
                {
                    IntPtr pszString;
                    if (shellItem.GetDisplayName(NativeMethod.SIGDN_FILESYSPATH, out pszString) == NativeMethod.S_OK)
                    {
                        if (pszString != IntPtr.Zero)
                        {
                            try
                            {
                                this.Folder = Marshal.PtrToStringAuto(pszString);
                                return DialogResult.OK;
                            }
                            finally
                            {
                                Marshal.FreeCoTaskMem(pszString);
                            }
                        }
                    }
                }
            }
            return DialogResult.Cancel;
        }

        private DialogResult ShowLegacyDialog(IWin32Window owner)
        {
            using (var frm = new SaveFileDialog())
            {
                frm.CheckFileExists = false;
                frm.CheckPathExists = true;
                frm.CreatePrompt = false;
                frm.Filter = "|" + Guid.Empty.ToString();
                frm.FileName = "any";
                if (this.InitialFolder != null) { frm.InitialDirectory = this.InitialFolder; }
                frm.OverwritePrompt = false;
                frm.Title = "Select Folder";
                frm.ValidateNames = false;
                if (frm.ShowDialog(owner) == DialogResult.OK)
                {
                    this.Folder = Path.GetDirectoryName(frm.FileName);
                    return DialogResult.OK;
                }
                else
                {
                    return DialogResult.Cancel;
                }
            }
        }


        public void Dispose() { } //just to have possibility of Using statement.

    }
}
