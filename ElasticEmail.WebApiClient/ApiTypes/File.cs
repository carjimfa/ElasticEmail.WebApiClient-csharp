using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ElasticEmail.WebApiClient.ApiTypes
{

    /// <summary>
    /// </summary>
    public class File
    {
        /// <summary>
        /// Name of your file.
        /// </summary>
        public string FileName { get; set; }

        /// <summary>
        /// Size of your attachment (in bytes).
        /// </summary>
        public int? Size { get; set; }

        /// <summary>
        /// Date of creation in YYYY-MM-DDThh:ii:ss format
        /// </summary>
        public DateTime DateAdded { get; set; }

        /// <summary>
        /// When will the file be deleted from the system
        /// </summary>
        public DateTime? ExpirationDate { get; set; }

        /// <summary>
        /// Content type of the file
        /// </summary>
        public string ContentType { get; set; }

    }
}
