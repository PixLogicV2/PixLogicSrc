using System;
using System.Collections.Generic;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PixLogic.DAL
{
    class ByteArrayToImage
    {
        public Image byteArrayToImage(byte[] byteArrayIn)
        {
            if (byteArrayIn != null)
            {
                MemoryStream ms = new MemoryStream(byteArrayIn);
                Image returnImage = Image.FromStream(ms);
                return returnImage;
            }
            else return null;
        }
    }
}
