using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ElasticEmail.WebApiClient.ApiTypes
{

    /// <summary>
    /// </summary>
    public enum MessageCategory : Int32
    {
        /// <summary>
        /// 
        /// </summary>
        Unknown = 0,

        /// <summary>
        /// 
        /// </summary>
        Ignore = 1,

        /// <summary>
        /// Number of messages marked as SPAM
        /// </summary>
        Spam = 2,

        /// <summary>
        /// Number of blacklisted messages
        /// </summary>
        BlackListed = 3,

        /// <summary>
        /// Number of messages flagged with 'No Mailbox'
        /// </summary>
        NoMailbox = 4,

        /// <summary>
        /// Number of messages flagged with 'Grey Listed'
        /// </summary>
        GreyListed = 5,

        /// <summary>
        /// Number of messages flagged with 'Throttled'
        /// </summary>
        Throttled = 6,

        /// <summary>
        /// Number of messages flagged with 'Timeout'
        /// </summary>
        Timeout = 7,

        /// <summary>
        /// Number of messages flagged with 'Connection Problem'
        /// </summary>
        ConnectionProblem = 8,

        /// <summary>
        /// Number of messages flagged with 'SPF Problem'
        /// </summary>
        SPFProblem = 9,

        /// <summary>
        /// Number of messages flagged with 'Account Problem'
        /// </summary>
        AccountProblem = 10,

        /// <summary>
        /// Number of messages flagged with 'DNS Problem'
        /// </summary>
        DNSProblem = 11,

        /// <summary>
        /// 
        /// </summary>
        NotDeliveredCancelled = 12,

        /// <summary>
        /// Number of messages flagged with 'Code Error'
        /// </summary>
        CodeError = 13,

        /// <summary>
        /// Number of manually cancelled messages
        /// </summary>
        ManualCancel = 14,

        /// <summary>
        /// Number of messages flagged with 'Connection terminated'
        /// </summary>
        ConnectionTerminated = 15,

        /// <summary>
        /// Number of messages flagged with 'Not Delivered'
        /// </summary>
        NotDelivered = 16,

    }
}
