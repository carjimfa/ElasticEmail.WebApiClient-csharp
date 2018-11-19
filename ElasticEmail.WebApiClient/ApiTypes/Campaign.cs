using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ElasticEmail.WebApiClient.ApiTypes
{
    /// <summary>
    /// Campaign
    /// </summary>
    public class Campaign
    {
        /// <summary>
        /// ID number of selected Channel.
        /// </summary>
        public int? ChannelID { get; set; }

        /// <summary>
        /// Campaign's name
        /// </summary>
        public string Name { get; set; }

        /// <summary>
        /// Name of campaign's status
        /// </summary>
        public ApiTypes.CampaignStatus Status { get; set; }

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
        /// Should the opens be tracked? If no value has been provided, account's default setting will be used.
        /// </summary>
        public bool? TrackOpens { get; set; }

        /// <summary>
        /// Should the clicks be tracked? If no value has been provided, account's default setting will be used.
        /// </summary>
        public bool? TrackClicks { get; set; }

        /// <summary>
        /// 
        /// </summary>
        public List<ApiTypes.CampaignTemplate> CampaignTemplates { get; set; }

    }
}
