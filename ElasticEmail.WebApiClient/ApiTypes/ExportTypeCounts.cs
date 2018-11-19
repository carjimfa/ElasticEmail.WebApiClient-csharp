using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ElasticEmail.WebApiClient.ApiTypes
{

    /// <summary>
    /// Number of Exports, grouped by export type
    /// </summary>
    public class ExportTypeCounts
    {
        /// <summary>
        /// 
        /// </summary>
        public long Log { get; set; }

        /// <summary>
        /// 
        /// </summary>
        public long Contact { get; set; }

        /// <summary>
        /// Json representation of a campaign
        /// </summary>
        public long Campaign { get; set; }

        /// <summary>
        /// True, if you have enabled link tracking. Otherwise, false
        /// </summary>
        public long LinkTracking { get; set; }

        /// <summary>
        /// Json representation of a survey
        /// </summary>
        public long Survey { get; set; }

    }
}
