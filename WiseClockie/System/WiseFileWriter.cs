using System;
using System.IO;
using System.Reflection;

namespace WiseClockie.System
{
    public class WiseFileWriter
    {
        /// <summary>
        /// Writes resource to local disk file.
        /// </summary>
        /// <param name="DestFileName">the destination file name</param>
        /// <param name="SrcResource">the source resource</param>
        public static void WriteAssetToFile(string DestFileName, byte[] SrcResource)
        {
            FileStream fs;
            BinaryWriter bw;

            if (File.Exists(DestFileName))
            {
                File.Delete(DestFileName);
            }

            fs = new FileStream(DestFileName, FileMode.OpenOrCreate);
            bw = new BinaryWriter(fs);

            foreach (byte b in SrcResource)
            {
                bw.Write(b);
            }

            bw.Close();
            fs.Close();
        }

        /// <summary>
        /// Writes the file stream into file.
        /// </summary>
        /// <param name="SrcResource">resource string, e.g.: <example>WinApp1.Resources.pic.png</example></param>
        /// <param name="DestStream">destination file stream</param>
        /// <param name="Length">the length of bytes injecting</param>
        /// <param name="Offset">the offset of destination file to write</param>
        public static void WriteStreamToFile(Stream SrcStream, string DestFileName, long Length = -1, long Offset = 0)
        {
            Stream DestStream = File.Open(DestFileName, FileMode.Open);
            DestStream.Seek(Offset, SeekOrigin.Begin);
            if (Length == -1)
            {
                Length = SrcStream.Length;
            }
            byte[] buffer = new byte[Length];
            SrcStream.Read(buffer, 0, buffer.Length);
            DestStream.Write(buffer, 0, buffer.Length);
            DestStream.Seek(0, SeekOrigin.Begin);
            DestStream.Close();
        }

        /// <summary>
        /// Writes the file stream into another one.
        /// </summary>
        /// <param name="SrcResource">resource string, e.g.: <example>WinApp1.Resources.pic.png</example></param>
        /// <param name="DestStream">destination file stream</param>
        /// <param name="Length">the length of bytes injecting</param>
        /// <param name="Offset">the offset of destination file to write</param>
        public static void WriteStreamToStream(Stream SrcStream, Stream DestStream, long Length = -1, long Offset = 0)
        {
            DestStream.Seek(Offset, SeekOrigin.Begin);
            if (Length == -1)
            {
                Length = SrcStream.Length;
            }
            byte[] buffer = new byte[Length];
            SrcStream.Read(buffer, 0, buffer.Length);
            DestStream.Write(buffer, 0, buffer.Length);
            DestStream.Seek(0, SeekOrigin.Begin);
            DestStream.Close();
        }

        /// <summary>
        /// Writes the resource to a file stream.
        /// </summary>
        /// <param name="SrcResource">resource string, e.g.: <example>WinApp1.Resources.pic.png</example></param>
        /// <param name="DestStream">destination file stream</param>
        /// <param name="Length">the length of bytes injecting</param>
        /// <param name="Offset">the offset of destination file to write</param>
        public static void WriteResourceToStream(string SrcResource, Stream DestStream, long Length = -1, long Offset = 0)
        {
            Stream SrcStream = Assembly.GetExecutingAssembly().GetManifestResourceStream(SrcResource);
            DestStream.Seek(Offset, SeekOrigin.Begin);
            if (Length == -1)
            {
                Length = SrcStream.Length;
            }
            byte[] buffer = new byte[Length];
            SrcStream.Read(buffer, 0, buffer.Length);
            DestStream.Write(buffer, 0, buffer.Length);
            DestStream.Seek(0, SeekOrigin.Begin);
            DestStream.Close();
        }
    }
}
