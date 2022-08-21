# MimetypeDetective


[![Build&Test](https://github.com/20Devs/MimetypeDetective/actions/workflows/ci.yml/badge.svg)](https://github.com/20Devs/MimetypeDetective/actions/workflows/ci.yml)
[![NuGet Badge](https://buildstats.info/nuget/TwentyDevs.MimeTypeDetective)](https://www.nuget.org/packages/TwentyDevs.MimeTypeDetective/)

A simple library to detect mimetype of a file, stream or buffer array via magic numbers in the header content.
Detects mimetype of an extension string.
Detects all information of a mimetype string like magic numbers, extension and ... .
It Contains over than 480 mimtyps sample that  as hardcod defined  in the library.

It possible to add more mimetypes at the library to detect files related to them.In fact, this  library find the mimetype via the content of file or stream.

### Installing Package
    Install-Package MimetypeDetective
    