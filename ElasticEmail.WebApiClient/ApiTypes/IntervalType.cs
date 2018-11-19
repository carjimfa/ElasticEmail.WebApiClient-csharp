using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ElasticEmail.WebApiClient.ApiTypes
{
    /// <summary>
    /// </summary>
    public enum IntervalType : Int32
    {
        /// <summary>
        /// Daily overview
        /// </summary>
        Summary = 0,

        /// <summary>
        /// Hourly, detailed information
        /// </summary>
        Hourly = 1,

    }
}
