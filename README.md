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

