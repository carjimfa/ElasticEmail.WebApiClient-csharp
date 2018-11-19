using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ElasticEmail.WebApiClient.ApiTypes
{

    /// <summary>
    /// Daily summary of log status, based on specified date range.
    /// </summary>
    public class DailyLogStatusSummary
    {
        /// <summary>
        /// Date in YYYY-MM-DDThh:ii:ss format
        /// </summary>
        public string Date { get; set; }

        /// <summary>
        /// Proper email address.
        /// </summary>
        public int Email { get; set; }

        /// <summary>
        /// Number of SMS
        /// </summary>
        public int Sms { get; set; }

        /// <summary>
        /// Number of delivered messages
        /// </summary>
        public int Delivered { get; set; }

        /// <summary>
        /// Number of opened messages
        /// </summary>
        public int Opened { get; set; }

        /// <summary>
        /// Number of clicked messages
        /// </summary>
        public int Clicked { get; set; }

        /// <summary>
        /// Number of unsubscribed messages
        /// </summary>
        public int Unsubscribed { get; set; }

        /// <summary>
        /// Number of complaint messages
        /// </summary>
        public int Complaint { get; set; }

        /// <summary>
        /// Number of bounced messages
        /// </summary>
        public int Bounced { get; set; }

        /// <summary>
        /// Number of inbound messages
        /// </summary>
        public int Inbound { get; set; }

        /// <summary>
        /// Number of manually cancelled messages
        /// </summary>
        public int ManualCancel { get; set; }

        /// <summary>
        /// Number of messages flagged with 'Not Delivered'
        /// </summary>
        public int NotDelivered { get; set; }

    }
}
