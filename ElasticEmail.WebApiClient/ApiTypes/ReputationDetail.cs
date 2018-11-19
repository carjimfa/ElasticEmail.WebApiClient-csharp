using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ElasticEmail.WebApiClient.ApiTypes
{

    /// <summary>
    /// Detailed sending reputation of your account.
    /// </summary>
    public class ReputationDetail
    {
        /// <summary>
        /// Overall reputation impact, based on the most important factors.
        /// </summary>
        public ApiTypes.ReputationImpact Impact { get; set; }

        /// <summary>
        /// Percent of Complaining users - those, who do not want to receive email from you.
        /// </summary>
        public double AbusePercent { get; set; }

        /// <summary>
        /// Percent of Unknown users - users that couldn't be found
        /// </summary>
        public double UnknownUsersPercent { get; set; }

        /// <summary>
        /// 
        /// </summary>
        public double OpenedPercent { get; set; }

        /// <summary>
        /// 
        /// </summary>
        public double ClickedPercent { get; set; }

        /// <summary>
        /// Penalty from messages marked as spam.
        /// </summary>
        public double AverageSpamScore { get; set; }

        /// <summary>
        /// Percent of Bounced users
        /// </summary>
        public double FailedSpamPercent { get; set; }

        /// <summary>
        /// Points from quantity of your emails.
        /// </summary>
        public double RepEmailsSent { get; set; }

        /// <summary>
        /// Average reputation.
        /// </summary>
        public double AverageReputation { get; set; }

        /// <summary>
        /// Actual price level.
        /// </summary>
        public double PriceLevelReputation { get; set; }

        /// <summary>
        /// Reputation needed to change pricing.
        /// </summary>
        public double NextPriceLevelReputation { get; set; }

        /// <summary>
        /// Amount of emails sent from this account
        /// </summary>
        public string PriceLevel { get; set; }

        /// <summary>
        /// True, if tracking domain is correctly configured. Otherwise, false.
        /// </summary>
        public bool TrackingDomainValid { get; set; }

        /// <summary>
        /// True, if sending domain is correctly configured. Otherwise, false.
        /// </summary>
        public bool SenderDomainValid { get; set; }

    }
}
