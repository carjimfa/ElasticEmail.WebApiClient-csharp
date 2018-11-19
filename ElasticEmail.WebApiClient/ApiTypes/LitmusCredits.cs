using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ElasticEmail.WebApiClient.ApiTypes
{

    /// <summary>
    /// Detailed information about litmus credits
    /// </summary>
    public class LitmusCredits
    {
        /// <summary>
        /// Date in YYYY-MM-DDThh:ii:ss format
        /// </summary>
        public DateTime Date { get; set; }

        /// <summary>
        /// Amount of money in transaction
        /// </summary>
        public decimal Amount { get; set; }

    }
}
