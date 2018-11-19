using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ElasticEmail.WebApiClient.ApiTypes
{
    /// <summary>
    /// Single spam score
    /// </summary>
    public class SpamRule
    {
        /// <summary>
        /// Spam score
        /// </summary>
        public string Score { get; set; }

        /// <summary>
        /// Name of rule
        /// </summary>
        public string Key { get; set; }

        /// <summary>
        /// Description of rule.
        /// </summary>
        public string Description { get; set; }

    }
}
