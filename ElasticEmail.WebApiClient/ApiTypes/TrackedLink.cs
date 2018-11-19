using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ElasticEmail.WebApiClient.ApiTypes
{

    /// <summary>
    /// Information about tracking link and its clicks.
    /// </summary>
    public class TrackedLink
    {
        /// <summary>
        /// URL clicked
        /// </summary>
        public string Link { get; set; }

        /// <summary>
        /// Number of clicks
        /// </summary>
        public string Clicks { get; set; }

        /// <summary>
        /// Percent of clicks
        /// </summary>
        public string Percent { get; set; }

    }
}
