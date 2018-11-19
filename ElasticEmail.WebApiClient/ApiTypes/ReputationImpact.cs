using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ElasticEmail.WebApiClient.ApiTypes
{

    /// <summary>
    /// Overall reputation impact, based on the most important factors.
    /// </summary>
    public class ReputationImpact
    {
        /// <summary>
        /// Abuses - mails sent to user without their consent
        /// </summary>
        public double Abuse { get; set; }

        /// <summary>
        /// Users, that could not be reached.
        /// </summary>
        public double UnknownUsers { get; set; }

        /// <summary>
        /// Number of opened messages
        /// </summary>
        public double Opened { get; set; }

        /// <summary>
        /// Number of clicked messages
        /// </summary>
        public double Clicked { get; set; }

        /// <summary>
        /// Penalty from messages marked as spam.
        /// </summary>
        public double AverageSpamScore { get; set; }

        /// <summary>
        /// Content analysis.
        /// </summary>
        public double ServerFilter { get; set; }

        /// <summary>
        /// Tracking domain.
        /// </summary>
        public double TrackingDomain { get; set; }

        /// <summary>
        /// Sending domain.
        /// </summary>
        public double SenderDomain { get; set; }

    }
}
