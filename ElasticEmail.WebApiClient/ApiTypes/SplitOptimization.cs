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
    public enum SplitOptimization : Int32
    {
        /// <summary>
        /// Number of opened messages
        /// </summary>
        Opened = 0,

        /// <summary>
        /// Number of clicked messages
        /// </summary>
        Clicked = 1,

    }
}
