using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;

namespace TwentyDevs.MimeTypeDetective
{
    /// <summary>
    /// A class that contain methos to find and detect miemtype of  a file Path or stream or extention.
    /// </summary>
    public static class MimeTypeDetection
    {
        /// <summary>
        /// Maximume header size must be read to detect the mimetype.
        /// </summary>
        public  const int MaxHeaderSize = 570;

        /// <summary>
        /// determine mimetype of the extention.
        /// </summary>
        /// <param name="extentin">the extention that its mimetype required</param>
        /// <returns>all information of the mimetype </returns>
        public static MimeTypeInfo GetMimeTypeByExtention(string extentin)
        {
            extentin = MimeTypeInfo.NormalizeExtention(extentin);
            return MimeTypes.MimeTypeList.FirstOrDefault(x => x.Extension == extentin);
        }

        /// <summary>
        /// determine mimetype information  of the mimetype string.
        /// this method usefull to return header content or magic numner of a mimetype
        /// </summary>
        /// <param name="mimetype">the mimetype that its information required</param>
        /// <returns>all information of the mimetype </returns>
        public static MimeTypeInfo GetMimeTypeinfoByMimetypestring(string mimetype)
        {
            mimetype = MimeTypeInfo.NormalizeMimeType(mimetype);
            return MimeTypes.MimeTypeList.FirstOrDefault(x => x.MimeType == mimetype);
             
        }

        /// <summary>
        /// Determin the  mimetype of the file by its path.
        /// </summary>
        /// <param name="FilePath">string that contain path of file</param>
        /// <returns>all information of the mimetype</returns>
        public static MimeTypeInfo GetMimeType(string FilePath )
        {
            var header = ReadHeaderContent(FilePath);

            return FindMimeTpe(header, Path.GetExtension(FilePath));

        }

        /// <summary>
        /// return the  mimetype of byte ararys.
        /// </summary>
        /// <param name="FileContent"> determine the contnet of array want to find its mimetype</param>
        /// <returns>all information of the mimetype</returns>
        public static MimeTypeInfo GetMimeType(this byte[] FileContent, string extention = "")
        {
            var header = Array.ConvertAll<byte, byte?>(FileContent.Take(MaxHeaderSize).ToArray(), input => input);

            return FindMimeTpe(header, extention);
        }

        /// <summary>
        /// return the  mimetype of the stream.
        /// </summary>
        /// <param name="stream"> determine the stream want to find its mimetype</param>
        /// <returns>all information of the mimetype</returns>
        public static MimeTypeInfo GetMimeType(this Stream stream, string extention = "")
        {
            var header = ReadHeaderContent(stream);

            return FindMimeTpe(header, extention);
        }

        /// <summary>
        /// return the  mimetype of the stream.
        /// </summary>
        /// <param name="stream"> determine the stream want to find its mimetype</param>
        /// <returns>all information of the mimetype</returns>
        public static MimeTypeInfo GetMimeType(this FileInfo file, string extention = "")
        {
            var header = ReadHeaderContent(file);

            return FindMimeTpe(header, MimeTypeInfo.NormalizeExtention( file.Extension));
        }

        /// <summary>
        /// find mimetype of a byte array
        /// </summary>
        /// <param name="headerContent">determine the header content that its mimetype required</param>
        /// <param name="extention">
        /// some mimetype have a same header content like zip and office documents
        /// </param>
        /// <returns>all information of the mimetype</returns>
        private static MimeTypeInfo FindMimeTpe(byte?[] headerContent,string extention ="")
        {
            //// if all headers are null value it is a text file.
            //if (headerContent.All(b => b != 0))
            //    return MimeTypes.TXT;


            // search the all list of 
            foreach (var mimeType in MimeTypes.MimeTypeList)
            {

                var header = mimeType.HeaderContent;
                if (CompareBuffer(ref headerContent, ref header, mimeType.HeaderOffset))
                {

                    if (mimeType.MustBeDetectByExtention && !string.IsNullOrWhiteSpace(extention))
                        return GetMimeTypeByExtention(extention);
                    
                    return mimeType;
                }
            }

            return null;
        }

        /// <summary>
        /// compare two byte array to detect are equals .
        /// </summary>
        /// <param name="Buffer1"></param>
        /// <param name="Buffer2"></param>
        /// <param name="startIndexOfBuffer1"></param>
        /// <returns>return true if sequential arrays are equal else return false.</returns>
        private static bool CompareBuffer(ref byte?[] Buffer1,ref byte?[] Buffer2, int startIndexOfBuffer1)
        {
            if (Buffer1 == null || Buffer2 == null || Buffer2.Length == 0)
                return false;

            if (Buffer1.Length < (Buffer2.Length + startIndexOfBuffer1))
                return false;

            for (int i = 0; i < Buffer2.Length; i++)
            {
                // if the first difference occurred return false
                if (Buffer1[i + startIndexOfBuffer1] != Buffer2[i])
                    return false;
            }
            return true;
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="file"></param>
        /// <returns></returns>
        /// <exception cref="ApplicationException"></exception>
        private static byte?[] ReadHeaderContent (FileInfo file)
        {
            var headerContent = new byte[MaxHeaderSize];
            try   
            {
                using (var fileStream = file.OpenRead())
                { 
                    fileStream.Read(headerContent, 0, MaxHeaderSize);
                }
                return Array.ConvertAll<byte, byte?>(headerContent, input => input);
            }
            catch (Exception e) 
            {
                throw new ApplicationException("Could not read header file : " + e.Message);
            }
        }
        private static byte?[] ReadHeaderContent (Stream stream)
        {
            var headerContent = new byte[MaxHeaderSize];

            try
            {
                stream.Read(headerContent, 0, MaxHeaderSize);
                return Array.ConvertAll<byte, byte?>(headerContent, input => input);
            }
            catch (Exception e)
            {
                throw new ApplicationException("Could not read header file : " + e.Message);
            }


        }
        private static byte?[] ReadHeaderContent (string FilePath)
        {
            var headerContent = new byte[MaxHeaderSize];

            try   
            {
                using (FileStream fsSource = new FileStream(FilePath, FileMode.Open, FileAccess.Read,FileShare.ReadWrite))
                {
                    fsSource.Read(headerContent, 0, MaxHeaderSize);
                }   

            }
            catch (Exception e) // file could not be found/read
            {
                throw new ApplicationException("Could not read file : " + e.Message);
            }

            return Array.ConvertAll<byte, byte?>(headerContent, input => input);

        }
    }
}
