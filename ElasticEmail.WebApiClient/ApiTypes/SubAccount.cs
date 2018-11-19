using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ElasticEmail.WebApiClient.ApiTypes
{
    /// <summary>
    /// Subaccount. Contains detailed data of your Subaccount.
    /// </summary>
    public class SubAccount
    {
        /// <summary>
        /// Public key for limited access to your account such as contact/add so you can use it safely on public websites.
        /// </summary>
        public string PublicAccountID { get; set; }

        /// <summary>
        /// ApiKey that gives you access to our SMTP and HTTP API's.
        /// </summary>
        public string ApiKey { get; set; }

        /// <summary>
        /// Proper email address.
        /// </summary>
        public string Email { get; set; }

        /// <summary>
        /// ID number of mailer
        /// </summary>
        public string MailerID { get; set; }

        /// <summary>
        /// Name of your custom IP Pool to be used in the sending process
        /// </summary>
        public string PoolName { get; set; }

        /// <summary>
        /// Date of last activity on account
        /// </summary>
        public string LastActivity { get; set; }

        /// <summary>
        /// Amount of email credits
        /// </summary>
        public string EmailCredits { get; set; }

        /// <summary>
        /// True, if account needs credits to send emails. Otherwise, false
        /// </summary>
        public bool RequiresEmailCredits { get; set; }

        /// <summary>
        /// Amount of credits added to account automatically
        /// </summary>
        public double MonthlyRefillCredits { get; set; }

        /// <summary>
        /// True, if account needs credits to buy templates. Otherwise, false
        /// </summary>
        public bool RequiresTemplateCredits { get; set; }

        /// <summary>
        /// Amount of Litmus credits
        /// </summary>
        public decimal LitmusCredits { get; set; }

        /// <summary>
        /// True, if account is able to send template tests to Litmus. Otherwise, false
        /// </summary>
        public bool EnableLitmusTest { get; set; }

        /// <summary>
        /// True, if account needs credits to send emails. Otherwise, false
        /// </summary>
        public bool RequiresLitmusCredits { get; set; }

        /// <summary>
        /// True, if account can buy templates on its own. Otherwise, false
        /// </summary>
        public bool EnablePremiumTemplates { get; set; }

        /// <summary>
        /// True, if account can request for private IP on its own. Otherwise, false
        /// </summary>
        public bool EnablePrivateIPRequest { get; set; }

        /// <summary>
        /// Amount of emails sent from this account
        /// </summary>
        public long TotalEmailsSent { get; set; }

        /// <summary>
        /// Percent of Unknown users - users that couldn't be found
        /// </summary>
        public double UnknownUsersPercent { get; set; }

        /// <summary>
        /// Percent of Complaining users - those, who do not want to receive email from you.
        /// </summary>
        public double AbusePercent { get; set; }

        /// <summary>
        /// Percent of Bounced users
        /// </summary>
        public double FailedSpamPercent { get; set; }

        /// <summary>
        /// Numeric reputation
        /// </summary>
        public double Reputation { get; set; }

        /// <summary>
        /// Amount of emails account can send daily
        /// </summary>
        public long DailySendLimit { get; set; }

        /// <summary>
        /// Name of account's status: Deleted, Disabled, UnderReview, NoPaymentsAllowed, NeverSignedIn, Active, SystemPaused
        /// </summary>
        public string Status { get; set; }

        /// <summary>
        /// Maximum size of email including attachments in MB's
        /// </summary>
        public int EmailSizeLimit { get; set; }

        /// <summary>
        /// Maximum number of contacts the account can have
        /// </summary>
        public int MaxContacts { get; set; }

        /// <summary>
        /// True, if you want to use Contact Delivery Tools.  Otherwise, false
        /// </summary>
        public bool EnableContactFeatures { get; set; }

        /// <summary>
        /// Sending permission setting for account
        /// </summary>
        public ApiTypes.SendingPermission SendingPermission { get; set; }

    }
}
