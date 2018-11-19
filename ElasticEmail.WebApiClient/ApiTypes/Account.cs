using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ElasticEmail.WebApiClient.ApiTypes
{
    /// <summary>
    /// Detailed information about your account
    /// </summary>
    public class Account
    {
        /// <summary>
        /// Code used for tax purposes.
        /// </summary>
        public string TaxCode { get; set; }

        /// <summary>
        /// Public key for limited access to your account such as contact/add so you can use it safely on public websites.
        /// </summary>
        public string PublicAccountID { get; set; }

        /// <summary>
        /// ApiKey that gives you access to our SMTP and HTTP API's.
        /// </summary>
        public string ApiKey { get; set; }

        /// <summary>
        /// Second ApiKey that gives you access to our SMTP and HTTP API's.  Used mainly for changing ApiKeys without disrupting services.
        /// </summary>
        public string ApiKey2 { get; set; }

        /// <summary>
        /// True, if account is a subaccount. Otherwise, false
        /// </summary>
        public bool IsSub { get; set; }

        /// <summary>
        /// The number of subaccounts this account has.
        /// </summary>
        public long SubAccountsCount { get; set; }

        /// <summary>
        /// Number of status: 1 - Active
        /// </summary>
        public int StatusNumber { get; set; }

        /// <summary>
        /// Account status: Active
        /// </summary>
        public string StatusFormatted { get; set; }

        /// <summary>
        /// URL form for payments.
        /// </summary>
        public string PaymentFormUrl { get; set; }

        /// <summary>
        /// URL to your logo image.
        /// </summary>
        public string LogoUrl { get; set; }

        /// <summary>
        /// HTTP address of your website.
        /// </summary>
        public string Website { get; set; }

        /// <summary>
        /// True: Turn on or off ability to send mails under your brand. Otherwise, false
        /// </summary>
        public bool EnablePrivateBranding { get; set; }

        /// <summary>
        /// Address to your support.
        /// </summary>
        public string SupportLink { get; set; }

        /// <summary>
        /// Subdomain for your rebranded service
        /// </summary>
        public string PrivateBrandingUrl { get; set; }

        /// <summary>
        /// First name.
        /// </summary>
        public string FirstName { get; set; }

        /// <summary>
        /// Last name.
        /// </summary>
        public string LastName { get; set; }

        /// <summary>
        /// Company name.
        /// </summary>
        public string Company { get; set; }

        /// <summary>
        /// First line of address.
        /// </summary>
        public string Address1 { get; set; }

        /// <summary>
        /// Second line of address.
        /// </summary>
        public string Address2 { get; set; }

        /// <summary>
        /// City.
        /// </summary>
        public string City { get; set; }

        /// <summary>
        /// State or province.
        /// </summary>
        public string State { get; set; }

        /// <summary>
        /// Zip/postal code.
        /// </summary>
        public string Zip { get; set; }

        /// <summary>
        /// Numeric ID of country. A file with the list of countries is available <a href="http://api.elasticemail.com/public/countries"><b>here</b></a>
        /// </summary>
        public int? CountryID { get; set; }

        /// <summary>
        /// Phone number
        /// </summary>
        public string Phone { get; set; }

        /// <summary>
        /// Proper email address.
        /// </summary>
        public string Email { get; set; }

        /// <summary>
        /// URL for affiliating.
        /// </summary>
        public string AffiliateLink { get; set; }

        /// <summary>
        /// Numeric reputation
        /// </summary>
        public double Reputation { get; set; }

        /// <summary>
        /// Amount of emails sent from this account
        /// </summary>
        public long TotalEmailsSent { get; set; }

        /// <summary>
        /// Amount of emails sent from this account
        /// </summary>
        public long? MonthlyEmailsSent { get; set; }

        /// <summary>
        /// Amount of emails sent from this account
        /// </summary>
        public decimal Credit { get; set; }

        /// <summary>
        /// Amount of email credits
        /// </summary>
        public int EmailCredits { get; set; }

        /// <summary>
        /// Amount of emails sent from this account
        /// </summary>
        public decimal PricePerEmail { get; set; }

        /// <summary>
        /// Why your clients are receiving your emails.
        /// </summary>
        public string DeliveryReason { get; set; }

        /// <summary>
        /// URL for making payments.
        /// </summary>
        public string AccountPaymentUrl { get; set; }

        /// <summary>
        /// Address of SMTP server.
        /// </summary>
        public string Smtp { get; set; }

        /// <summary>
        /// Address of alternative SMTP server.
        /// </summary>
        public string SmtpAlternative { get; set; }

        /// <summary>
        /// Status of automatic payments configuration.
        /// </summary>
        public string AutoCreditStatus { get; set; }

        /// <summary>
        /// When AutoCreditStatus is Enabled, the credit level that triggers the credit to be recharged.
        /// </summary>
        public decimal AutoCreditLevel { get; set; }

        /// <summary>
        /// When AutoCreditStatus is Enabled, the amount of credit to be recharged.
        /// </summary>
        public decimal AutoCreditAmount { get; set; }

        /// <summary>
        /// Amount of emails account can send daily
        /// </summary>
        public int DailySendLimit { get; set; }

        /// <summary>
        /// Creation date.
        /// </summary>
        public DateTime DateCreated { get; set; }

        /// <summary>
        /// True, if you have enabled link tracking. Otherwise, false
        /// </summary>
        public bool LinkTracking { get; set; }

        /// <summary>
        /// Type of content encoding
        /// </summary>
        public string ContentTransferEncoding { get; set; }

        /// <summary>
        /// Amount of Litmus credits
        /// </summary>
        public decimal LitmusCredits { get; set; }

        /// <summary>
        /// Enable contact delivery and optimization tools on your Account.
        /// </summary>
        public bool EnableContactFeatures { get; set; }

        /// <summary>
        /// 
        /// </summary>
        public bool NeedsSMSVerification { get; set; }

        /// <summary>
        /// </summary>
        public bool DisableGlobalContacts { get; set; }

    }
}
