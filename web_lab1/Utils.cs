using System;
using System.Collections.Generic;
using System.Drawing;
using System.IO;
using System.Text;

namespace web_lab1
{
    static class Utils
    {
        public static byte[] ToByteArray(this Image imageIn)
        {
            using var ms = new MemoryStream();
            imageIn.Save(ms, System.Drawing.Imaging.ImageFormat.Gif);

            return ms.ToArray();
        }

        public static Image ToImage(this byte[] byteArrayIn)
        {
            using var ms = new MemoryStream(byteArrayIn);
            var returnImage = Image.FromStream(ms);

            return returnImage;
        }
    }
}
