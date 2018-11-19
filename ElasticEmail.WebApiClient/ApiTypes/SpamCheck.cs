using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ElasticEmail.WebApiClient.ApiTypes
{
    /// <summary>
    /// Spam check of specified message.
    /// </summary>
    public class SpamCheck
    {
        /// <summary>
        /// Total spam score from
        /// </summary>
        public string TotalScore { get; set; }

        /// <summary>
        /// Date in YYYY-MM-DDThh:ii:ss format
        /// </summary>
        public string Date { get; set; }

        /// <summary>
        /// Default subject of email.
        /// </summary>
        public string Subject { get; set; }

        /// <summary>
        /// Default From: email address.
        /// </summary>
        public string FromEmail { get; set; }

        /// <summary>
        /// ID number of selected message.
        /// </summary>
        public string MsgID { get; set; }

        /// <summary>
        /// Name of selected channel.
        /// </summary>
        public string ChannelName { get; set; }

        /// <summary>
        /// 
        /// </summary>
        public List<ApiTypes.SpamRule> Rules { get; set; }

    }
}
