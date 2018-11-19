using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ElasticEmail.WebApiClient.ApiTypes
{

    /// <summary>
    /// </summary>
    public enum SurveyStepType : Int32
    {
        /// <summary>
        /// 
        /// </summary>
        PageBreak = 1,

        /// <summary>
        /// 
        /// </summary>
        Question = 2,

        /// <summary>
        /// 
        /// </summary>
        TextMedia = 3,

        /// <summary>
        /// 
        /// </summary>
        ConfirmationPage = 4,

        /// <summary>
        /// 
        /// </summary>
        ExpiredPage = 5,

    }
}
