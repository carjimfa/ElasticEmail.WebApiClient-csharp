using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ElasticEmail.WebApiClient.ApiTypes
{
    /// <summary>
    /// Summary of bounced categories, based on specified date range.
    /// </summary>
    public class BouncedCategorySummary
    {
        /// <summary>
        /// Number of messages marked as SPAM
        /// </summary>
        public long Spam { get; set; }

        /// <summary>
        /// Number of blacklisted messages
        /// </summary>
        public long BlackListed { get; set; }

        /// <summary>
        /// Number of messages flagged with 'No Mailbox'
        /// </summary>
        public long NoMailbox { get; set; }

        /// <summary>
        /// Number of messages flagged with 'Grey Listed'
        /// </summary>
        public long GreyListed { get; set; }

        /// <summary>
        /// Number of messages flagged with 'Throttled'
        /// </summary>
        public long Throttled { get; set; }

        /// <summary>
        /// Number of messages flagged with 'Timeout'
        /// </summary>
        public long Timeout { get; set; }

        /// <summary>
        /// Number of messages flagged with 'Connection Problem'
        /// </summary>
        public long ConnectionProblem { get; set; }

        /// <summary>
        /// Number of messages flagged with 'SPF Problem'
        /// </summary>
        public long SpfProblem { get; set; }

        /// <summary>
        /// Number of messages flagged with 'Account Problem'
        /// </summary>
        public long AccountProblem { get; set; }

        /// <summary>
        /// Number of messages flagged with 'DNS Problem'
        /// </summary>
        public long DnsProblem { get; set; }

        /// <summary>
        /// Number of messages flagged with 'WhiteListing Problem'
        /// </summary>
        public long WhitelistingProblem { get; set; }

        /// <summary>
        /// Number of messages flagged with 'Code Error'
        /// </summary>
        public long CodeError { get; set; }

        /// <summary>
        /// Number of messages flagged with 'Not Delivered'
        /// </summary>
        public long NotDelivered { get; set; }

        /// <summary>
        /// Number of manually cancelled messages
        /// </summary>
        public long ManualCancel { get; set; }

        /// <summary>
        /// Number of messages flagged with 'Connection terminated'
        /// </summary>
        public long ConnectionTerminated { get; set; }

    }
}
