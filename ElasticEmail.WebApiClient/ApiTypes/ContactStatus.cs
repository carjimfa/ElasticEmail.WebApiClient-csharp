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
    public enum ContactStatus : Int32
    {
        /// <summary>
        /// Only transactional email can be sent to contacts with this status.
        /// </summary>
        Transactional = -2,

        /// <summary>
        /// Contact has had an open or click in the last 6 months.
        /// </summary>
        Engaged = -1,

        /// <summary>
        /// Contact is eligible to be sent to.
        /// </summary>
        Active = 0,

        /// <summary>
        /// Contact has had a hard bounce and is no longer eligible to be sent to.
        /// </summary>
        Bounced = 1,

        /// <summary>
        /// Contact has unsubscribed and is no longer eligible to be sent to.
        /// </summary>
        Unsubscribed = 2,

        /// <summary>
        /// Contact has complained and is no longer eligible to be sent to.
        /// </summary>
        Abuse = 3,

        /// <summary>
        /// Contact has not been activated or has been de-activated and is not eligible to be sent to.
        /// </summary>
        Inactive = 4,

        /// <summary>
        /// Contact has not been opening emails for a long period of time and is not eligible to be sent to.
        /// </summary>
        Stale = 5,

        /// <summary>
        /// Contact has not confirmed their double opt-in activation and is not eligible to be sent to.
        /// </summary>
        NotConfirmed = 6,

    }
}
