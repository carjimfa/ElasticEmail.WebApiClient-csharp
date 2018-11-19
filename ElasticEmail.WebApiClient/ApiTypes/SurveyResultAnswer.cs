using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ElasticEmail.WebApiClient.ApiTypes
{

    /// <summary>
    /// </summary>
    public class SurveyResultsAnswer
    {
        /// <summary>
        /// Identifier of the answer of the step
        /// </summary>
        public string SurveyStepAnswerID { get; set; }

        /// <summary>
        /// Number of items.
        /// </summary>
        public int Count { get; set; }

        /// <summary>
        /// Answer's content
        /// </summary>
        public string Content { get; set; }

    }
}
