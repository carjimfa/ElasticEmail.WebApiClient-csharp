using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ElasticEmail.WebApiClient.ApiTypes
{
    /// <summary>
    /// 
    /// </summary>
    public class CampaignTemplate
    {
        /// <summary>
        /// ID number of selected Channel.
        /// </summary>
        public int? ChannelID { get; set; }

        /// <summary>
        /// Name of campaign's status
        /// </summary>
        public ApiTypes.CampaignStatus Status { get; set; }

        /// <summary>
        /// Name of your custom IP Pool to be used in the sending process
        /// </summary>
        public string PoolName { get; set; }

        /// <summary>
        /// ID number of template.
        /// </summary>
        public int? TemplateID { get; set; }

        /// <summary>
        /// Default subject of email.
        /// </summary>
        public string TemplateSubject { get; set; }

        /// <summary>
        /// Default From: email address.
        /// </summary>
        public string TemplateFromEmail { get; set; }

        /// <summary>
        /// Default From: name.
        /// </summary>
        public string TemplateFromName { get; set; }

        /// <summary>
        /// Default Reply: email address.
        /// </summary>
        public string TemplateReplyEmail { get; set; }

        /// <summary>
        /// Default Reply: name.
        /// </summary>
        public string TemplateReplyName { get; set; }

    }
}
