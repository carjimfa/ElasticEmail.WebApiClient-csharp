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
    public enum SendingPermission : Int32
    {
        /// <summary>
        /// Sending not allowed.
        /// </summary>
        None = 0,

        /// <summary>
        /// Allow sending via SMTP only.
        /// </summary>
        Smtp = 1,

        /// <summary>
        /// Allow sending via HTTP API only.
        /// </summary>
        HttpApi = 2,

        /// <summary>
        /// Allow sending via SMTP and HTTP API.
        /// </summary>
        SmtpAndHttpApi = 3,

        /// <summary>
        /// Allow sending via the website interface only.
        /// </summary>
        Interface = 4,

        /// <summary>
        /// Allow sending via SMTP and the website interface.
        /// </summary>
        SmtpAndInterface = 5,

        /// <summary>
        /// Allow sendnig via HTTP API and the website interface.
        /// </summary>
        HttpApiAndInterface = 6,

        /// <summary>
        /// Use access level sending permission.
        /// </summary>
        UseAccessLevel = 16,

        /// <summary>
        /// Sending allowed via SMTP, HTTP API and the website interface.
        /// </summary>
        All = 255,

    }
}
