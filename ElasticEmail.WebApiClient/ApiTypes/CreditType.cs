using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ElasticEmail.WebApiClient.ApiTypes
{

    /// <summary>
    /// Type of credits
    /// </summary>
    public enum CreditType : Int32
    {
        /// <summary>
        /// Used to send emails.  One credit = one email.
        /// </summary>
        Email = 9,

        /// <summary>
        /// Used to run a litmus test on a template.  1 credit = 1 test.
        /// </summary>
        Litmus = 11,

    }
}
