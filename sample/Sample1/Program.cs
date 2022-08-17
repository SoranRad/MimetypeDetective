using System;
using System.IO;
using System.Text;
using TwentyDevs.MimeTypeDetective;

namespace Sample1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // --------------------
            // XML Mimetype Adding To List 
            // --------------------

            var headerXML = new byte?[]
            {
                0x3c, 0x3f, 0x78, 0x6d, 0x6c, 0x20, 0x76, 0x65, 0x72, 0x73, 0x69, 0x6f, 0x6e, 0x3d, 0x22, 0x31, 0x2e,
                0x30, 0x22, 0x20, 0x65, 0x6e, 0x63, 0x6f, 0x64, 0x69, 0x6e, 0x67, 0x3d, 0x22, 0x75, 0x74, 0x66, 0x2d,
                0x38, 0x22, 0x3f, 0x3e
            };

            MimeTypes.Add
            (
                fileContent: headerXML,
                headerOffset: 0,
                headerSize: headerXML.Length,
                extension: "svg",
                mimeType: "image/svg+xml",
                description: "Scalable Vector Graphics is an XML-based vector",
                mustBeDetectByExtention: true

            );


            //--------------------
            //Mimetype Detection
            //--------------------

            Console.Write($"Enter File Path :>");
            var filePath = Console.ReadLine();
            //var buffer      = File.ReadAllBytes(filePath);
            var stream = File.OpenRead(filePath);

            //var mimetype    = MimeTypeDetection.GetMimeType(filePath);
            //var mimetype    = MimeTypeDetection.GetMimeType(buffer, Path.GetExtension(filePath));
            var mimetype = MimeTypeDetection.GetMimeType(stream, Path.GetExtension(filePath));

            
            if (mimetype == null)
            {
                Console.WriteLine($"Sorry,No Item Found.");
            }
            else
            {
                Console.WriteLine($"Extention:{mimetype.Extension}");
                Console.WriteLine($"miemtype:{mimetype.MimeType}");
                Console.WriteLine($"Description:{mimetype.Description}");
            }


            Console.ReadKey();
        }
    }
}
