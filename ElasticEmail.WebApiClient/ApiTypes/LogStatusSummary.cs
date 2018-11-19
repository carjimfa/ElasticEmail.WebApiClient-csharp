using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ElasticEmail.WebApiClient.ApiTypes
{
    /// <summary>
    /// Summary of log status, based on specified date range.
    /// </summary>
    public class LogStatusSummary
    {
        /// <summary>
        /// Starting date for search in YYYY-MM-DDThh:mm:ss format.
        /// </summary>
        public string From { get; set; }

        /// <summary>
        /// Ending date for search in YYYY-MM-DDThh:mm:ss format.
        /// </summary>
        public string To { get; set; }

        /// <summary>
        /// Overall duration
        /// </summary>
        public double Duration { get; set; }

        /// <summary>
        /// Number of recipients
        /// </summary>
        public long Recipients { get; set; }

        /// <summary>
        /// Number of emails
        /// </summary>
        public long EmailTotal { get; set; }

        /// <summary>
        /// Number of SMS
        /// </summary>
        public long SmsTotal { get; set; }

        /// <summary>
        /// Number of delivered messages
        /// </summary>
        public long Delivered { get; set; }

        /// <summary>
        /// Number of bounced messages
        /// </summary>
        public long Bounced { get; set; }

        /// <summary>
        /// Number of messages in progress
        /// </summary>
        public long InProgress { get; set; }

        /// <summary>
        /// Number of opened messages
        /// </summary>
        public long Opened { get; set; }

        /// <summary>
        /// Number of clicked messages
        /// </summary>
        public long Clicked { get; set; }

        /// <summary>
        /// Number of unsubscribed messages
        /// </summary>
        public long Unsubscribed { get; set; }

        /// <summary>
        /// Number of complaint messages
        /// </summary>
        public long Complaints { get; set; }

        /// <summary>
        /// Number of inbound messages
        /// </summary>
        public long Inbound { get; set; }

        /// <summary>
        /// Number of manually cancelled messages
        /// </summary>
        public long ManualCancel { get; set; }

        /// <summary>
        /// Number of messages flagged with 'Not Delivered'
        /// </summary>
        public long NotDelivered { get; set; }

        /// <summary>
        /// ID number of template used
        /// </summary>
        public bool TemplateChannel { get; set; }

    }
}
