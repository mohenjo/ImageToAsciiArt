using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Drawing;
using ImageToAsciiArt;


namespace ConsoleTestbed
{
    class Program
    {
        static void Main()
        {
            string imageUrl = @"C:\Users\haenn\Downloads\Korea.jpg";
            Bitmap bitmap = new Bitmap(imageUrl, true);
            Bitmap newBitmap = AsciiArt.GetResizedBitmap(bitmap, 256);
            newBitmap.Save(imageUrl + "-new.jpg", System.Drawing.Imaging.ImageFormat.Jpeg);
        }
    }
}
