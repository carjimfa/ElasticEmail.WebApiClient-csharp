using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ElasticEmail.WebApiClient.ApiTypes
{
    /// <summary>
    /// Lists advanced sending options of your account.
    /// </summary>
    public class AdvancedOptions
    {
        /// <summary>
        /// True, if you want to track clicks. Otherwise, false
        /// </summary>
        public bool EnableClickTracking { get; set; }

        /// <summary>
        /// True, if you want to track by link tracking. Otherwise, false
        /// </summary>
        public bool EnableLinkClickTracking { get; set; }

        /// <summary>
        /// True, if you want to use template scripting in your emails {{}}. Otherwise, false
        /// </summary>
        public bool EnableTemplateScripting { get; set; }

        /// <summary>
        /// True, if text BODY of message should be created automatically. Otherwise, false
        /// </summary>
        public bool AutoTextFormat { get; set; }

        /// <summary>
        /// True, if you want bounce notifications returned. Otherwise, false
        /// </summary>
        public bool EmailNotificationForError { get; set; }

        /// <summary>
        /// True, if you want to send web notifications for sent email. Otherwise, false
        /// </summary>
        public bool WebNotificationForSent { get; set; }

        /// <summary>
        /// True, if you want to send web notifications for opened email. Otherwise, false
        /// </summary>
        public bool WebNotificationForOpened { get; set; }

        /// <summary>
        /// True, if you want to send web notifications for clicked email. Otherwise, false
        /// </summary>
        public bool WebNotificationForClicked { get; set; }

        /// <summary>
        /// True, if you want to send web notifications for unsubscribed email. Otherwise, false
        /// </summary>
        public bool WebnotificationForUnsubscribed { get; set; }

        /// <summary>
        /// True, if you want to send web notifications for complaint email. Otherwise, false
        /// </summary>
        public bool WebNotificationForAbuse { get; set; }

        /// <summary>
        /// True, if you want to send web notifications for bounced email. Otherwise, false
        /// </summary>
        public bool WebNotificationForError { get; set; }

        /// <summary>
        /// True, if you want to receive notifications for each type only once per email. Otherwise, false
        /// </summary>
        public bool WebNotificationNotifyOncePerEmail { get; set; }

        /// <summary>
        /// True, if you want to receive low credit email notifications. Otherwise, false
        /// </summary>
        public bool LowCreditNotification { get; set; }

        /// <summary>
        /// True, if you want inbound email to only process contacts from your account. Otherwise, false
        /// </summary>
        public bool InboundContactsOnly { get; set; }

        /// <summary>
        /// True, if this account is a sub-account. Otherwise, false
        /// </summary>
        public bool IsSubAccount { get; set; }

        /// <summary>
        /// True, if this account resells Elastic Email. Otherwise, false.
        /// </summary>
        public bool IsOwnedByReseller { get; set; }

        /// <summary>
        /// True, if you want to enable list-unsubscribe header. Otherwise, false
        /// </summary>
        public bool EnableUnsubscribeHeader { get; set; }

        /// <summary>
        /// True, if you want to display your labels on your unsubscribe form. Otherwise, false
        /// </summary>
        public bool ManageSubscriptions { get; set; }

        /// <summary>
        /// True, if you want to only display labels that the contact is subscribed to on your unsubscribe form. Otherwise, false
        /// </summary>
        public bool ManageSubscribedOnly { get; set; }

        /// <summary>
        /// True, if you want to display an option for the contact to opt into transactional email only on your unsubscribe form. Otherwise, false
        /// </summary>
        public bool TransactionalOnUnsubscribe { get; set; }

        /// <summary>
        /// 
        /// </summary>
        public bool ConsentTrackingOnUnsubscribe { get; set; }

        /// <summary>
        /// 
        /// </summary>
        public string PreviewMessageID { get; set; }

        /// <summary>
        /// True, if you want to apply custom headers to your emails. Otherwise, false
        /// </summary>
        public bool AllowCustomHeaders { get; set; }

        /// <summary>
        /// Email address to send a copy of all email to.
        /// </summary>
        public string BccEmail { get; set; }

        /// <summary>
        /// Type of content encoding
        /// </summary>
        public string ContentTransferEncoding { get; set; }

        /// <summary>
        /// True, if you want to receive bounce email notifications. Otherwise, false
        /// </summary>
        public string EmailNotification { get; set; }

        /// <summary>
        /// Email addresses to send a copy of all notifications from our system. Separated by semicolon
        /// </summary>
        public string NotificationsEmails { get; set; }

        /// <summary>
        /// Emails, separated by semicolon, to which the notification about contact unsubscribing should be sent to
        /// </summary>
        public string UnsubscribeNotificationEmails { get; set; }

        /// <summary>
        /// URL address to receive web notifications to parse and process.
        /// </summary>
        public string WebNotificationUrl { get; set; }

        /// <summary>
        /// URL used for tracking action of inbound emails
        /// </summary>
        public string HubCallbackUrl { get; set; }

        /// <summary>
        /// Domain you use as your inbound domain
        /// </summary>
        public string InboundDomain { get; set; }

        /// <summary>
        /// True, if account has tooltips active. Otherwise, false
        /// </summary>
        public bool EnableUITooltips { get; set; }

        /// <summary>
        /// True, if you want to use Contact Delivery Tools.  Otherwise, false
        /// </summary>
        public bool EnableContactFeatures { get; set; }

        /// <summary>
        /// URL to your logo image.
        /// </summary>
        public string LogoUrl { get; set; }

        /// <summary>
        /// (0 means this functionality is NOT enabled) Score, depending on the number of times you have sent to a recipient, at which the given recipient should be moved to the Stale status
        /// </summary>
        public int StaleContactScore { get; set; }

        /// <summary>
        /// (0 means this functionality is NOT enabled) Number of days of inactivity for a contact after which the given recipient should be moved to the Stale status
        /// </summary>
        public int StaleContactInactiveDays { get; set; }

        /// <summary>
        /// Why your clients are receiving your emails.
        /// </summary>
        public string DeliveryReason { get; set; }

    }
}
