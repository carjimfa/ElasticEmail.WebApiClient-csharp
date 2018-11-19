using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ElasticEmail.WebApiClient.ApiTypes
{
    /// <summary>
    /// </summary>
    public class EmailSend
    {
        /// <summary>
        /// ID number of transaction
        /// </summary>
        public string TransactionID { get; set; }

        /// <summary>
        /// Unique identifier for this email.
        /// </summary>
        public string MessageID { get; set; }

    }
}
