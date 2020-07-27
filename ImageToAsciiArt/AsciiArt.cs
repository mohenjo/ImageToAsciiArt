using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Drawing;

namespace ImageToAsciiArt
{
    public class AsciiArt
    {
        /// <summary>
        /// 아스키 아트의 표현을 위한 클래스 (70 level)
        /// </summary>
        private const string GrayScale = @"$@B%8&WM#*oahkbdpqwmZO0QLCJUYXzcvunxrjft/\|()1{}[]?-_+~<>i!lI;:,""^`'. ";

        /// <summary>
        /// AsciiArt 클래스의 인스턴스를 생성합니다.
        /// </summary>
        /// <param name="bitmap">원본 이미지의 비트맵</param>
        public AsciiArt(Bitmap bitmap)
        {
            this.OriginalBitmap = bitmap;
        }

        /// <summary>
        /// 원본 이미지의 비트맵
        /// </summary>
        public Bitmap OriginalBitmap { get; }

        /// <summary>
        /// 원본 이미지에 대한 아스키 아트 스트링을 반환합니다.
        /// </summary>
        /// <param name="width">아스키 아트의 폭</param>
        /// <param name="isOnWhiteBackground">흰색 배경에서의 표시를 기준으로 그레이 스케일을 계산할 것인지의 여부</param>
        /// <returns></returns>
        public string GetAsciiArt(int width, bool isOnWhiteBackground = true)
        {
            if (width < 80 || width > OriginalBitmap.Width)
            {
                int maxWidth = OriginalBitmap.Width;
                throw new ArgumentException($"아스키 아트의 폭은 [80, 원본이미지 폭({maxWidth}픽셀)]의 범위 내에 있어야 합니다.");
            }
            
            Bitmap bitmap = GetResizedBitmap(OriginalBitmap, width);

            StringBuilder sb = new StringBuilder();
            for (int h = 0; h < bitmap.Height; h++)
            {
                for (int w = 0; w < bitmap.Width; w++)
                {
                    Color pixelColor = bitmap.GetPixel(w, h);
                    int brightness = (int)(0.299 * pixelColor.R + 0.587 * pixelColor.G + 0.114 * pixelColor.B);
                    //int brightness = (int)(pixelColor.R + pixelColor.G + pixelColor.B) / 3;
                    Color grayColor = Color.FromArgb(brightness, brightness, brightness);

                    int grayIndex = (grayColor.R * (GrayScale.Length - 1)) / 255;
                    if (!isOnWhiteBackground)
                    {
                        grayIndex = (GrayScale.Length - 1) - grayIndex;
                    }
                    sb.Append(GrayScale[grayIndex]);
                }
                sb.AppendLine();
            }
            return sb.ToString();
        }

        /// <summary>
        /// 크기가 조절된 비트맵을 반환합니다.
        /// </summary>
        /// <param name="bitmap">원본 비트맵</param>
        /// <param name="width">변환 후 비트맵의 폭(픽셀)</param>
        /// <returns></returns>
        private static Bitmap GetResizedBitmap(Bitmap bitmap, int width)
        {
            // scale factor = new width / original width
            // new height = scale factor * original height
            int height = (int)Math.Ceiling((double)width / bitmap.Width * bitmap.Height);
            Size resize = new Size(width, height);
            return new Bitmap(bitmap, resize);
        }
    }
}
