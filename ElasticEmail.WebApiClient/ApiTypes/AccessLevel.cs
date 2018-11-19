using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ElasticEmail.WebApiClient.ApiTypes
{
    /// <summary>
    /// </summary>
    public enum AccessLevel : Int64
    {
        /// <summary>
        /// </summary>
        None = 0,

        /// <summary>
        /// </summary>
        ViewAccount = 1,

        /// <summary>
        /// </summary>
        ViewContacts = 2,

        /// <summary>
        /// </summary>
        ViewForms = 4,

        /// <summary>
        /// </summary>
        ViewTemplates = 8,

        /// <summary>
        /// </summary>
        ViewCampaigns = 16,

        /// <summary>
        /// </summary>
        ViewChannels = 32,

        /// <summary>
        /// </summary>
        ViewJourneys = 64,

        /// <summary>
        /// </summary>
        ViewSurveys = 128,

        /// <summary>
        /// </summary>
        ViewSettings = 256,

        /// <summary>
        /// </summary>
        ViewBilling = 512,

        /// <summary>
        /// </summary>
        ViewSubAccounts = 1024,

        /// <summary>
        /// </summary>
        ViewUsers = 2048,

        /// <summary>
        /// </summary>
        ViewFiles = 4096,

        /// <summary>
        /// </summary>
        ViewReports = 8192,

        /// <summary>
        /// </summary>
        ModifyAccount = 16384,

        /// <summary>
        /// </summary>
        ModifyContacts = 32768,

        /// <summary>
        /// </summary>
        ModifyForms = 65536,

        /// <summary>
        /// </summary>
        ModifyTemplates = 131072,

        /// <summary>
        /// </summary>
        ModifyCampaigns = 262144,

        /// <summary>
        /// </summary>
        ModifyChannels = 524288,

        /// <summary>
        /// </summary>
        ModifyJourneys = 1048576,

        /// <summary>
        /// </summary>
        ModifySurveys = 2097152,

        /// <summary>
        /// </summary>
        ModifyFiles = 4194304,

        /// <summary>
        /// </summary>
        Export = 8388608,

        /// <summary>
        /// </summary>
        SendSmtp = 16777216,

        /// <summary>
        /// </summary>
        SendSMS = 33554432,

        /// <summary>
        /// </summary>
        ModifySettings = 67108864,

        /// <summary>
        /// </summary>
        ModifyBilling = 134217728,

        /// <summary>
        /// </summary>
        ModifyProfile = 268435456,

        /// <summary>
        /// </summary>
        ModifySubAccounts = 536870912,

        /// <summary>
        /// </summary>
        ModifyUsers = 1073741824,

        /// <summary>
        /// </summary>
        Security = 2147483648,

        /// <summary>
        /// </summary>
        ModifyLanguage = 4294967296,

        /// <summary>
        /// </summary>
        ModifySupport = 8589934592,

        /// <summary>
        /// </summary>
        ViewSupport = 8589934592,

        /// <summary>
        /// </summary>
        SendHttp = 17179869184,

    }
}
