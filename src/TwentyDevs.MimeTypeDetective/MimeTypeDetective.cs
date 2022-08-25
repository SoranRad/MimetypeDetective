using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace TwentyDevs.MimeTypeDetective
{
    /// <summary>
    /// A class that contain methos to find and detect miemtype of  a file Path or stream or Extension.
    /// </summary>
    public static class MimeTypeDetection
    {
        /// <summary>
        /// Maximume header size must be read to detect the mimetype.
        /// </summary>
        public  const int MaxHeaderSize = 570;

        /// <summary>
        /// determine mimetype of the Extension.
        /// </summary>
        /// <param name="extentin">the Extension that its mimetype required</param>
        /// <returns>all information of the mimetype </returns>
        public static MimeTypeInfo GetMimeTypeByExtension(string extentin)
        {
            extentin = MimeTypeInfo.NormalizeExtension(extentin);
            return MimeTypes.MimeTypeList.FirstOrDefault(x => x.Extension == extentin);
        }

        /// <summary>
        /// determine mimetype information  of the mimetype string.
        /// this method usefull to return header content or magic numner of a mimetype
        /// </summary>
        /// <param name="mimetype">the mimetype that its information required</param>
        /// <returns>all information of the mimetype </returns>
        public static MimeTypeInfo GetMimeTypeinfoByMimetypeString(string mimetype)
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
        /// Determin the  mimetype of the file by its path.
        /// </summary>
        /// <param name="FilePath">string that contain path of file</param>
        /// <param name="token">Cancellation token</param>
        /// <returns>all information of the mimetype</returns>
        public async static Task<MimeTypeInfo> GetMimeTypeAsync(string FilePath, CancellationToken token = default)
        {
            var header = await ReadHeaderContentAsync(FilePath, token);

            return FindMimeTpe(header, Path.GetExtension(FilePath));

        }

        /// <summary>
        /// return the  mimetype of byte ararys.
        /// </summary>
        /// <param name="FileContent"> determine the contnet of array want to find its mimetype</param>
         /// <param name="Extension"></param>
        /// <returns>all information of the mimetype</returns>
        public static MimeTypeInfo GetMimeType(this byte[] FileContent, string Extension = "")
        {
            var header = Array.ConvertAll<byte, byte?>(FileContent.Take(MaxHeaderSize).ToArray(), input => input);

            return FindMimeTpe(header, Extension);
        }

        /// <summary>
        /// return the  mimetype of the stream.
        /// </summary>
        /// <param name="stream"> determine the stream want to find its mimetype</param>
        /// <param name="Extension"></param>
        /// <returns>all information of the mimetype</returns>
        public static MimeTypeInfo GetMimeType(this Stream stream, string Extension = "")
        {
            var header = ReadHeaderContent(stream);

            return FindMimeTpe(header, Extension);
        }
        
        /// <summary>
        /// return the  mimetype of the stream.
        /// </summary>
        /// <param name="stream"> determine the stream want to find its mimetype</param>
        /// <param name="Extension"></param>
        /// <param name="token"></param>
        /// <returns>all information of the mimetype</returns>
        public async static Task<MimeTypeInfo> GetMimeTypeAsync(this Stream stream, string Extension = "", CancellationToken token = default)
        {
            var header = await ReadHeaderContentAsync(stream, token);

            return FindMimeTpe(header, Extension);
        }
        /// <summary>
        /// return the  mimetype of the stream.
        /// </summary>
        /// <param name="file"> determine the stream want to find its mimetype</param>
        /// <param name="Extension"></param>
        /// <returns>all information of the mimetype</returns>
        public static MimeTypeInfo GetMimeType(this FileInfo file, string Extension = "")
        {
            var header = ReadHeaderContent(file);

            return FindMimeTpe(header, MimeTypeInfo.NormalizeExtension( file.Extension));
        }
         /// <summary>
        /// return the  mimetype of the stream.
        /// </summary>
        /// <param name="file"> determine the stream want to find its mimetype</param>
        /// <param name="Extension"></param>
        /// <param name="token"></param>
        /// <returns>all information of the mimetype</returns>
        public async static Task<MimeTypeInfo> GetMimeTypeAsync(this FileInfo file, string Extension = "" , CancellationToken token = default)
        {
            var header = await ReadHeaderContentAsync(file, token);

            return FindMimeTpe(header, MimeTypeInfo.NormalizeExtension( file.Extension));
        }

        /// <summary>
        /// find mimetype of a byte array
        /// </summary>
        /// <param name="headerContent">determine the header content that its mimetype required</param>
        /// <param name="Extension">
        /// some mimetype have a same header content like zip and office documents
        /// </param>
        /// <returns>all information of the mimetype</returns>
        private static MimeTypeInfo FindMimeTpe(byte?[] headerContent,string Extension ="")
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

                    if (mimeType.MustBeDetectByExtension && !string.IsNullOrWhiteSpace(Extension))
                        return GetMimeTypeByExtension(Extension);
                    
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
        /// <param name="token"></param>
        /// <returns></returns>
        /// <exception cref="ApplicationException"></exception>
        private async static Task<byte?[]> ReadHeaderContentAsync (FileInfo file, CancellationToken token)
        {
            var headerContent = new byte[MaxHeaderSize];
            try   
            {
                using (var fileStream = file.OpenRead())
                { 
                   await fileStream.ReadAsync(headerContent, 0, MaxHeaderSize, token);
                }
                return Array.ConvertAll<byte, byte?>(headerContent, input => input);
            }
            catch (Exception e) 
            {
                throw new ApplicationException("Could not read header file : " + e.Message);
            }
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
           private async static Task<byte?[]> ReadHeaderContentAsync (Stream stream, CancellationToken token)
        {
            var headerContent = new byte[MaxHeaderSize];

            try
            {
                await stream.ReadAsync(headerContent, 0, MaxHeaderSize, token);
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
          private async static Task<byte?[]> ReadHeaderContentAsync (string FilePath, CancellationToken token)
        {
            var headerContent = new byte[MaxHeaderSize];

            try   
            {
                using (FileStream fsSource = new FileStream(FilePath, FileMode.Open, FileAccess.Read,FileShare.ReadWrite))
                {
                    await fsSource.ReadAsync(headerContent, 0, MaxHeaderSize, token);
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
