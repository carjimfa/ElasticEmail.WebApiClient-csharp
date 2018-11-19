using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ElasticEmail.WebApiClient.ApiTypes
{
    /// <summary>
    /// A survey object
    /// </summary>
    public class Survey
    {
        /// <summary>
        /// Survey identifier
        /// </summary>
        public Guid PublicSurveyID { get; set; }

        /// <summary>
        /// Creation date.
        /// </summary>
        public DateTime DateCreated { get; set; }

        /// <summary>
        /// Last change date
        /// </summary>
        public DateTime? DateUpdated { get; set; }

        /// <summary>
        /// 
        /// </summary>
        public DateTime? ExpiryDate { get; set; }

        /// <summary>
        /// Filename
        /// </summary>
        public string Name { get; set; }

        /// <summary>
        /// Activate, delete, or pause your survey
        /// </summary>
        public ApiTypes.SurveyStatus Status { get; set; }

        /// <summary>
        /// Number of results count
        /// </summary>
        public int ResultCount { get; set; }

        /// <summary>
        /// 
        /// </summary>
        public List<ApiTypes.SurveyStep> SurveySteps { get; set; }

        /// <summary>
        /// URL of the survey
        /// </summary>
        public string SurveyLink { get; set; }

    }
}
