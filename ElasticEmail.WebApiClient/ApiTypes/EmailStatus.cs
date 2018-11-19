using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ElasticEmail.WebApiClient.ApiTypes
{

    /// <summary>
    /// Status information of the specified email
    /// </summary>
    public class EmailStatus
    {
        /// <summary>
        /// Email address this email was sent from.
        /// </summary>
        public string From { get; set; }

        /// <summary>
        /// Email address this email was sent to.
        /// </summary>
        public string To { get; set; }

        /// <summary>
        /// Date the email was submitted.
        /// </summary>
        public DateTime Date { get; set; }

        /// <summary>
        /// Value of email's status
        /// </summary>
        public ApiTypes.LogJobStatus Status { get; set; }

        /// <summary>
        /// Name of email's status
        /// </summary>
        public string StatusName { get; set; }

        /// <summary>
        /// Date of last status change.
        /// </summary>
        public DateTime StatusChangeDate { get; set; }

        /// <summary>
        /// Date when the email was sent
        /// </summary>
        public DateTime DateSent { get; set; }

        /// <summary>
        /// Date when the email changed the status to 'opened'
        /// </summary>
        public DateTime? DateOpened { get; set; }

        /// <summary>
        /// Date when the email changed the status to 'clicked'
        /// </summary>
        public DateTime? DateClicked { get; set; }

        /// <summary>
        /// Detailed error or bounced message.
        /// </summary>
        public string ErrorMessage { get; set; }

        /// <summary>
        /// ID number of transaction
        /// </summary>
        public Guid TransactionID { get; set; }

    }
}
