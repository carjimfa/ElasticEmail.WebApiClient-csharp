using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ElasticEmail.WebApiClient.ApiTypes
{
    /// <summary>
    /// Basic overview of your account
    /// </summary>
    public class AccountOverview
    {
        /// <summary>
        /// Amount of emails sent from this account
        /// </summary>
        public long TotalEmailsSent { get; set; }

        /// <summary>
        /// Amount of emails sent from this account
        /// </summary>
        public decimal Credit { get; set; }

        /// <summary>
        /// Cost of 1000 emails
        /// </summary>
        public decimal CostPerThousand { get; set; }

        /// <summary>
        /// Number of messages in progress
        /// </summary>
        public long InProgressCount { get; set; }

        /// <summary>
        /// Number of contacts currently with blocked status of Unsubscribed, Complaint, Bounced or InActive
        /// </summary>
        public long BlockedContactsCount { get; set; }

        /// <summary>
        /// Numeric reputation
        /// </summary>
        public double Reputation { get; set; }

        /// <summary>
        /// Number of contacts
        /// </summary>
        public long ContactCount { get; set; }

        /// <summary>
        /// Number of created campaigns
        /// </summary>
        public long CampaignCount { get; set; }

        /// <summary>
        /// Number of available templates
        /// </summary>
        public long TemplateCount { get; set; }

        /// <summary>
        /// Number of created subaccounts
        /// </summary>
        public long SubAccountCount { get; set; }

        /// <summary>
        /// Number of active referrals
        /// </summary>
        public long ReferralCount { get; set; }

    }
}
