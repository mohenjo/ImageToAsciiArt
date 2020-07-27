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
            Bitmap sampleBitmap = Properties.Resources.cat;
            string OriginalImagePath = Path.Combine(System.Environment.CurrentDirectory, "sample_image.png");
            sampleBitmap.Save(OriginalImagePath);
            System.Diagnostics.Process.Start(OriginalImagePath);

            AsciiArt asciiArt = new AsciiArt(sampleBitmap);

            string asciiArtString = asciiArt.GetAsciiArt(256, true);
            string AsciiArtPath = Path.Combine(System.Environment.CurrentDirectory, "sample_image.txt");
            File.WriteAllText(AsciiArtPath, asciiArtString, Encoding.Default);
        }
    }
}
