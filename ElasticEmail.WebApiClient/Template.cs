using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ElasticEmail.WebApiClient
{

    /// <summary>
    /// Template
    /// </summary>
    public class Template
    {
        /// <summary>
        /// ID number of template.
        /// </summary>
        public int TemplateID { get; set; }

        /// <summary>
        /// 0 for API connections
        /// </summary>
        public ApiTypes.TemplateType TemplateType { get; set; }

        /// <summary>
        /// Filename
        /// </summary>
        public string Name { get; set; }

        /// <summary>
        /// Date of creation in YYYY-MM-DDThh:ii:ss format
        /// </summary>
        public DateTime DateAdded { get; set; }

        /// <summary>
        /// CSS style
        /// </summary>
        public string Css { get; set; }

        /// <summary>
        /// Default subject of email.
        /// </summary>
        public string Subject { get; set; }

        /// <summary>
        /// Default From: email address.
        /// </summary>
        public string FromEmail { get; set; }

        /// <summary>
        /// Default From: name.
        /// </summary>
        public string FromName { get; set; }

        /// <summary>
        /// HTML code of email (needs escaping).
        /// </summary>
        public string BodyHtml { get; set; }

        /// <summary>
        /// Text body of email.
        /// </summary>
        public string BodyText { get; set; }

        /// <summary>
        /// ID number of original template.
        /// </summary>
        public int OriginalTemplateID { get; set; }

        /// <summary>
        /// Enum: 0 - private, 1 - public, 2 - mockup
        /// </summary>
        public ApiTypes.TemplateScope TemplateScope { get; set; }

    }
}
