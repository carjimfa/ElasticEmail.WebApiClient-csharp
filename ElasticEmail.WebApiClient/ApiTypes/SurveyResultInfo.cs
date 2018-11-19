using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ElasticEmail.WebApiClient.ApiTypes
{
    /// <summary>
    /// Single answer's data with user's specific info
    /// </summary>
    public class SurveyResultInfo
    {
        /// <summary>
        /// Identifier of the result
        /// </summary>
        public string SurveyResultID { get; set; }

        /// <summary>
        /// IP address
        /// </summary>
        public string CreatedFromIP { get; set; }

        /// <summary>
        /// Completion date
        /// </summary>
        public DateTime DateCompleted { get; set; }

        /// <summary>
        /// Start date
        /// </summary>
        public DateTime DateStart { get; set; }

        /// <summary>
        /// Answers for the survey
        /// </summary>
        public List<ApiTypes.SurveyResultAnswerInfo> SurveyResultAnswers { get; set; }

    }
}
