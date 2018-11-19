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
    public enum ContactSource : Int32
    {
        /// <summary>
        /// Source of the contact is from sending an email via our SMTP or HTTP API's
        /// </summary>
        DeliveryApi = 0,

        /// <summary>
        /// Contact was manually entered from the interface.
        /// </summary>
        ManualInput = 1,

        /// <summary>
        /// Contact was uploaded via a file such as CSV.
        /// </summary>
        FileUpload = 2,

        /// <summary>
        /// Contact was added from a public web form.
        /// </summary>
        WebForm = 3,

        /// <summary>
        /// Contact was added from the contact api.
        /// </summary>
        ContactApi = 4,

    }
}
