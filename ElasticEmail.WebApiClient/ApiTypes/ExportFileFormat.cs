using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ElasticEmail.WebApiClient.ApiTypes
{
    /// <summary>
    /// Type of export
    /// </summary>
    public enum ExportFileFormats : Int32
    {
        /// <summary>
        /// Export in comma separated values format.
        /// </summary>
        Csv = 1,

        /// <summary>
        /// Export in xml format
        /// </summary>
        Xml = 2,

        /// <summary>
        /// Export in json format
        /// </summary>
        Json = 3,

    }
}
