using System;
using System.IO;
using System.Runtime.InteropServices;
using System.Text;

namespace WiseClockie.Media
{
    public class WiseSoundPlayer
    {
        [DllImport("winmm.dll")]
        private static extern long mciSendString(string strCommand, StringBuilder strReturn, int iReturnLength, IntPtr hwndCallback);

        /// <summary>
        /// Plays sound from a file.
        /// </summary>
        /// <param name="FileName">the media file name</param>
        /// <param name="Repeat">continuously play the sound</param>
        public static void Play(string FileName, bool Repeat)
        {
            mciSendString("stop MediaFile", null, 0, IntPtr.Zero);
            mciSendString("close MediaFile", null, 0, IntPtr.Zero);
            mciSendString("open \"" + FileName + "\" type mpegvideo alias MediaFile", null, 0, IntPtr.Zero);
            mciSendString("play MediaFile" + (Repeat ? " repeat" : String.Empty), null, 0, IntPtr.Zero);
        }

        /// <summary>
        /// Plays sound from a resource.
        /// </summary>
        /// <param name="Resource">the resource</param>
        /// <param name="Repeat">continuously play the sound</param>
        public static void Play(byte[] Resource, bool Repeat)
        {
            mciSendString("stop MediaFile", null, 0, IntPtr.Zero);
            mciSendString("close MediaFile", null, 0, IntPtr.Zero);
            extractResource(Resource, Path.GetTempPath() + "resource.tmp");
            mciSendString("open \"" + Path.GetTempPath() + "resource.tmp" + "\" type mpegvideo alias MediaFile", null, 0, IntPtr.Zero);
            mciSendString("play MediaFile" + (Repeat ? " repeat" : String.Empty), null, 0, IntPtr.Zero);
        }

        /// <summary>
        /// Pause playing the sound.
        /// </summary>
        public static void Pause()
        {
            mciSendString("stop MediaFile", null, 0, IntPtr.Zero);
        }

        /// <summary>
        /// Stop playing the sound.
        /// </summary>
        public static void Stop()
        {
            mciSendString("close MediaFile", null, 0, IntPtr.Zero);
        }

        private static void extractResource(byte[] res, string filePath)
        {
            FileStream fs;
            BinaryWriter bw;

            if (File.Exists(filePath))
            {
                File.Delete(filePath);
            }
            fs = new FileStream(filePath, FileMode.OpenOrCreate);
            bw = new BinaryWriter(fs);

            foreach (byte b in res)
            {
                bw.Write(b);
            }

            bw.Close();
            fs.Close();
        }
    }
}
