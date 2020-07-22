using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Drawing;

namespace ImageToAsciiArt
{
    /// <summary>
    /// 아스키 아트를 나타내는 클래스
    /// </summary>
    public class AsciiArt
    {
        /// <summary>
        /// 아스키 아트
        /// </summary>
        /// <param name="bitmapImage">원본 비트맵 이미지</param>
        /// <param name="asciiWidth">출력되는 아스키 글자의 폭</param>
        public AsciiArt(Bitmap bitmapImage, int asciiWidth)
        {
            BitmapImage = bitmapImage;
            AsciiWidth = asciiWidth;
            ResizedBitmapImage = GetResizedBitmap(BitmapImage, AsciiWidth);
        }

        /// <summary>
        /// 원본 비트맵 이미지
        /// </summary>
        public Bitmap BitmapImage { get; }

        /// <summary>
        /// 아스키 출력폭과 동일하게 사이즈가 변경된 비트맵 이미지
        /// </summary>
        public Bitmap ResizedBitmapImage { get; }

        /// <summary>
        /// 출력되는 아스키 글자의 폭
        /// </summary>
        public int AsciiWidth { get; }

        /// <summary>
        /// 비트맵 이미지의 크기를 변경합니다.
        /// </summary>
        /// <param name="bitmap">변경할 원본 비트맵</param>
        /// <param name="width">이미지의 가로 크기(픽셀)</param>
        /// <returns></returns>
        private static Bitmap GetResizedBitmap(Bitmap bitmap, int width)
        {
            // scale factor = ascii width / image width
            // ascii height = scale factor * image height
            int height = (int)Math.Ceiling((double)width / bitmap.Width * bitmap.Height);

            Bitmap resizedBitmap = new Bitmap(width, height);
            Graphics graphics = Graphics.FromImage(resizedBitmap);
            graphics.InterpolationMode = System.Drawing.Drawing2D.InterpolationMode.HighQualityBicubic;
            graphics.DrawImage(bitmap, 0, 0, width, height);
            graphics.Dispose();

            return resizedBitmap;
        }

        private string ConvertBitmapToAscii()
        {
            return string.Empty;
        }

        
    }
}
