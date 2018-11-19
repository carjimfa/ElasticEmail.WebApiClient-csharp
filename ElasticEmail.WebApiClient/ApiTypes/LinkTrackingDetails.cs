using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ElasticEmail.WebApiClient.ApiTypes
{
    /// <summary>
    /// Object containig tracking data.
    /// </summary>
    public class LinkTrackingDetails
    {
        /// <summary>
        /// Number of items.
        /// </summary>
        public int Count { get; set; }

        /// <summary>
        /// True, if there are more detailed data available. Otherwise, false
        /// </summary>
        public bool MoreAvailable { get; set; }

        /// <summary>
        /// 
        /// </summary>
        public List<ApiTypes.TrackedLink> TrackedLink { get; set; }

    }
}
