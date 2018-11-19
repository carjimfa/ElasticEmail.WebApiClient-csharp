using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ElasticEmail.WebApiClient.ApiTypes
{

    /// <summary>
    /// Overall log summary information.
    /// </summary>
    public class LogSummary
    {
        /// <summary>
        /// Summary of log status, based on specified date range.
        /// </summary>
        public ApiTypes.LogStatusSummary LogStatusSummary { get; set; }

        /// <summary>
        /// Summary of bounced categories, based on specified date range.
        /// </summary>
        public ApiTypes.BouncedCategorySummary BouncedCategorySummary { get; set; }

        /// <summary>
        /// Daily summary of log status, based on specified date range.
        /// </summary>
        public List<ApiTypes.DailyLogStatusSummary> DailyLogStatusSummary { get; set; }

    }
}
