using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ElasticEmail.WebApiClient.ApiTypes
{

    /// <summary>
    /// Record of exported data from the system.
    /// </summary>
    public class Export
    {
        /// <summary>
        /// 
        /// </summary>
        public Guid PublicExportID { get; set; }

        /// <summary>
        /// Date the export was created
        /// </summary>
        public DateTime DateAdded { get; set; }

        /// <summary>
        /// Type of export
        /// </summary>
        public string Type { get; set; }

        /// <summary>
        /// Current status of export
        /// </summary>
        public string Status { get; set; }

        /// <summary>
        /// Long description of the export
        /// </summary>
        public string Info { get; set; }

        /// <summary>
        /// Name of the file
        /// </summary>
        public string Filename { get; set; }

        /// <summary>
        /// Link to download the export
        /// </summary>
        public string Link { get; set; }

        /// <summary>
        /// Log start date (for Type = Log only)
        /// </summary>
        public DateTime? LogFrom { get; set; }

        /// <summary>
        /// Log end date (for Type = Log only)
        /// </summary>
        public DateTime? LogTo { get; set; }

    }
}
