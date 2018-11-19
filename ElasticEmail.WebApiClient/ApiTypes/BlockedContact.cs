using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ElasticEmail.WebApiClient.ApiTypes
{
    /// <summary>
    /// Blocked Contact - Contact returning Hard Bounces
    /// </summary>
    public class BlockedContact
    {
        /// <summary>
        /// Proper email address.
        /// </summary>
        public string Email { get; set; }

        /// <summary>
        /// Name of status: Active, Engaged, Inactive, Abuse, Bounced, Unsubscribed.
        /// </summary>
        public string Status { get; set; }

        /// <summary>
        /// RFC error message
        /// </summary>
        public string FriendlyErrorMessage { get; set; }

        /// <summary>
        /// Last change date
        /// </summary>
        public string DateUpdated { get; set; }

    }
}
