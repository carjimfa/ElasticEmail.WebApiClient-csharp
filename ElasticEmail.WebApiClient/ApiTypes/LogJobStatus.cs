using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ElasticEmail.WebApiClient.ApiTypes
{

    /// <summary>
    /// </summary>
    public enum LogJobStatus : Int32
    {
        /// <summary>
        /// All emails
        /// </summary>
        All = 0,

        /// <summary>
        /// Email has been submitted successfully and is queued for sending.
        /// </summary>
        ReadyToSend = 1,

        /// <summary>
        /// Email has soft bounced and is scheduled to retry.
        /// </summary>
        WaitingToRetry = 2,

        /// <summary>
        /// Email is currently sending.
        /// </summary>
        Sending = 3,

        /// <summary>
        /// Email has errored or bounced for some reason.
        /// </summary>
        Error = 4,

        /// <summary>
        /// Email has been successfully delivered.
        /// </summary>
        Sent = 5,

        /// <summary>
        /// Email has been opened by the recipient.
        /// </summary>
        Opened = 6,

        /// <summary>
        /// Email has had at least one link clicked by the recipient.
        /// </summary>
        Clicked = 7,

        /// <summary>
        /// Email has been unsubscribed by the recipient.
        /// </summary>
        Unsubscribed = 8,

        /// <summary>
        /// Email has been complained about or marked as spam by the recipient.
        /// </summary>
        AbuseReport = 9,

    }
}
