using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ElasticEmail.WebApiClient.ApiTypes
{

    /// <summary>
    /// SMTP and HTTP API channel for grouping email delivery
    /// </summary>
    public class Channel
    {
        /// <summary>
        /// Descriptive name of the channel.
        /// </summary>
        public string Name { get; set; }

        /// <summary>
        /// The date the channel was added to your account.
        /// </summary>
        public DateTime DateAdded { get; set; }

        /// <summary>
        /// The date the channel was last sent through.
        /// </summary>
        public DateTime? LastActivity { get; set; }

        /// <summary>
        /// The number of email jobs this channel has been used with.
        /// </summary>
        public int JobCount { get; set; }

        /// <summary>
        /// The number of emails that have been clicked within this channel.
        /// </summary>
        public int ClickedCount { get; set; }

        /// <summary>
        /// The number of emails that have been opened within this channel.
        /// </summary>
        public int OpenedCount { get; set; }

        /// <summary>
        /// The number of emails attempted to be sent within this channel.
        /// </summary>
        public int RecipientCount { get; set; }

        /// <summary>
        /// The number of emails that have been sent within this channel.
        /// </summary>
        public int SentCount { get; set; }

        /// <summary>
        /// The number of emails that have been bounced within this channel.
        /// </summary>
        public int FailedCount { get; set; }

        /// <summary>
        /// The number of emails that have been unsubscribed within this channel.
        /// </summary>
        public int UnsubscribedCount { get; set; }

        /// <summary>
        /// The number of emails that have been marked as abuse or complaint within this channel.
        /// </summary>
        public int FailedAbuse { get; set; }

        /// <summary>
        /// The total cost for emails/attachments within this channel.
        /// </summary>
        public decimal Cost { get; set; }

    }
}
