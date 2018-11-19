using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ElasticEmail.WebApiClient.ApiTypes
{
    /// <summary>
    /// File response from the server
    /// </summary>
    public class FileData
    {
        /// <summary>
        /// File content
        /// </summary>
        public byte[] Content { get; set; }

        /// <summary>
        /// MIME content type, optional for uploads
        /// </summary>
        public string ContentType { get; set; }

        /// <summary>
        /// Name of the file this class contains
        /// </summary>
        public string FileName { get; set; }

        /// <summary>
        /// Saves this file to given destination
        /// </summary>
        /// <param name="path">Path string exluding file name</param>
        public void SaveToDirectory(string path)
        {
            System.IO.File.WriteAllBytes(Path.Combine(path, FileName), Content);
        }

        /// <summary>
        /// Saves this file to given destination
        /// </summary>
        /// <param name="pathWithFileName">Path string including file name</param>
        public void SaveTo(string pathWithFileName)
        {
            System.IO.File.WriteAllBytes(pathWithFileName, Content);
        }

        /// <summary>
        /// Reads a file to this class instance
        /// </summary>
        /// <param name="pathWithFileName">Path string including file name</param>
        public void ReadFrom(string pathWithFileName)
        {
            Content = System.IO.File.ReadAllBytes(pathWithFileName);
            FileName = Path.GetFileName(pathWithFileName);
            ContentType = System.Web.MimeMapping.GetMimeMapping(FileName); // NOTE: Requires a reference to be added to the project
        }

        /// <summary>
        /// Creates a new FileData instance from a file
        /// </summary>
        /// <param name="pathWithFileName">Path string including file name</param>
        /// <returns></returns>
        public static FileData CreateFromFile(string pathWithFileName)
        {
            FileData fileData = new FileData();
            fileData.ReadFrom(pathWithFileName);
            return fileData;
        }
    }
}
