using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ElasticEmail.WebApiClient.ApiTypes
{

    /// <summary>
    /// Object with the single answer's data
    /// </summary>
    public class SurveyResultAnswerInfo
    {
        /// <summary>
        /// Answer's content
        /// </summary>
        public string content { get; set; }

        /// <summary>
        /// Identifier of the step
        /// </summary>
        public int surveystepid { get; set; }

        /// <summary>
        /// Identifier of the answer of the step
        /// </summary>
        public string surveystepanswerid { get; set; }

    }
}
