using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ElasticEmail.WebApiClient.ApiTypes
{
    /// <summary>
    /// Information about Contact Segment, selected by RULE.
    /// </summary>
    public class Segment
    {
        /// <summary>
        /// ID number of your segment.
        /// </summary>
        public int SegmentID { get; set; }

        /// <summary>
        /// Filename
        /// </summary>
        public string Name { get; set; }

        /// <summary>
        /// Query used for filtering.
        /// </summary>
        public string Rule { get; set; }

        /// <summary>
        /// Number of items from last check.
        /// </summary>
        public long LastCount { get; set; }

        /// <summary>
        /// History of segment information.
        /// </summary>
        public List<ApiTypes.SegmentHistory> History { get; set; }

    }
}
