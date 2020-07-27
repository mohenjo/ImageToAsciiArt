"""Convert an image to an ascii art"""

from PIL import Image
import math


class AsciiArt:
    # levels of gray (70 level)
    __grayscale = "$@B%8&WM#*oahkbdpqwmZO0QLCJUYXzcvunxrjft/\|()1{}[]?-_+~<>i!lI;:,\"^`'. "

    def __init__(self, img_path: str):
        self._img_path = img_path
        self._original_img_obj = Image.open(img_path)

    def show_original_img(self):
        self._original_img_obj.show()

    def get_img_path(self):
        return self._img_path

    def cnvt2asc(self, width):
        pass

    @staticmethod
    def _resize_img(original_img, width):
        """이미지의 크기를 변경합니다.

        Args:
            original_img: PIL 이미지 개체
            width: 변경 후의 이미지 폭

        Returns:
            리사이징된 PIL 이미지 개체
        """
        # scale factor = ascii width / image width
        # ascii height = scale factor * image height
        original_width, original_height = original_img.size
        height = math.ceil(width / original_width * original_height)

        resized_img = original_img.resize((width, height))

        return resized_img




def convert_img2ascii(image):
    ascii_str = ""

    rgbimg = image.convert("RGB")
    for y in range(rgbimg.size[1]):
        for x in range(rgbimg.size[0]):
            r, g, b = rgbimg.getpixel((x, y))
            rgb = (r + g + b) / 3


def _main():
    img = AsciiArt("./testimg.jpg")
    img.show_original_img()
    print(img.get_img_path())

    # print(AsciiArt.grayscale)


if __name__ == '__main__':
    _main()
