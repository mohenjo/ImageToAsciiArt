using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using System.Drawing;
using ImageToAsciiArt;

namespace ConsoleTest
{
    class Program
    {
        static void Main()
        {
            Bitmap sampleBitmap = Properties.Resources.testimg;
            /*
            string OriginalImagePath = Path.Combine(System.Environment.CurrentDirectory, "testimg.jpg");
            sampleBitmap.Save(OriginalImagePath);
            System.Diagnostics.Process.Start(OriginalImagePath);
            */

            AsciiArt asciiArt = new AsciiArt(sampleBitmap);

        }
    }
}
