using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ElasticEmail.WebApiClient.ApiTypes
{
    /// <summary>
    /// Account's ready to send e-mails Status
    /// </summary>
    public enum AccountSendStatus : Int32
    {
        /// <summary>
        /// Account doesn't have enough credits
        /// </summary>
        NotEnoughCredits = 1,

        /// <summary>
        /// Account can send e-mails but only without the attachments
        /// </summary>
        CanSendEmailsNoAttachments = 2,

        /// <summary>
        /// Account has exceeded his daily send limit
        /// </summary>
        DailySendLimitExceeded = 3,

        /// <summary>
        /// Account is ready to send e-mails
        /// </summary>
        CanSendEmails = 4,

    }
}
