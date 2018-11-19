using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ElasticEmail.WebApiClient.ApiTypes
{

    /// <summary>
    /// Detailed information about message recipient
    /// </summary>
    public class Recipient
    {
        /// <summary>
        /// True, if message is SMS. Otherwise, false
        /// </summary>
        public bool IsSms { get; set; }

        /// <summary>
        /// ID number of selected message.
        /// </summary>
        public string MsgID { get; set; }

        /// <summary>
        /// Ending date for search in YYYY-MM-DDThh:mm:ss format.
        /// </summary>
        public string To { get; set; }

        /// <summary>
        /// Name of recipient's status: Submitted, ReadyToSend, WaitingToRetry, Sending, Bounced, Sent, Opened, Clicked, Unsubscribed, AbuseReport
        /// </summary>
        public string Status { get; set; }

        /// <summary>
        /// Name of selected Channel.
        /// </summary>
        public string Channel { get; set; }

        /// <summary>
        /// Creation date
        /// </summary>
        public string Date { get; set; }

        /// <summary>
        /// Date when the email was sent
        /// </summary>
        public string DateSent { get; set; }

        /// <summary>
        /// Date when the email changed the status to 'opened'
        /// </summary>
        public string DateOpened { get; set; }

        /// <summary>
        /// Date when the email changed the status to 'clicked'
        /// </summary>
        public string DateClicked { get; set; }

        /// <summary>
        /// Content of message, HTML encoded
        /// </summary>
        public string Message { get; set; }

        /// <summary>
        /// True, if message category should be shown. Otherwise, false
        /// </summary>
        public bool ShowCategory { get; set; }

        /// <summary>
        /// Name of message category
        /// </summary>
        public string MessageCategory { get; set; }

        /// <summary>
        /// ID of message category
        /// </summary>
        public ApiTypes.MessageCategory MessageCategoryID { get; set; }

        /// <summary>
        /// Date of last status change.
        /// </summary>
        public string StatusChangeDate { get; set; }

        /// <summary>
        /// Date of next try
        /// </summary>
        public string NextTryOn { get; set; }

        /// <summary>
        /// Default subject of email.
        /// </summary>
        public string Subject { get; set; }

        /// <summary>
        /// Default From: email address.
        /// </summary>
        public string FromEmail { get; set; }

        /// <summary>
        /// ID of certain mail job
        /// </summary>
        public string JobID { get; set; }

        /// <summary>
        /// True, if message is a SMS and status is not yet confirmed. Otherwise, false
        /// </summary>
        public bool SmsUpdateRequired { get; set; }

        /// <summary>
        /// Content of message
        /// </summary>
        public string TextMessage { get; set; }

        /// <summary>
        /// Comma separated ID numbers of messages.
        /// </summary>
        public string MessageSid { get; set; }

        /// <summary>
        /// Recipient's last bounce error because of which this e-mail was suppressed
        /// </summary>
        public string ContactLastError { get; set; }

    }
}
