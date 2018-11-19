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
    public enum CampaignTriggerType : Int32
    {
        /// <summary>
        /// 
        /// </summary>
        SendNow = 1,

        /// <summary>
        /// 
        /// </summary>
        FutureScheduled = 2,

        /// <summary>
        /// 
        /// </summary>
        OnAdd = 3,

        /// <summary>
        /// 
        /// </summary>
        OnOpen = 4,

        /// <summary>
        /// 
        /// </summary>
        OnClick = 5,

    }
}
