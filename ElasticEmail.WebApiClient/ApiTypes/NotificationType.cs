using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ElasticEmail.WebApiClient.ApiTypes
{

    /// <summary>
    /// </summary>
    public enum NotificationType : Int32
    {
        /// <summary>
        /// Both, email and web, notifications
        /// </summary>
        All = 0,

        /// <summary>
        /// Only email notifications
        /// </summary>
        Email = 1,

        /// <summary>
        /// Only web notifications
        /// </summary>
        Web = 2,

    }
}
