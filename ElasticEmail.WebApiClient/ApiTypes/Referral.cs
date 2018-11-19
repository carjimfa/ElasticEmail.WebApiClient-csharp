using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ElasticEmail.WebApiClient.ApiTypes
{
    /// <summary>
    /// Referral details for this account.
    /// </summary>
    public class Referral
    {
        /// <summary>
        /// Current amount of dolars you have from referring.
        /// </summary>
        public decimal CurrentReferralCredit { get; set; }

        /// <summary>
        /// Number of active referrals.
        /// </summary>
        public long CurrentReferralCount { get; set; }

    }
}
