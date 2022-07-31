using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;

namespace TwentyDevs.MimeTypeDetective
{
    /// <summary>
    /// Declared about 600 mimetypes in a static list.
    /// if you want to add another mimetype use add method.Or create a new issue in github repository.
    /// </summary>
    public static class MimeTypes
    {
        /// <summary>
        /// A list of all mimetype about 600
        /// </summary>
        private static List<MimeTypeInfo> mimeTypeList;

        public static IEnumerable<MimeTypeInfo> MimeTypeList => mimeTypeList.AsEnumerable();

        public readonly static MimeTypeInfo TXT = new MimeTypeInfo(new byte?[0], "txt", "text/plain",false);
        public readonly static MimeTypeInfo ZIP = new MimeTypeInfo(new byte?[] { 0x50, 0x4B, 0x03, 0x04 }, "zip", "application/x-compressed", true);


        /// <summary>
        /// Initialize to create mimetype in a list.
        /// </summary>
        static MimeTypes()
        {
            mimeTypeList = new List<MimeTypeInfo>()
            {
                TXT,
                ZIP
            };
        }

        /// <summary>
        /// Add new mimetype to the list of mimetypes.
        /// </summary>
        /// <param name="mimeType">New mimetype add to list of mimetypes.</param>
        public static void Add(MimeTypeInfo mimeType)
        {
            mimeTypeList.Add(mimeType);
        }

        /// <summary>
        /// Add new mimetype to the list of mimetypes from a file path.
        /// </summary>
        /// <param name="filePath">path of the file that want to add the list.</param>
        /// <param name="headerOffset">how far is the header from begin of file content</param>
        /// <param name="headerSize">size of header to read.length fo the header</param>
        /// <param name="extension">mimetype extention like "mp3","avi",... </param>
        /// <param name="mimeType">
        /// Mimetype of file.a MimeType most-commonly consists of just two parts,
        /// a type and a subtype,
        /// separated by a slash (/) — with no whitespace between:
        ///  "video/3gpp","image/x-icon"
        /// </param>
        public static void Add(
            string filePath, 
            int headerOffset,
            int headerSize,
            string extension,
            string mimeType
            )
        {
            byte[] headerContent = new byte[headerSize];
            using (FileStream fsSource = new FileStream(filePath, FileMode.Open, FileAccess.Read, FileShare.ReadWrite))
            {
                fsSource.Read(headerContent, headerOffset, headerSize);
            }

            var header = Array.ConvertAll<byte, byte?>(headerContent, input => input);

            mimeTypeList.Add
            (
                new MimeTypeInfo(header, headerOffset, extension, mimeType,false)
            );
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="fileInfo">determine the file that needs its mimetype</param>
        /// <param name="headerOffset">how far is the header from begin of file content</param>
        /// <param name="headerSize">size of header to read.length fo the header</param>
        /// <param name="extension">mimetype extention like "mp3","avi",... </param>
        /// <param name="mimeType">
        /// Mimetype of file.a MimeType most-commonly consists of just two parts,
        /// a type and a subtype,
        /// separated by a slash (/) — with no whitespace between:
        ///  "video/3gpp","image/x-icon"
        /// </param>
        public static void Add(
            FileInfo fileInfo,
            int headerOffset,
            int headerSize,
            string extension,
            string mimeType
        )
        {
            byte[] headerContent = new byte[headerSize];
            using (FileStream stream = fileInfo.OpenRead())
            {
                stream.Read(headerContent, headerOffset, headerSize);
            }

            var header = Array.ConvertAll<byte, byte?>(headerContent, input => input);

            mimeTypeList.Add
                (
                new MimeTypeInfo(header, headerOffset,extension,mimeType, false)    
                );
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="stream">determine stream that needs </param>
        /// <param name="headerOffset">how far is the header from begin of file content</param>
        /// <param name="headerSize">size of header to read.length fo the header</param>
        /// <param name="extension">mimetype extention like "mp3","avi",... </param>
        /// <param name="mimeType">
        /// Mimetype of file.a MimeType most-commonly consists of just two parts,
        /// a type and a subtype,
        /// separated by a slash (/) — with no whitespace between:
        ///  "video/3gpp","image/x-icon"
        /// </param>
        public static void Add(
            Stream stream,
            int headerOffset,
            int headerSize,
            string extension,
            string mimeType
        )
        {
            byte[] headerContent = new byte[headerSize];
           
            stream.Read(headerContent, headerOffset, headerSize);

            var header = Array.ConvertAll<byte, byte?>(headerContent, input => input);

            mimeTypeList.Add
            (
                new MimeTypeInfo(header, headerOffset, extension, mimeType, false)
            );
        }



    }
}
