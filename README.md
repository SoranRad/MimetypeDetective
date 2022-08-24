# MimetypeDetective


[![Build&Test](https://github.com/20Devs/MimetypeDetective/actions/workflows/ci.yml/badge.svg)](https://github.com/20Devs/MimetypeDetective/actions/workflows/ci.yml)
[![NuGet Badge](https://buildstats.info/nuget/TwentyDevs.MimeTypeDetective)](https://www.nuget.org/packages/TwentyDevs.MimeTypeDetective/)

A simple library to detect mimetype of a file, stream or buffer array via magic numbers in the header content. It contains over 480 samples that as hardcoded in the library.

Detect mimetype of an extension string or mimetype string like “rar”, “exe”,” image/gif” ….
It is possible to add more mimetypes in the library to detect files related to them. In fact, this library finds the mimetype via magic numbers.


### Installing Package
    Install-Package TwentyDevs.MimeTypeDetective
    
### Or via the .NET Core command line interface:
    dotnet add package TwentyDevs.MimeTypeDetective	

to detect a mimetype of a file with the address : 

```csharp
MimeTypeDetection.GetMimeType(filePath, Path.GetExtension(filePath));
```
In the example, passed the extension to method because some files like fdf, pdf, zip, and office files(xlsx, Docx, … ) have the same magic numbers, then detection must be done by extension.
Also, it is possible to Detect the mimetype of streams and buffers (byte array) with the method.

To get the mimetype of an extension :

```csharp
MimeTypeDetection.GetMimeTypeByExtension("rar");
```
To get other information about the particular mimetype :

```csharp
MimeTypeDetection.GetMimeTypeinfoByMimetypeString("image/gif");
```

Except for mimetypes that are defined in the library you can add other mimetype to the mimetypes collection.


```csharp
MimeTypes.Add
            (
                fileContent,
                headerOffset,
                headerSize,
                extension,
                mimeType,
                description,
                mustBeDetectByExtention
            );
```

There is a sample in the source code to add a new mimetype and then use it to detect a file (SVG File).

### Using To File Validation 

I will develope some attributes in asp.net to validate files via this library.
I’ll link it here so follow us.

### Donate Us

<a href="https://www.buymeacoffee.com/20devs" target="_blank"><img src="https://cdn.buymeacoffee.com/buttons/default-orange.png" alt="Buy Me A Coffee" height="41" width="174"></a>


