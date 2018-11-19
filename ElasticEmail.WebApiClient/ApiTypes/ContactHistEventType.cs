using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ElasticEmail.WebApiClient.ApiTypes
{

    /// <summary>
    /// </summary>
    public enum ContactHistEventType : Int32
    {
        /// <summary>
        /// Contact opened an e-mail
        /// </summary>
        Opened = 2,

        /// <summary>
        /// Contact clicked an e-mail
        /// </summary>
        Clicked = 3,

        /// <summary>
        /// E-mail sent to the contact bounced
        /// </summary>
        Bounced = 10,

        /// <summary>
        /// Contact unsubscribed
        /// </summary>
        Unsubscribed = 11,

        /// <summary>
        /// Contact complained to an e-mail
        /// </summary>
        Complained = 12,

        /// <summary>
        /// Contact clicked an activation link
        /// </summary>
        Activated = 20,

        /// <summary>
        /// Contact has opted to receive Transactional-only e-mails
        /// </summary>
        TransactionalUnsubscribed = 21,

        /// <summary>
        /// Contact's status was changed manually
        /// </summary>
        ManualStatusChange = 22,

        /// <summary>
        /// An Activation e-mail was sent
        /// </summary>
        ActivationSent = 24,

        /// <summary>
        /// Contact was deleted
        /// </summary>
        Deleted = 28,

    }
}
