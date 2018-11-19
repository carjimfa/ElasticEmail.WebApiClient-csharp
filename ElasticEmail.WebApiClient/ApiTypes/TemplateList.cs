using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ElasticEmail.WebApiClient.ApiTypes
{
    /// <summary>
    /// List of templates (including drafts)
    /// </summary>
    public class TemplateList
    {
        /// <summary>
        /// List of templates
        /// </summary>
        public List<Template> Templates { get; set; }

        /// <summary>
        /// List of draft templates
        /// </summary>
        public List<Template> DraftTemplate { get; set; }

    }
}
