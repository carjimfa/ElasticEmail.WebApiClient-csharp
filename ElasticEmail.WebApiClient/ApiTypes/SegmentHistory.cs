using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ElasticEmail.WebApiClient.ApiTypes
{

    /// <summary>
    /// Segment History
    /// </summary>
    public class SegmentHistory
    {
        /// <summary>
        /// ID number of history.
        /// </summary>
        public int SegmentHistoryID { get; set; }

        /// <summary>
        /// ID number of your segment.
        /// </summary>
        public int SegmentID { get; set; }

        /// <summary>
        /// Date in YYYY-MM-DD format
        /// </summary>
        public int Day { get; set; }

        /// <summary>
        /// Number of items.
        /// </summary>
        public long Count { get; set; }

        /// <summary>
        /// 
        /// </summary>
        public long EngagedCount { get; set; }

        /// <summary>
        /// 
        /// </summary>
        public long ActiveCount { get; set; }

        /// <summary>
        /// 
        /// </summary>
        public long BouncedCount { get; set; }

        /// <summary>
        /// Total emails clicked
        /// </summary>
        public long UnsubscribedCount { get; set; }

        /// <summary>
        /// 
        /// </summary>
        public long AbuseCount { get; set; }

        /// <summary>
        /// 
        /// </summary>
        public long InactiveCount { get; set; }

    }
}
