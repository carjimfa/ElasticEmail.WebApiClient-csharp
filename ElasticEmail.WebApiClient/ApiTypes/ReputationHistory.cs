using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ElasticEmail.WebApiClient.ApiTypes
{
    /// <summary>
    /// Reputation history of your account.
    /// </summary>
    public class ReputationHistory
    {
        /// <summary>
        /// Creation date.
        /// </summary>
        public string DateCreated { get; set; }

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
        /// Points from proper setup of your account
        /// </summary>
        public double SetupScore { get; set; }

        /// <summary>
        /// Points from quantity of your emails.
        /// </summary>
        public double RepEmailsSent { get; set; }

        /// <summary>
        /// Numeric reputation
        /// </summary>
        public double Reputation { get; set; }

    }

}
