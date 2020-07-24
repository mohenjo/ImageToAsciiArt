"""Convert an image to an ascii art"""

from PIL import Image
import math


def resize_img(original_image, width):
    """이미지의 크기를 변경합니다.

    Args:
        original_image: PIL 이미지 개체
        width: 변경 후의 이미지 폭

    Returns:
        리사이징된 PIL 이미지 개체
    """
    # scale factor = ascii width / image width
    # ascii height = scale factor * image height
    original_width, original_height = original_image.size
    height = math.ceil(width / original_width * original_height)

    resized_img = original_image.resize((width, height))

    return resized_img

def convert_img2ascii(image):
    ascii_str = ""

    rgbimg = image.convert("RGB")
    for y in range(rgbimg.size[1]):
        for x in range(rgbimg.size[0]):
            r, g, b = rgbimg.getpixel((x, y))
            rgb = (r + g+ b) / 3
            

def _main():
    img = Image.open("./testimg.jpg")
    print(type(img))
    resized_img = resize_img(img, 80)
    resized_img.convert("RGB").show()


if __name__ == '__main__':
    _main()
