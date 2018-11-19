using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ElasticEmail.WebApiClient.ApiTypes
{

    /// <summary>
    /// Data on the survey's result
    /// </summary>
    public class SurveyResultsSummaryInfo
    {
        /// <summary>
        /// Number of items.
        /// </summary>
        public int Count { get; set; }

        /// <summary>
        /// Summary statistics
        /// </summary>
        public Dictionary<int, List<ApiTypes.SurveyResultsAnswer>> Summary { get; set; }

    }
}
