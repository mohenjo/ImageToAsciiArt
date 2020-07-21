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
        /// <param name="bitmapImage">비트맵 이미지</param>
        /// <param name="asciiWidth">출력되는 아스키 글자의 폭</param>
        public AsciiArt(Bitmap bitmapImage, int asciiWidth)
        {
            BitmapImage = bitmapImage;
            AsciiWidth = asciiWidth;
        }

        /// <summary>
        /// 비트맵 이미지
        /// </summary>
        public Bitmap BitmapImage { get; }

        /// <summary>
        /// 출력되는 아스키 글자의 폭
        /// </summary>
        public int AsciiWidth { get; }

        
    }
}
