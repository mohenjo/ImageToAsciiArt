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
            Bitmap sampleBitmap = Properties.Resources.sample_image;
            string OriginalImagePath = Path.Combine(System.Environment.CurrentDirectory, "sample_image.jpg");
            sampleBitmap.Save(OriginalImagePath);
            System.Diagnostics.Process.Start(OriginalImagePath);

            AsciiArt asciiArt = new AsciiArt(sampleBitmap);

            string asciiArtString = asciiArt.GetAsciiArt(200, true);
            string AsciiArtPath = Path.Combine(System.Environment.CurrentDirectory, "sample_image.txt");
            File.WriteAllText(AsciiArtPath, asciiArtString, Encoding.Default);
            System.Diagnostics.Process.Start(AsciiArtPath);
        }
    }
}
