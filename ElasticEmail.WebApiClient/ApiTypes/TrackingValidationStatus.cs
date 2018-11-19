using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ElasticEmail.WebApiClient.ApiTypes
{

    /// <summary>
    /// Status of ValidDomain used by DomainValidationService to determine how often tracking validation should be performed.
    /// </summary>
    public enum TrackingValidationStatus : Int32
    {
        /// <summary>
        /// </summary>
        Validated = 0,

        /// <summary>
        /// </summary>
        NotValidated = 1,

        /// <summary>
        /// </summary>
        Invalid = 2,

        /// <summary>
        /// </summary>
        Broken = 3,

    }
}
