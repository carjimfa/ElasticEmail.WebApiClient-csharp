using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ElasticEmail.WebApiClient.ApiTypes
{

    /// <summary>
    /// Current status of export
    /// </summary>
    public enum ExportStatus : Int32
    {
        /// <summary>
        /// Export had an error and can not be downloaded.
        /// </summary>
        Error = -1,

        /// <summary>
        /// Export is currently loading and can not be downloaded.
        /// </summary>
        Loading = 0,

        /// <summary>
        /// Export is currently available for downloading.
        /// </summary>
        Ready = 1,

        /// <summary>
        /// Export is no longer available for downloading.
        /// </summary>
        Expired = 2,

    }
}
