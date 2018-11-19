using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ElasticEmail.WebApiClient.ApiTypes
{
    /// <summary>
    /// Number of Contacts, grouped by Status;
    /// </summary>
    public class ContactStatusCounts
    {
        /// <summary>
        /// Number of engaged contacts
        /// </summary>
        public long Engaged { get; set; }

        /// <summary>
        /// Number of active contacts
        /// </summary>
        public long Active { get; set; }

        /// <summary>
        /// Number of complaint messages
        /// </summary>
        public long Complaint { get; set; }

        /// <summary>
        /// Number of unsubscribed messages
        /// </summary>
        public long Unsubscribed { get; set; }

        /// <summary>
        /// Number of bounced messages
        /// </summary>
        public long Bounced { get; set; }

        /// <summary>
        /// Number of inactive contacts
        /// </summary>
        public long Inactive { get; set; }

        /// <summary>
        /// Number of transactional contacts
        /// </summary>
        public long Transactional { get; set; }

        /// <summary>
        /// 
        /// </summary>
        public long Stale { get; set; }

        /// <summary>
        /// 
        /// </summary>
        public long NotConfirmed { get; set; }

    }
}
