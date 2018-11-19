using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ElasticEmail.WebApiClient.ApiTypes
{
    /// <summary>
    /// Email details formatted in json
    /// </summary>
    public class EmailView
    {
        /// <summary>
        /// Body (text) of your message.
        /// </summary>
        public string Body { get; set; }

        /// <summary>
        /// Default subject of email.
        /// </summary>
        public string Subject { get; set; }

        /// <summary>
        /// Starting date for search in YYYY-MM-DDThh:mm:ss format.
        /// </summary>
        public string From { get; set; }

    }
}
