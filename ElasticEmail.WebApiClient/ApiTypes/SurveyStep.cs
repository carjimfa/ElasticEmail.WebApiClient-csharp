using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ElasticEmail.WebApiClient.ApiTypes
{
    /// <summary>
    /// Survey's single step info with the answers
    /// </summary>
    public class SurveyStep
    {
        /// <summary>
        /// Identifier of the step
        /// </summary>
        public int SurveyStepID { get; set; }

        /// <summary>
        /// Type of the step
        /// </summary>
        public ApiTypes.SurveyStepType SurveyStepType { get; set; }

        /// <summary>
        /// Type of the question
        /// </summary>
        public ApiTypes.QuestionType QuestionType { get; set; }

        /// <summary>
        /// Answer's content
        /// </summary>
        public string Content { get; set; }

        /// <summary>
        /// Is the answer required
        /// </summary>
        public bool Required { get; set; }

        /// <summary>
        /// Sequence of the answers
        /// </summary>
        public int Sequence { get; set; }

        /// <summary>
        /// 
        /// </summary>
        public List<ApiTypes.SurveyStepAnswer> SurveyStepAnswers { get; set; }

    }
}
