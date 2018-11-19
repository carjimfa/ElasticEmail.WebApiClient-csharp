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
    public enum SurveyStatus : Int32
    {
        /// <summary>
        /// The survey is deleted
        /// </summary>
        Deleted = -1,

        /// <summary>
        /// The survey is not receiving result for now
        /// </summary>
        Expired = 0,

        /// <summary>
        /// The survey is active and receiving answers
        /// </summary>
        Active = 1,

    }
}
