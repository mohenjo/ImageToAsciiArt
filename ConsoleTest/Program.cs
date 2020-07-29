using ImageToAsciiArt;
using System.Drawing;
using System.IO;
using System.Text;

namespace ConsoleTest
{
    class Program
    {
        static void Main()
        {
            // 원본 이미지
            Bitmap sampleBitmap = Properties.Resources.sample_image;
            string OriginalImagePath = Path.Combine(System.Environment.CurrentDirectory, "sample_image.jpg");
            sampleBitmap.Save(OriginalImagePath);
            System.Diagnostics.Process.Start(OriginalImagePath);

            AsciiArt asciiArt = new AsciiArt(sampleBitmap);

            // 아스키 아트 생성 - text
            string asciiArtText = asciiArt.GetAsciiArt(200, AsciiArt.ArtType.Text);
            string AsciiArtTextPath = Path.Combine(System.Environment.CurrentDirectory, "sample_image.txt");
            File.WriteAllText(AsciiArtTextPath, asciiArtText, Encoding.Default);
            System.Diagnostics.Process.Start(AsciiArtTextPath);

            // 아스키 아트 생성 - html
            string asciiArtHtml = asciiArt.GetAsciiArt(200, AsciiArt.ArtType.Html);
            string AsciiArtHtmlPath = Path.Combine(System.Environment.CurrentDirectory, "sample_image.html");
            File.WriteAllText(AsciiArtHtmlPath, asciiArtHtml, Encoding.Default);
            System.Diagnostics.Process.Start(AsciiArtHtmlPath);
        }
    }
}
