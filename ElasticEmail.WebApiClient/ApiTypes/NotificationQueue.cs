using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ElasticEmail.WebApiClient.ApiTypes
{

    /// <summary>
    /// Queue of notifications
    /// </summary>
    public class NotificationQueue
    {
        /// <summary>
        /// Creation date.
        /// </summary>
        public string DateCreated { get; set; }

        /// <summary>
        /// Date of last status change.
        /// </summary>
        public string StatusChangeDate { get; set; }

        /// <summary>
        /// Actual status.
        /// </summary>
        public string NewStatus { get; set; }

        /// <summary>
        /// 
        /// </summary>
        public string Reference { get; set; }

        /// <summary>
        /// Error message.
        /// </summary>
        public string ErrorMessage { get; set; }

        /// <summary>
        /// Number of previous delivery attempts
        /// </summary>
        public string RetryCount { get; set; }

    }
}
