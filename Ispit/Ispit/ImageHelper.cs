using System;
using System.Collections.Generic;
using System.Drawing;
using System.Drawing.Imaging;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Februarski_3
{
   class ImageHelper
    {
        static public byte[] FromImageToByte(Image slika)
        {
            MemoryStream ms = new MemoryStream();
            slika.Save(ms, ImageFormat.Jpeg);
            return ms.ToArray();
        }
        static public Image FromByteToImage(byte[] slika)
        {
            MemoryStream ms = new MemoryStream(slika);
            return Image.FromStream(ms);
        }
    }
}
