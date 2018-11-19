using ElasticEmail.WebApiClient.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ElasticEmail.WebApiClient.ApiTypes;
using System.Collections.Specialized;
using System.Net;

namespace ElasticEmail.WebApiClient
{
    public static class Api
    {
        public static string ApiKey = "00000000-0000-0000-0000-000000000000";
        public static readonly string ApiUri = "https://api.elasticemail.com/v2";


        #region AccessToken functions
        /// <summary>
        /// Managinf ApiKeys
        /// </summary>
        public static class AccessToken
        {
            /// <summary>
            /// Add new AccessToken
            /// </summary>
            /// <param name="apikey">ApiKey that gives you access to our SMTP and HTTP API's.</param>
            /// <param name="tokenName"></param>
            /// <param name="accessLevel"></param>
            /// <returns>string</returns>
            public static string Add(string tokenName, AccessLevel accessLevel)
            {
                WebClient client = new CustomWebClient();
                NameValueCollection values = new NameValueCollection();
                values.Add("apikey", Api.ApiKey);
                values.Add("tokenName", tokenName);
                values.Add("accessLevel", accessLevel.ToString());
                byte[] apiResponse = client.UploadValues(Api.ApiUri + "/accesstoken/add", values);
                ApiResponse<string> apiRet = Newtonsoft.Json.JsonConvert.DeserializeObject<ApiResponse<string>>(Encoding.UTF8.GetString(apiResponse));
                if (!apiRet.success) throw new ApplicationException(apiRet.error);
                return apiRet.Data;
            }

            /// <summary>
            /// Permanently delete AccessToken.
            /// </summary>
            /// <param name="apikey">ApiKey that gives you access to our SMTP and HTTP API's.</param>
            /// <param name="tokenName"></param>
            public static void Delete(string tokenName)
            {
                WebClient client = new CustomWebClient();
                NameValueCollection values = new NameValueCollection();
                values.Add("apikey", Api.ApiKey);
                values.Add("tokenName", tokenName);
                byte[] apiResponse = client.UploadValues(Api.ApiUri + "/accesstoken/delete", values);
                ApiResponse<VoidApiResponse> apiRet = Newtonsoft.Json.JsonConvert.DeserializeObject<ApiResponse<VoidApiResponse>>(Encoding.UTF8.GetString(apiResponse));
                if (!apiRet.success) throw new ApplicationException(apiRet.error);
            }

            /// <summary>
            /// Edit AccessToken.
            /// </summary>
            /// <param name="apikey">ApiKey that gives you access to our SMTP and HTTP API's.</param>
            /// <param name="tokenName"></param>
            /// <param name="accessLevel"></param>
            /// <param name="tokenNameNew"></param>
            public static void Edit(string tokenName, AccessLevel accessLevel, string tokenNameNew = null)
            {
                WebClient client = new CustomWebClient();
                NameValueCollection values = new NameValueCollection();
                values.Add("apikey", Api.ApiKey);
                values.Add("tokenName", tokenName);
                values.Add("accessLevel", accessLevel.ToString());
                if (tokenNameNew != null) values.Add("tokenNameNew", tokenNameNew);
                byte[] apiResponse = client.UploadValues(Api.ApiUri + "/accesstoken/edit", values);
                ApiResponse<VoidApiResponse> apiRet = Newtonsoft.Json.JsonConvert.DeserializeObject<ApiResponse<VoidApiResponse>>(Encoding.UTF8.GetString(apiResponse));
                if (!apiRet.success) throw new ApplicationException(apiRet.error);
            }

            /// <summary>
            /// Get AccessToken list.
            /// </summary>
            /// <param name="apikey">ApiKey that gives you access to our SMTP and HTTP API's.</param>
            /// <returns>List(AccessToken)</returns>
            public static List<ApiTypes.AccessToken> GetList()
            {
                WebClient client = new CustomWebClient();
                NameValueCollection values = new NameValueCollection();
                values.Add("apikey", Api.ApiKey);
                byte[] apiResponse = client.UploadValues(Api.ApiUri + "/accesstoken/getlist", values);
                ApiResponse<List<ApiTypes.AccessToken>> apiRet = Newtonsoft.Json.JsonConvert.DeserializeObject<ApiResponse<List<ApiTypes.AccessToken>>>(Encoding.UTF8.GetString(apiResponse));
                if (!apiRet.success) throw new ApplicationException(apiRet.error);
                return apiRet.Data;
            }

        }
        #endregion


        #region Account functions
        /// <summary>
        /// Methods for managing your account and subaccounts.
        /// </summary>
        public static class Account
        {
            /// <summary>
            /// Create new subaccount and provide most important data about it.
            /// </summary>
            /// <param name="apikey">ApiKey that gives you access to our SMTP and HTTP API's.</param>
            /// <param name="email">Proper email address.</param>
            /// <param name="password">Current password.</param>
            /// <param name="confirmPassword">Repeat new password.</param>
            /// <param name="requiresEmailCredits">True, if account needs credits to send emails. Otherwise, false</param>
            /// <param name="enableLitmusTest">True, if account is able to send template tests to Litmus. Otherwise, false</param>
            /// <param name="requiresLitmusCredits">True, if account needs credits to send emails. Otherwise, false</param>
            /// <param name="maxContacts">Maximum number of contacts the account can have</param>
            /// <param name="enablePrivateIPRequest">True, if account can request for private IP on its own. Otherwise, false</param>
            /// <param name="sendActivation">True, if you want to send activation email to this account. Otherwise, false</param>
            /// <param name="returnUrl">URL to navigate to after account creation</param>
            /// <param name="sendingPermission">Sending permission setting for account</param>
            /// <param name="enableContactFeatures">True, if you want to use Contact Delivery Tools.  Otherwise, false</param>
            /// <param name="poolName">Private IP required. Name of the custom IP Pool which Sub Account should use to send its emails. Leave empty for the default one or if no Private IPs have been bought</param>
            /// <param name="emailSizeLimit">Maximum size of email including attachments in MB's</param>
            /// <param name="dailySendLimit">Amount of emails account can send daily</param>
            /// <returns>string</returns>
            public static string AddSubAccount(string email, string password, string confirmPassword, bool requiresEmailCredits = false, bool enableLitmusTest = false, bool requiresLitmusCredits = false, int maxContacts = 0, bool enablePrivateIPRequest = true, bool sendActivation = false, string returnUrl = null, SendingPermission? sendingPermission = null, bool? enableContactFeatures = null, string poolName = null, int emailSizeLimit = 10, int? dailySendLimit = null)
            {
                WebClient client = new CustomWebClient();
                NameValueCollection values = new NameValueCollection();
                values.Add("apikey", Api.ApiKey);
                values.Add("email", email);
                values.Add("password", password);
                values.Add("confirmPassword", confirmPassword);
                if (requiresEmailCredits != false) values.Add("requiresEmailCredits", requiresEmailCredits.ToString());
                if (enableLitmusTest != false) values.Add("enableLitmusTest", enableLitmusTest.ToString());
                if (requiresLitmusCredits != false) values.Add("requiresLitmusCredits", requiresLitmusCredits.ToString());
                if (maxContacts != 0) values.Add("maxContacts", maxContacts.ToString());
                if (enablePrivateIPRequest != true) values.Add("enablePrivateIPRequest", enablePrivateIPRequest.ToString());
                if (sendActivation != false) values.Add("sendActivation", sendActivation.ToString());
                if (returnUrl != null) values.Add("returnUrl", returnUrl);
                if (sendingPermission != null) values.Add("sendingPermission", Newtonsoft.Json.JsonConvert.SerializeObject(sendingPermission));
                if (enableContactFeatures != null) values.Add("enableContactFeatures", enableContactFeatures.ToString());
                if (poolName != null) values.Add("poolName", poolName);
                if (emailSizeLimit != 10) values.Add("emailSizeLimit", emailSizeLimit.ToString());
                if (dailySendLimit != null) values.Add("dailySendLimit", dailySendLimit.ToString());
                byte[] apiResponse = client.UploadValues(Api.ApiUri + "/account/addsubaccount", values);
                ApiResponse<string> apiRet = Newtonsoft.Json.JsonConvert.DeserializeObject<ApiResponse<string>>(Encoding.UTF8.GetString(apiResponse));
                if (!apiRet.success) throw new ApplicationException(apiRet.error);
                return apiRet.Data;
            }

            /// <summary>
            /// Add email, template or litmus credits to a sub-account
            /// </summary>
            /// <param name="apikey">ApiKey that gives you access to our SMTP and HTTP API's.</param>
            /// <param name="credits">Amount of credits to add</param>
            /// <param name="notes">Specific notes about the transaction</param>
            /// <param name="creditType">Type of credits to add (Email or Litmus)</param>
            /// <param name="subAccountEmail">Email address of sub-account</param>
            /// <param name="publicAccountID">Public key of sub-account to add credits to. Use subAccountEmail or publicAccountID not both.</param>
            public static void AddSubAccountCredits(int credits, string notes, CreditType creditType = CreditType.Email, string subAccountEmail = null, string publicAccountID = null)
            {
                WebClient client = new CustomWebClient();
                NameValueCollection values = new NameValueCollection();
                values.Add("apikey", Api.ApiKey);
                values.Add("credits", credits.ToString());
                values.Add("notes", notes);
                if (creditType != CreditType.Email) values.Add("creditType", creditType.ToString());
                if (subAccountEmail != null) values.Add("subAccountEmail", subAccountEmail);
                if (publicAccountID != null) values.Add("publicAccountID", publicAccountID);
                byte[] apiResponse = client.UploadValues(Api.ApiUri + "/account/addsubaccountcredits", values);
                ApiResponse<VoidApiResponse> apiRet = Newtonsoft.Json.JsonConvert.DeserializeObject<ApiResponse<VoidApiResponse>>(Encoding.UTF8.GetString(apiResponse));
                if (!apiRet.success) throw new ApplicationException(apiRet.error);
            }

            /// <summary>
            /// Change your email address. Remember, that your email address is used as login!
            /// </summary>
            /// <param name="apikey">ApiKey that gives you access to our SMTP and HTTP API's.</param>
            /// <param name="newEmail">New email address.</param>
            /// <param name="confirmEmail">New email address.</param>
            /// <param name="sourceUrl">URL from which request was sent.</param>
            /// <returns>string</returns>
            public static string ChangeEmail(string newEmail, string confirmEmail, string sourceUrl = "https://elasticemail.com/account/")
            {
                WebClient client = new CustomWebClient();
                NameValueCollection values = new NameValueCollection();
                values.Add("apikey", Api.ApiKey);
                values.Add("newEmail", newEmail);
                values.Add("confirmEmail", confirmEmail);
                if (sourceUrl != "https://elasticemail.com/account/") values.Add("sourceUrl", sourceUrl);
                byte[] apiResponse = client.UploadValues(Api.ApiUri + "/account/changeemail", values);
                ApiResponse<string> apiRet = Newtonsoft.Json.JsonConvert.DeserializeObject<ApiResponse<string>>(Encoding.UTF8.GetString(apiResponse));
                if (!apiRet.success) throw new ApplicationException(apiRet.error);
                return apiRet.Data;
            }

            /// <summary>
            /// Create new password for your account. Password needs to be at least 6 characters long.
            /// </summary>
            /// <param name="apikey">ApiKey that gives you access to our SMTP and HTTP API's.</param>
            /// <param name="currentPassword">Current password.</param>
            /// <param name="newPassword">New password for account.</param>
            /// <param name="confirmPassword">Repeat new password.</param>
            public static void ChangePassword(string currentPassword, string newPassword, string confirmPassword)
            {
                WebClient client = new CustomWebClient();
                NameValueCollection values = new NameValueCollection();
                values.Add("apikey", Api.ApiKey);
                values.Add("currentPassword", currentPassword);
                values.Add("newPassword", newPassword);
                values.Add("confirmPassword", confirmPassword);
                byte[] apiResponse = client.UploadValues(Api.ApiUri + "/account/changepassword", values);
                ApiResponse<VoidApiResponse> apiRet = Newtonsoft.Json.JsonConvert.DeserializeObject<ApiResponse<VoidApiResponse>>(Encoding.UTF8.GetString(apiResponse));
                if (!apiRet.success) throw new ApplicationException(apiRet.error);
            }

            /// <summary>
            /// Deletes specified Subaccount
            /// </summary>
            /// <param name="apikey">ApiKey that gives you access to our SMTP and HTTP API's.</param>
            /// <param name="notify">True, if you want to send an email notification. Otherwise, false</param>
            /// <param name="subAccountEmail">Email address of sub-account</param>
            /// <param name="publicAccountID">Public key of sub-account to delete. Use subAccountEmail or publicAccountID not both.</param>
            /// <param name="deleteDomains"></param>
            public static void DeleteSubAccount(bool notify = true, string subAccountEmail = null, string publicAccountID = null, bool deleteDomains = true)
            {
                WebClient client = new CustomWebClient();
                NameValueCollection values = new NameValueCollection();
                values.Add("apikey", Api.ApiKey);
                if (notify != true) values.Add("notify", notify.ToString());
                if (subAccountEmail != null) values.Add("subAccountEmail", subAccountEmail);
                if (publicAccountID != null) values.Add("publicAccountID", publicAccountID);
                if (deleteDomains != true) values.Add("deleteDomains", deleteDomains.ToString());
                byte[] apiResponse = client.UploadValues(Api.ApiUri + "/account/deletesubaccount", values);
                ApiResponse<VoidApiResponse> apiRet = Newtonsoft.Json.JsonConvert.DeserializeObject<ApiResponse<VoidApiResponse>>(Encoding.UTF8.GetString(apiResponse));
                if (!apiRet.success) throw new ApplicationException(apiRet.error);
            }

            /// <summary>
            /// Validate account's ability to send e-mail
            /// </summary>
            /// <param name="apikey">ApiKey that gives you access to our SMTP and HTTP API's.</param>
            /// <returns>AccountSendStatus</returns>
            public static AccountSendStatus GetAccountAbilityToSendEmail()
            {
                WebClient client = new CustomWebClient();
                NameValueCollection values = new NameValueCollection();
                values.Add("apikey", Api.ApiKey);
                byte[] apiResponse = client.UploadValues(Api.ApiUri + "/account/getaccountabilitytosendemail", values);
                ApiResponse<AccountSendStatus> apiRet = Newtonsoft.Json.JsonConvert.DeserializeObject<ApiResponse<AccountSendStatus>>(Encoding.UTF8.GetString(apiResponse));
                if (!apiRet.success) throw new ApplicationException(apiRet.error);
                return apiRet.Data;
            }

            /// <summary>
            /// Returns API Key for the given Sub Account.
            /// </summary>
            /// <param name="apikey">ApiKey that gives you access to our SMTP and HTTP API's.</param>
            /// <param name="subAccountEmail">Email address of sub-account</param>
            /// <param name="publicAccountID">Public key of sub-account to retrieve sub-account API Key. Use subAccountEmail or publicAccountID not both.</param>
            /// <returns>string</returns>
            public static string GetSubAccountApiKey(string subAccountEmail = null, string publicAccountID = null)
            {
                WebClient client = new CustomWebClient();
                NameValueCollection values = new NameValueCollection();
                values.Add("apikey", Api.ApiKey);
                if (subAccountEmail != null) values.Add("subAccountEmail", subAccountEmail);
                if (publicAccountID != null) values.Add("publicAccountID", publicAccountID);
                byte[] apiResponse = client.UploadValues(Api.ApiUri + "/account/getsubaccountapikey", values);
                ApiResponse<string> apiRet = Newtonsoft.Json.JsonConvert.DeserializeObject<ApiResponse<string>>(Encoding.UTF8.GetString(apiResponse));
                if (!apiRet.success) throw new ApplicationException(apiRet.error);
                return apiRet.Data;
            }

            /// <summary>
            /// Lists all of your subaccounts
            /// </summary>
            /// <param name="apikey">ApiKey that gives you access to our SMTP and HTTP API's.</param>
            /// <param name="limit">Maximum of loaded items.</param>
            /// <param name="offset">How many items should be loaded ahead.</param>
            /// <returns>List(SubAccount)</returns>
            public static List<SubAccount> GetSubAccountList(int limit = 0, int offset = 0)
            {
                WebClient client = new CustomWebClient();
                NameValueCollection values = new NameValueCollection();
                values.Add("apikey", Api.ApiKey);
                if (limit != 0) values.Add("limit", limit.ToString());
                if (offset != 0) values.Add("offset", offset.ToString());
                byte[] apiResponse = client.UploadValues(Api.ApiUri + "/account/getsubaccountlist", values);
                ApiResponse<List<SubAccount>> apiRet = Newtonsoft.Json.JsonConvert.DeserializeObject<ApiResponse<List<SubAccount>>>(Encoding.UTF8.GetString(apiResponse));
                if (!apiRet.success) throw new ApplicationException(apiRet.error);
                return apiRet.Data;
            }

            /// <summary>
            /// Loads your account. Returns detailed information about your account.
            /// </summary>
            /// <param name="apikey">ApiKey that gives you access to our SMTP and HTTP API's.</param>
            /// <returns>Account</returns>
            public static ApiTypes.Account Load()
            {
                WebClient client = new CustomWebClient();
                NameValueCollection values = new NameValueCollection();
                values.Add("apikey", Api.ApiKey);
                byte[] apiResponse = client.UploadValues(Api.ApiUri + "/account/load", values);
                ApiResponse<ApiTypes.Account> apiRet = Newtonsoft.Json.JsonConvert.DeserializeObject<ApiResponse<ApiTypes.Account>>(Encoding.UTF8.GetString(apiResponse));
                if (!apiRet.success) throw new ApplicationException(apiRet.error);
                return apiRet.Data;
            }

            /// <summary>
            /// Load advanced options of your account
            /// </summary>
            /// <param name="apikey">ApiKey that gives you access to our SMTP and HTTP API's.</param>
            /// <returns>AdvancedOptions</returns>
            public static AdvancedOptions LoadAdvancedOptions()
            {
                WebClient client = new CustomWebClient();
                NameValueCollection values = new NameValueCollection();
                values.Add("apikey", Api.ApiKey);
                byte[] apiResponse = client.UploadValues(Api.ApiUri + "/account/loadadvancedoptions", values);
                ApiResponse<AdvancedOptions> apiRet = Newtonsoft.Json.JsonConvert.DeserializeObject<ApiResponse<AdvancedOptions>>(Encoding.UTF8.GetString(apiResponse));
                if (!apiRet.success) throw new ApplicationException(apiRet.error);
                return apiRet.Data;
            }

            /// <summary>
            /// Lists email credits history
            /// </summary>
            /// <param name="apikey">ApiKey that gives you access to our SMTP and HTTP API's.</param>
            /// <returns>List(EmailCredits)</returns>
            public static List<EmailCredits> LoadEmailCreditsHistory()
            {
                WebClient client = new CustomWebClient();
                NameValueCollection values = new NameValueCollection();
                values.Add("apikey", Api.ApiKey);
                byte[] apiResponse = client.UploadValues(Api.ApiUri + "/account/loademailcreditshistory", values);
                ApiResponse<List<EmailCredits>> apiRet = Newtonsoft.Json.JsonConvert.DeserializeObject<ApiResponse<List<EmailCredits>>>(Encoding.UTF8.GetString(apiResponse));
                if (!apiRet.success) throw new ApplicationException(apiRet.error);
                return apiRet.Data;
            }

            /// <summary>
            /// Loads your account. Returns detailed information about your account.
            /// </summary>
            /// <param name="apikey">ApiKey that gives you access to our SMTP and HTTP API's.</param>
            /// <returns>Account</returns>
            public static ApiTypes.Account LoadInfo()
            {
                WebClient client = new CustomWebClient();
                NameValueCollection values = new NameValueCollection();
                values.Add("apikey", Api.ApiKey);
                byte[] apiResponse = client.UploadValues(Api.ApiUri + "/account/loadinfo", values);
                ApiResponse<ApiTypes.Account> apiRet = Newtonsoft.Json.JsonConvert.DeserializeObject<ApiResponse<ApiTypes.Account>>(Encoding.UTF8.GetString(apiResponse));
                if (!apiRet.success) throw new ApplicationException(apiRet.error);
                return apiRet.Data;
            }

            /// <summary>
            /// Lists litmus credits history
            /// </summary>
            /// <param name="apikey">ApiKey that gives you access to our SMTP and HTTP API's.</param>
            /// <returns>List(LitmusCredits)</returns>
            public static List<LitmusCredits> LoadLitmusCreditsHistory()
            {
                WebClient client = new CustomWebClient();
                NameValueCollection values = new NameValueCollection();
                values.Add("apikey", Api.ApiKey);
                byte[] apiResponse = client.UploadValues(Api.ApiUri + "/account/loadlitmuscreditshistory", values);
                ApiResponse<List<LitmusCredits>> apiRet = Newtonsoft.Json.JsonConvert.DeserializeObject<ApiResponse<List<LitmusCredits>>>(Encoding.UTF8.GetString(apiResponse));
                if (!apiRet.success) throw new ApplicationException(apiRet.error);
                return apiRet.Data;
            }

            /// <summary>
            /// Shows queue of newest notifications - very useful when you want to check what happened with mails that were not received.
            /// </summary>
            /// <param name="apikey">ApiKey that gives you access to our SMTP and HTTP API's.</param>
            /// <returns>List(NotificationQueue)</returns>
            public static List<NotificationQueue> LoadNotificationQueue()
            {
                WebClient client = new CustomWebClient();
                NameValueCollection values = new NameValueCollection();
                values.Add("apikey", Api.ApiKey);
                byte[] apiResponse = client.UploadValues(Api.ApiUri + "/account/loadnotificationqueue", values);
                ApiResponse<List<NotificationQueue>> apiRet = Newtonsoft.Json.JsonConvert.DeserializeObject<ApiResponse<List<NotificationQueue>>>(Encoding.UTF8.GetString(apiResponse));
                if (!apiRet.success) throw new ApplicationException(apiRet.error);
                return apiRet.Data;
            }

            /// <summary>
            /// Lists all payments
            /// </summary>
            /// <param name="apikey">ApiKey that gives you access to our SMTP and HTTP API's.</param>
            /// <param name="limit">Maximum of loaded items.</param>
            /// <param name="offset">How many items should be loaded ahead.</param>
            /// <param name="fromDate">Starting date for search in YYYY-MM-DDThh:mm:ss format.</param>
            /// <param name="toDate">Ending date for search in YYYY-MM-DDThh:mm:ss format.</param>
            /// <returns>List(Payment)</returns>
            public static List<Payment> LoadPaymentHistory(int limit, int offset, DateTime fromDate, DateTime toDate)
            {
                WebClient client = new CustomWebClient();
                NameValueCollection values = new NameValueCollection();
                values.Add("apikey", Api.ApiKey);
                values.Add("limit", limit.ToString());
                values.Add("offset", offset.ToString());
                values.Add("fromDate", fromDate.ToString("M/d/yyyy h:mm:ss tt"));
                values.Add("toDate", toDate.ToString("M/d/yyyy h:mm:ss tt"));
                byte[] apiResponse = client.UploadValues(Api.ApiUri + "/account/loadpaymenthistory", values);
                ApiResponse<List<Payment>> apiRet = Newtonsoft.Json.JsonConvert.DeserializeObject<ApiResponse<List<Payment>>>(Encoding.UTF8.GetString(apiResponse));
                if (!apiRet.success) throw new ApplicationException(apiRet.error);
                return apiRet.Data;
            }

            /// <summary>
            /// Lists all referral payout history
            /// </summary>
            /// <param name="apikey">ApiKey that gives you access to our SMTP and HTTP API's.</param>
            /// <returns>List(Payment)</returns>
            public static List<Payment> LoadPayoutHistory()
            {
                WebClient client = new CustomWebClient();
                NameValueCollection values = new NameValueCollection();
                values.Add("apikey", Api.ApiKey);
                byte[] apiResponse = client.UploadValues(Api.ApiUri + "/account/loadpayouthistory", values);
                ApiResponse<List<Payment>> apiRet = Newtonsoft.Json.JsonConvert.DeserializeObject<ApiResponse<List<Payment>>>(Encoding.UTF8.GetString(apiResponse));
                if (!apiRet.success) throw new ApplicationException(apiRet.error);
                return apiRet.Data;
            }

            /// <summary>
            /// Shows information about your referral details
            /// </summary>
            /// <param name="apikey">ApiKey that gives you access to our SMTP and HTTP API's.</param>
            /// <returns>Referral</returns>
            public static Referral LoadReferralDetails()
            {
                WebClient client = new CustomWebClient();
                NameValueCollection values = new NameValueCollection();
                values.Add("apikey", Api.ApiKey);
                byte[] apiResponse = client.UploadValues(Api.ApiUri + "/account/loadreferraldetails", values);
                ApiResponse<Referral> apiRet = Newtonsoft.Json.JsonConvert.DeserializeObject<ApiResponse<Referral>>(Encoding.UTF8.GetString(apiResponse));
                if (!apiRet.success) throw new ApplicationException(apiRet.error);
                return apiRet.Data;
            }

            /// <summary>
            /// Shows latest changes in your sending reputation
            /// </summary>
            /// <param name="apikey">ApiKey that gives you access to our SMTP and HTTP API's.</param>
            /// <param name="limit">Maximum of loaded items.</param>
            /// <param name="offset">How many items should be loaded ahead.</param>
            /// <returns>List(ReputationHistory)</returns>
            public static List<ReputationHistory> LoadReputationHistory(int limit = 20, int offset = 0)
            {
                WebClient client = new CustomWebClient();
                NameValueCollection values = new NameValueCollection();
                values.Add("apikey", Api.ApiKey);
                if (limit != 20) values.Add("limit", limit.ToString());
                if (offset != 0) values.Add("offset", offset.ToString());
                byte[] apiResponse = client.UploadValues(Api.ApiUri + "/account/loadreputationhistory", values);
                ApiResponse<List<ReputationHistory>> apiRet = Newtonsoft.Json.JsonConvert.DeserializeObject<ApiResponse<List<ReputationHistory>>>(Encoding.UTF8.GetString(apiResponse));
                if (!apiRet.success) throw new ApplicationException(apiRet.error);
                return apiRet.Data;
            }

            /// <summary>
            /// Shows detailed information about your actual reputation score
            /// </summary>
            /// <param name="apikey">ApiKey that gives you access to our SMTP and HTTP API's.</param>
            /// <returns>ReputationDetail</returns>
            public static ReputationDetail LoadReputationImpact()
            {
                WebClient client = new CustomWebClient();
                NameValueCollection values = new NameValueCollection();
                values.Add("apikey", Api.ApiKey);
                byte[] apiResponse = client.UploadValues(Api.ApiUri + "/account/loadreputationimpact", values);
                ApiResponse<ReputationDetail> apiRet = Newtonsoft.Json.JsonConvert.DeserializeObject<ApiResponse<ReputationDetail>>(Encoding.UTF8.GetString(apiResponse));
                if (!apiRet.success) throw new ApplicationException(apiRet.error);
                return apiRet.Data;
            }

            /// <summary>
            /// Returns detailed spam check.
            /// </summary>
            /// <param name="apikey">ApiKey that gives you access to our SMTP and HTTP API's.</param>
            /// <param name="limit">Maximum of loaded items.</param>
            /// <param name="offset">How many items should be loaded ahead.</param>
            /// <returns>List(SpamCheck)</returns>
            public static List<SpamCheck> LoadSpamCheck(int limit = 20, int offset = 0)
            {
                WebClient client = new CustomWebClient();
                NameValueCollection values = new NameValueCollection();
                values.Add("apikey", Api.ApiKey);
                if (limit != 20) values.Add("limit", limit.ToString());
                if (offset != 0) values.Add("offset", offset.ToString());
                byte[] apiResponse = client.UploadValues(Api.ApiUri + "/account/loadspamcheck", values);
                ApiResponse<List<SpamCheck>> apiRet = Newtonsoft.Json.JsonConvert.DeserializeObject<ApiResponse<List<SpamCheck>>>(Encoding.UTF8.GetString(apiResponse));
                if (!apiRet.success) throw new ApplicationException(apiRet.error);
                return apiRet.Data;
            }

            /// <summary>
            /// Lists email credits history for sub-account
            /// </summary>
            /// <param name="apikey">ApiKey that gives you access to our SMTP and HTTP API's.</param>
            /// <param name="subAccountEmail">Email address of sub-account</param>
            /// <param name="publicAccountID">Public key of sub-account to list history for. Use subAccountEmail or publicAccountID not both.</param>
            /// <returns>List(EmailCredits)</returns>
            public static List<EmailCredits> LoadSubAccountsEmailCreditsHistory(string subAccountEmail = null, string publicAccountID = null)
            {
                WebClient client = new CustomWebClient();
                NameValueCollection values = new NameValueCollection();
                values.Add("apikey", Api.ApiKey);
                if (subAccountEmail != null) values.Add("subAccountEmail", subAccountEmail);
                if (publicAccountID != null) values.Add("publicAccountID", publicAccountID);
                byte[] apiResponse = client.UploadValues(Api.ApiUri + "/account/loadsubaccountsemailcreditshistory", values);
                ApiResponse<List<EmailCredits>> apiRet = Newtonsoft.Json.JsonConvert.DeserializeObject<ApiResponse<List<EmailCredits>>>(Encoding.UTF8.GetString(apiResponse));
                if (!apiRet.success) throw new ApplicationException(apiRet.error);
                return apiRet.Data;
            }

            /// <summary>
            /// Loads settings of subaccount
            /// </summary>
            /// <param name="apikey">ApiKey that gives you access to our SMTP and HTTP API's.</param>
            /// <param name="subAccountEmail">Email address of sub-account</param>
            /// <param name="publicAccountID">Public key of sub-account to load settings for. Use subAccountEmail or publicAccountID not both.</param>
            /// <returns>SubAccountSettings</returns>
            public static SubAccountSettings LoadSubAccountSettings(string subAccountEmail = null, string publicAccountID = null)
            {
                WebClient client = new CustomWebClient();
                NameValueCollection values = new NameValueCollection();
                values.Add("apikey", Api.ApiKey);
                if (subAccountEmail != null) values.Add("subAccountEmail", subAccountEmail);
                if (publicAccountID != null) values.Add("publicAccountID", publicAccountID);
                byte[] apiResponse = client.UploadValues(Api.ApiUri + "/account/loadsubaccountsettings", values);
                ApiResponse<SubAccountSettings> apiRet = Newtonsoft.Json.JsonConvert.DeserializeObject<ApiResponse<SubAccountSettings>>(Encoding.UTF8.GetString(apiResponse));
                if (!apiRet.success) throw new ApplicationException(apiRet.error);
                return apiRet.Data;
            }

            /// <summary>
            /// Lists litmus credits history for sub-account
            /// </summary>
            /// <param name="apikey">ApiKey that gives you access to our SMTP and HTTP API's.</param>
            /// <param name="subAccountEmail">Email address of sub-account</param>
            /// <param name="publicAccountID">Public key of sub-account to list history for. Use subAccountEmail or publicAccountID not both.</param>
            /// <returns>List(LitmusCredits)</returns>
            public static List<LitmusCredits> LoadSubAccountsLitmusCreditsHistory(string subAccountEmail = null, string publicAccountID = null)
            {
                WebClient client = new CustomWebClient();
                NameValueCollection values = new NameValueCollection();
                values.Add("apikey", Api.ApiKey);
                if (subAccountEmail != null) values.Add("subAccountEmail", subAccountEmail);
                if (publicAccountID != null) values.Add("publicAccountID", publicAccountID);
                byte[] apiResponse = client.UploadValues(Api.ApiUri + "/account/loadsubaccountslitmuscreditshistory", values);
                ApiResponse<List<LitmusCredits>> apiRet = Newtonsoft.Json.JsonConvert.DeserializeObject<ApiResponse<List<LitmusCredits>>>(Encoding.UTF8.GetString(apiResponse));
                if (!apiRet.success) throw new ApplicationException(apiRet.error);
                return apiRet.Data;
            }

            /// <summary>
            /// Shows usage of your account in given time.
            /// </summary>
            /// <param name="apikey">ApiKey that gives you access to our SMTP and HTTP API's.</param>
            /// <param name="from">Starting date for search in YYYY-MM-DDThh:mm:ss format.</param>
            /// <param name="to">Ending date for search in YYYY-MM-DDThh:mm:ss format.</param>
            /// <returns>List(Usage)</returns>
            public static List<Usage> LoadUsage(DateTime from, DateTime to)
            {
                WebClient client = new CustomWebClient();
                NameValueCollection values = new NameValueCollection();
                values.Add("apikey", Api.ApiKey);
                values.Add("from", from.ToString("M/d/yyyy h:mm:ss tt"));
                values.Add("to", to.ToString("M/d/yyyy h:mm:ss tt"));
                byte[] apiResponse = client.UploadValues(Api.ApiUri + "/account/loadusage", values);
                ApiResponse<List<Usage>> apiRet = Newtonsoft.Json.JsonConvert.DeserializeObject<ApiResponse<List<Usage>>>(Encoding.UTF8.GetString(apiResponse));
                if (!apiRet.success) throw new ApplicationException(apiRet.error);
                return apiRet.Data;
            }

            /// <summary>
            /// Shows summary for your account.
            /// </summary>
            /// <param name="apikey">ApiKey that gives you access to our SMTP and HTTP API's.</param>
            /// <returns>AccountOverview</returns>
            public static AccountOverview Overview()
            {
                WebClient client = new CustomWebClient();
                NameValueCollection values = new NameValueCollection();
                values.Add("apikey", Api.ApiKey);
                byte[] apiResponse = client.UploadValues(Api.ApiUri + "/account/overview", values);
                ApiResponse<AccountOverview> apiRet = Newtonsoft.Json.JsonConvert.DeserializeObject<ApiResponse<AccountOverview>>(Encoding.UTF8.GetString(apiResponse));
                if (!apiRet.success) throw new ApplicationException(apiRet.error);
                return apiRet.Data;
            }

            /// <summary>
            /// Shows you account's profile basic overview
            /// </summary>
            /// <param name="apikey">ApiKey that gives you access to our SMTP and HTTP API's.</param>
            /// <returns>Profile</returns>
            public static Profile ProfileOverview()
            {
                WebClient client = new CustomWebClient();
                NameValueCollection values = new NameValueCollection();
                values.Add("apikey", Api.ApiKey);
                byte[] apiResponse = client.UploadValues(Api.ApiUri + "/account/profileoverview", values);
                ApiResponse<Profile> apiRet = Newtonsoft.Json.JsonConvert.DeserializeObject<ApiResponse<Profile>>(Encoding.UTF8.GetString(apiResponse));
                if (!apiRet.success) throw new ApplicationException(apiRet.error);
                return apiRet.Data;
            }

            /// <summary>
            /// Remove email, template or litmus credits from a sub-account
            /// </summary>
            /// <param name="apikey">ApiKey that gives you access to our SMTP and HTTP API's.</param>
            /// <param name="creditType">Type of credits to add (Email or Litmus)</param>
            /// <param name="notes">Specific notes about the transaction</param>
            /// <param name="subAccountEmail">Email address of sub-account</param>
            /// <param name="publicAccountID">Public key of sub-account to remove credits from. Use subAccountEmail or publicAccountID not both.</param>
            /// <param name="credits">Amount of credits to remove</param>
            /// <param name="removeAll">Remove all credits of this type from sub-account (overrides credits if provided)</param>
            public static void RemoveSubAccountCredits(CreditType creditType, string notes, string subAccountEmail = null, string publicAccountID = null, int? credits = null, bool removeAll = false)
            {
                WebClient client = new CustomWebClient();
                NameValueCollection values = new NameValueCollection();
                values.Add("apikey", Api.ApiKey);
                values.Add("creditType", creditType.ToString());
                values.Add("notes", notes);
                if (subAccountEmail != null) values.Add("subAccountEmail", subAccountEmail);
                if (publicAccountID != null) values.Add("publicAccountID", publicAccountID);
                if (credits != null) values.Add("credits", credits.ToString());
                if (removeAll != false) values.Add("removeAll", removeAll.ToString());
                byte[] apiResponse = client.UploadValues(Api.ApiUri + "/account/removesubaccountcredits", values);
                ApiResponse<VoidApiResponse> apiRet = Newtonsoft.Json.JsonConvert.DeserializeObject<ApiResponse<VoidApiResponse>>(Encoding.UTF8.GetString(apiResponse));
                if (!apiRet.success) throw new ApplicationException(apiRet.error);
            }

            /// <summary>
            /// Request a new default APIKey.
            /// </summary>
            /// <param name="apikey">ApiKey that gives you access to our SMTP and HTTP API's.</param>
            /// <returns>string</returns>
            public static string RequestNewApiKey()
            {
                WebClient client = new CustomWebClient();
                NameValueCollection values = new NameValueCollection();
                values.Add("apikey", Api.ApiKey);
                byte[] apiResponse = client.UploadValues(Api.ApiUri + "/account/requestnewapikey", values);
                ApiResponse<string> apiRet = Newtonsoft.Json.JsonConvert.DeserializeObject<ApiResponse<string>>(Encoding.UTF8.GetString(apiResponse));
                if (!apiRet.success) throw new ApplicationException(apiRet.error);
                return apiRet.Data;
            }

            /// <summary>
            /// Request premium support for your account
            /// </summary>
            /// <param name="apikey">ApiKey that gives you access to our SMTP and HTTP API's.</param>
            public static void RequestPremiumSupport()
            {
                WebClient client = new CustomWebClient();
                NameValueCollection values = new NameValueCollection();
                values.Add("apikey", Api.ApiKey);
                byte[] apiResponse = client.UploadValues(Api.ApiUri + "/account/requestpremiumsupport", values);
                ApiResponse<VoidApiResponse> apiRet = Newtonsoft.Json.JsonConvert.DeserializeObject<ApiResponse<VoidApiResponse>>(Encoding.UTF8.GetString(apiResponse));
                if (!apiRet.success) throw new ApplicationException(apiRet.error);
            }

            /// <summary>
            /// Request a private IP for your Account
            /// </summary>
            /// <param name="apikey">ApiKey that gives you access to our SMTP and HTTP API's.</param>
            /// <param name="count">Number of items.</param>
            /// <param name="notes">Free form field of notes</param>
            public static void RequestPrivateIP(int count, string notes)
            {
                WebClient client = new CustomWebClient();
                NameValueCollection values = new NameValueCollection();
                values.Add("apikey", Api.ApiKey);
                values.Add("count", count.ToString());
                values.Add("notes", notes);
                byte[] apiResponse = client.UploadValues(Api.ApiUri + "/account/requestprivateip", values);
                ApiResponse<VoidApiResponse> apiRet = Newtonsoft.Json.JsonConvert.DeserializeObject<ApiResponse<VoidApiResponse>>(Encoding.UTF8.GetString(apiResponse));
                if (!apiRet.success) throw new ApplicationException(apiRet.error);
            }

            /// <summary>
            /// Update sending and tracking options of your account.
            /// </summary>
            /// <param name="apikey">ApiKey that gives you access to our SMTP and HTTP API's.</param>
            /// <param name="enableClickTracking">True, if you want to track clicks. Otherwise, false</param>
            /// <param name="enableLinkClickTracking">True, if you want to track by link tracking. Otherwise, false</param>
            /// <param name="manageSubscriptions">True, if you want to display your labels on your unsubscribe form. Otherwise, false</param>
            /// <param name="manageSubscribedOnly">True, if you want to only display labels that the contact is subscribed to on your unsubscribe form. Otherwise, false</param>
            /// <param name="transactionalOnUnsubscribe">True, if you want to display an option for the contact to opt into transactional email only on your unsubscribe form. Otherwise, false</param>
            /// <param name="skipListUnsubscribe">True, if you do not want to use list-unsubscribe headers. Otherwise, false</param>
            /// <param name="autoTextFromHtml">True, if text BODY of message should be created automatically. Otherwise, false</param>
            /// <param name="allowCustomHeaders">True, if you want to apply custom headers to your emails. Otherwise, false</param>
            /// <param name="bccEmail">Email address to send a copy of all email to.</param>
            /// <param name="contentTransferEncoding">Type of content encoding</param>
            /// <param name="emailNotificationForError">True, if you want bounce notifications returned. Otherwise, false</param>
            /// <param name="emailNotificationEmail">Specific email address to send bounce email notifications to.</param>
            /// <param name="webNotificationUrl">URL address to receive web notifications to parse and process.</param>
            /// <param name="webNotificationNotifyOncePerEmail">True, if you want to receive notifications for each type only once per email. Otherwise, false</param>
            /// <param name="webNotificationForSent">True, if you want to send web notifications for sent email. Otherwise, false</param>
            /// <param name="webNotificationForOpened">True, if you want to send web notifications for opened email. Otherwise, false</param>
            /// <param name="webNotificationForClicked">True, if you want to send web notifications for clicked email. Otherwise, false</param>
            /// <param name="webNotificationForUnsubscribed">True, if you want to send web notifications for unsubscribed email. Otherwise, false</param>
            /// <param name="webNotificationForAbuseReport">True, if you want to send web notifications for complaint email. Otherwise, false</param>
            /// <param name="webNotificationForError">True, if you want to send web notifications for bounced email. Otherwise, false</param>
            /// <param name="hubCallBackUrl">URL used for tracking action of inbound emails</param>
            /// <param name="inboundDomain">Domain you use as your inbound domain</param>
            /// <param name="inboundContactsOnly">True, if you want inbound email to only process contacts from your account. Otherwise, false</param>
            /// <param name="lowCreditNotification">True, if you want to receive low credit email notifications. Otherwise, false</param>
            /// <param name="enableUITooltips">True, if account has tooltips active. Otherwise, false</param>
            /// <param name="enableContactFeatures">True, if you want to use Contact Delivery Tools.  Otherwise, false</param>
            /// <param name="notificationsEmails">Email addresses to send a copy of all notifications from our system. Separated by semicolon</param>
            /// <param name="unsubscribeNotificationsEmails">Emails, separated by semicolon, to which the notification about contact unsubscribing should be sent to</param>
            /// <param name="logoUrl">URL to your logo image.</param>
            /// <param name="enableTemplateScripting">True, if you want to use template scripting in your emails {{}}. Otherwise, false</param>
            /// <param name="staleContactScore">(0 means this functionality is NOT enabled) Score, depending on the number of times you have sent to a recipient, at which the given recipient should be moved to the Stale status</param>
            /// <param name="staleContactInactiveDays">(0 means this functionality is NOT enabled) Number of days of inactivity for a contact after which the given recipient should be moved to the Stale status</param>
            /// <param name="deliveryReason">Why your clients are receiving your emails.</param>
            /// <param name="tutorialsEnabled">True, if you want to enable Dashboard Tutotials</param>
            /// <param name="enableOpenTracking">True, if you want to track opens. Otherwise, false</param>
            /// <param name="consentTrackingOnUnsubscribe"></param>
            /// <returns>AdvancedOptions</returns>
            public static AdvancedOptions UpdateAdvancedOptions(bool? enableClickTracking = null, bool? enableLinkClickTracking = null, bool? manageSubscriptions = null, bool? manageSubscribedOnly = null, bool? transactionalOnUnsubscribe = null, bool? skipListUnsubscribe = null, bool? autoTextFromHtml = null, bool? allowCustomHeaders = null, string bccEmail = null, string contentTransferEncoding = null, bool? emailNotificationForError = null, string emailNotificationEmail = null, string webNotificationUrl = null, bool? webNotificationNotifyOncePerEmail = null, bool? webNotificationForSent = null, bool? webNotificationForOpened = null, bool? webNotificationForClicked = null, bool? webNotificationForUnsubscribed = null, bool? webNotificationForAbuseReport = null, bool? webNotificationForError = null, string hubCallBackUrl = "", string inboundDomain = null, bool? inboundContactsOnly = null, bool? lowCreditNotification = null, bool? enableUITooltips = null, bool? enableContactFeatures = null, string notificationsEmails = null, string unsubscribeNotificationsEmails = null, string logoUrl = null, bool? enableTemplateScripting = true, int? staleContactScore = null, int? staleContactInactiveDays = null, string deliveryReason = null, bool? tutorialsEnabled = null, bool? enableOpenTracking = null, bool? consentTrackingOnUnsubscribe = null)
            {
                WebClient client = new CustomWebClient();
                NameValueCollection values = new NameValueCollection();
                values.Add("apikey", Api.ApiKey);
                if (enableClickTracking != null) values.Add("enableClickTracking", enableClickTracking.ToString());
                if (enableLinkClickTracking != null) values.Add("enableLinkClickTracking", enableLinkClickTracking.ToString());
                if (manageSubscriptions != null) values.Add("manageSubscriptions", manageSubscriptions.ToString());
                if (manageSubscribedOnly != null) values.Add("manageSubscribedOnly", manageSubscribedOnly.ToString());
                if (transactionalOnUnsubscribe != null) values.Add("transactionalOnUnsubscribe", transactionalOnUnsubscribe.ToString());
                if (skipListUnsubscribe != null) values.Add("skipListUnsubscribe", skipListUnsubscribe.ToString());
                if (autoTextFromHtml != null) values.Add("autoTextFromHtml", autoTextFromHtml.ToString());
                if (allowCustomHeaders != null) values.Add("allowCustomHeaders", allowCustomHeaders.ToString());
                if (bccEmail != null) values.Add("bccEmail", bccEmail);
                if (contentTransferEncoding != null) values.Add("contentTransferEncoding", contentTransferEncoding);
                if (emailNotificationForError != null) values.Add("emailNotificationForError", emailNotificationForError.ToString());
                if (emailNotificationEmail != null) values.Add("emailNotificationEmail", emailNotificationEmail);
                if (webNotificationUrl != null) values.Add("webNotificationUrl", webNotificationUrl);
                if (webNotificationNotifyOncePerEmail != null) values.Add("webNotificationNotifyOncePerEmail", webNotificationNotifyOncePerEmail.ToString());
                if (webNotificationForSent != null) values.Add("webNotificationForSent", webNotificationForSent.ToString());
                if (webNotificationForOpened != null) values.Add("webNotificationForOpened", webNotificationForOpened.ToString());
                if (webNotificationForClicked != null) values.Add("webNotificationForClicked", webNotificationForClicked.ToString());
                if (webNotificationForUnsubscribed != null) values.Add("webNotificationForUnsubscribed", webNotificationForUnsubscribed.ToString());
                if (webNotificationForAbuseReport != null) values.Add("webNotificationForAbuseReport", webNotificationForAbuseReport.ToString());
                if (webNotificationForError != null) values.Add("webNotificationForError", webNotificationForError.ToString());
                if (hubCallBackUrl != "") values.Add("hubCallBackUrl", hubCallBackUrl);
                if (inboundDomain != null) values.Add("inboundDomain", inboundDomain);
                if (inboundContactsOnly != null) values.Add("inboundContactsOnly", inboundContactsOnly.ToString());
                if (lowCreditNotification != null) values.Add("lowCreditNotification", lowCreditNotification.ToString());
                if (enableUITooltips != null) values.Add("enableUITooltips", enableUITooltips.ToString());
                if (enableContactFeatures != null) values.Add("enableContactFeatures", enableContactFeatures.ToString());
                if (notificationsEmails != null) values.Add("notificationsEmails", notificationsEmails);
                if (unsubscribeNotificationsEmails != null) values.Add("unsubscribeNotificationsEmails", unsubscribeNotificationsEmails);
                if (logoUrl != null) values.Add("logoUrl", logoUrl);
                if (enableTemplateScripting != true) values.Add("enableTemplateScripting", enableTemplateScripting.ToString());
                if (staleContactScore != null) values.Add("staleContactScore", staleContactScore.ToString());
                if (staleContactInactiveDays != null) values.Add("staleContactInactiveDays", staleContactInactiveDays.ToString());
                if (deliveryReason != null) values.Add("deliveryReason", deliveryReason);
                if (tutorialsEnabled != null) values.Add("tutorialsEnabled", tutorialsEnabled.ToString());
                if (enableOpenTracking != null) values.Add("enableOpenTracking", enableOpenTracking.ToString());
                if (consentTrackingOnUnsubscribe != null) values.Add("consentTrackingOnUnsubscribe", consentTrackingOnUnsubscribe.ToString());
                byte[] apiResponse = client.UploadValues(Api.ApiUri + "/account/updateadvancedoptions", values);
                ApiResponse<AdvancedOptions> apiRet = Newtonsoft.Json.JsonConvert.DeserializeObject<ApiResponse<AdvancedOptions>>(Encoding.UTF8.GetString(apiResponse));
                if (!apiRet.success) throw new ApplicationException(apiRet.error);
                return apiRet.Data;
            }

            /// <summary>
            /// Update settings of your private branding. These settings are needed, if you want to use Elastic Email under your brand.
            /// </summary>
            /// <param name="apikey">ApiKey that gives you access to our SMTP and HTTP API's.</param>
            /// <param name="enablePrivateBranding">True: Turn on or off ability to send mails under your brand. Otherwise, false</param>
            /// <param name="logoUrl">URL to your logo image.</param>
            /// <param name="supportLink">Address to your support.</param>
            /// <param name="privateBrandingUrl">Subdomain for your rebranded service</param>
            /// <param name="smtpAddress">Address of SMTP server.</param>
            /// <param name="smtpAlternative">Address of alternative SMTP server.</param>
            /// <param name="paymentUrl">URL for making payments.</param>
            public static void UpdateCustomBranding(bool enablePrivateBranding = false, string logoUrl = null, string supportLink = null, string privateBrandingUrl = null, string smtpAddress = null, string smtpAlternative = null, string paymentUrl = null)
            {
                WebClient client = new CustomWebClient();
                NameValueCollection values = new NameValueCollection();
                values.Add("apikey", Api.ApiKey);
                if (enablePrivateBranding != false) values.Add("enablePrivateBranding", enablePrivateBranding.ToString());
                if (logoUrl != null) values.Add("logoUrl", logoUrl);
                if (supportLink != null) values.Add("supportLink", supportLink);
                if (privateBrandingUrl != null) values.Add("privateBrandingUrl", privateBrandingUrl);
                if (smtpAddress != null) values.Add("smtpAddress", smtpAddress);
                if (smtpAlternative != null) values.Add("smtpAlternative", smtpAlternative);
                if (paymentUrl != null) values.Add("paymentUrl", paymentUrl);
                byte[] apiResponse = client.UploadValues(Api.ApiUri + "/account/updatecustombranding", values);
                ApiResponse<VoidApiResponse> apiRet = Newtonsoft.Json.JsonConvert.DeserializeObject<ApiResponse<VoidApiResponse>>(Encoding.UTF8.GetString(apiResponse));
                if (!apiRet.success) throw new ApplicationException(apiRet.error);
            }

            /// <summary>
            /// Update http notification URL.
            /// </summary>
            /// <param name="apikey">ApiKey that gives you access to our SMTP and HTTP API's.</param>
            /// <param name="url">URL of notification.</param>
            /// <param name="notifyOncePerEmail">True, if you want to receive notifications for each type only once per email. Otherwise, false</param>
            /// <param name="settings">Http notification settings serialized to JSON </param>
            public static void UpdateHttpNotification(string url, bool notifyOncePerEmail = false, string settings = null)
            {
                WebClient client = new CustomWebClient();
                NameValueCollection values = new NameValueCollection();
                values.Add("apikey", Api.ApiKey);
                values.Add("url", url);
                if (notifyOncePerEmail != false) values.Add("notifyOncePerEmail", notifyOncePerEmail.ToString());
                if (settings != null) values.Add("settings", settings);
                byte[] apiResponse = client.UploadValues(Api.ApiUri + "/account/updatehttpnotification", values);
                ApiResponse<VoidApiResponse> apiRet = Newtonsoft.Json.JsonConvert.DeserializeObject<ApiResponse<VoidApiResponse>>(Encoding.UTF8.GetString(apiResponse));
                if (!apiRet.success) throw new ApplicationException(apiRet.error);
            }

            /// <summary>
            /// Update your profile.
            /// </summary>
            /// <param name="apikey">ApiKey that gives you access to our SMTP and HTTP API's.</param>
            /// <param name="firstName">First name.</param>
            /// <param name="lastName">Last name.</param>
            /// <param name="address1">First line of address.</param>
            /// <param name="city">City.</param>
            /// <param name="state">State or province.</param>
            /// <param name="zip">Zip/postal code.</param>
            /// <param name="countryID">Numeric ID of country. A file with the list of countries is available <a href="http://api.elasticemail.com/public/countries"><b>here</b></a></param>
            /// <param name="marketingConsent">True if you want to receive newsletters from Elastic Email. Otherwise, false. Empty to leave the current value.</param>
            /// <param name="address2">Second line of address.</param>
            /// <param name="company">Company name.</param>
            /// <param name="website">HTTP address of your website.</param>
            /// <param name="logoUrl">URL to your logo image.</param>
            /// <param name="taxCode">Code used for tax purposes.</param>
            /// <param name="phone">Phone number</param>
            public static void UpdateProfile(string firstName, string lastName, string address1, string city, string state, string zip, int countryID, bool? marketingConsent = null, string address2 = null, string company = null, string website = null, string logoUrl = null, string taxCode = null, string phone = null)
            {
                WebClient client = new CustomWebClient();
                NameValueCollection values = new NameValueCollection();
                values.Add("apikey", Api.ApiKey);
                values.Add("firstName", firstName);
                values.Add("lastName", lastName);
                values.Add("address1", address1);
                values.Add("city", city);
                values.Add("state", state);
                values.Add("zip", zip);
                values.Add("countryID", countryID.ToString());
                if (marketingConsent != null) values.Add("marketingConsent", marketingConsent.ToString());
                if (address2 != null) values.Add("address2", address2);
                if (company != null) values.Add("company", company);
                if (website != null) values.Add("website", website);
                if (logoUrl != null) values.Add("logoUrl", logoUrl);
                if (taxCode != null) values.Add("taxCode", taxCode);
                if (phone != null) values.Add("phone", phone);
                byte[] apiResponse = client.UploadValues(Api.ApiUri + "/account/updateprofile", values);
                ApiResponse<VoidApiResponse> apiRet = Newtonsoft.Json.JsonConvert.DeserializeObject<ApiResponse<VoidApiResponse>>(Encoding.UTF8.GetString(apiResponse));
                if (!apiRet.success) throw new ApplicationException(apiRet.error);
            }

            /// <summary>
            /// Updates settings of specified subaccount
            /// </summary>
            /// <param name="apikey">ApiKey that gives you access to our SMTP and HTTP API's.</param>
            /// <param name="requiresEmailCredits">True, if account needs credits to send emails. Otherwise, false</param>
            /// <param name="monthlyRefillCredits">Amount of credits added to account automatically</param>
            /// <param name="requiresLitmusCredits">True, if account needs credits to send emails. Otherwise, false</param>
            /// <param name="enableLitmusTest">True, if account is able to send template tests to Litmus. Otherwise, false</param>
            /// <param name="dailySendLimit">Amount of emails account can send daily</param>
            /// <param name="emailSizeLimit">Maximum size of email including attachments in MB's</param>
            /// <param name="enablePrivateIPRequest">True, if account can request for private IP on its own. Otherwise, false</param>
            /// <param name="maxContacts">Maximum number of contacts the account can have</param>
            /// <param name="subAccountEmail">Email address of sub-account</param>
            /// <param name="publicAccountID">Public key of sub-account to update. Use subAccountEmail or publicAccountID not both.</param>
            /// <param name="sendingPermission">Sending permission setting for account</param>
            /// <param name="enableContactFeatures">True, if you want to use Contact Delivery Tools.  Otherwise, false</param>
            /// <param name="poolName">Name of your custom IP Pool to be used in the sending process</param>
            public static void UpdateSubAccountSettings(bool requiresEmailCredits = false, int monthlyRefillCredits = 0, bool requiresLitmusCredits = false, bool enableLitmusTest = false, int? dailySendLimit = null, int emailSizeLimit = 10, bool enablePrivateIPRequest = false, int maxContacts = 0, string subAccountEmail = null, string publicAccountID = null, SendingPermission? sendingPermission = null, bool? enableContactFeatures = null, string poolName = null)
            {
                WebClient client = new CustomWebClient();
                NameValueCollection values = new NameValueCollection();
                values.Add("apikey", Api.ApiKey);
                if (requiresEmailCredits != false) values.Add("requiresEmailCredits", requiresEmailCredits.ToString());
                if (monthlyRefillCredits != 0) values.Add("monthlyRefillCredits", monthlyRefillCredits.ToString());
                if (requiresLitmusCredits != false) values.Add("requiresLitmusCredits", requiresLitmusCredits.ToString());
                if (enableLitmusTest != false) values.Add("enableLitmusTest", enableLitmusTest.ToString());
                if (dailySendLimit != null) values.Add("dailySendLimit", dailySendLimit.ToString());
                if (emailSizeLimit != 10) values.Add("emailSizeLimit", emailSizeLimit.ToString());
                if (enablePrivateIPRequest != false) values.Add("enablePrivateIPRequest", enablePrivateIPRequest.ToString());
                if (maxContacts != 0) values.Add("maxContacts", maxContacts.ToString());
                if (subAccountEmail != null) values.Add("subAccountEmail", subAccountEmail);
                if (publicAccountID != null) values.Add("publicAccountID", publicAccountID);
                if (sendingPermission != null) values.Add("sendingPermission", Newtonsoft.Json.JsonConvert.SerializeObject(sendingPermission));
                if (enableContactFeatures != null) values.Add("enableContactFeatures", enableContactFeatures.ToString());
                if (poolName != null) values.Add("poolName", poolName);
                byte[] apiResponse = client.UploadValues(Api.ApiUri + "/account/updatesubaccountsettings", values);
                ApiResponse<VoidApiResponse> apiRet = Newtonsoft.Json.JsonConvert.DeserializeObject<ApiResponse<VoidApiResponse>>(Encoding.UTF8.GetString(apiResponse));
                if (!apiRet.success) throw new ApplicationException(apiRet.error);
            }

        }
        #endregion


        #region Campaign functions
        /// <summary>
        /// Sending and monitoring progress of your Campaigns
        /// </summary>
        public static class Campaign
        {
            /// <summary>
            /// Adds a campaign to the queue for processing based on the configuration
            /// </summary>
            /// <param name="apikey">ApiKey that gives you access to our SMTP and HTTP API's.</param>
            /// <param name="campaign">Json representation of a campaign</param>
            /// <returns>int</returns>
            public static int Add(ApiTypes.Campaign campaign)
            {
                WebClient client = new CustomWebClient();
                NameValueCollection values = new NameValueCollection();
                values.Add("apikey", Api.ApiKey);
                values.Add("campaign", Newtonsoft.Json.JsonConvert.SerializeObject(campaign));
                byte[] apiResponse = ApiUtilities.HttpPostFile(Api.ApiUri + "/campaign/add", null, values);
                ApiResponse<int> apiRet = Newtonsoft.Json.JsonConvert.DeserializeObject<ApiResponse<int>>(Encoding.UTF8.GetString(apiResponse));
                if (!apiRet.success) throw new ApplicationException(apiRet.error);
                return apiRet.Data;
            }

            /// <summary>
            /// Copy selected campaign
            /// </summary>
            /// <param name="apikey">ApiKey that gives you access to our SMTP and HTTP API's.</param>
            /// <param name="channelID">ID number of selected Channel.</param>
            /// <returns>int</returns>
            public static int Copy(int channelID)
            {
                WebClient client = new CustomWebClient();
                NameValueCollection values = new NameValueCollection();
                values.Add("apikey", Api.ApiKey);
                values.Add("channelID", channelID.ToString());
                byte[] apiResponse = client.UploadValues(Api.ApiUri + "/campaign/copy", values);
                ApiResponse<int> apiRet = Newtonsoft.Json.JsonConvert.DeserializeObject<ApiResponse<int>>(Encoding.UTF8.GetString(apiResponse));
                if (!apiRet.success) throw new ApplicationException(apiRet.error);
                return apiRet.Data;
            }

            /// <summary>
            /// Delete selected campaign
            /// </summary>
            /// <param name="apikey">ApiKey that gives you access to our SMTP and HTTP API's.</param>
            /// <param name="channelID">ID number of selected Channel.</param>
            public static void Delete(int channelID)
            {
                WebClient client = new CustomWebClient();
                NameValueCollection values = new NameValueCollection();
                values.Add("apikey", Api.ApiKey);
                values.Add("channelID", channelID.ToString());
                byte[] apiResponse = client.UploadValues(Api.ApiUri + "/campaign/delete", values);
                ApiResponse<VoidApiResponse> apiRet = Newtonsoft.Json.JsonConvert.DeserializeObject<ApiResponse<VoidApiResponse>>(Encoding.UTF8.GetString(apiResponse));
                if (!apiRet.success) throw new ApplicationException(apiRet.error);
            }

            /// <summary>
            /// Export selected campaigns to chosen file format.
            /// </summary>
            /// <param name="apikey">ApiKey that gives you access to our SMTP and HTTP API's.</param>
            /// <param name="channelIDs">List of campaign IDs used for processing</param>
            /// <param name="fileFormat">Format of the exported file</param>
            /// <param name="compressionFormat">FileResponse compression format. None or Zip.</param>
            /// <param name="fileName">Name of your file.</param>
            /// <returns>ExportLink</returns>
            public static ExportLink Export(IEnumerable<int> channelIDs = null, ExportFileFormats fileFormat = ExportFileFormats.Csv, CompressionFormat compressionFormat = CompressionFormat.None, string fileName = null)
            {
                WebClient client = new CustomWebClient();
                NameValueCollection values = new NameValueCollection();
                values.Add("apikey", Api.ApiKey);
                if (channelIDs != null) values.Add("channelIDs", string.Join(",", channelIDs));
                if (fileFormat != ExportFileFormats.Csv) values.Add("fileFormat", fileFormat.ToString());
                if (compressionFormat != CompressionFormat.None) values.Add("compressionFormat", compressionFormat.ToString());
                if (fileName != null) values.Add("fileName", fileName);
                byte[] apiResponse = client.UploadValues(Api.ApiUri + "/campaign/export", values);
                ApiResponse<ExportLink> apiRet = Newtonsoft.Json.JsonConvert.DeserializeObject<ApiResponse<ExportLink>>(Encoding.UTF8.GetString(apiResponse));
                if (!apiRet.success) throw new ApplicationException(apiRet.error);
                return apiRet.Data;
            }

            /// <summary>
            /// List all of your campaigns
            /// </summary>
            /// <param name="apikey">ApiKey that gives you access to our SMTP and HTTP API's.</param>
            /// <param name="search">Text fragment used for searching.</param>
            /// <param name="offset">How many items should be loaded ahead.</param>
            /// <param name="limit">Maximum of loaded items.</param>
            /// <returns>List(CampaignChannel)</returns>
            public static List<CampaignChannel> List(string search = null, int offset = 0, int limit = 0)
            {
                WebClient client = new CustomWebClient();
                NameValueCollection values = new NameValueCollection();
                values.Add("apikey", Api.ApiKey);
                if (search != null) values.Add("search", search);
                if (offset != 0) values.Add("offset", offset.ToString());
                if (limit != 0) values.Add("limit", limit.ToString());
                byte[] apiResponse = client.UploadValues(Api.ApiUri + "/campaign/list", values);
                ApiResponse<List<CampaignChannel>> apiRet = Newtonsoft.Json.JsonConvert.DeserializeObject<ApiResponse<List<CampaignChannel>>>(Encoding.UTF8.GetString(apiResponse));
                if (!apiRet.success) throw new ApplicationException(apiRet.error);
                return apiRet.Data;
            }

            /// <summary>
            /// Updates a previously added campaign.  Only Active and Paused campaigns can be updated.
            /// </summary>
            /// <param name="apikey">ApiKey that gives you access to our SMTP and HTTP API's.</param>
            /// <param name="campaign">Json representation of a campaign</param>
            /// <returns>int</returns>
            public static int Update(ApiTypes.Campaign campaign)
            {
                WebClient client = new CustomWebClient();
                NameValueCollection values = new NameValueCollection();
                values.Add("apikey", Api.ApiKey);
                values.Add("campaign", Newtonsoft.Json.JsonConvert.SerializeObject(campaign));
                byte[] apiResponse = ApiUtilities.HttpPostFile(Api.ApiUri + "/campaign/update", null, values);
                ApiResponse<int> apiRet = Newtonsoft.Json.JsonConvert.DeserializeObject<ApiResponse<int>>(Encoding.UTF8.GetString(apiResponse));
                if (!apiRet.success) throw new ApplicationException(apiRet.error);
                return apiRet.Data;
            }

        }
        #endregion


        #region Channel functions
        /// <summary>
        /// SMTP and HTTP API channels for grouping email delivery.
        /// </summary>
        public static class Channel
        {
            /// <summary>
            /// Manually add a channel to your account to group email
            /// </summary>
            /// <param name="apikey">ApiKey that gives you access to our SMTP and HTTP API's.</param>
            /// <param name="name">Descriptive name of the channel</param>
            /// <returns>string</returns>
            public static string Add(string name)
            {
                WebClient client = new CustomWebClient();
                NameValueCollection values = new NameValueCollection();
                values.Add("apikey", Api.ApiKey);
                values.Add("name", name);
                byte[] apiResponse = client.UploadValues(Api.ApiUri + "/channel/add", values);
                ApiResponse<string> apiRet = Newtonsoft.Json.JsonConvert.DeserializeObject<ApiResponse<string>>(Encoding.UTF8.GetString(apiResponse));
                if (!apiRet.success) throw new ApplicationException(apiRet.error);
                return apiRet.Data;
            }

            /// <summary>
            /// Delete the channel.
            /// </summary>
            /// <param name="apikey">ApiKey that gives you access to our SMTP and HTTP API's.</param>
            /// <param name="name">The name of the channel to delete.</param>
            public static void Delete(string name)
            {
                WebClient client = new CustomWebClient();
                NameValueCollection values = new NameValueCollection();
                values.Add("apikey", Api.ApiKey);
                values.Add("name", name);
                byte[] apiResponse = client.UploadValues(Api.ApiUri + "/channel/delete", values);
                ApiResponse<VoidApiResponse> apiRet = Newtonsoft.Json.JsonConvert.DeserializeObject<ApiResponse<VoidApiResponse>>(Encoding.UTF8.GetString(apiResponse));
                if (!apiRet.success) throw new ApplicationException(apiRet.error);
            }

            /// <summary>
            /// Export channels in CSV file format.
            /// </summary>
            /// <param name="apikey">ApiKey that gives you access to our SMTP and HTTP API's.</param>
            /// <param name="channelNames">List of channel names used for processing</param>
            /// <param name="compressionFormat">FileResponse compression format. None or Zip.</param>
            /// <param name="fileName">Name of your file.</param>
            /// <returns>FileData</returns>
            public static FileData ExportCsv(IEnumerable<string> channelNames, CompressionFormat compressionFormat = CompressionFormat.None, string fileName = null)
            {
                NameValueCollection values = new NameValueCollection();
                values.Add("apikey", Api.ApiKey);
                values.Add("channelNames", string.Join(",", channelNames));
                if (compressionFormat != CompressionFormat.None) values.Add("compressionFormat", compressionFormat.ToString());
                if (fileName != null) values.Add("fileName", fileName);
                return ApiUtilities.HttpGetFile(Api.ApiUri + "/channel/exportcsv", values);
            }

            /// <summary>
            /// Export channels in JSON file format.
            /// </summary>
            /// <param name="apikey">ApiKey that gives you access to our SMTP and HTTP API's.</param>
            /// <param name="channelNames">List of channel names used for processing</param>
            /// <param name="compressionFormat">FileResponse compression format. None or Zip.</param>
            /// <param name="fileName">Name of your file.</param>
            /// <returns>FileData</returns>
            public static FileData ExportJson(IEnumerable<string> channelNames, CompressionFormat compressionFormat = CompressionFormat.None, string fileName = null)
            {
                NameValueCollection values = new NameValueCollection();
                values.Add("apikey", Api.ApiKey);
                values.Add("channelNames", string.Join(",", channelNames));
                if (compressionFormat != CompressionFormat.None) values.Add("compressionFormat", compressionFormat.ToString());
                if (fileName != null) values.Add("fileName", fileName);
                return ApiUtilities.HttpGetFile(Api.ApiUri + "/channel/exportjson", values);
            }

            /// <summary>
            /// Export channels in XML file format.
            /// </summary>
            /// <param name="apikey">ApiKey that gives you access to our SMTP and HTTP API's.</param>
            /// <param name="channelNames">List of channel names used for processing</param>
            /// <param name="compressionFormat">FileResponse compression format. None or Zip.</param>
            /// <param name="fileName">Name of your file.</param>
            /// <returns>FileData</returns>
            public static FileData ExportXml(IEnumerable<string> channelNames, CompressionFormat compressionFormat = CompressionFormat.None, string fileName = null)
            {
                NameValueCollection values = new NameValueCollection();
                values.Add("apikey", Api.ApiKey);
                values.Add("channelNames", string.Join(",", channelNames));
                if (compressionFormat != CompressionFormat.None) values.Add("compressionFormat", compressionFormat.ToString());
                if (fileName != null) values.Add("fileName", fileName);
                return ApiUtilities.HttpGetFile(Api.ApiUri + "/channel/exportxml", values);
            }

            /// <summary>
            /// List all of your channels
            /// </summary>
            /// <param name="apikey">ApiKey that gives you access to our SMTP and HTTP API's.</param>
            /// <returns>List(Channel)</returns>
            public static List<ApiTypes.Channel> List()
            {
                WebClient client = new CustomWebClient();
                NameValueCollection values = new NameValueCollection();
                values.Add("apikey", Api.ApiKey);
                byte[] apiResponse = client.UploadValues(Api.ApiUri + "/channel/list", values);
                ApiResponse<List<ApiTypes.Channel>> apiRet = Newtonsoft.Json.JsonConvert.DeserializeObject<ApiResponse<List<ApiTypes.Channel>>>(Encoding.UTF8.GetString(apiResponse));
                if (!apiRet.success) throw new ApplicationException(apiRet.error);
                return apiRet.Data;
            }

            /// <summary>
            /// Rename an existing channel.
            /// </summary>
            /// <param name="apikey">ApiKey that gives you access to our SMTP and HTTP API's.</param>
            /// <param name="name">The name of the channel to update.</param>
            /// <param name="newName">The new name for the channel.</param>
            /// <returns>string</returns>
            public static string Update(string name, string newName)
            {
                WebClient client = new CustomWebClient();
                NameValueCollection values = new NameValueCollection();
                values.Add("apikey", Api.ApiKey);
                values.Add("name", name);
                values.Add("newName", newName);
                byte[] apiResponse = client.UploadValues(Api.ApiUri + "/channel/update", values);
                ApiResponse<string> apiRet = Newtonsoft.Json.JsonConvert.DeserializeObject<ApiResponse<string>>(Encoding.UTF8.GetString(apiResponse));
                if (!apiRet.success) throw new ApplicationException(apiRet.error);
                return apiRet.Data;
            }

        }
        #endregion


        #region Contact functions
        /// <summary>
        /// Methods used to manage your Contacts.
        /// </summary>
        public static class Contact
        {
            /// <summary>
            /// Add a new contact and optionally to one of your lists.  Note that your API KEY is not required for this call.
            /// </summary>
            /// <param name="publicAccountID">Public key for limited access to your account such as contact/add so you can use it safely on public websites.</param>
            /// <param name="email">Proper email address.</param>
            /// <param name="publicListID">ID code of list</param>
            /// <param name="listName">Name of your list.</param>
            /// <param name="firstName">First name.</param>
            /// <param name="lastName">Last name.</param>
            /// <param name="source">Specifies the way of uploading the contact</param>
            /// <param name="returnUrl">URL to navigate to after account creation</param>
            /// <param name="sourceUrl">URL from which request was sent.</param>
            /// <param name="activationReturnUrl">The url to return the contact to after activation.</param>
            /// <param name="activationTemplate"></param>
            /// <param name="sendActivation">True, if you want to send activation email to this account. Otherwise, false</param>
            /// <param name="consentDate">Date of consent to send this contact(s) your email. If not provided current date is used for consent.</param>
            /// <param name="consentIP">IP address of consent to send this contact(s) your email. If not provided your current public IP address is used for consent.</param>
            /// <param name="field">Custom contact field like firstname, lastname, city etc. Request parameters prefixed by field_ like field_firstname, field_lastname </param>
            /// <param name="notifyEmail">Emails, separated by semicolon, to which the notification about contact subscribing should be sent to</param>
            /// <param name="alreadyActiveUrl"></param>
            /// <param name="consentTracking"></param>
            /// <returns>string</returns>
            public static string Add(string publicAccountID, string email, IEnumerable<string> publicListID = null, string[] listName = null, string firstName = null, string lastName = null, ContactSource source = ContactSource.ContactApi, string returnUrl = null, string sourceUrl = null, string activationReturnUrl = null, string activationTemplate = null, bool sendActivation = true, DateTime? consentDate = null, string consentIP = null, Dictionary<string, string> field = null, string notifyEmail = null, string alreadyActiveUrl = null, ConsentTracking consentTracking = ConsentTracking.Unknown)
            {
                WebClient client = new CustomWebClient();
                NameValueCollection values = new NameValueCollection();
                values.Add("apikey", Api.ApiKey);
                values.Add("publicAccountID", publicAccountID);
                values.Add("email", email);
                if (publicListID != null) values.Add("publicListID", string.Join(",", publicListID));
                if (listName != null)
                {
                    foreach (string _item in listName)
                    {
                        values.Add("listName", _item);
                    }
                }
                if (firstName != null) values.Add("firstName", firstName);
                if (lastName != null) values.Add("lastName", lastName);
                if (source != ContactSource.ContactApi) values.Add("source", source.ToString());
                if (returnUrl != null) values.Add("returnUrl", returnUrl);
                if (sourceUrl != null) values.Add("sourceUrl", sourceUrl);
                if (activationReturnUrl != null) values.Add("activationReturnUrl", activationReturnUrl);
                if (activationTemplate != null) values.Add("activationTemplate", activationTemplate);
                if (sendActivation != true) values.Add("sendActivation", sendActivation.ToString());
                if (consentDate != null) values.Add("consentDate", consentDate.Value.ToString("M/d/yyyy h:mm:ss tt"));
                if (consentIP != null) values.Add("consentIP", consentIP);
                if (field != null)
                {
                    foreach (KeyValuePair<string, string> _item in field)
                    {
                        values.Add("field_" + _item.Key, _item.Value);
                    }
                }
                if (notifyEmail != null) values.Add("notifyEmail", notifyEmail);
                if (alreadyActiveUrl != null) values.Add("alreadyActiveUrl", alreadyActiveUrl);
                if (consentTracking != ConsentTracking.Unknown) values.Add("consentTracking", consentTracking.ToString());
                byte[] apiResponse = client.UploadValues(Api.ApiUri + "/contact/add", values);
                ApiResponse<string> apiRet = Newtonsoft.Json.JsonConvert.DeserializeObject<ApiResponse<string>>(Encoding.UTF8.GetString(apiResponse));
                if (!apiRet.success) throw new ApplicationException(apiRet.error);
                return apiRet.Data;
            }

            /// <summary>
            /// Manually add or update a contacts status to Abuse or Unsubscribed status (blocked).
            /// </summary>
            /// <param name="apikey">ApiKey that gives you access to our SMTP and HTTP API's.</param>
            /// <param name="email">Proper email address.</param>
            /// <param name="status">Name of status: Active, Engaged, Inactive, Abuse, Bounced, Unsubscribed.</param>
            public static void AddBlocked(string email, ContactStatus status)
            {
                WebClient client = new CustomWebClient();
                NameValueCollection values = new NameValueCollection();
                values.Add("apikey", Api.ApiKey);
                values.Add("email", email);
                values.Add("status", status.ToString());
                byte[] apiResponse = client.UploadValues(Api.ApiUri + "/contact/addblocked", values);
                ApiResponse<VoidApiResponse> apiRet = Newtonsoft.Json.JsonConvert.DeserializeObject<ApiResponse<VoidApiResponse>>(Encoding.UTF8.GetString(apiResponse));
                if (!apiRet.success) throw new ApplicationException(apiRet.error);
            }

            /// <summary>
            /// Change any property on the contact record.
            /// </summary>
            /// <param name="apikey">ApiKey that gives you access to our SMTP and HTTP API's.</param>
            /// <param name="email">Proper email address.</param>
            /// <param name="name">Name of the contact property you want to change.</param>
            /// <param name="value">Value you would like to change the contact property to.</param>
            public static void ChangeProperty(string email, string name, string value)
            {
                WebClient client = new CustomWebClient();
                NameValueCollection values = new NameValueCollection();
                values.Add("apikey", Api.ApiKey);
                values.Add("email", email);
                values.Add("name", name);
                values.Add("value", value);
                byte[] apiResponse = client.UploadValues(Api.ApiUri + "/contact/changeproperty", values);
                ApiResponse<VoidApiResponse> apiRet = Newtonsoft.Json.JsonConvert.DeserializeObject<ApiResponse<VoidApiResponse>>(Encoding.UTF8.GetString(apiResponse));
                if (!apiRet.success) throw new ApplicationException(apiRet.error);
            }

            /// <summary>
            /// Changes status of selected Contacts. You may provide RULE for selection or specify list of Contact IDs.
            /// </summary>
            /// <param name="apikey">ApiKey that gives you access to our SMTP and HTTP API's.</param>
            /// <param name="status">Name of status: Active, Engaged, Inactive, Abuse, Bounced, Unsubscribed.</param>
            /// <param name="rule">Query used for filtering.</param>
            /// <param name="emails">Comma delimited list of contact emails</param>
            public static void ChangeStatus(ContactStatus status, string rule = null, IEnumerable<string> emails = null)
            {
                WebClient client = new CustomWebClient();
                NameValueCollection values = new NameValueCollection();
                values.Add("apikey", Api.ApiKey);
                values.Add("status", status.ToString());
                if (rule != null) values.Add("rule", rule);
                if (emails != null) values.Add("emails", string.Join(",", emails));
                byte[] apiResponse = client.UploadValues(Api.ApiUri + "/contact/changestatus", values);
                ApiResponse<VoidApiResponse> apiRet = Newtonsoft.Json.JsonConvert.DeserializeObject<ApiResponse<VoidApiResponse>>(Encoding.UTF8.GetString(apiResponse));
                if (!apiRet.success) throw new ApplicationException(apiRet.error);
            }

            /// <summary>
            /// Returns number of Contacts, RULE specifies contact Status.
            /// </summary>
            /// <param name="apikey">ApiKey that gives you access to our SMTP and HTTP API's.</param>
            /// <param name="rule">Query used for filtering.</param>
            /// <param name="allContacts">True: Include every Contact in your Account. Otherwise, false</param>
            /// <returns>ContactStatusCounts</returns>
            public static ContactStatusCounts CountByStatus(string rule = null, bool allContacts = false)
            {
                WebClient client = new CustomWebClient();
                NameValueCollection values = new NameValueCollection();
                values.Add("apikey", Api.ApiKey);
                if (rule != null) values.Add("rule", rule);
                if (allContacts != false) values.Add("allContacts", allContacts.ToString());
                byte[] apiResponse = client.UploadValues(Api.ApiUri + "/contact/countbystatus", values);
                ApiResponse<ContactStatusCounts> apiRet = Newtonsoft.Json.JsonConvert.DeserializeObject<ApiResponse<ContactStatusCounts>>(Encoding.UTF8.GetString(apiResponse));
                if (!apiRet.success) throw new ApplicationException(apiRet.error);
                return apiRet.Data;
            }

            /// <summary>
            /// Returns count of unsubscribe reasons for unsubscribed and complaint contacts.
            /// </summary>
            /// <param name="apikey">ApiKey that gives you access to our SMTP and HTTP API's.</param>
            /// <param name="from">Starting date for search in YYYY-MM-DDThh:mm:ss format.</param>
            /// <param name="to">Ending date for search in YYYY-MM-DDThh:mm:ss format.</param>
            /// <returns>ContactUnsubscribeReasonCounts</returns>
            public static ContactUnsubscribeReasonCounts CountByUnsubscribeReason(DateTime? from = null, DateTime? to = null)
            {
                WebClient client = new CustomWebClient();
                NameValueCollection values = new NameValueCollection();
                values.Add("apikey", Api.ApiKey);
                if (from != null) values.Add("from", from.Value.ToString("M/d/yyyy h:mm:ss tt"));
                if (to != null) values.Add("to", to.Value.ToString("M/d/yyyy h:mm:ss tt"));
                byte[] apiResponse = client.UploadValues(Api.ApiUri + "/contact/countbyunsubscribereason", values);
                ApiResponse<ContactUnsubscribeReasonCounts> apiRet = Newtonsoft.Json.JsonConvert.DeserializeObject<ApiResponse<ContactUnsubscribeReasonCounts>>(Encoding.UTF8.GetString(apiResponse));
                if (!apiRet.success) throw new ApplicationException(apiRet.error);
                return apiRet.Data;
            }

            /// <summary>
            /// Permanantly deletes the contacts provided.  You can provide either a qualified rule or a list of emails (comma separated string).
            /// </summary>
            /// <param name="apikey">ApiKey that gives you access to our SMTP and HTTP API's.</param>
            /// <param name="rule">Query used for filtering.</param>
            /// <param name="emails">Comma delimited list of contact emails</param>
            public static void Delete(string rule = null, IEnumerable<string> emails = null)
            {
                WebClient client = new CustomWebClient();
                NameValueCollection values = new NameValueCollection();
                values.Add("apikey", Api.ApiKey);
                if (rule != null) values.Add("rule", rule);
                if (emails != null) values.Add("emails", string.Join(",", emails));
                byte[] apiResponse = client.UploadValues(Api.ApiUri + "/contact/delete", values);
                ApiResponse<VoidApiResponse> apiRet = Newtonsoft.Json.JsonConvert.DeserializeObject<ApiResponse<VoidApiResponse>>(Encoding.UTF8.GetString(apiResponse));
                if (!apiRet.success) throw new ApplicationException(apiRet.error);
            }

            /// <summary>
            /// Export selected Contacts to file.
            /// </summary>
            /// <param name="apikey">ApiKey that gives you access to our SMTP and HTTP API's.</param>
            /// <param name="fileFormat">Format of the exported file</param>
            /// <param name="rule">Query used for filtering.</param>
            /// <param name="emails">Comma delimited list of contact emails</param>
            /// <param name="compressionFormat">FileResponse compression format. None or Zip.</param>
            /// <param name="fileName">Name of your file.</param>
            /// <returns>ExportLink</returns>
            public static ExportLink Export(ExportFileFormats fileFormat = ExportFileFormats.Csv, string rule = null, IEnumerable<string> emails = null, CompressionFormat compressionFormat = CompressionFormat.None, string fileName = null)
            {
                WebClient client = new CustomWebClient();
                NameValueCollection values = new NameValueCollection();
                values.Add("apikey", Api.ApiKey);
                if (fileFormat != ExportFileFormats.Csv) values.Add("fileFormat", fileFormat.ToString());
                if (rule != null) values.Add("rule", rule);
                if (emails != null) values.Add("emails", string.Join(",", emails));
                if (compressionFormat != CompressionFormat.None) values.Add("compressionFormat", compressionFormat.ToString());
                if (fileName != null) values.Add("fileName", fileName);
                byte[] apiResponse = client.UploadValues(Api.ApiUri + "/contact/export", values);
                ApiResponse<ExportLink> apiRet = Newtonsoft.Json.JsonConvert.DeserializeObject<ApiResponse<ExportLink>>(Encoding.UTF8.GetString(apiResponse));
                if (!apiRet.success) throw new ApplicationException(apiRet.error);
                return apiRet.Data;
            }

            /// <summary>
            /// Export contacts' unsubscribe reasons count to file.
            /// </summary>
            /// <param name="apikey">ApiKey that gives you access to our SMTP and HTTP API's.</param>
            /// <param name="from">Starting date for search in YYYY-MM-DDThh:mm:ss format.</param>
            /// <param name="to">Ending date for search in YYYY-MM-DDThh:mm:ss format.</param>
            /// <param name="fileFormat">Format of the exported file</param>
            /// <param name="compressionFormat">FileResponse compression format. None or Zip.</param>
            /// <param name="fileName">Name of your file.</param>
            /// <returns>ExportLink</returns>
            public static ExportLink ExportUnsubscribeReasonCount(DateTime? from = null, DateTime? to = null, ExportFileFormats fileFormat = ExportFileFormats.Csv, CompressionFormat compressionFormat = CompressionFormat.None, string fileName = null)
            {
                WebClient client = new CustomWebClient();
                NameValueCollection values = new NameValueCollection();
                values.Add("apikey", Api.ApiKey);
                if (from != null) values.Add("from", from.Value.ToString("M/d/yyyy h:mm:ss tt"));
                if (to != null) values.Add("to", to.Value.ToString("M/d/yyyy h:mm:ss tt"));
                if (fileFormat != ExportFileFormats.Csv) values.Add("fileFormat", fileFormat.ToString());
                if (compressionFormat != CompressionFormat.None) values.Add("compressionFormat", compressionFormat.ToString());
                if (fileName != null) values.Add("fileName", fileName);
                byte[] apiResponse = client.UploadValues(Api.ApiUri + "/contact/exportunsubscribereasoncount", values);
                ApiResponse<ExportLink> apiRet = Newtonsoft.Json.JsonConvert.DeserializeObject<ApiResponse<ExportLink>>(Encoding.UTF8.GetString(apiResponse));
                if (!apiRet.success) throw new ApplicationException(apiRet.error);
                return apiRet.Data;
            }

            /// <summary>
            /// Finds all Lists and Segments this email belongs to.
            /// </summary>
            /// <param name="apikey">ApiKey that gives you access to our SMTP and HTTP API's.</param>
            /// <param name="email">Proper email address.</param>
            /// <returns>ContactCollection</returns>
            public static ContactCollection FindContact(string email)
            {
                WebClient client = new CustomWebClient();
                NameValueCollection values = new NameValueCollection();
                values.Add("apikey", Api.ApiKey);
                values.Add("email", email);
                byte[] apiResponse = client.UploadValues(Api.ApiUri + "/contact/findcontact", values);
                ApiResponse<ContactCollection> apiRet = Newtonsoft.Json.JsonConvert.DeserializeObject<ApiResponse<ContactCollection>>(Encoding.UTF8.GetString(apiResponse));
                if (!apiRet.success) throw new ApplicationException(apiRet.error);
                return apiRet.Data;
            }

            /// <summary>
            /// List of Contacts for provided List
            /// </summary>
            /// <param name="apikey">ApiKey that gives you access to our SMTP and HTTP API's.</param>
            /// <param name="listName">Name of your list.</param>
            /// <param name="limit">Maximum of loaded items.</param>
            /// <param name="offset">How many items should be loaded ahead.</param>
            /// <returns>List(Contact)</returns>
            public static List<ApiTypes.Contact> GetContactsByList(string listName, int limit = 20, int offset = 0)
            {
                WebClient client = new CustomWebClient();
                NameValueCollection values = new NameValueCollection();
                values.Add("apikey", Api.ApiKey);
                values.Add("listName", listName);
                if (limit != 20) values.Add("limit", limit.ToString());
                if (offset != 0) values.Add("offset", offset.ToString());
                byte[] apiResponse = client.UploadValues(Api.ApiUri + "/contact/getcontactsbylist", values);
                ApiResponse<List<ApiTypes.Contact>> apiRet = Newtonsoft.Json.JsonConvert.DeserializeObject<ApiResponse<List<ApiTypes.Contact>>>(Encoding.UTF8.GetString(apiResponse));
                if (!apiRet.success) throw new ApplicationException(apiRet.error);
                return apiRet.Data;
            }

            /// <summary>
            /// List of Contacts for provided Segment
            /// </summary>
            /// <param name="apikey">ApiKey that gives you access to our SMTP and HTTP API's.</param>
            /// <param name="segmentName">Name of your segment.</param>
            /// <param name="limit">Maximum of loaded items.</param>
            /// <param name="offset">How many items should be loaded ahead.</param>
            /// <returns>List(Contact)</returns>
            public static List<ApiTypes.Contact> GetContactsBySegment(string segmentName, int limit = 20, int offset = 0)
            {
                WebClient client = new CustomWebClient();
                NameValueCollection values = new NameValueCollection();
                values.Add("apikey", Api.ApiKey);
                values.Add("segmentName", segmentName);
                if (limit != 20) values.Add("limit", limit.ToString());
                if (offset != 0) values.Add("offset", offset.ToString());
                byte[] apiResponse = client.UploadValues(Api.ApiUri + "/contact/getcontactsbysegment", values);
                ApiResponse<List<ApiTypes.Contact>> apiRet = Newtonsoft.Json.JsonConvert.DeserializeObject<ApiResponse<List<ApiTypes.Contact>>>(Encoding.UTF8.GetString(apiResponse));
                if (!apiRet.success) throw new ApplicationException(apiRet.error);
                return apiRet.Data;
            }

            /// <summary>
            /// List of all contacts. If you have not specified RULE, all Contacts will be listed.
            /// </summary>
            /// <param name="apikey">ApiKey that gives you access to our SMTP and HTTP API's.</param>
            /// <param name="rule">Query used for filtering.</param>
            /// <param name="limit">Maximum of loaded items.</param>
            /// <param name="offset">How many items should be loaded ahead.</param>
            /// <returns>List(Contact)</returns>
            public static List<ApiTypes.Contact> List(string rule = null, int limit = 20, int offset = 0)
            {
                WebClient client = new CustomWebClient();
                NameValueCollection values = new NameValueCollection();
                values.Add("apikey", Api.ApiKey);
                if (rule != null) values.Add("rule", rule);
                if (limit != 20) values.Add("limit", limit.ToString());
                if (offset != 0) values.Add("offset", offset.ToString());
                byte[] apiResponse = client.UploadValues(Api.ApiUri + "/contact/list", values);
                ApiResponse<List<ApiTypes.Contact>> apiRet = Newtonsoft.Json.JsonConvert.DeserializeObject<ApiResponse<List<ApiTypes.Contact>>>(Encoding.UTF8.GetString(apiResponse));
                if (!apiRet.success) throw new ApplicationException(apiRet.error);
                return apiRet.Data;
            }

            /// <summary>
            /// Load blocked contacts
            /// </summary>
            /// <param name="apikey">ApiKey that gives you access to our SMTP and HTTP API's.</param>
            /// <param name="statuses">List of blocked statuses: Abuse, Bounced or Unsubscribed</param>
            /// <param name="search">Text fragment used for searching.</param>
            /// <param name="limit">Maximum of loaded items.</param>
            /// <param name="offset">How many items should be loaded ahead.</param>
            /// <returns>List(BlockedContact)</returns>
            public static List<BlockedContact> LoadBlocked(IEnumerable<ContactStatus> statuses, string search = null, int limit = 0, int offset = 0)
            {
                WebClient client = new CustomWebClient();
                NameValueCollection values = new NameValueCollection();
                values.Add("apikey", Api.ApiKey);
                values.Add("statuses", string.Join(",", statuses));
                if (search != null) values.Add("search", search);
                if (limit != 0) values.Add("limit", limit.ToString());
                if (offset != 0) values.Add("offset", offset.ToString());
                byte[] apiResponse = client.UploadValues(Api.ApiUri + "/contact/loadblocked", values);
                ApiResponse<List<BlockedContact>> apiRet = Newtonsoft.Json.JsonConvert.DeserializeObject<ApiResponse<List<BlockedContact>>>(Encoding.UTF8.GetString(apiResponse));
                if (!apiRet.success) throw new ApplicationException(apiRet.error);
                return apiRet.Data;
            }

            /// <summary>
            /// Load detailed contact information
            /// </summary>
            /// <param name="apikey">ApiKey that gives you access to our SMTP and HTTP API's.</param>
            /// <param name="email">Proper email address.</param>
            /// <returns>Contact</returns>
            public static ApiTypes.Contact LoadContact(string email)
            {
                WebClient client = new CustomWebClient();
                NameValueCollection values = new NameValueCollection();
                values.Add("apikey", Api.ApiKey);
                values.Add("email", email);
                byte[] apiResponse = client.UploadValues(Api.ApiUri + "/contact/loadcontact", values);
                ApiResponse<ApiTypes.Contact> apiRet = Newtonsoft.Json.JsonConvert.DeserializeObject<ApiResponse<ApiTypes.Contact>>(Encoding.UTF8.GetString(apiResponse));
                if (!apiRet.success) throw new ApplicationException(apiRet.error);
                return apiRet.Data;
            }

            /// <summary>
            /// Shows detailed history of chosen Contact.
            /// </summary>
            /// <param name="apikey">ApiKey that gives you access to our SMTP and HTTP API's.</param>
            /// <param name="email">Proper email address.</param>
            /// <param name="limit">Maximum of loaded items.</param>
            /// <param name="offset">How many items should be loaded ahead.</param>
            /// <returns>List(ContactHistory)</returns>
            public static List<ContactHistory> LoadHistory(string email, int limit = 0, int offset = 0)
            {
                WebClient client = new CustomWebClient();
                NameValueCollection values = new NameValueCollection();
                values.Add("apikey", Api.ApiKey);
                values.Add("email", email);
                if (limit != 0) values.Add("limit", limit.ToString());
                if (offset != 0) values.Add("offset", offset.ToString());
                byte[] apiResponse = client.UploadValues(Api.ApiUri + "/contact/loadhistory", values);
                ApiResponse<List<ContactHistory>> apiRet = Newtonsoft.Json.JsonConvert.DeserializeObject<ApiResponse<List<ContactHistory>>>(Encoding.UTF8.GetString(apiResponse));
                if (!apiRet.success) throw new ApplicationException(apiRet.error);
                return apiRet.Data;
            }

            /// <summary>
            /// Add new Contact to one of your Lists.
            /// </summary>
            /// <param name="apikey">ApiKey that gives you access to our SMTP and HTTP API's.</param>
            /// <param name="emails">Comma delimited list of contact emails</param>
            /// <param name="firstName">First name.</param>
            /// <param name="lastName">Last name.</param>
            /// <param name="publicListID">ID code of list</param>
            /// <param name="listName">Name of your list.</param>
            /// <param name="status">Name of status: Active, Engaged, Inactive, Abuse, Bounced, Unsubscribed.</param>
            /// <param name="notes">Free form field of notes</param>
            /// <param name="consentDate">Date of consent to send this contact(s) your email. If not provided current date is used for consent.</param>
            /// <param name="consentIP">IP address of consent to send this contact(s) your email. If not provided your current public IP address is used for consent.</param>
            /// <param name="field">Custom contact field like firstname, lastname, city etc. Request parameters prefixed by field_ like field_firstname, field_lastname </param>
            /// <param name="notifyEmail">Emails, separated by semicolon, to which the notification about contact subscribing should be sent to</param>
            /// <param name="consentTracking"></param>
            public static void QuickAdd(IEnumerable<string> emails, string firstName = null, string lastName = null, string publicListID = null, string listName = null, ContactStatus status = ContactStatus.Active, string notes = null, DateTime? consentDate = null, string consentIP = null, Dictionary<string, string> field = null, string notifyEmail = null, ConsentTracking consentTracking = ConsentTracking.Unknown)
            {
                WebClient client = new CustomWebClient();
                NameValueCollection values = new NameValueCollection();
                values.Add("apikey", Api.ApiKey);
                values.Add("emails", string.Join(",", emails));
                if (firstName != null) values.Add("firstName", firstName);
                if (lastName != null) values.Add("lastName", lastName);
                if (publicListID != null) values.Add("publicListID", publicListID);
                if (listName != null) values.Add("listName", listName);
                if (status != ContactStatus.Active) values.Add("status", status.ToString());
                if (notes != null) values.Add("notes", notes);
                if (consentDate != null) values.Add("consentDate", consentDate.Value.ToString("M/d/yyyy h:mm:ss tt"));
                if (consentIP != null) values.Add("consentIP", consentIP);
                if (field != null)
                {
                    foreach (KeyValuePair<string, string> _item in field)
                    {
                        values.Add("field_" + _item.Key, _item.Value);
                    }
                }
                if (notifyEmail != null) values.Add("notifyEmail", notifyEmail);
                if (consentTracking != ConsentTracking.Unknown) values.Add("consentTracking", consentTracking.ToString());
                byte[] apiResponse = client.UploadValues(Api.ApiUri + "/contact/quickadd", values);
                ApiResponse<VoidApiResponse> apiRet = Newtonsoft.Json.JsonConvert.DeserializeObject<ApiResponse<VoidApiResponse>>(Encoding.UTF8.GetString(apiResponse));
                if (!apiRet.success) throw new ApplicationException(apiRet.error);
            }

            /// <summary>
            /// Basic double opt-in email subscribe form for your account.  This can be used for contacts that need to re-subscribe as well.
            /// </summary>
            /// <param name="publicAccountID">Public key for limited access to your account such as contact/add so you can use it safely on public websites.</param>
            /// <returns>string</returns>
            public static string Subscribe(string publicAccountID)
            {
                WebClient client = new CustomWebClient();
                NameValueCollection values = new NameValueCollection();
                values.Add("apikey", Api.ApiKey);
                values.Add("publicAccountID", publicAccountID);
                byte[] apiResponse = client.UploadValues(Api.ApiUri + "/contact/subscribe", values);
                ApiResponse<string> apiRet = Newtonsoft.Json.JsonConvert.DeserializeObject<ApiResponse<string>>(Encoding.UTF8.GetString(apiResponse));
                if (!apiRet.success) throw new ApplicationException(apiRet.error);
                return apiRet.Data;
            }

            /// <summary>
            /// Update selected contact. Omitted contact's fields will be reset by default (see the clearRestOfFields parameter)
            /// </summary>
            /// <param name="apikey">ApiKey that gives you access to our SMTP and HTTP API's.</param>
            /// <param name="email">Proper email address.</param>
            /// <param name="firstName">First name.</param>
            /// <param name="lastName">Last name.</param>
            /// <param name="clearRestOfFields">States if the fields that were omitted in this request are to be reset or should they be left with their current value</param>
            /// <param name="field">Custom contact field like firstname, lastname, city etc. Request parameters prefixed by field_ like field_firstname, field_lastname </param>
            /// <param name="customFields">Custom contact field like firstname, lastname, city etc. JSON serialized text like { "city":"london" } </param>
            /// <returns>Contact</returns>
            public static ApiTypes.Contact Update(string email, string firstName = null, string lastName = null, bool clearRestOfFields = true, Dictionary<string, string> field = null, string customFields = null)
            {
                WebClient client = new CustomWebClient();
                NameValueCollection values = new NameValueCollection();
                values.Add("apikey", Api.ApiKey);
                values.Add("email", email);
                if (firstName != null) values.Add("firstName", firstName);
                if (lastName != null) values.Add("lastName", lastName);
                if (clearRestOfFields != true) values.Add("clearRestOfFields", clearRestOfFields.ToString());
                if (field != null)
                {
                    foreach (KeyValuePair<string, string> _item in field)
                    {
                        values.Add("field_" + _item.Key, _item.Value);
                    }
                }
                if (customFields != null) values.Add("customFields", customFields);
                byte[] apiResponse = client.UploadValues(Api.ApiUri + "/contact/update", values);
                ApiResponse<ApiTypes.Contact> apiRet = Newtonsoft.Json.JsonConvert.DeserializeObject<ApiResponse<ApiTypes.Contact>>(Encoding.UTF8.GetString(apiResponse));
                if (!apiRet.success) throw new ApplicationException(apiRet.error);
                return apiRet.Data;
            }

            /// <summary>
            /// Upload contacts in CSV file.
            /// </summary>
            /// <param name="apikey">ApiKey that gives you access to our SMTP and HTTP API's.</param>
            /// <param name="contactFile">Name of CSV file with Contacts.</param>
            /// <param name="allowUnsubscribe">True: Allow unsubscribing from this (optional) newly created list. Otherwise, false</param>
            /// <param name="listID">ID number of selected list.</param>
            /// <param name="listName">Name of your list to upload contacts to, or how the new, automatically created list should be named</param>
            /// <param name="status">Name of status: Active, Engaged, Inactive, Abuse, Bounced, Unsubscribed.</param>
            /// <param name="consentDate">Date of consent to send this contact(s) your email. If not provided current date is used for consent.</param>
            /// <param name="consentIP">IP address of consent to send this contact(s) your email. If not provided your current public IP address is used for consent.</param>
            /// <param name="consentTracking"></param>
            /// <returns>int</returns>
            public static int Upload(FileData contactFile, bool allowUnsubscribe = false, int? listID = null, string listName = null, ContactStatus status = ContactStatus.Active, DateTime? consentDate = null, string consentIP = null, ConsentTracking consentTracking = ConsentTracking.Unknown)
            {
                NameValueCollection values = new NameValueCollection();
                values.Add("apikey", Api.ApiKey);
                if (allowUnsubscribe != false) values.Add("allowUnsubscribe", allowUnsubscribe.ToString());
                if (listID != null) values.Add("listID", listID.ToString());
                if (listName != null) values.Add("listName", listName);
                if (status != ContactStatus.Active) values.Add("status", status.ToString());
                if (consentDate != null) values.Add("consentDate", consentDate.Value.ToString("M/d/yyyy h:mm:ss tt"));
                if (consentIP != null) values.Add("consentIP", consentIP);
                if (consentTracking != ConsentTracking.Unknown) values.Add("consentTracking", consentTracking.ToString());
                byte[] apiResponse = ApiUtilities.HttpPostFile(Api.ApiUri + "/contact/upload", new List<FileData>() { contactFile }, values);
                ApiResponse<int> apiRet = Newtonsoft.Json.JsonConvert.DeserializeObject<ApiResponse<int>>(Encoding.UTF8.GetString(apiResponse));
                if (!apiRet.success) throw new ApplicationException(apiRet.error);
                return apiRet.Data;
            }

        }
        #endregion


        #region Domain functions
        /// <summary>
        /// Managing sender domains. Creating new entries and validating domain records.
        /// </summary>
        public static class Domain
        {
            /// <summary>
            /// Add new domain to account
            /// </summary>
            /// <param name="apikey">ApiKey that gives you access to our SMTP and HTTP API's.</param>
            /// <param name="domain">Name of selected domain.</param>
            /// <param name="trackingType"></param>
            public static void Add(string domain, TrackingType trackingType = TrackingType.Http)
            {
                WebClient client = new CustomWebClient();
                NameValueCollection values = new NameValueCollection();
                values.Add("apikey", Api.ApiKey);
                values.Add("domain", domain);
                if (trackingType != TrackingType.Http) values.Add("trackingType", trackingType.ToString());
                byte[] apiResponse = client.UploadValues(Api.ApiUri + "/domain/add", values);
                ApiResponse<VoidApiResponse> apiRet = Newtonsoft.Json.JsonConvert.DeserializeObject<ApiResponse<VoidApiResponse>>(Encoding.UTF8.GetString(apiResponse));
                if (!apiRet.success) throw new ApplicationException(apiRet.error);
            }

            /// <summary>
            /// Deletes configured domain from account
            /// </summary>
            /// <param name="apikey">ApiKey that gives you access to our SMTP and HTTP API's.</param>
            /// <param name="domain">Name of selected domain.</param>
            public static void Delete(string domain)
            {
                WebClient client = new CustomWebClient();
                NameValueCollection values = new NameValueCollection();
                values.Add("apikey", Api.ApiKey);
                values.Add("domain", domain);
                byte[] apiResponse = client.UploadValues(Api.ApiUri + "/domain/delete", values);
                ApiResponse<VoidApiResponse> apiRet = Newtonsoft.Json.JsonConvert.DeserializeObject<ApiResponse<VoidApiResponse>>(Encoding.UTF8.GetString(apiResponse));
                if (!apiRet.success) throw new ApplicationException(apiRet.error);
            }

            /// <summary>
            /// Lists all domains configured for this account.
            /// </summary>
            /// <param name="apikey">ApiKey that gives you access to our SMTP and HTTP API's.</param>
            /// <returns>List(DomainDetail)</returns>
            public static List<DomainDetail> List()
            {
                WebClient client = new CustomWebClient();
                NameValueCollection values = new NameValueCollection();
                values.Add("apikey", Api.ApiKey);
                byte[] apiResponse = client.UploadValues(Api.ApiUri + "/domain/list", values);
                ApiResponse<List<DomainDetail>> apiRet = Newtonsoft.Json.JsonConvert.DeserializeObject<ApiResponse<List<DomainDetail>>>(Encoding.UTF8.GetString(apiResponse));
                if (!apiRet.success) throw new ApplicationException(apiRet.error);
                return apiRet.Data;
            }

            /// <summary>
            /// Verification of email addres set for domain.
            /// </summary>
            /// <param name="apikey">ApiKey that gives you access to our SMTP and HTTP API's.</param>
            /// <param name="domain">Default email sender, example: mail@yourdomain.com</param>
            public static void SetDefault(string domain)
            {
                WebClient client = new CustomWebClient();
                NameValueCollection values = new NameValueCollection();
                values.Add("apikey", Api.ApiKey);
                values.Add("domain", domain);
                byte[] apiResponse = client.UploadValues(Api.ApiUri + "/domain/setdefault", values);
                ApiResponse<VoidApiResponse> apiRet = Newtonsoft.Json.JsonConvert.DeserializeObject<ApiResponse<VoidApiResponse>>(Encoding.UTF8.GetString(apiResponse));
                if (!apiRet.success) throw new ApplicationException(apiRet.error);
            }

            /// <summary>
            /// Verification of DKIM record for domain
            /// </summary>
            /// <param name="apikey">ApiKey that gives you access to our SMTP and HTTP API's.</param>
            /// <param name="domain">Name of selected domain.</param>
            /// <returns>string</returns>
            public static string VerifyDkim(string domain)
            {
                WebClient client = new CustomWebClient();
                NameValueCollection values = new NameValueCollection();
                values.Add("apikey", Api.ApiKey);
                values.Add("domain", domain);
                byte[] apiResponse = client.UploadValues(Api.ApiUri + "/domain/verifydkim", values);
                ApiResponse<string> apiRet = Newtonsoft.Json.JsonConvert.DeserializeObject<ApiResponse<string>>(Encoding.UTF8.GetString(apiResponse));
                if (!apiRet.success) throw new ApplicationException(apiRet.error);
                return apiRet.Data;
            }

            /// <summary>
            /// Verification of MX record for domain
            /// </summary>
            /// <param name="apikey">ApiKey that gives you access to our SMTP and HTTP API's.</param>
            /// <param name="domain">Name of selected domain.</param>
            /// <returns>string</returns>
            public static string VerifyMX(string domain)
            {
                WebClient client = new CustomWebClient();
                NameValueCollection values = new NameValueCollection();
                values.Add("apikey", Api.ApiKey);
                values.Add("domain", domain);
                byte[] apiResponse = client.UploadValues(Api.ApiUri + "/domain/verifymx", values);
                ApiResponse<string> apiRet = Newtonsoft.Json.JsonConvert.DeserializeObject<ApiResponse<string>>(Encoding.UTF8.GetString(apiResponse));
                if (!apiRet.success) throw new ApplicationException(apiRet.error);
                return apiRet.Data;
            }

            /// <summary>
            /// Verification of SPF record for domain
            /// </summary>
            /// <param name="apikey">ApiKey that gives you access to our SMTP and HTTP API's.</param>
            /// <param name="domain">Name of selected domain.</param>
            /// <returns>string</returns>
            public static string VerifySpf(string domain)
            {
                WebClient client = new CustomWebClient();
                NameValueCollection values = new NameValueCollection();
                values.Add("apikey", Api.ApiKey);
                values.Add("domain", domain);
                byte[] apiResponse = client.UploadValues(Api.ApiUri + "/domain/verifyspf", values);
                ApiResponse<string> apiRet = Newtonsoft.Json.JsonConvert.DeserializeObject<ApiResponse<string>>(Encoding.UTF8.GetString(apiResponse));
                if (!apiRet.success) throw new ApplicationException(apiRet.error);
                return apiRet.Data;
            }

            /// <summary>
            /// Verification of tracking CNAME record for domain
            /// </summary>
            /// <param name="apikey">ApiKey that gives you access to our SMTP and HTTP API's.</param>
            /// <param name="domain">Name of selected domain.</param>
            /// <param name="trackingType"></param>
            /// <returns>string</returns>
            public static string VerifyTracking(string domain, TrackingType trackingType = TrackingType.Http)
            {
                WebClient client = new CustomWebClient();
                NameValueCollection values = new NameValueCollection();
                values.Add("apikey", Api.ApiKey);
                values.Add("domain", domain);
                if (trackingType != TrackingType.Http) values.Add("trackingType", trackingType.ToString());
                byte[] apiResponse = client.UploadValues(Api.ApiUri + "/domain/verifytracking", values);
                ApiResponse<string> apiRet = Newtonsoft.Json.JsonConvert.DeserializeObject<ApiResponse<string>>(Encoding.UTF8.GetString(apiResponse));
                if (!apiRet.success) throw new ApplicationException(apiRet.error);
                return apiRet.Data;
            }

        }
        #endregion


        #region Email functions
        /// <summary>
        /// 
        /// </summary>
        public static class Email
        {
            /// <summary>
            /// Get email batch status
            /// </summary>
            /// <param name="apikey">ApiKey that gives you access to our SMTP and HTTP API's.</param>
            /// <param name="transactionID">Transaction identifier</param>
            /// <param name="showFailed">Include Bounced email addresses.</param>
            /// <param name="showSent">Include Sent email addresses.</param>
            /// <param name="showDelivered">Include all delivered email addresses.</param>
            /// <param name="showPending">Include Ready to send email addresses.</param>
            /// <param name="showOpened">Include Opened email addresses.</param>
            /// <param name="showClicked">Include Clicked email addresses.</param>
            /// <param name="showAbuse">Include Reported as abuse email addresses.</param>
            /// <param name="showUnsubscribed">Include Unsubscribed email addresses.</param>
            /// <param name="showErrors">Include error messages for bounced emails.</param>
            /// <param name="showMessageIDs">Include all MessageIDs for this transaction</param>
            /// <returns>EmailJobStatus</returns>
            public static EmailJobStatus GetStatus(string transactionID, bool showFailed = false, bool showSent = false, bool showDelivered = false, bool showPending = false, bool showOpened = false, bool showClicked = false, bool showAbuse = false, bool showUnsubscribed = false, bool showErrors = false, bool showMessageIDs = false)
            {
                WebClient client = new CustomWebClient();
                NameValueCollection values = new NameValueCollection();
                values.Add("apikey", Api.ApiKey);
                values.Add("transactionID", transactionID);
                if (showFailed != false) values.Add("showFailed", showFailed.ToString());
                if (showSent != false) values.Add("showSent", showSent.ToString());
                if (showDelivered != false) values.Add("showDelivered", showDelivered.ToString());
                if (showPending != false) values.Add("showPending", showPending.ToString());
                if (showOpened != false) values.Add("showOpened", showOpened.ToString());
                if (showClicked != false) values.Add("showClicked", showClicked.ToString());
                if (showAbuse != false) values.Add("showAbuse", showAbuse.ToString());
                if (showUnsubscribed != false) values.Add("showUnsubscribed", showUnsubscribed.ToString());
                if (showErrors != false) values.Add("showErrors", showErrors.ToString());
                if (showMessageIDs != false) values.Add("showMessageIDs", showMessageIDs.ToString());
                byte[] apiResponse = client.UploadValues(Api.ApiUri + "/email/getstatus", values);
                ApiResponse<EmailJobStatus> apiRet = Newtonsoft.Json.JsonConvert.DeserializeObject<ApiResponse<EmailJobStatus>>(Encoding.UTF8.GetString(apiResponse));
                if (!apiRet.success) throw new ApplicationException(apiRet.error);
                return apiRet.Data;
            }

            /// <summary>
            /// Submit emails. The HTTP POST request is suggested. The default, maximum (accepted by us) size of an email is 10 MB in total, with or without attachments included. For suggested implementations please refer to https://elasticemail.com/support/http-api/
            /// </summary>
            /// <param name="apikey">ApiKey that gives you access to our SMTP and HTTP API's.</param>
            /// <param name="subject">Email subject</param>
            /// <param name="from">From email address</param>
            /// <param name="fromName">Display name for from email address</param>
            /// <param name="sender">Email address of the sender</param>
            /// <param name="senderName">Display name sender</param>
            /// <param name="msgFrom">Optional parameter. Sets FROM MIME header.</param>
            /// <param name="msgFromName">Optional parameter. Sets FROM name of MIME header.</param>
            /// <param name="replyTo">Email address to reply to</param>
            /// <param name="replyToName">Display name of the reply to address</param>
            /// <param name="to">List of email recipients (each email is treated separately, like a BCC). Separated by comma or semicolon. We suggest using the "msgTo" parameter if backward compatibility with API version 1 is not a must.</param>
            /// <param name="msgTo">Optional parameter. Will be ignored if the 'to' parameter is also provided. List of email recipients (visible to all other recipients of the message as TO MIME header). Separated by comma or semicolon.</param>
            /// <param name="msgCC">Optional parameter. Will be ignored if the 'to' parameter is also provided. List of email recipients (visible to all other recipients of the message as CC MIME header). Separated by comma or semicolon.</param>
            /// <param name="msgBcc">Optional parameter. Will be ignored if the 'to' parameter is also provided. List of email recipients (each email is treated seperately). Separated by comma or semicolon.</param>
            /// <param name="lists">The name of a contact list you would like to send to. Separate multiple contact lists by commas or semicolons.</param>
            /// <param name="segments">The name of a segment you would like to send to. Separate multiple segments by comma or semicolon. Insert "0" for all Active contacts.</param>
            /// <param name="mergeSourceFilename">File name one of attachments which is a CSV list of Recipients.</param>
            /// <param name="dataSource">Name or ID of the previously uploaded file which should be a CSV list of Recipients.</param>
            /// <param name="channel">An ID field (max 191 chars) that can be used for reporting [will default to HTTP API or SMTP API]</param>
            /// <param name="bodyHtml">Html email body</param>
            /// <param name="bodyText">Text email body</param>
            /// <param name="charset">Text value of charset encoding for example: iso-8859-1, windows-1251, utf-8, us-ascii, windows-1250 and more…</param>
            /// <param name="charsetBodyHtml">Sets charset for body html MIME part (overrides default value from charset parameter)</param>
            /// <param name="charsetBodyText">Sets charset for body text MIME part (overrides default value from charset parameter)</param>
            /// <param name="encodingType">0 for None, 1 for Raw7Bit, 2 for Raw8Bit, 3 for QuotedPrintable, 4 for Base64 (Default), 5 for Uue  note that you can also provide the text version such as "Raw7Bit" for value 1.  NOTE: Base64 or QuotedPrintable is recommended if you are validating your domain(s) with DKIM.</param>
            /// <param name="template">The ID of an email template you have created in your account.</param>
            /// <param name="attachmentFiles">Attachment files. These files should be provided with the POST multipart file upload, not directly in the request's URL. Can also include merge CSV file</param>
            /// <param name="headers">Optional Custom Headers. Request parameters prefixed by headers_ like headers_customheader1, headers_customheader2. Note: a space is required after the colon before the custom header value. headers_xmailer=xmailer: header-value1</param>
            /// <param name="postBack">Optional header returned in notifications.</param>
            /// <param name="merge">Request parameters prefixed by merge_ like merge_firstname, merge_lastname. If sending to a template you can send merge_ fields to merge data with the template. Template fields are entered with {firstname}, {lastname} etc.</param>
            /// <param name="timeOffSetMinutes">Number of minutes in the future this email should be sent up to a maximum of 1 year (524160 minutes)</param>
            /// <param name="poolName">Name of your custom IP Pool to be used in the sending process</param>
            /// <param name="isTransactional">True, if email is transactional (non-bulk, non-marketing, non-commercial). Otherwise, false</param>
            /// <param name="attachments">Names or IDs of attachments previously uploaded to your account that should be sent with this e-mail.</param>
            /// <param name="trackOpens">Should the opens be tracked? If no value has been provided, account's default setting will be used.</param>
            /// <param name="trackClicks">Should the clicks be tracked? If no value has been provided, account's default setting will be used.</param>
            /// <returns>EmailSend</returns>
            public static EmailSend Send(string subject = null, string from = null, string fromName = null, string sender = null, string senderName = null, string msgFrom = null, string msgFromName = null, string replyTo = null, string replyToName = null, IEnumerable<string> to = null, IEnumerable<string> msgTo = null, IEnumerable<string> msgCC = null, IEnumerable<string> msgBcc = null, IEnumerable<string> lists = null, IEnumerable<string> segments = null, string mergeSourceFilename = null, string dataSource = null, string channel = null, string bodyHtml = null, string bodyText = null, string charset = null, string charsetBodyHtml = null, string charsetBodyText = null, EncodingType encodingType = EncodingType.None, string template = null, IEnumerable<FileData> attachmentFiles = null, Dictionary<string, string> headers = null, string postBack = null, Dictionary<string, string> merge = null, string timeOffSetMinutes = null, string poolName = null, bool isTransactional = false, IEnumerable<string> attachments = null, bool? trackOpens = null, bool? trackClicks = null)
            {
                NameValueCollection values = new NameValueCollection();
                values.Add("apikey", Api.ApiKey);
                if (subject != null) values.Add("subject", subject);
                if (from != null) values.Add("from", from);
                if (fromName != null) values.Add("fromName", fromName);
                if (sender != null) values.Add("sender", sender);
                if (senderName != null) values.Add("senderName", senderName);
                if (msgFrom != null) values.Add("msgFrom", msgFrom);
                if (msgFromName != null) values.Add("msgFromName", msgFromName);
                if (replyTo != null) values.Add("replyTo", replyTo);
                if (replyToName != null) values.Add("replyToName", replyToName);
                if (to != null) values.Add("to", string.Join(",", to));
                if (msgTo != null) values.Add("msgTo", string.Join(",", msgTo));
                if (msgCC != null) values.Add("msgCC", string.Join(",", msgCC));
                if (msgBcc != null) values.Add("msgBcc", string.Join(",", msgBcc));
                if (lists != null) values.Add("lists", string.Join(",", lists));
                if (segments != null) values.Add("segments", string.Join(",", segments));
                if (mergeSourceFilename != null) values.Add("mergeSourceFilename", mergeSourceFilename);
                if (dataSource != null) values.Add("dataSource", dataSource);
                if (channel != null) values.Add("channel", channel);
                if (bodyHtml != null) values.Add("bodyHtml", bodyHtml);
                if (bodyText != null) values.Add("bodyText", bodyText);
                if (charset != null) values.Add("charset", charset);
                if (charsetBodyHtml != null) values.Add("charsetBodyHtml", charsetBodyHtml);
                if (charsetBodyText != null) values.Add("charsetBodyText", charsetBodyText);
                if (encodingType != EncodingType.None) values.Add("encodingType", encodingType.ToString());
                if (template != null) values.Add("template", template);
                if (headers != null)
                {
                    foreach (KeyValuePair<string, string> _item in headers)
                    {
                        values.Add("headers_" + _item.Key, _item.Value);
                    }
                }
                if (postBack != null) values.Add("postBack", postBack);
                if (merge != null)
                {
                    foreach (KeyValuePair<string, string> _item in merge)
                    {
                        values.Add("merge_" + _item.Key, _item.Value);
                    }
                }
                if (timeOffSetMinutes != null) values.Add("timeOffSetMinutes", timeOffSetMinutes);
                if (poolName != null) values.Add("poolName", poolName);
                if (isTransactional != false) values.Add("isTransactional", isTransactional.ToString());
                if (attachments != null) values.Add("attachments", string.Join(",", attachments));
                if (trackOpens != null) values.Add("trackOpens", trackOpens.ToString());
                if (trackClicks != null) values.Add("trackClicks", trackClicks.ToString());
                byte[] apiResponse = ApiUtilities.HttpPostFile(Api.ApiUri + "/email/send", attachmentFiles == null ? null : attachmentFiles.ToList(), values);
                ApiResponse<EmailSend> apiRet = Newtonsoft.Json.JsonConvert.DeserializeObject<ApiResponse<EmailSend>>(Encoding.UTF8.GetString(apiResponse));
                if (!apiRet.success) throw new ApplicationException(apiRet.error);
                return apiRet.Data;
            }

            /// <summary>
            /// Detailed status of a unique email sent through your account. Returns a 'Email has expired and the status is unknown.' error, if the email has not been fully processed yet.
            /// </summary>
            /// <param name="apikey">ApiKey that gives you access to our SMTP and HTTP API's.</param>
            /// <param name="messageID">Unique identifier for this email.</param>
            /// <returns>EmailStatus</returns>
            public static EmailStatus Status(string messageID)
            {
                WebClient client = new CustomWebClient();
                NameValueCollection values = new NameValueCollection();
                values.Add("apikey", Api.ApiKey);
                values.Add("messageID", messageID);
                byte[] apiResponse = client.UploadValues(Api.ApiUri + "/email/status", values);
                ApiResponse<EmailStatus> apiRet = Newtonsoft.Json.JsonConvert.DeserializeObject<ApiResponse<EmailStatus>>(Encoding.UTF8.GetString(apiResponse));
                if (!apiRet.success) throw new ApplicationException(apiRet.error);
                return apiRet.Data;
            }

            /// <summary>
            /// View email
            /// </summary>
            /// <param name="messageID">Message identifier</param>
            /// <returns>EmailView</returns>
            public static EmailView View(string messageID)
            {
                WebClient client = new CustomWebClient();
                NameValueCollection values = new NameValueCollection();
                values.Add("apikey", Api.ApiKey);
                values.Add("messageID", messageID);
                byte[] apiResponse = client.UploadValues(Api.ApiUri + "/email/view", values);
                ApiResponse<EmailView> apiRet = Newtonsoft.Json.JsonConvert.DeserializeObject<ApiResponse<EmailView>>(Encoding.UTF8.GetString(apiResponse));
                if (!apiRet.success) throw new ApplicationException(apiRet.error);
                return apiRet.Data;
            }

        }
        #endregion


        #region Export functions
        /// <summary>
        /// 
        /// </summary>
        public static class Export
        {
            /// <summary>
            /// Check the current status of the export.
            /// </summary>
            /// <param name="apikey">ApiKey that gives you access to our SMTP and HTTP API's.</param>
            /// <param name="publicExportID"></param>
            /// <returns>ExportStatus</returns>
            public static ExportStatus CheckStatus(Guid publicExportID)
            {
                WebClient client = new CustomWebClient();
                NameValueCollection values = new NameValueCollection();
                values.Add("apikey", Api.ApiKey);
                values.Add("publicExportID", publicExportID.ToString());
                byte[] apiResponse = client.UploadValues(Api.ApiUri + "/export/checkstatus", values);
                ApiResponse<ExportStatus> apiRet = Newtonsoft.Json.JsonConvert.DeserializeObject<ApiResponse<ExportStatus>>(Encoding.UTF8.GetString(apiResponse));
                if (!apiRet.success) throw new ApplicationException(apiRet.error);
                return apiRet.Data;
            }

            /// <summary>
            /// Summary of export type counts.
            /// </summary>
            /// <param name="apikey">ApiKey that gives you access to our SMTP and HTTP API's.</param>
            /// <returns>ExportTypeCounts</returns>
            public static ExportTypeCounts CountByType()
            {
                WebClient client = new CustomWebClient();
                NameValueCollection values = new NameValueCollection();
                values.Add("apikey", Api.ApiKey);
                byte[] apiResponse = client.UploadValues(Api.ApiUri + "/export/countbytype", values);
                ApiResponse<ExportTypeCounts> apiRet = Newtonsoft.Json.JsonConvert.DeserializeObject<ApiResponse<ExportTypeCounts>>(Encoding.UTF8.GetString(apiResponse));
                if (!apiRet.success) throw new ApplicationException(apiRet.error);
                return apiRet.Data;
            }

            /// <summary>
            /// Delete the specified export.
            /// </summary>
            /// <param name="apikey">ApiKey that gives you access to our SMTP and HTTP API's.</param>
            /// <param name="publicExportID"></param>
            public static void Delete(Guid publicExportID)
            {
                WebClient client = new CustomWebClient();
                NameValueCollection values = new NameValueCollection();
                values.Add("apikey", Api.ApiKey);
                values.Add("publicExportID", publicExportID.ToString());
                byte[] apiResponse = client.UploadValues(Api.ApiUri + "/export/delete", values);
                ApiResponse<VoidApiResponse> apiRet = Newtonsoft.Json.JsonConvert.DeserializeObject<ApiResponse<VoidApiResponse>>(Encoding.UTF8.GetString(apiResponse));
                if (!apiRet.success) throw new ApplicationException(apiRet.error);
            }

            /// <summary>
            /// Returns a list of all exported data.
            /// </summary>
            /// <param name="apikey">ApiKey that gives you access to our SMTP and HTTP API's.</param>
            /// <param name="limit">Maximum of loaded items.</param>
            /// <param name="offset">How many items should be loaded ahead.</param>
            /// <returns>List(Export)</returns>
            public static List<ApiTypes.Export> List(int limit = 0, int offset = 0)
            {
                WebClient client = new CustomWebClient();
                NameValueCollection values = new NameValueCollection();
                values.Add("apikey", Api.ApiKey);
                if (limit != 0) values.Add("limit", limit.ToString());
                if (offset != 0) values.Add("offset", offset.ToString());
                byte[] apiResponse = client.UploadValues(Api.ApiUri + "/export/list", values);
                ApiResponse<List<ApiTypes.Export>> apiRet = Newtonsoft.Json.JsonConvert.DeserializeObject<ApiResponse<List<ApiTypes.Export>>>(Encoding.UTF8.GetString(apiResponse));
                if (!apiRet.success) throw new ApplicationException(apiRet.error);
                return apiRet.Data;
            }

        }
        #endregion


        #region File functions
        /// <summary>
        /// Manage the files on your account
        /// </summary>
        public static class File
        {
            /// <summary>
            /// Permanently deletes the file from your account
            /// </summary>
            /// <param name="apikey">ApiKey that gives you access to our SMTP and HTTP API's.</param>
            /// <param name="fileID"></param>
            /// <param name="filename">Name of your file.</param>
            public static void Delete(int? fileID = null, string filename = null)
            {
                WebClient client = new CustomWebClient();
                NameValueCollection values = new NameValueCollection();
                values.Add("apikey", Api.ApiKey);
                if (fileID != null) values.Add("fileID", fileID.ToString());
                if (filename != null) values.Add("filename", filename);
                byte[] apiResponse = client.UploadValues(Api.ApiUri + "/file/delete", values);
                ApiResponse<VoidApiResponse> apiRet = Newtonsoft.Json.JsonConvert.DeserializeObject<ApiResponse<VoidApiResponse>>(Encoding.UTF8.GetString(apiResponse));
                if (!apiRet.success) throw new ApplicationException(apiRet.error);
            }

            /// <summary>
            /// Gets content of the chosen File
            /// </summary>
            /// <param name="apikey">ApiKey that gives you access to our SMTP and HTTP API's.</param>
            /// <param name="filename">Name of your file.</param>
            /// <param name="fileID"></param>
            /// <returns>FileData</returns>
            public static ApiTypes.FileData Download(string filename = null, int? fileID = null)
            {
                NameValueCollection values = new NameValueCollection();
                values.Add("apikey", Api.ApiKey);
                if (filename != null) values.Add("filename", filename);
                if (fileID != null) values.Add("fileID", fileID.ToString());
                return ApiUtilities.HttpGetFile(Api.ApiUri + "/file/download", values);
            }

            /// <summary>
            /// Lists your available Attachments in the given email
            /// </summary>
            /// <param name="apikey">ApiKey that gives you access to our SMTP and HTTP API's.</param>
            /// <param name="msgID">ID number of selected message.</param>
            /// <returns>List(File)</returns>
            public static List<ApiTypes.File> List(string msgID)
            {
                WebClient client = new CustomWebClient();
                NameValueCollection values = new NameValueCollection();
                values.Add("apikey", Api.ApiKey);
                values.Add("msgID", msgID);
                byte[] apiResponse = client.UploadValues(Api.ApiUri + "/file/list", values);
                ApiResponse<List<ApiTypes.File>> apiRet = Newtonsoft.Json.JsonConvert.DeserializeObject<ApiResponse<List<ApiTypes.File>>>(Encoding.UTF8.GetString(apiResponse));
                if (!apiRet.success) throw new ApplicationException(apiRet.error);
                return apiRet.Data;
            }

            /// <summary>
            /// Lists all your available files
            /// </summary>
            /// <param name="apikey">ApiKey that gives you access to our SMTP and HTTP API's.</param>
            /// <returns>List(File)</returns>
            public static List<ApiTypes.File> ListAll()
            {
                WebClient client = new CustomWebClient();
                NameValueCollection values = new NameValueCollection();
                values.Add("apikey", Api.ApiKey);
                byte[] apiResponse = client.UploadValues(Api.ApiUri + "/file/listall", values);
                ApiResponse<List<ApiTypes.File>> apiRet = Newtonsoft.Json.JsonConvert.DeserializeObject<ApiResponse<List<ApiTypes.File>>>(Encoding.UTF8.GetString(apiResponse));
                if (!apiRet.success) throw new ApplicationException(apiRet.error);
                return apiRet.Data;
            }

            /// <summary>
            /// Gets chosen File
            /// </summary>
            /// <param name="apikey">ApiKey that gives you access to our SMTP and HTTP API's.</param>
            /// <param name="filename">Name of your file.</param>
            /// <returns>File</returns>
            public static ApiTypes.File Load(string filename)
            {
                WebClient client = new CustomWebClient();
                NameValueCollection values = new NameValueCollection();
                values.Add("apikey", Api.ApiKey);
                values.Add("filename", filename);
                byte[] apiResponse = client.UploadValues(Api.ApiUri + "/file/load", values);
                ApiResponse<ApiTypes.File> apiRet = Newtonsoft.Json.JsonConvert.DeserializeObject<ApiResponse<ApiTypes.File>>(Encoding.UTF8.GetString(apiResponse));
                if (!apiRet.success) throw new ApplicationException(apiRet.error);
                return apiRet.Data;
            }

            /// <summary>
            /// Uploads selected file to the server using http form upload format (MIME multipart/form-data) or PUT method.
            /// </summary>
            /// <param name="apikey">ApiKey that gives you access to our SMTP and HTTP API's.</param>
            /// <param name="file"></param>
            /// <param name="name">Filename</param>
            /// <param name="expiresAfterDays">After how many days should the file be deleted.</param>
            /// <returns>File</returns>
            public static ApiTypes.File Upload(FileData file, string name = null, int? expiresAfterDays = 35)
            {
                NameValueCollection values = new NameValueCollection();
                values.Add("apikey", Api.ApiKey);
                if (name != null) values.Add("name", name);
                if (expiresAfterDays != 35) values.Add("expiresAfterDays", expiresAfterDays.ToString());
                byte[] apiResponse = ApiUtilities.HttpPostFile(Api.ApiUri + "/file/upload", new List<FileData>() { file }, values);
                ApiResponse<ApiTypes.File> apiRet = Newtonsoft.Json.JsonConvert.DeserializeObject<ApiResponse<ApiTypes.File>>(Encoding.UTF8.GetString(apiResponse));
                if (!apiRet.success) throw new ApplicationException(apiRet.error);
                return apiRet.Data;
            }

        }
        #endregion


        #region List functions
        /// <summary>
        /// API methods for managing your Lists
        /// </summary>
        public static class List
        {
            /// <summary>
            /// Create new list, based on filtering rule or list of IDs
            /// </summary>
            /// <param name="apikey">ApiKey that gives you access to our SMTP and HTTP API's.</param>
            /// <param name="listName">Name of your list.</param>
            /// <param name="createEmptyList">True to create an empty list, otherwise false. Ignores rule and emails parameters if provided.</param>
            /// <param name="allowUnsubscribe">True: Allow unsubscribing from this list. Otherwise, false</param>
            /// <param name="rule">Query used for filtering.</param>
            /// <param name="emails">Comma delimited list of contact emails</param>
            /// <param name="allContacts">True: Include every Contact in your Account. Otherwise, false</param>
            /// <returns>int</returns>
            public static int Add(string listName, bool createEmptyList = false, bool allowUnsubscribe = false, string rule = null, IEnumerable<string> emails = null, bool allContacts = false)
            {
                WebClient client = new CustomWebClient();
                NameValueCollection values = new NameValueCollection();
                values.Add("apikey", Api.ApiKey);
                values.Add("listName", listName);
                if (createEmptyList != false) values.Add("createEmptyList", createEmptyList.ToString());
                if (allowUnsubscribe != false) values.Add("allowUnsubscribe", allowUnsubscribe.ToString());
                if (rule != null) values.Add("rule", rule);
                if (emails != null) values.Add("emails", string.Join(",", emails));
                if (allContacts != false) values.Add("allContacts", allContacts.ToString());
                byte[] apiResponse = client.UploadValues(Api.ApiUri + "/list/add", values);
                ApiResponse<int> apiRet = Newtonsoft.Json.JsonConvert.DeserializeObject<ApiResponse<int>>(Encoding.UTF8.GetString(apiResponse));
                if (!apiRet.success) throw new ApplicationException(apiRet.error);
                return apiRet.Data;
            }

            /// <summary>
            /// Add existing Contacts to chosen list
            /// </summary>
            /// <param name="apikey">ApiKey that gives you access to our SMTP and HTTP API's.</param>
            /// <param name="listName">Name of your list.</param>
            /// <param name="rule">Query used for filtering.</param>
            /// <param name="emails">Comma delimited list of contact emails</param>
            /// <param name="allContacts">True: Include every Contact in your Account. Otherwise, false</param>
            public static void AddContacts(string listName, string rule = null, IEnumerable<string> emails = null, bool allContacts = false)
            {
                WebClient client = new CustomWebClient();
                NameValueCollection values = new NameValueCollection();
                values.Add("apikey", Api.ApiKey);
                values.Add("listName", listName);
                if (rule != null) values.Add("rule", rule);
                if (emails != null) values.Add("emails", string.Join(",", emails));
                if (allContacts != false) values.Add("allContacts", allContacts.ToString());
                byte[] apiResponse = client.UploadValues(Api.ApiUri + "/list/addcontacts", values);
                ApiResponse<VoidApiResponse> apiRet = Newtonsoft.Json.JsonConvert.DeserializeObject<ApiResponse<VoidApiResponse>>(Encoding.UTF8.GetString(apiResponse));
                if (!apiRet.success) throw new ApplicationException(apiRet.error);
            }

            /// <summary>
            /// Copy your existing List with the option to provide new settings to it. Some fields, when left empty, default to the source list's settings
            /// </summary>
            /// <param name="apikey">ApiKey that gives you access to our SMTP and HTTP API's.</param>
            /// <param name="sourceListName">The name of the list you want to copy</param>
            /// <param name="newlistName">Name of your list if you want to change it.</param>
            /// <param name="createEmptyList">True to create an empty list, otherwise false. Ignores rule and emails parameters if provided.</param>
            /// <param name="allowUnsubscribe">True: Allow unsubscribing from this list. Otherwise, false</param>
            /// <param name="rule">Query used for filtering.</param>
            /// <returns>int</returns>
            public static int Copy(string sourceListName, string newlistName = null, bool? createEmptyList = null, bool? allowUnsubscribe = null, string rule = null)
            {
                WebClient client = new CustomWebClient();
                NameValueCollection values = new NameValueCollection();
                values.Add("apikey", Api.ApiKey);
                values.Add("sourceListName", sourceListName);
                if (newlistName != null) values.Add("newlistName", newlistName);
                if (createEmptyList != null) values.Add("createEmptyList", createEmptyList.ToString());
                if (allowUnsubscribe != null) values.Add("allowUnsubscribe", allowUnsubscribe.ToString());
                if (rule != null) values.Add("rule", rule);
                byte[] apiResponse = client.UploadValues(Api.ApiUri + "/list/copy", values);
                ApiResponse<int> apiRet = Newtonsoft.Json.JsonConvert.DeserializeObject<ApiResponse<int>>(Encoding.UTF8.GetString(apiResponse));
                if (!apiRet.success) throw new ApplicationException(apiRet.error);
                return apiRet.Data;
            }

            /// <summary>
            /// Create a new list from the recipients of the given campaign, using the given statuses of Messages
            /// </summary>
            /// <param name="apikey">ApiKey that gives you access to our SMTP and HTTP API's.</param>
            /// <param name="campaignID">ID of the campaign which recipients you want to copy</param>
            /// <param name="listName">Name of your list.</param>
            /// <param name="statuses">Statuses of a campaign's emails you want to include in the new list (but NOT the contacts' statuses)</param>
            /// <returns>int</returns>
            public static int CreateFromCampaign(int campaignID, string listName, IEnumerable<LogJobStatus> statuses = null)
            {
                WebClient client = new CustomWebClient();
                NameValueCollection values = new NameValueCollection();
                values.Add("apikey", Api.ApiKey);
                values.Add("campaignID", campaignID.ToString());
                values.Add("listName", listName);
                if (statuses != null) values.Add("statuses", string.Join(",", statuses));
                byte[] apiResponse = client.UploadValues(Api.ApiUri + "/list/createfromcampaign", values);
                ApiResponse<int> apiRet = Newtonsoft.Json.JsonConvert.DeserializeObject<ApiResponse<int>>(Encoding.UTF8.GetString(apiResponse));
                if (!apiRet.success) throw new ApplicationException(apiRet.error);
                return apiRet.Data;
            }

            /// <summary>
            /// Create a series of nth selection lists from an existing list or segment
            /// </summary>
            /// <param name="apikey">ApiKey that gives you access to our SMTP and HTTP API's.</param>
            /// <param name="listName">Name of your list.</param>
            /// <param name="numberOfLists">The number of evenly distributed lists to create.</param>
            /// <param name="excludeBlocked">True if you want to exclude contacts that are currently in a blocked status of either unsubscribe, complaint or bounce. Otherwise, false.</param>
            /// <param name="allowUnsubscribe">True: Allow unsubscribing from this list. Otherwise, false</param>
            /// <param name="rule">Query used for filtering.</param>
            /// <param name="allContacts">True: Include every Contact in your Account. Otherwise, false</param>
            public static void CreateNthSelectionLists(string listName, int numberOfLists, bool excludeBlocked = true, bool allowUnsubscribe = false, string rule = null, bool allContacts = false)
            {
                WebClient client = new CustomWebClient();
                NameValueCollection values = new NameValueCollection();
                values.Add("apikey", Api.ApiKey);
                values.Add("listName", listName);
                values.Add("numberOfLists", numberOfLists.ToString());
                if (excludeBlocked != true) values.Add("excludeBlocked", excludeBlocked.ToString());
                if (allowUnsubscribe != false) values.Add("allowUnsubscribe", allowUnsubscribe.ToString());
                if (rule != null) values.Add("rule", rule);
                if (allContacts != false) values.Add("allContacts", allContacts.ToString());
                byte[] apiResponse = client.UploadValues(Api.ApiUri + "/list/createnthselectionlists", values);
                ApiResponse<VoidApiResponse> apiRet = Newtonsoft.Json.JsonConvert.DeserializeObject<ApiResponse<VoidApiResponse>>(Encoding.UTF8.GetString(apiResponse));
                if (!apiRet.success) throw new ApplicationException(apiRet.error);
            }

            /// <summary>
            /// Create a new list with randomized contacts from an existing list or segment
            /// </summary>
            /// <param name="apikey">ApiKey that gives you access to our SMTP and HTTP API's.</param>
            /// <param name="listName">Name of your list.</param>
            /// <param name="count">Number of items.</param>
            /// <param name="excludeBlocked">True if you want to exclude contacts that are currently in a blocked status of either unsubscribe, complaint or bounce. Otherwise, false.</param>
            /// <param name="allowUnsubscribe">True: Allow unsubscribing from this list. Otherwise, false</param>
            /// <param name="rule">Query used for filtering.</param>
            /// <param name="allContacts">True: Include every Contact in your Account. Otherwise, false</param>
            /// <returns>int</returns>
            public static int CreateRandomList(string listName, int count, bool excludeBlocked = true, bool allowUnsubscribe = false, string rule = null, bool allContacts = false)
            {
                WebClient client = new CustomWebClient();
                NameValueCollection values = new NameValueCollection();
                values.Add("apikey", Api.ApiKey);
                values.Add("listName", listName);
                values.Add("count", count.ToString());
                if (excludeBlocked != true) values.Add("excludeBlocked", excludeBlocked.ToString());
                if (allowUnsubscribe != false) values.Add("allowUnsubscribe", allowUnsubscribe.ToString());
                if (rule != null) values.Add("rule", rule);
                if (allContacts != false) values.Add("allContacts", allContacts.ToString());
                byte[] apiResponse = client.UploadValues(Api.ApiUri + "/list/createrandomlist", values);
                ApiResponse<int> apiRet = Newtonsoft.Json.JsonConvert.DeserializeObject<ApiResponse<int>>(Encoding.UTF8.GetString(apiResponse));
                if (!apiRet.success) throw new ApplicationException(apiRet.error);
                return apiRet.Data;
            }

            /// <summary>
            /// Deletes List and removes all the Contacts from it (does not delete Contacts).
            /// </summary>
            /// <param name="apikey">ApiKey that gives you access to our SMTP and HTTP API's.</param>
            /// <param name="listName">Name of your list.</param>
            public static void Delete(string listName)
            {
                WebClient client = new CustomWebClient();
                NameValueCollection values = new NameValueCollection();
                values.Add("apikey", Api.ApiKey);
                values.Add("listName", listName);
                byte[] apiResponse = client.UploadValues(Api.ApiUri + "/list/delete", values);
                ApiResponse<VoidApiResponse> apiRet = Newtonsoft.Json.JsonConvert.DeserializeObject<ApiResponse<VoidApiResponse>>(Encoding.UTF8.GetString(apiResponse));
                if (!apiRet.success) throw new ApplicationException(apiRet.error);
            }

            /// <summary>
            /// Exports all the contacts from the provided list
            /// </summary>
            /// <param name="apikey">ApiKey that gives you access to our SMTP and HTTP API's.</param>
            /// <param name="listName">Name of your list.</param>
            /// <param name="fileFormat">Format of the exported file</param>
            /// <param name="compressionFormat">FileResponse compression format. None or Zip.</param>
            /// <param name="fileName">Name of your file.</param>
            /// <returns>ExportLink</returns>
            public static ExportLink Export(string listName, ExportFileFormats fileFormat = ExportFileFormats.Csv, CompressionFormat compressionFormat = CompressionFormat.None, string fileName = null)
            {
                WebClient client = new CustomWebClient();
                NameValueCollection values = new NameValueCollection();
                values.Add("apikey", Api.ApiKey);
                values.Add("listName", listName);
                if (fileFormat != ExportFileFormats.Csv) values.Add("fileFormat", fileFormat.ToString());
                if (compressionFormat != CompressionFormat.None) values.Add("compressionFormat", compressionFormat.ToString());
                if (fileName != null) values.Add("fileName", fileName);
                byte[] apiResponse = client.UploadValues(Api.ApiUri + "/list/export", values);
                ApiResponse<ExportLink> apiRet = Newtonsoft.Json.JsonConvert.DeserializeObject<ApiResponse<ExportLink>>(Encoding.UTF8.GetString(apiResponse));
                if (!apiRet.success) throw new ApplicationException(apiRet.error);
                return apiRet.Data;
            }

            /// <summary>
            /// Shows all your existing lists
            /// </summary>
            /// <param name="apikey">ApiKey that gives you access to our SMTP and HTTP API's.</param>
            /// <param name="from">Starting date for search in YYYY-MM-DDThh:mm:ss format.</param>
            /// <param name="to">Ending date for search in YYYY-MM-DDThh:mm:ss format.</param>
            /// <returns>List(List)</returns>
            public static List<ApiTypes.List> list(DateTime? from = null, DateTime? to = null)
            {
                WebClient client = new CustomWebClient();
                NameValueCollection values = new NameValueCollection();
                values.Add("apikey", Api.ApiKey);
                if (from != null) values.Add("from", from.Value.ToString("M/d/yyyy h:mm:ss tt"));
                if (to != null) values.Add("to", to.Value.ToString("M/d/yyyy h:mm:ss tt"));
                byte[] apiResponse = client.UploadValues(Api.ApiUri + "/list/list", values);
                ApiResponse<List<ApiTypes.List>> apiRet = Newtonsoft.Json.JsonConvert.DeserializeObject<ApiResponse<List<ApiTypes.List>>>(Encoding.UTF8.GetString(apiResponse));
                if (!apiRet.success) throw new ApplicationException(apiRet.error);
                return apiRet.Data;
            }

            /// <summary>
            /// Returns detailed information about specific list.
            /// </summary>
            /// <param name="apikey">ApiKey that gives you access to our SMTP and HTTP API's.</param>
            /// <param name="listName">Name of your list.</param>
            /// <returns>List</returns>
            public static ApiTypes.List Load(string listName)
            {
                WebClient client = new CustomWebClient();
                NameValueCollection values = new NameValueCollection();
                values.Add("apikey", Api.ApiKey);
                values.Add("listName", listName);
                byte[] apiResponse = client.UploadValues(Api.ApiUri + "/list/load", values);
                ApiResponse<ApiTypes.List> apiRet = Newtonsoft.Json.JsonConvert.DeserializeObject<ApiResponse<ApiTypes.List>>(Encoding.UTF8.GetString(apiResponse));
                if (!apiRet.success) throw new ApplicationException(apiRet.error);
                return apiRet.Data;
            }

            /// <summary>
            /// Move selected contacts from one List to another
            /// </summary>
            /// <param name="apikey">ApiKey that gives you access to our SMTP and HTTP API's.</param>
            /// <param name="oldListName">The name of the list from which the contacts will be copied from</param>
            /// <param name="newListName">The name of the list to copy the contacts to</param>
            /// <param name="emails">Comma delimited list of contact emails</param>
            /// <param name="moveAll">TRUE - moves all contacts; FALSE - moves contacts provided in the 'emails' parameter. This is ignored if the 'statuses' parameter has been provided</param>
            /// <param name="statuses">List of contact statuses which are eligible to move. This ignores the 'moveAll' parameter</param>
            /// <param name="rule">Query used for filtering.</param>
            public static void MoveContacts(string oldListName, string newListName, IEnumerable<string> emails = null, bool? moveAll = null, IEnumerable<ContactStatus> statuses = null, string rule = null)
            {
                WebClient client = new CustomWebClient();
                NameValueCollection values = new NameValueCollection();
                values.Add("apikey", Api.ApiKey);
                values.Add("oldListName", oldListName);
                values.Add("newListName", newListName);
                if (emails != null) values.Add("emails", string.Join(",", emails));
                if (moveAll != null) values.Add("moveAll", moveAll.ToString());
                if (statuses != null) values.Add("statuses", string.Join(",", statuses));
                if (rule != null) values.Add("rule", rule);
                byte[] apiResponse = client.UploadValues(Api.ApiUri + "/list/movecontacts", values);
                ApiResponse<VoidApiResponse> apiRet = Newtonsoft.Json.JsonConvert.DeserializeObject<ApiResponse<VoidApiResponse>>(Encoding.UTF8.GetString(apiResponse));
                if (!apiRet.success) throw new ApplicationException(apiRet.error);
            }

            /// <summary>
            /// Remove selected Contacts from your list
            /// </summary>
            /// <param name="apikey">ApiKey that gives you access to our SMTP and HTTP API's.</param>
            /// <param name="listName">Name of your list.</param>
            /// <param name="rule">Query used for filtering.</param>
            /// <param name="emails">Comma delimited list of contact emails</param>
            public static void RemoveContacts(string listName, string rule = null, IEnumerable<string> emails = null)
            {
                WebClient client = new CustomWebClient();
                NameValueCollection values = new NameValueCollection();
                values.Add("apikey", Api.ApiKey);
                values.Add("listName", listName);
                if (rule != null) values.Add("rule", rule);
                if (emails != null) values.Add("emails", string.Join(",", emails));
                byte[] apiResponse = client.UploadValues(Api.ApiUri + "/list/removecontacts", values);
                ApiResponse<VoidApiResponse> apiRet = Newtonsoft.Json.JsonConvert.DeserializeObject<ApiResponse<VoidApiResponse>>(Encoding.UTF8.GetString(apiResponse));
                if (!apiRet.success) throw new ApplicationException(apiRet.error);
            }

            /// <summary>
            /// Update existing list
            /// </summary>
            /// <param name="apikey">ApiKey that gives you access to our SMTP and HTTP API's.</param>
            /// <param name="listName">Name of your list.</param>
            /// <param name="newListName">Name of your list if you want to change it.</param>
            /// <param name="allowUnsubscribe">True: Allow unsubscribing from this list. Otherwise, false</param>
            public static void Update(string listName, string newListName = null, bool allowUnsubscribe = false)
            {
                WebClient client = new CustomWebClient();
                NameValueCollection values = new NameValueCollection();
                values.Add("apikey", Api.ApiKey);
                values.Add("listName", listName);
                if (newListName != null) values.Add("newListName", newListName);
                if (allowUnsubscribe != false) values.Add("allowUnsubscribe", allowUnsubscribe.ToString());
                byte[] apiResponse = client.UploadValues(Api.ApiUri + "/list/update", values);
                ApiResponse<VoidApiResponse> apiRet = Newtonsoft.Json.JsonConvert.DeserializeObject<ApiResponse<VoidApiResponse>>(Encoding.UTF8.GetString(apiResponse));
                if (!apiRet.success) throw new ApplicationException(apiRet.error);
            }

        }
        #endregion


        #region Log functions
        /// <summary>
        /// Methods to check logs of your campaigns
        /// </summary>
        public static class Log
        {
            /// <summary>
            /// Cancels emails that are waiting to be sent.
            /// </summary>
            /// <param name="apikey">ApiKey that gives you access to our SMTP and HTTP API's.</param>
            /// <param name="channelName">Name of selected channel.</param>
            /// <param name="transactionID">ID number of transaction</param>
            public static void CancelInProgress(string channelName = null, string transactionID = null)
            {
                WebClient client = new CustomWebClient();
                NameValueCollection values = new NameValueCollection();
                values.Add("apikey", Api.ApiKey);
                if (channelName != null) values.Add("channelName", channelName);
                if (transactionID != null) values.Add("transactionID", transactionID);
                byte[] apiResponse = client.UploadValues(Api.ApiUri + "/log/cancelinprogress", values);
                ApiResponse<VoidApiResponse> apiRet = Newtonsoft.Json.JsonConvert.DeserializeObject<ApiResponse<VoidApiResponse>>(Encoding.UTF8.GetString(apiResponse));
                if (!apiRet.success) throw new ApplicationException(apiRet.error);
            }

            /// <summary>
            /// Export email log information to the specified file format.
            /// </summary>
            /// <param name="apikey">ApiKey that gives you access to our SMTP and HTTP API's.</param>
            /// <param name="statuses">List of comma separated message statuses: 0 for all, 1 for ReadyToSend, 2 for InProgress, 4 for Bounced, 5 for Sent, 6 for Opened, 7 for Clicked, 8 for Unsubscribed, 9 for Abuse Report</param>
            /// <param name="fileFormat">Format of the exported file</param>
            /// <param name="from">Start date.</param>
            /// <param name="to">End date.</param>
            /// <param name="channelName">Name of selected channel.</param>
            /// <param name="includeEmail">True: Search includes emails. Otherwise, false.</param>
            /// <param name="includeSms">True: Search includes SMS. Otherwise, false.</param>
            /// <param name="messageCategory">ID of message category</param>
            /// <param name="compressionFormat">FileResponse compression format. None or Zip.</param>
            /// <param name="fileName">Name of your file.</param>
            /// <param name="email">Proper email address.</param>
            /// <returns>ExportLink</returns>
            public static ExportLink Export(IEnumerable<LogJobStatus> statuses, ExportFileFormats fileFormat = ExportFileFormats.Csv, DateTime? from = null, DateTime? to = null, string channelName = null, bool includeEmail = true, bool includeSms = true, IEnumerable<MessageCategory> messageCategory = null, CompressionFormat compressionFormat = CompressionFormat.None, string fileName = null, string email = null)
            {
                WebClient client = new CustomWebClient();
                NameValueCollection values = new NameValueCollection();
                values.Add("apikey", Api.ApiKey);
                values.Add("statuses", string.Join(",", statuses));
                if (fileFormat != ExportFileFormats.Csv) values.Add("fileFormat", fileFormat.ToString());
                if (from != null) values.Add("from", from.Value.ToString("M/d/yyyy h:mm:ss tt"));
                if (to != null) values.Add("to", to.Value.ToString("M/d/yyyy h:mm:ss tt"));
                if (channelName != null) values.Add("channelName", channelName);
                if (includeEmail != true) values.Add("includeEmail", includeEmail.ToString());
                if (includeSms != true) values.Add("includeSms", includeSms.ToString());
                if (messageCategory != null) values.Add("messageCategory", string.Join(",", messageCategory));
                if (compressionFormat != CompressionFormat.None) values.Add("compressionFormat", compressionFormat.ToString());
                if (fileName != null) values.Add("fileName", fileName);
                if (email != null) values.Add("email", email);
                byte[] apiResponse = client.UploadValues(Api.ApiUri + "/log/export", values);
                ApiResponse<ExportLink> apiRet = Newtonsoft.Json.JsonConvert.DeserializeObject<ApiResponse<ExportLink>>(Encoding.UTF8.GetString(apiResponse));
                if (!apiRet.success) throw new ApplicationException(apiRet.error);
                return apiRet.Data;
            }

            /// <summary>
            /// Export detailed link tracking information to the specified file format.
            /// </summary>
            /// <param name="apikey">ApiKey that gives you access to our SMTP and HTTP API's.</param>
            /// <param name="from">Starting date for search in YYYY-MM-DDThh:mm:ss format.</param>
            /// <param name="to">Ending date for search in YYYY-MM-DDThh:mm:ss format.</param>
            /// <param name="channelName">Name of selected channel.</param>
            /// <param name="fileFormat">Format of the exported file</param>
            /// <param name="limit">Maximum of loaded items.</param>
            /// <param name="offset">How many items should be loaded ahead.</param>
            /// <param name="compressionFormat">FileResponse compression format. None or Zip.</param>
            /// <param name="fileName">Name of your file.</param>
            /// <returns>ExportLink</returns>
            public static ExportLink ExportLinkTracking(DateTime? from, DateTime? to, string channelName = null, ExportFileFormats fileFormat = ExportFileFormats.Csv, int limit = 0, int offset = 0, CompressionFormat compressionFormat = CompressionFormat.None, string fileName = null)
            {
                WebClient client = new CustomWebClient();
                NameValueCollection values = new NameValueCollection();
                values.Add("apikey", Api.ApiKey);
                values.Add("from", from.Value.ToString("M/d/yyyy h:mm:ss tt"));
                values.Add("to", to.Value.ToString("M/d/yyyy h:mm:ss tt"));
                if (channelName != null) values.Add("channelName", channelName);
                if (fileFormat != ExportFileFormats.Csv) values.Add("fileFormat", fileFormat.ToString());
                if (limit != 0) values.Add("limit", limit.ToString());
                if (offset != 0) values.Add("offset", offset.ToString());
                if (compressionFormat != CompressionFormat.None) values.Add("compressionFormat", compressionFormat.ToString());
                if (fileName != null) values.Add("fileName", fileName);
                byte[] apiResponse = client.UploadValues(Api.ApiUri + "/log/exportlinktracking", values);
                ApiResponse<ExportLink> apiRet = Newtonsoft.Json.JsonConvert.DeserializeObject<ApiResponse<ExportLink>>(Encoding.UTF8.GetString(apiResponse));
                if (!apiRet.success) throw new ApplicationException(apiRet.error);
                return apiRet.Data;
            }

            /// <summary>
            /// Track link clicks
            /// </summary>
            /// <param name="apikey">ApiKey that gives you access to our SMTP and HTTP API's.</param>
            /// <param name="from">Starting date for search in YYYY-MM-DDThh:mm:ss format.</param>
            /// <param name="to">Ending date for search in YYYY-MM-DDThh:mm:ss format.</param>
            /// <param name="limit">Maximum of loaded items.</param>
            /// <param name="offset">How many items should be loaded ahead.</param>
            /// <param name="channelName">Name of selected channel.</param>
            /// <returns>LinkTrackingDetails</returns>
            public static LinkTrackingDetails LinkTracking(DateTime? from = null, DateTime? to = null, int limit = 0, int offset = 0, string channelName = null)
            {
                WebClient client = new CustomWebClient();
                NameValueCollection values = new NameValueCollection();
                values.Add("apikey", Api.ApiKey);
                if (from != null) values.Add("from", from.Value.ToString("M/d/yyyy h:mm:ss tt"));
                if (to != null) values.Add("to", to.Value.ToString("M/d/yyyy h:mm:ss tt"));
                if (limit != 0) values.Add("limit", limit.ToString());
                if (offset != 0) values.Add("offset", offset.ToString());
                if (channelName != null) values.Add("channelName", channelName);
                byte[] apiResponse = client.UploadValues(Api.ApiUri + "/log/linktracking", values);
                ApiResponse<LinkTrackingDetails> apiRet = Newtonsoft.Json.JsonConvert.DeserializeObject<ApiResponse<LinkTrackingDetails>>(Encoding.UTF8.GetString(apiResponse));
                if (!apiRet.success) throw new ApplicationException(apiRet.error);
                return apiRet.Data;
            }

            /// <summary>
            /// Returns logs filtered by specified parameters.
            /// </summary>
            /// <param name="apikey">ApiKey that gives you access to our SMTP and HTTP API's.</param>
            /// <param name="statuses">List of comma separated message statuses: 0 for all, 1 for ReadyToSend, 2 for InProgress, 4 for Bounced, 5 for Sent, 6 for Opened, 7 for Clicked, 8 for Unsubscribed, 9 for Abuse Report</param>
            /// <param name="from">Starting date for search in YYYY-MM-DDThh:mm:ss format.</param>
            /// <param name="to">Ending date for search in YYYY-MM-DDThh:mm:ss format.</param>
            /// <param name="channelName">Name of selected channel.</param>
            /// <param name="limit">Maximum of loaded items.</param>
            /// <param name="offset">How many items should be loaded ahead.</param>
            /// <param name="includeEmail">True: Search includes emails. Otherwise, false.</param>
            /// <param name="includeSms">True: Search includes SMS. Otherwise, false.</param>
            /// <param name="messageCategory">ID of message category</param>
            /// <param name="email">Proper email address.</param>
            /// <param name="useStatusChangeDate">True, if 'from' and 'to' parameters should resolve to the Status Change date. To resolve to the creation date - false</param>
            /// <returns>Log</returns>
            public static ApiTypes.Log Load(IEnumerable<LogJobStatus> statuses, DateTime? from = null, DateTime? to = null, string channelName = null, int limit = 0, int offset = 0, bool includeEmail = true, bool includeSms = true, IEnumerable<MessageCategory> messageCategory = null, string email = null, bool useStatusChangeDate = false)
            {
                WebClient client = new CustomWebClient();
                NameValueCollection values = new NameValueCollection();
                values.Add("apikey", Api.ApiKey);
                values.Add("statuses", string.Join(",", statuses));
                if (from != null) values.Add("from", from.Value.ToString("M/d/yyyy h:mm:ss tt"));
                if (to != null) values.Add("to", to.Value.ToString("M/d/yyyy h:mm:ss tt"));
                if (channelName != null) values.Add("channelName", channelName);
                if (limit != 0) values.Add("limit", limit.ToString());
                if (offset != 0) values.Add("offset", offset.ToString());
                if (includeEmail != true) values.Add("includeEmail", includeEmail.ToString());
                if (includeSms != true) values.Add("includeSms", includeSms.ToString());
                if (messageCategory != null) values.Add("messageCategory", string.Join(",", messageCategory));
                if (email != null) values.Add("email", email);
                if (useStatusChangeDate != false) values.Add("useStatusChangeDate", useStatusChangeDate.ToString());
                byte[] apiResponse = client.UploadValues(Api.ApiUri + "/log/load", values);
                ApiResponse<ApiTypes.Log> apiRet = Newtonsoft.Json.JsonConvert.DeserializeObject<ApiResponse<ApiTypes.Log>>(Encoding.UTF8.GetString(apiResponse));
                if (!apiRet.success) throw new ApplicationException(apiRet.error);
                return apiRet.Data;
            }

            /// <summary>
            /// Returns notification logs filtered by specified parameters.
            /// </summary>
            /// <param name="apikey">ApiKey that gives you access to our SMTP and HTTP API's.</param>
            /// <param name="statuses">List of comma separated message statuses: 0 for all, 1 for ReadyToSend, 2 for InProgress, 4 for Bounced, 5 for Sent, 6 for Opened, 7 for Clicked, 8 for Unsubscribed, 9 for Abuse Report</param>
            /// <param name="from">Starting date for search in YYYY-MM-DDThh:mm:ss format.</param>
            /// <param name="to">Ending date for search in YYYY-MM-DDThh:mm:ss format.</param>
            /// <param name="limit">Maximum of loaded items.</param>
            /// <param name="offset">How many items should be loaded ahead.</param>
            /// <param name="messageCategory">ID of message category</param>
            /// <param name="useStatusChangeDate">True, if 'from' and 'to' parameters should resolve to the Status Change date. To resolve to the creation date - false</param>
            /// <param name="notificationType"></param>
            /// <returns>Log</returns>
            public static ApiTypes.Log LoadNotifications(IEnumerable<LogJobStatus> statuses, DateTime? from = null, DateTime? to = null, int limit = 0, int offset = 0, IEnumerable<MessageCategory> messageCategory = null, bool useStatusChangeDate = false, NotificationType notificationType = NotificationType.All)
            {
                WebClient client = new CustomWebClient();
                NameValueCollection values = new NameValueCollection();
                values.Add("apikey", Api.ApiKey);
                values.Add("statuses", string.Join(",", statuses));
                if (from != null) values.Add("from", from.Value.ToString("M/d/yyyy h:mm:ss tt"));
                if (to != null) values.Add("to", to.Value.ToString("M/d/yyyy h:mm:ss tt"));
                if (limit != 0) values.Add("limit", limit.ToString());
                if (offset != 0) values.Add("offset", offset.ToString());
                if (messageCategory != null) values.Add("messageCategory", string.Join(",", messageCategory));
                if (useStatusChangeDate != false) values.Add("useStatusChangeDate", useStatusChangeDate.ToString());
                if (notificationType != NotificationType.All) values.Add("notificationType", notificationType.ToString());
                byte[] apiResponse = client.UploadValues(Api.ApiUri + "/log/loadnotifications", values);
                ApiResponse<ApiTypes.Log> apiRet = Newtonsoft.Json.JsonConvert.DeserializeObject<ApiResponse<ApiTypes.Log>>(Encoding.UTF8.GetString(apiResponse));
                if (!apiRet.success) throw new ApplicationException(apiRet.error);
                return apiRet.Data;
            }

            /// <summary>
            /// Retry sending of temporarily not delivered message.
            /// </summary>
            /// <param name="apikey">ApiKey that gives you access to our SMTP and HTTP API's.</param>
            /// <param name="msgID">ID number of selected message.</param>
            public static void RetryNow(string msgID)
            {
                WebClient client = new CustomWebClient();
                NameValueCollection values = new NameValueCollection();
                values.Add("apikey", Api.ApiKey);
                values.Add("msgID", msgID);
                byte[] apiResponse = client.UploadValues(Api.ApiUri + "/log/retrynow", values);
                ApiResponse<VoidApiResponse> apiRet = Newtonsoft.Json.JsonConvert.DeserializeObject<ApiResponse<VoidApiResponse>>(Encoding.UTF8.GetString(apiResponse));
                if (!apiRet.success) throw new ApplicationException(apiRet.error);
            }

            /// <summary>
            /// Loads summary information about activity in chosen date range.
            /// </summary>
            /// <param name="apikey">ApiKey that gives you access to our SMTP and HTTP API's.</param>
            /// <param name="from">Starting date for search in YYYY-MM-DDThh:mm:ss format.</param>
            /// <param name="to">Ending date for search in YYYY-MM-DDThh:mm:ss format.</param>
            /// <param name="channelName">Name of selected channel.</param>
            /// <param name="interval">'Hourly' for detailed information, 'summary' for daily overview</param>
            /// <param name="transactionID">ID number of transaction</param>
            /// <returns>LogSummary</returns>
            public static ApiTypes.LogSummary Summary(DateTime from, DateTime to, string channelName = null, IntervalType interval = IntervalType.Summary, string transactionID = null)
            {
                WebClient client = new CustomWebClient();
                NameValueCollection values = new NameValueCollection();
                values.Add("apikey", Api.ApiKey);
                values.Add("from", from.ToString("M/d/yyyy h:mm:ss tt"));
                values.Add("to", to.ToString("M/d/yyyy h:mm:ss tt"));
                if (channelName != null) values.Add("channelName", channelName);
                if (interval != IntervalType.Summary) values.Add("interval", interval.ToString());
                if (transactionID != null) values.Add("transactionID", transactionID);
                byte[] apiResponse = client.UploadValues(Api.ApiUri + "/log/summary", values);
                ApiResponse<ApiTypes.LogSummary> apiRet = Newtonsoft.Json.JsonConvert.DeserializeObject<ApiResponse<ApiTypes.LogSummary>>(Encoding.UTF8.GetString(apiResponse));
                if (!apiRet.success) throw new ApplicationException(apiRet.error);
                return apiRet.Data;
            }

        }
        #endregion


        #region Segment functions
        /// <summary>
        /// Manages your segments - dynamically created lists of contacts
        /// </summary>
        public static class Segment
        {
            /// <summary>
            /// Create new segment, based on specified RULE.
            /// </summary>
            /// <param name="apikey">ApiKey that gives you access to our SMTP and HTTP API's.</param>
            /// <param name="segmentName">Name of your segment.</param>
            /// <param name="rule">Query used for filtering.</param>
            /// <returns>Segment</returns>
            public static ApiTypes.Segment Add(string segmentName, string rule)
            {
                WebClient client = new CustomWebClient();
                NameValueCollection values = new NameValueCollection();
                values.Add("apikey", Api.ApiKey);
                values.Add("segmentName", segmentName);
                values.Add("rule", rule);
                byte[] apiResponse = client.UploadValues(Api.ApiUri + "/segment/add", values);
                ApiResponse<ApiTypes.Segment> apiRet = Newtonsoft.Json.JsonConvert.DeserializeObject<ApiResponse<ApiTypes.Segment>>(Encoding.UTF8.GetString(apiResponse));
                if (!apiRet.success) throw new ApplicationException(apiRet.error);
                return apiRet.Data;
            }

            /// <summary>
            /// Copy your existing Segment with the optional new rule and custom name
            /// </summary>
            /// <param name="apikey">ApiKey that gives you access to our SMTP and HTTP API's.</param>
            /// <param name="sourceSegmentName">The name of the segment you want to copy</param>
            /// <param name="newSegmentName">New name of your segment if you want to change it.</param>
            /// <param name="rule">Query used for filtering.</param>
            /// <returns>Segment</returns>
            public static ApiTypes.Segment Copy(string sourceSegmentName, string newSegmentName = null, string rule = null)
            {
                WebClient client = new CustomWebClient();
                NameValueCollection values = new NameValueCollection();
                values.Add("apikey", Api.ApiKey);
                values.Add("sourceSegmentName", sourceSegmentName);
                if (newSegmentName != null) values.Add("newSegmentName", newSegmentName);
                if (rule != null) values.Add("rule", rule);
                byte[] apiResponse = client.UploadValues(Api.ApiUri + "/segment/copy", values);
                ApiResponse<ApiTypes.Segment> apiRet = Newtonsoft.Json.JsonConvert.DeserializeObject<ApiResponse<ApiTypes.Segment>>(Encoding.UTF8.GetString(apiResponse));
                if (!apiRet.success) throw new ApplicationException(apiRet.error);
                return apiRet.Data;
            }

            /// <summary>
            /// Delete existing segment.
            /// </summary>
            /// <param name="apikey">ApiKey that gives you access to our SMTP and HTTP API's.</param>
            /// <param name="segmentName">Name of your segment.</param>
            public static void Delete(string segmentName)
            {
                WebClient client = new CustomWebClient();
                NameValueCollection values = new NameValueCollection();
                values.Add("apikey", Api.ApiKey);
                values.Add("segmentName", segmentName);
                byte[] apiResponse = client.UploadValues(Api.ApiUri + "/segment/delete", values);
                ApiResponse<VoidApiResponse> apiRet = Newtonsoft.Json.JsonConvert.DeserializeObject<ApiResponse<VoidApiResponse>>(Encoding.UTF8.GetString(apiResponse));
                if (!apiRet.success) throw new ApplicationException(apiRet.error);
            }

            /// <summary>
            /// Exports all the contacts from the provided segment
            /// </summary>
            /// <param name="apikey">ApiKey that gives you access to our SMTP and HTTP API's.</param>
            /// <param name="segmentName">Name of your segment.</param>
            /// <param name="fileFormat">Format of the exported file</param>
            /// <param name="compressionFormat">FileResponse compression format. None or Zip.</param>
            /// <param name="fileName">Name of your file.</param>
            /// <returns>ExportLink</returns>
            public static ApiTypes.ExportLink Export(string segmentName, ExportFileFormats fileFormat = ExportFileFormats.Csv, CompressionFormat compressionFormat = CompressionFormat.None, string fileName = null)
            {
                WebClient client = new CustomWebClient();
                NameValueCollection values = new NameValueCollection();
                values.Add("apikey", Api.ApiKey);
                values.Add("segmentName", segmentName);
                if (fileFormat != ExportFileFormats.Csv) values.Add("fileFormat", fileFormat.ToString());
                if (compressionFormat != CompressionFormat.None) values.Add("compressionFormat", compressionFormat.ToString());
                if (fileName != null) values.Add("fileName", fileName);
                byte[] apiResponse = client.UploadValues(Api.ApiUri + "/segment/export", values);
                ApiResponse<ApiTypes.ExportLink> apiRet = Newtonsoft.Json.JsonConvert.DeserializeObject<ApiResponse<ApiTypes.ExportLink>>(Encoding.UTF8.GetString(apiResponse));
                if (!apiRet.success) throw new ApplicationException(apiRet.error);
                return apiRet.Data;
            }

            /// <summary>
            /// Lists all your available Segments
            /// </summary>
            /// <param name="apikey">ApiKey that gives you access to our SMTP and HTTP API's.</param>
            /// <param name="includeHistory">True: Include history of last 30 days. Otherwise, false.</param>
            /// <param name="from">From what date should the segment history be shown. In YYYY-MM-DDThh:mm:ss format.</param>
            /// <param name="to">To what date should the segment history be shown. In YYYY-MM-DDThh:mm:ss format.</param>
            /// <returns>List(Segment)</returns>
            public static List<ApiTypes.Segment> List(bool includeHistory = false, DateTime? from = null, DateTime? to = null)
            {
                WebClient client = new CustomWebClient();
                NameValueCollection values = new NameValueCollection();
                values.Add("apikey", Api.ApiKey);
                if (includeHistory != false) values.Add("includeHistory", includeHistory.ToString());
                if (from != null) values.Add("from", from.Value.ToString("M/d/yyyy h:mm:ss tt"));
                if (to != null) values.Add("to", to.Value.ToString("M/d/yyyy h:mm:ss tt"));
                byte[] apiResponse = client.UploadValues(Api.ApiUri + "/segment/list", values);
                ApiResponse<List<ApiTypes.Segment>> apiRet = Newtonsoft.Json.JsonConvert.DeserializeObject<ApiResponse<List<ApiTypes.Segment>>>(Encoding.UTF8.GetString(apiResponse));
                if (!apiRet.success) throw new ApplicationException(apiRet.error);
                return apiRet.Data;
            }

            /// <summary>
            /// Lists your available Segments using the provided names
            /// </summary>
            /// <param name="apikey">ApiKey that gives you access to our SMTP and HTTP API's.</param>
            /// <param name="segmentNames">Names of segments you want to load. Will load all contacts if left empty or the 'All Contacts' name has been provided</param>
            /// <param name="includeHistory">True: Include history of last 30 days. Otherwise, false.</param>
            /// <param name="from">From what date should the segment history be shown. In YYYY-MM-DDThh:mm:ss format.</param>
            /// <param name="to">To what date should the segment history be shown. In YYYY-MM-DDThh:mm:ss format.</param>
            /// <returns>List(Segment)</returns>
            public static List<ApiTypes.Segment> LoadByName(IEnumerable<string> segmentNames, bool includeHistory = false, DateTime? from = null, DateTime? to = null)
            {
                WebClient client = new CustomWebClient();
                NameValueCollection values = new NameValueCollection();
                values.Add("apikey", Api.ApiKey);
                values.Add("segmentNames", string.Join(",", segmentNames));
                if (includeHistory != false) values.Add("includeHistory", includeHistory.ToString());
                if (from != null) values.Add("from", from.Value.ToString("M/d/yyyy h:mm:ss tt"));
                if (to != null) values.Add("to", to.Value.ToString("M/d/yyyy h:mm:ss tt"));
                byte[] apiResponse = client.UploadValues(Api.ApiUri + "/segment/loadbyname", values);
                ApiResponse<List<ApiTypes.Segment>> apiRet = Newtonsoft.Json.JsonConvert.DeserializeObject<ApiResponse<List<ApiTypes.Segment>>>(Encoding.UTF8.GetString(apiResponse));
                if (!apiRet.success) throw new ApplicationException(apiRet.error);
                return apiRet.Data;
            }

            /// <summary>
            /// Rename or change RULE for your segment
            /// </summary>
            /// <param name="apikey">ApiKey that gives you access to our SMTP and HTTP API's.</param>
            /// <param name="segmentName">Name of your segment.</param>
            /// <param name="newSegmentName">New name of your segment if you want to change it.</param>
            /// <param name="rule">Query used for filtering.</param>
            /// <returns>Segment</returns>
            public static ApiTypes.Segment Update(string segmentName, string newSegmentName = null, string rule = null)
            {
                WebClient client = new CustomWebClient();
                NameValueCollection values = new NameValueCollection();
                values.Add("apikey", Api.ApiKey);
                values.Add("segmentName", segmentName);
                if (newSegmentName != null) values.Add("newSegmentName", newSegmentName);
                if (rule != null) values.Add("rule", rule);
                byte[] apiResponse = client.UploadValues(Api.ApiUri + "/segment/update", values);
                ApiResponse<ApiTypes.Segment> apiRet = Newtonsoft.Json.JsonConvert.DeserializeObject<ApiResponse<ApiTypes.Segment>>(Encoding.UTF8.GetString(apiResponse));
                if (!apiRet.success) throw new ApplicationException(apiRet.error);
                return apiRet.Data;
            }

        }
        #endregion


        #region SMS functions
        /// <summary>
        /// Managing texting to your clients.
        /// </summary>
        public static class SMS
        {
            /// <summary>
            /// Send a short SMS Message (maximum of 1600 characters) to any mobile phone.
            /// </summary>
            /// <param name="apikey">ApiKey that gives you access to our SMTP and HTTP API's.</param>
            /// <param name="to">Mobile number you want to message. Can be any valid mobile number in E.164 format. To provide the country code you need to provide "+" before the number.  If your URL is not encoded then you need to replace the "+" with "%2B" instead.</param>
            /// <param name="body">Body of your message. The maximum body length is 160 characters.  If the message body is greater than 160 characters it is split into multiple messages and you are charged per message for the number of message required to send your length</param>
            public static void Send(string to, string body)
            {
                WebClient client = new CustomWebClient();
                NameValueCollection values = new NameValueCollection();
                values.Add("apikey", Api.ApiKey);
                values.Add("to", to);
                values.Add("body", body);
                byte[] apiResponse = client.UploadValues(Api.ApiUri + "/sms/send", values);
                ApiResponse<VoidApiResponse> apiRet = Newtonsoft.Json.JsonConvert.DeserializeObject<ApiResponse<VoidApiResponse>>(Encoding.UTF8.GetString(apiResponse));
                if (!apiRet.success) throw new ApplicationException(apiRet.error);
            }

        }
        #endregion


        #region Survey functions
        /// <summary>
        /// Methods to organize and get results of your surveys
        /// </summary>
        public static class Survey
        {
            /// <summary>
            /// Adds a new survey
            /// </summary>
            /// <param name="apikey">ApiKey that gives you access to our SMTP and HTTP API's.</param>
            /// <param name="survey">Json representation of a survey</param>
            /// <returns>Survey</returns>
            public static ApiTypes.Survey Add(ApiTypes.Survey survey)
            {
                WebClient client = new CustomWebClient();
                NameValueCollection values = new NameValueCollection();
                values.Add("apikey", Api.ApiKey);
                values.Add("survey", Newtonsoft.Json.JsonConvert.SerializeObject(survey));
                byte[] apiResponse = client.UploadValues(Api.ApiUri + "/survey/add", values);
                ApiResponse<ApiTypes.Survey> apiRet = Newtonsoft.Json.JsonConvert.DeserializeObject<ApiResponse<ApiTypes.Survey>>(Encoding.UTF8.GetString(apiResponse));
                if (!apiRet.success) throw new ApplicationException(apiRet.error);
                return apiRet.Data;
            }

            /// <summary>
            /// Deletes the survey
            /// </summary>
            /// <param name="apikey">ApiKey that gives you access to our SMTP and HTTP API's.</param>
            /// <param name="publicSurveyID">Survey identifier</param>
            public static void Delete(Guid publicSurveyID)
            {
                WebClient client = new CustomWebClient();
                NameValueCollection values = new NameValueCollection();
                values.Add("apikey", Api.ApiKey);
                values.Add("publicSurveyID", publicSurveyID.ToString());
                byte[] apiResponse = client.UploadValues(Api.ApiUri + "/survey/delete", values);
                ApiResponse<VoidApiResponse> apiRet = Newtonsoft.Json.JsonConvert.DeserializeObject<ApiResponse<VoidApiResponse>>(Encoding.UTF8.GetString(apiResponse));
                if (!apiRet.success) throw new ApplicationException(apiRet.error);
            }

            /// <summary>
            /// Export given survey's data to provided format
            /// </summary>
            /// <param name="apikey">ApiKey that gives you access to our SMTP and HTTP API's.</param>
            /// <param name="publicSurveyID">Survey identifier</param>
            /// <param name="fileName">Name of your file.</param>
            /// <param name="fileFormat">Format of the exported file</param>
            /// <param name="compressionFormat">FileResponse compression format. None or Zip.</param>
            /// <returns>ExportLink</returns>
            public static ApiTypes.ExportLink Export(Guid publicSurveyID, string fileName, ExportFileFormats fileFormat = ExportFileFormats.Csv, CompressionFormat compressionFormat = CompressionFormat.None)
            {
                WebClient client = new CustomWebClient();
                NameValueCollection values = new NameValueCollection();
                values.Add("apikey", Api.ApiKey);
                values.Add("publicSurveyID", publicSurveyID.ToString());
                values.Add("fileName", fileName);
                if (fileFormat != ExportFileFormats.Csv) values.Add("fileFormat", fileFormat.ToString());
                if (compressionFormat != CompressionFormat.None) values.Add("compressionFormat", compressionFormat.ToString());
                byte[] apiResponse = client.UploadValues(Api.ApiUri + "/survey/export", values);
                ApiResponse<ApiTypes.ExportLink> apiRet = Newtonsoft.Json.JsonConvert.DeserializeObject<ApiResponse<ApiTypes.ExportLink>>(Encoding.UTF8.GetString(apiResponse));
                if (!apiRet.success) throw new ApplicationException(apiRet.error);
                return apiRet.Data;
            }

            /// <summary>
            /// Shows all your existing surveys
            /// </summary>
            /// <param name="apikey">ApiKey that gives you access to our SMTP and HTTP API's.</param>
            /// <returns>List(Survey)</returns>
            public static List<ApiTypes.Survey> List()
            {
                WebClient client = new CustomWebClient();
                NameValueCollection values = new NameValueCollection();
                values.Add("apikey", Api.ApiKey);
                byte[] apiResponse = client.UploadValues(Api.ApiUri + "/survey/list", values);
                ApiResponse<List<ApiTypes.Survey>> apiRet = Newtonsoft.Json.JsonConvert.DeserializeObject<ApiResponse<List<ApiTypes.Survey>>>(Encoding.UTF8.GetString(apiResponse));
                if (!apiRet.success) throw new ApplicationException(apiRet.error);
                return apiRet.Data;
            }

            /// <summary>
            /// Get list of personal answers for the specific survey
            /// </summary>
            /// <param name="apikey">ApiKey that gives you access to our SMTP and HTTP API's.</param>
            /// <param name="publicSurveyID">Survey identifier</param>
            /// <returns>List(SurveyResultInfo)</returns>
            public static List<ApiTypes.SurveyResultInfo> LoadResponseList(Guid publicSurveyID)
            {
                WebClient client = new CustomWebClient();
                NameValueCollection values = new NameValueCollection();
                values.Add("apikey", Api.ApiKey);
                values.Add("publicSurveyID", publicSurveyID.ToString());
                byte[] apiResponse = client.UploadValues(Api.ApiUri + "/survey/loadresponselist", values);
                ApiResponse<List<ApiTypes.SurveyResultInfo>> apiRet = Newtonsoft.Json.JsonConvert.DeserializeObject<ApiResponse<List<ApiTypes.SurveyResultInfo>>>(Encoding.UTF8.GetString(apiResponse));
                if (!apiRet.success) throw new ApplicationException(apiRet.error);
                return apiRet.Data;
            }

            /// <summary>
            /// Get general results of the specific survey
            /// </summary>
            /// <param name="apikey">ApiKey that gives you access to our SMTP and HTTP API's.</param>
            /// <param name="publicSurveyID">Survey identifier</param>
            /// <returns>SurveyResultsSummaryInfo</returns>
            public static ApiTypes.SurveyResultsSummaryInfo LoadResults(Guid publicSurveyID)
            {
                WebClient client = new CustomWebClient();
                NameValueCollection values = new NameValueCollection();
                values.Add("apikey", Api.ApiKey);
                values.Add("publicSurveyID", publicSurveyID.ToString());
                byte[] apiResponse = client.UploadValues(Api.ApiUri + "/survey/loadresults", values);
                ApiResponse<ApiTypes.SurveyResultsSummaryInfo> apiRet = Newtonsoft.Json.JsonConvert.DeserializeObject<ApiResponse<ApiTypes.SurveyResultsSummaryInfo>>(Encoding.UTF8.GetString(apiResponse));
                if (!apiRet.success) throw new ApplicationException(apiRet.error);
                return apiRet.Data;
            }

            /// <summary>
            /// Update the survey information
            /// </summary>
            /// <param name="apikey">ApiKey that gives you access to our SMTP and HTTP API's.</param>
            /// <param name="survey">Json representation of a survey</param>
            /// <returns>Survey</returns>
            public static ApiTypes.Survey Update(ApiTypes.Survey survey)
            {
                WebClient client = new CustomWebClient();
                NameValueCollection values = new NameValueCollection();
                values.Add("apikey", Api.ApiKey);
                values.Add("survey", Newtonsoft.Json.JsonConvert.SerializeObject(survey));
                byte[] apiResponse = client.UploadValues(Api.ApiUri + "/survey/update", values);
                ApiResponse<ApiTypes.Survey> apiRet = Newtonsoft.Json.JsonConvert.DeserializeObject<ApiResponse<ApiTypes.Survey>>(Encoding.UTF8.GetString(apiResponse));
                if (!apiRet.success) throw new ApplicationException(apiRet.error);
                return apiRet.Data;
            }

        }
        #endregion


        #region Template functions
        /// <summary>
        /// Managing and editing templates of your emails
        /// </summary>
        public static class Template
        {
            /// <summary>
            /// Create new Template. Needs to be sent using POST method
            /// </summary>
            /// <param name="apikey">ApiKey that gives you access to our SMTP and HTTP API's.</param>
            /// <param name="name">Filename</param>
            /// <param name="subject">Default subject of email.</param>
            /// <param name="fromEmail">Default From: email address.</param>
            /// <param name="fromName">Default From: name.</param>
            /// <param name="templateType">0 for API connections</param>
            /// <param name="templateScope">Enum: 0 - private, 1 - public, 2 - mockup</param>
            /// <param name="bodyHtml">HTML code of email (needs escaping).</param>
            /// <param name="bodyText">Text body of email.</param>
            /// <param name="css">CSS style</param>
            /// <param name="originalTemplateID">ID number of original template.</param>
            /// <returns>int</returns>
            public static int Add(string name, string subject, string fromEmail, string fromName, TemplateType templateType = TemplateType.RawHTML, TemplateScope templateScope = TemplateScope.Private, string bodyHtml = null, string bodyText = null, string css = null, int originalTemplateID = 0)
            {
                WebClient client = new CustomWebClient();
                NameValueCollection values = new NameValueCollection();
                values.Add("apikey", Api.ApiKey);
                values.Add("name", name);
                values.Add("subject", subject);
                values.Add("fromEmail", fromEmail);
                values.Add("fromName", fromName);
                if (templateType != TemplateType.RawHTML) values.Add("templateType", templateType.ToString());
                if (templateScope != TemplateScope.Private) values.Add("templateScope", templateScope.ToString());
                if (bodyHtml != null) values.Add("bodyHtml", bodyHtml);
                if (bodyText != null) values.Add("bodyText", bodyText);
                if (css != null) values.Add("css", css);
                if (originalTemplateID != 0) values.Add("originalTemplateID", originalTemplateID.ToString());
                byte[] apiResponse = ApiUtilities.HttpPostFile(Api.ApiUri + "/template/add", null, values);
                ApiResponse<int> apiRet = Newtonsoft.Json.JsonConvert.DeserializeObject<ApiResponse<int>>(Encoding.UTF8.GetString(apiResponse));
                if (!apiRet.success) throw new ApplicationException(apiRet.error);
                return apiRet.Data;
            }

            /// <summary>
            /// Check if template is used by campaign.
            /// </summary>
            /// <param name="apikey">ApiKey that gives you access to our SMTP and HTTP API's.</param>
            /// <param name="templateID">ID number of template.</param>
            /// <returns>bool</returns>
            public static bool CheckUsage(int templateID)
            {
                WebClient client = new CustomWebClient();
                NameValueCollection values = new NameValueCollection();
                values.Add("apikey", Api.ApiKey);
                values.Add("templateID", templateID.ToString());
                byte[] apiResponse = client.UploadValues(Api.ApiUri + "/template/checkusage", values);
                ApiResponse<bool> apiRet = Newtonsoft.Json.JsonConvert.DeserializeObject<ApiResponse<bool>>(Encoding.UTF8.GetString(apiResponse));
                if (!apiRet.success) throw new ApplicationException(apiRet.error);
                return apiRet.Data;
            }

            /// <summary>
            /// Copy Selected Template
            /// </summary>
            /// <param name="apikey">ApiKey that gives you access to our SMTP and HTTP API's.</param>
            /// <param name="templateID">ID number of template.</param>
            /// <param name="name">Filename</param>
            /// <param name="subject">Default subject of email.</param>
            /// <param name="fromEmail">Default From: email address.</param>
            /// <param name="fromName">Default From: name.</param>
            /// <returns>Template</returns>
            public static ApiTypes.Template Copy(int templateID, string name, string subject, string fromEmail, string fromName)
            {
                WebClient client = new CustomWebClient();
                NameValueCollection values = new NameValueCollection();
                values.Add("apikey", Api.ApiKey);
                values.Add("templateID", templateID.ToString());
                values.Add("name", name);
                values.Add("subject", subject);
                values.Add("fromEmail", fromEmail);
                values.Add("fromName", fromName);
                byte[] apiResponse = client.UploadValues(Api.ApiUri + "/template/copy", values);
                ApiResponse<ApiTypes.Template> apiRet = Newtonsoft.Json.JsonConvert.DeserializeObject<ApiResponse<ApiTypes.Template>>(Encoding.UTF8.GetString(apiResponse));
                if (!apiRet.success) throw new ApplicationException(apiRet.error);
                return apiRet.Data;
            }

            /// <summary>
            /// Delete template with the specified ID
            /// </summary>
            /// <param name="apikey">ApiKey that gives you access to our SMTP and HTTP API's.</param>
            /// <param name="templateID">ID number of template.</param>
            public static void Delete(int templateID)
            {
                WebClient client = new CustomWebClient();
                NameValueCollection values = new NameValueCollection();
                values.Add("apikey", Api.ApiKey);
                values.Add("templateID", templateID.ToString());
                byte[] apiResponse = client.UploadValues(Api.ApiUri + "/template/delete", values);
                ApiResponse<VoidApiResponse> apiRet = Newtonsoft.Json.JsonConvert.DeserializeObject<ApiResponse<VoidApiResponse>>(Encoding.UTF8.GetString(apiResponse));
                if (!apiRet.success) throw new ApplicationException(apiRet.error);
            }

            /// <summary>
            /// Search for references to images and replaces them with base64 code.
            /// </summary>
            /// <param name="apikey">ApiKey that gives you access to our SMTP and HTTP API's.</param>
            /// <param name="templateID">ID number of template.</param>
            /// <returns>string</returns>
            public static string GetEmbeddedHtml(int templateID)
            {
                WebClient client = new CustomWebClient();
                NameValueCollection values = new NameValueCollection();
                values.Add("apikey", Api.ApiKey);
                values.Add("templateID", templateID.ToString());
                byte[] apiResponse = client.UploadValues(Api.ApiUri + "/template/getembeddedhtml", values);
                ApiResponse<string> apiRet = Newtonsoft.Json.JsonConvert.DeserializeObject<ApiResponse<string>>(Encoding.UTF8.GetString(apiResponse));
                if (!apiRet.success) throw new ApplicationException(apiRet.error);
                return apiRet.Data;
            }

            /// <summary>
            /// Lists your templates
            /// </summary>
            /// <param name="apikey">ApiKey that gives you access to our SMTP and HTTP API's.</param>
            /// <param name="limit">Maximum of loaded items.</param>
            /// <param name="offset">How many items should be loaded ahead.</param>
            /// <returns>TemplateList</returns>
            public static ApiTypes.TemplateList GetList(int limit = 500, int offset = 0)
            {
                WebClient client = new CustomWebClient();
                NameValueCollection values = new NameValueCollection();
                values.Add("apikey", Api.ApiKey);
                if (limit != 500) values.Add("limit", limit.ToString());
                if (offset != 0) values.Add("offset", offset.ToString());
                byte[] apiResponse = client.UploadValues(Api.ApiUri + "/template/getlist", values);
                ApiResponse<ApiTypes.TemplateList> apiRet = Newtonsoft.Json.JsonConvert.DeserializeObject<ApiResponse<ApiTypes.TemplateList>>(Encoding.UTF8.GetString(apiResponse));
                if (!apiRet.success) throw new ApplicationException(apiRet.error);
                return apiRet.Data;
            }

            /// <summary>
            /// Load template with content
            /// </summary>
            /// <param name="apikey">ApiKey that gives you access to our SMTP and HTTP API's.</param>
            /// <param name="templateID">ID number of template.</param>
            /// <param name="ispublic"></param>
            /// <returns>Template</returns>
            public static ApiTypes.Template LoadTemplate(int templateID, bool ispublic = false)
            {
                WebClient client = new CustomWebClient();
                NameValueCollection values = new NameValueCollection();
                values.Add("apikey", Api.ApiKey);
                values.Add("templateID", templateID.ToString());
                if (ispublic != false) values.Add("ispublic", ispublic.ToString());
                byte[] apiResponse = client.UploadValues(Api.ApiUri + "/template/loadtemplate", values);
                ApiResponse<ApiTypes.Template> apiRet = Newtonsoft.Json.JsonConvert.DeserializeObject<ApiResponse<ApiTypes.Template>>(Encoding.UTF8.GetString(apiResponse));
                if (!apiRet.success) throw new ApplicationException(apiRet.error);
                return apiRet.Data;
            }

            /// <summary>
            /// Removes previously generated screenshot of template
            /// </summary>
            /// <param name="apikey">ApiKey that gives you access to our SMTP and HTTP API's.</param>
            /// <param name="templateID">ID number of template.</param>
            public static void RemoveScreenshot(int templateID)
            {
                WebClient client = new CustomWebClient();
                NameValueCollection values = new NameValueCollection();
                values.Add("apikey", Api.ApiKey);
                values.Add("templateID", templateID.ToString());
                byte[] apiResponse = client.UploadValues(Api.ApiUri + "/template/removescreenshot", values);
                ApiResponse<VoidApiResponse> apiRet = Newtonsoft.Json.JsonConvert.DeserializeObject<ApiResponse<VoidApiResponse>>(Encoding.UTF8.GetString(apiResponse));
                if (!apiRet.success) throw new ApplicationException(apiRet.error);
            }

            /// <summary>
            /// Saves screenshot of chosen Template
            /// </summary>
            /// <param name="apikey">ApiKey that gives you access to our SMTP and HTTP API's.</param>
            /// <param name="base64Image">Image, base64 coded.</param>
            /// <param name="templateID">ID number of template.</param>
            /// <returns>string</returns>
            public static string SaveScreenshot(string base64Image, int templateID)
            {
                WebClient client = new CustomWebClient();
                NameValueCollection values = new NameValueCollection();
                values.Add("apikey", Api.ApiKey);
                values.Add("base64Image", base64Image);
                values.Add("templateID", templateID.ToString());
                byte[] apiResponse = client.UploadValues(Api.ApiUri + "/template/savescreenshot", values);
                ApiResponse<string> apiRet = Newtonsoft.Json.JsonConvert.DeserializeObject<ApiResponse<string>>(Encoding.UTF8.GetString(apiResponse));
                if (!apiRet.success) throw new ApplicationException(apiRet.error);
                return apiRet.Data;
            }

            /// <summary>
            /// Update existing template, overwriting existing data. Needs to be sent using POST method.
            /// </summary>
            /// <param name="apikey">ApiKey that gives you access to our SMTP and HTTP API's.</param>
            /// <param name="templateID">ID number of template.</param>
            /// <param name="templateScope">Enum: 0 - private, 1 - public, 2 - mockup</param>
            /// <param name="name">Filename</param>
            /// <param name="subject">Default subject of email.</param>
            /// <param name="fromEmail">Default From: email address.</param>
            /// <param name="fromName">Default From: name.</param>
            /// <param name="bodyHtml">HTML code of email (needs escaping).</param>
            /// <param name="bodyText">Text body of email.</param>
            /// <param name="css">CSS style</param>
            /// <param name="removeScreenshot"></param>
            public static void Update(int templateID, TemplateScope templateScope = TemplateScope.Private, string name = null, string subject = null, string fromEmail = null, string fromName = null, string bodyHtml = null, string bodyText = null, string css = null, bool removeScreenshot = true)
            {
                WebClient client = new CustomWebClient();
                NameValueCollection values = new NameValueCollection();
                values.Add("apikey", Api.ApiKey);
                values.Add("templateID", templateID.ToString());
                if (templateScope != TemplateScope.Private) values.Add("templateScope", templateScope.ToString());
                if (name != null) values.Add("name", name);
                if (subject != null) values.Add("subject", subject);
                if (fromEmail != null) values.Add("fromEmail", fromEmail);
                if (fromName != null) values.Add("fromName", fromName);
                if (bodyHtml != null) values.Add("bodyHtml", bodyHtml);
                if (bodyText != null) values.Add("bodyText", bodyText);
                if (css != null) values.Add("css", css);
                if (removeScreenshot != true) values.Add("removeScreenshot", removeScreenshot.ToString());
                byte[] apiResponse = ApiUtilities.HttpPostFile(Api.ApiUri + "/template/update", null, values);
                ApiResponse<VoidApiResponse> apiRet = Newtonsoft.Json.JsonConvert.DeserializeObject<ApiResponse<VoidApiResponse>>(Encoding.UTF8.GetString(apiResponse));
                if (!apiRet.success) throw new ApplicationException(apiRet.error);
            }

        }
        #endregion


    }
}
