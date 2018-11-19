using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ElasticEmail.WebApiClient.ApiTypes
{

    /// <summary>
    /// Detailed account settings.
    /// </summary>
    public class SubAccountSettings
    {
        /// <summary>
        /// Proper email address.
        /// </summary>
        public string Email { get; set; }

        /// <summary>
        /// True, if account needs credits to send emails. Otherwise, false
        /// </summary>
        public bool RequiresEmailCredits { get; set; }

        /// <summary>
        /// True, if account needs credits to buy templates. Otherwise, false
        /// </summary>
        public bool RequiresTemplateCredits { get; set; }

        /// <summary>
        /// Amount of credits added to account automatically
        /// </summary>
        public double MonthlyRefillCredits { get; set; }

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
        /// Maximum size of email including attachments in MB's
        /// </summary>
        public int EmailSizeLimit { get; set; }

        /// <summary>
        /// Amount of emails account can send daily
        /// </summary>
        public int DailySendLimit { get; set; }

        /// <summary>
        /// Maximum number of contacts the account can have
        /// </summary>
        public int MaxContacts { get; set; }

        /// <summary>
        /// True, if account can request for private IP on its own. Otherwise, false
        /// </summary>
        public bool EnablePrivateIPRequest { get; set; }

        /// <summary>
        /// True, if you want to use Contact Delivery Tools.  Otherwise, false
        /// </summary>
        public bool EnableContactFeatures { get; set; }

        /// <summary>
        /// Sending permission setting for account
        /// </summary>
        public ApiTypes.SendingPermission SendingPermission { get; set; }

        /// <summary>
        /// Name of your custom IP Pool to be used in the sending process
        /// </summary>
        public string PoolName { get; set; }

        /// <summary>
        /// Public key for limited access to your account such as contact/add so you can use it safely on public websites.
        /// </summary>
        public string PublicAccountID { get; set; }

    }
}
