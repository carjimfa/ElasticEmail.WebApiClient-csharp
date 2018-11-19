using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ElasticEmail.WebApiClient.ApiTypes
{

    /// <summary>
    /// Single step's answer object
    /// </summary>
    public class SurveyStepAnswer
    {
        /// <summary>
        /// Identifier of the answer of the step
        /// </summary>
        public string SurveyStepAnswerID { get; set; }

        /// <summary>
        /// Answer's content
        /// </summary>
        public string Content { get; set; }

        /// <summary>
        /// Sequence of the answers
        /// </summary>
        public int Sequence { get; set; }

    }
}
