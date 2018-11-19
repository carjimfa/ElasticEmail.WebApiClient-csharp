using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ElasticEmail.WebApiClient.ApiTypes
{

    /// <summary>
    /// Account usage
    /// </summary>
    public class Usage
    {
        /// <summary>
        /// Proper email address.
        /// </summary>
        public string Email { get; set; }

        /// <summary>
        /// True, if this account is a sub-account. Otherwise, false
        /// </summary>
        public bool IsSubAccount { get; set; }

        /// <summary>
        /// 
        /// </summary>
        public List<UsageData> List { get; set; }

    }
}
