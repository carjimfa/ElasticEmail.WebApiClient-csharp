using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ElasticEmail.WebApiClient.ApiTypes
{

    /// <summary>
    /// Number of Unsubscribed or Complaint Contacts, grouped by Unsubscribe Reason;
    /// </summary>
    public class ContactUnsubscribeReasonCounts
    {
        /// <summary>
        /// 
        /// </summary>
        public long Unknown { get; set; }

        /// <summary>
        /// 
        /// </summary>
        public long NoLongerWant { get; set; }

        /// <summary>
        /// 
        /// </summary>
        public long IrrelevantContent { get; set; }

        /// <summary>
        /// 
        /// </summary>
        public long TooFrequent { get; set; }

        /// <summary>
        /// 
        /// </summary>
        public long NeverConsented { get; set; }

        /// <summary>
        /// 
        /// </summary>
        public long DeceptiveContent { get; set; }

        /// <summary>
        /// 
        /// </summary>
        public long AbuseReported { get; set; }

        /// <summary>
        /// 
        /// </summary>
        public long ThirdParty { get; set; }

        /// <summary>
        /// 
        /// </summary>
        public long ListUnsubscribe { get; set; }

    }
}
