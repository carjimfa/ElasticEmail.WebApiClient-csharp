using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ElasticEmail.WebApiClient.ApiTypes
{

    /// <summary>
    /// </summary>
    public class EmailJobStatus
    {
        /// <summary>
        /// ID number of your attachment
        /// </summary>
        public string ID { get; set; }

        /// <summary>
        /// Name of status: submitted, complete, in_progress
        /// </summary>
        public string Status { get; set; }

        /// <summary>
        /// 
        /// </summary>
        public int RecipientsCount { get; set; }

        /// <summary>
        /// 
        /// </summary>
        public List<ApiTypes.EmailJobFailedStatus> Failed { get; set; }

        /// <summary>
        /// Total emails sent.
        /// </summary>
        public int FailedCount { get; set; }

        /// <summary>
        /// 
        /// </summary>
        public List<string> Sent { get; set; }

        /// <summary>
        /// Total emails sent.
        /// </summary>
        public int SentCount { get; set; }

        /// <summary>
        /// Number of delivered messages
        /// </summary>
        public List<string> Delivered { get; set; }

        /// <summary>
        /// 
        /// </summary>
        public int DeliveredCount { get; set; }

        /// <summary>
        /// 
        /// </summary>
        public List<string> Pending { get; set; }

        /// <summary>
        /// 
        /// </summary>
        public int PendingCount { get; set; }

        /// <summary>
        /// Number of opened messages
        /// </summary>
        public List<string> Opened { get; set; }

        /// <summary>
        /// Total emails opened.
        /// </summary>
        public int OpenedCount { get; set; }

        /// <summary>
        /// Number of clicked messages
        /// </summary>
        public List<string> Clicked { get; set; }

        /// <summary>
        /// Total emails clicked
        /// </summary>
        public int ClickedCount { get; set; }

        /// <summary>
        /// Number of unsubscribed messages
        /// </summary>
        public List<string> Unsubscribed { get; set; }

        /// <summary>
        /// Total emails clicked
        /// </summary>
        public int UnsubscribedCount { get; set; }

        /// <summary>
        /// 
        /// </summary>
        public List<string> AbuseReports { get; set; }

        /// <summary>
        /// 
        /// </summary>
        public int AbuseReportsCount { get; set; }

        /// <summary>
        /// List of all MessageIDs for this job.
        /// </summary>
        public List<string> MessageIDs { get; set; }

    }
}
