using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ElasticEmail.WebApiClient.ApiTypes
{
    /// <summary>
    /// Channel
    /// </summary>
    public class CampaignChannel
    {
        /// <summary>
        /// ID number of selected Channel.
        /// </summary>
        public int ChannelID { get; set; }

        /// <summary>
        /// Filename
        /// </summary>
        public string Name { get; set; }

        /// <summary>
        /// True, if you are sending a campaign. Otherwise, false.
        /// </summary>
        public bool IsCampaign { get; set; }

        /// <summary>
        /// Name of your custom IP Pool to be used in the sending process
        /// </summary>
        public string PoolName { get; set; }

        /// <summary>
        /// Date of creation in YYYY-MM-DDThh:ii:ss format
        /// </summary>
        public DateTime DateAdded { get; set; }

        /// <summary>
        /// Name of campaign's status
        /// </summary>
        public ApiTypes.CampaignStatus Status { get; set; }

        /// <summary>
        /// Date of last activity on account
        /// </summary>
        public DateTime? LastActivity { get; set; }

        /// <summary>
        /// Datetime of last action done on campaign.
        /// </summary>
        public DateTime? LastProcessed { get; set; }

        /// <summary>
        /// Id number of parent channel
        /// </summary>
        public int ParentChannelID { get; set; }

        /// <summary>
        /// List of Segment and List IDs, preceded with 'l' for Lists and 's' for Segments, comma separated
        /// </summary>
        public string[] Targets { get; set; }

        /// <summary>
        /// Number of event, triggering mail sending
        /// </summary>
        public ApiTypes.CampaignTriggerType TriggerType { get; set; }

        /// <summary>
        /// Date of triggered send
        /// </summary>
        public DateTime? TriggerDate { get; set; }

        /// <summary>
        /// How far into the future should the campaign be sent, in minutes
        /// </summary>
        public double TriggerDelay { get; set; }

        /// <summary>
        /// When your next automatic mail will be sent, in minutes
        /// </summary>
        public double TriggerFrequency { get; set; }

        /// <summary>
        /// How many times should the campaign be sent
        /// </summary>
        public int TriggerCount { get; set; }

        /// <summary>
        /// ID number of transaction
        /// </summary>
        public int TriggerChannelID { get; set; }

        /// <summary>
        /// Data for filtering event campaigns such as specific link addresses.
        /// </summary>
        public string TriggerData { get; set; }

        /// <summary>
        /// What should be checked for choosing the winner: opens or clicks
        /// </summary>
        public ApiTypes.SplitOptimization SplitOptimization { get; set; }

        /// <summary>
        /// Number of minutes between sends during optimization period
        /// </summary>
        public int SplitOptimizationMinutes { get; set; }

        /// <summary>
        /// 
        /// </summary>
        public int TimingOption { get; set; }

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

        /// <summary>
        /// Total emails clicked
        /// </summary>
        public int ClickedCount { get; set; }

        /// <summary>
        /// Total emails opened.
        /// </summary>
        public int OpenedCount { get; set; }

        /// <summary>
        /// Overall number of recipients
        /// </summary>
        public int RecipientCount { get; set; }

        /// <summary>
        /// Total emails sent.
        /// </summary>
        public int SentCount { get; set; }

        /// <summary>
        /// Total emails sent.
        /// </summary>
        public int FailedCount { get; set; }

        /// <summary>
        /// Total emails clicked
        /// </summary>
        public int UnsubscribedCount { get; set; }

        /// <summary>
        /// Abuses - mails sent to user without their consent
        /// </summary>
        public int FailedAbuse { get; set; }

        /// <summary>
        /// List of CampaignTemplate for sending A-X split testing.
        /// </summary>
        public List<ApiTypes.CampaignChannel> TemplateChannels { get; set; }

        /// <summary>
        /// Should the opens be tracked? If no value has been provided, account's default setting will be used.
        /// </summary>
        public bool? TrackOpens { get; set; }

        /// <summary>
        /// Should the clicks be tracked? If no value has been provided, account's default setting will be used.
        /// </summary>
        public bool? TrackClicks { get; set; }

    }
}
