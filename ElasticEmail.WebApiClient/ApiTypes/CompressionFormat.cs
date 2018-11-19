using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ElasticEmail.WebApiClient.ApiTypes
{
    /// <summary>
    /// FileResponse compression format
    /// </summary>
    public enum CompressionFormat : Int32
    {
        /// <summary>
        /// No compression
        /// </summary>
        None = 0,

        /// <summary>
        /// Zip compression
        /// </summary>
        Zip = 1,

    }
}
