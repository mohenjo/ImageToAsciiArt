# Image to Ascii Art

Generating text/html ascii art from image (.NET Framework library)

![text_screenshot](https://user-images.githubusercontent.com/66149782/88767124-239c8480-d1b4-11ea-98ea-3d01743d67d4.jpg)
![html_screenshot](https://user-images.githubusercontent.com/66149782/88767687-f6040b00-d1b4-11ea-8ad4-d700b0df0179.jpg)

## `AsciiArt` Class

### Constructor

+ `public AsciiArt(Bitmap bitmap)`

### Enum

+ `AsciiArt.ArtType.Text`: return as string
+ `AsciiArt.ArtType.Html`: return as coloured html

### Properties

+ `public Bitmap OriginalBitmap`

### Method

+ `public string GetAsciiArt(int width, ArtType artType)`
  + `int width`: the width of ascii art



## Project Info

### Version

+ Version 1.2007

### Dev Tools

+ C# (.NET Framework 4.7.2)
+ Microsoft Visual Studio Community 2019

### Environments

+ Test Environment

    + Microsoft Windows 10 (x64)
    
+ Dependencies / 3rd-party package(s)

    + None



## License

+ MIT License


