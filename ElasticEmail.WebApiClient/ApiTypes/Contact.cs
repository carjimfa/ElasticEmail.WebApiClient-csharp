using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ElasticEmail.WebApiClient.ApiTypes
{
    /// <summary>
    /// Contact
    /// </summary>
    public class Contact
    {
        /// <summary>
        /// 
        /// </summary>
        public int ContactScore { get; set; }

        /// <summary>
        /// Date of creation in YYYY-MM-DDThh:ii:ss format
        /// </summary>
        public DateTime DateAdded { get; set; }

        /// <summary>
        /// Proper email address.
        /// </summary>
        public string Email { get; set; }

        /// <summary>
        /// First name.
        /// </summary>
        public string FirstName { get; set; }

        /// <summary>
        /// Last name.
        /// </summary>
        public string LastName { get; set; }

        /// <summary>
        /// Name of status: Active, Engaged, Inactive, Abuse, Bounced, Unsubscribed.
        /// </summary>
        public ContactStatus Status { get; set; }

        /// <summary>
        /// RFC Error code
        /// </summary>
        public int? BouncedErrorCode { get; set; }

        /// <summary>
        /// RFC error message
        /// </summary>
        public string BouncedErrorMessage { get; set; }

        /// <summary>
        /// Total emails sent.
        /// </summary>
        public int TotalSent { get; set; }

        /// <summary>
        /// Total emails sent.
        /// </summary>
        public int TotalFailed { get; set; }

        /// <summary>
        /// Total emails opened.
        /// </summary>
        public int TotalOpened { get; set; }

        /// <summary>
        /// Total emails clicked
        /// </summary>
        public int TotalClicked { get; set; }

        /// <summary>
        /// Date of first failed message
        /// </summary>
        public DateTime? FirstFailedDate { get; set; }

        /// <summary>
        /// Number of fails in sending to this Contact
        /// </summary>
        public int LastFailedCount { get; set; }

        /// <summary>
        /// Last change date
        /// </summary>
        public DateTime DateUpdated { get; set; }

        /// <summary>
        /// Source of URL of payment
        /// </summary>
        public ContactSource Source { get; set; }

        /// <summary>
        /// RFC Error code
        /// </summary>
        public int? ErrorCode { get; set; }

        /// <summary>
        /// RFC error message
        /// </summary>
        public string FriendlyErrorMessage { get; set; }

        /// <summary>
        /// IP address
        /// </summary>
        public string CreatedFromIP { get; set; }

        /// <summary>
        /// IP address of consent to send this contact(s) your email. If not provided your current public IP address is used for consent.
        /// </summary>
        public string ConsentIP { get; set; }

        /// <summary>
        /// Date of consent to send this contact(s) your email. If not provided current date is used for consent.
        /// </summary>
        public DateTime? ConsentDate { get; set; }

        /// <summary>
        /// 
        /// </summary>
        public ConsentTracking ConsentTracking { get; set; }

        /// <summary>
        /// Unsubscribed date in YYYY-MM-DD format
        /// </summary>
        public DateTime? UnsubscribedDate { get; set; }

        /// <summary>
        /// Free form field of notes
        /// </summary>
        public string Notes { get; set; }

        /// <summary>
        /// Website of contact
        /// </summary>
        public string WebsiteUrl { get; set; }

        /// <summary>
        /// Date this contact last opened an email
        /// </summary>
        public DateTime? LastOpened { get; set; }

        /// <summary>
        /// 
        /// </summary>
        public DateTime? LastClicked { get; set; }

        /// <summary>
        /// Custom contact field like firstname, lastname, city etc. JSON serialized text like { "city":"london" }
        /// </summary>
        public Dictionary<string, string> CustomFields { get; set; }

    }
}
