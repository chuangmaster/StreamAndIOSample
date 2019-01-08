using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StreamAndIOSample
{
    public class IOService
    {
        //stream to bytes
        public static byte[] StreamToByte(Stream stream)
        {
            byte[] bytes = new byte[stream.Length];
            stream.Read(bytes, 0, bytes.Length);
            stream.Seek(0, SeekOrigin.Begin);//將串流設回起始
            stream.Close();
            return bytes;
        }

        //bytes to stream
        public static Stream ByteToStream(byte[] bytes)
        {
            Stream stream = new MemoryStream(bytes);
            return stream;
        }

        //write stream to file
        public static void StreamToFile(string filePath, Stream stream)
        {
            byte[] bytes = StreamToByte(stream);
            FileStream fs = new FileStream(filePath, FileMode.Create);
            fs.Write(bytes, 0, bytes.Length);
            fs.Close();
        }

        // read file to stream
        public static Stream FileToStream(string filePath)
        {
            FileStream fs = new FileStream(filePath, FileMode.Open);
            byte[] bytes = new byte[fs.Length];
            fs.Read(bytes, 0, bytes.Length);
            fs.Close();
            Stream stream = new MemoryStream(bytes);
            return stream;
        }
    }
}
