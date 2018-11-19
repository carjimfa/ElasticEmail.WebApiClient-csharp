using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ElasticEmail.WebApiClient.ApiTypes
{

    /// <summary>
    /// </summary>
    public enum TrackingType : Int32
    {
        /// <summary>
        /// </summary>
        None = -2,

        /// <summary>
        /// </summary>
        Delete = -1,

        /// <summary>
        /// </summary>
        Http = 0,

        /// <summary>
        /// </summary>
        ExternalHttps = 1,

        /// <summary>
        /// </summary>
        InternalCertHttps = 2,

        /// <summary>
        /// </summary>
        LetsEncryptCert = 3,

    }

}
