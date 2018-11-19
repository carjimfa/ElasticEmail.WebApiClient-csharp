using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ElasticEmail.WebApiClient.ApiTypes
{
    /// <summary>
    /// </summary>
    public enum CertificateValidationStatus : Int32
    {
        /// <summary>
        /// </summary>
        ErrorOccured = -2,

        /// <summary>
        /// </summary>
        CertNotSet = 0,

        /// <summary>
        /// </summary>
        Valid = 1,

        /// <summary>
        /// </summary>
        NotValid = 2,

    }
}
