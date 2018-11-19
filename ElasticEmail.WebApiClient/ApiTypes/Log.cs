using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ElasticEmail.WebApiClient.ApiTypes
{

    /// <summary>
    /// Logs for selected date range
    /// </summary>
    public class Log
    {
        /// <summary>
        /// Starting date for search in YYYY-MM-DDThh:mm:ss format.
        /// </summary>
        public DateTime? From { get; set; }

        /// <summary>
        /// Ending date for search in YYYY-MM-DDThh:mm:ss format.
        /// </summary>
        public DateTime? To { get; set; }

        /// <summary>
        /// Number of recipients
        /// </summary>
        public List<ApiTypes.Recipient> Recipients { get; set; }

    }
}
