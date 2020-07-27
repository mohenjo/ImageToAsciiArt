using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Drawing;

namespace ImageToAsciiArt
{
    /// <summary>
    /// 아스키 아트의 표현을 위한 클래스
    /// </summary>
    public class AsciiArt
    {
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
    }
}
