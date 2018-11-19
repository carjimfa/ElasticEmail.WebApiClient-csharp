using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ElasticEmail.WebApiClient.ApiTypes

        /// <summary>
        /// Encoding type for the email headers
        /// </summary>
public enum EncodingType : Int32
{
    /// <summary>
    /// Encoding of the email is provided by the sender and not altered.
    /// </summary>
    UserProvided = -1,

    /// <summary>
    /// No endcoding is set for the email.
    /// </summary>
    None = 0,

    /// <summary>
    /// Encoding of the email is in Raw7bit format.
    /// </summary>
    Raw7bit = 1,

    /// <summary>
    /// Encoding of the email is in Raw8bit format.
    /// </summary>
    Raw8bit = 2,

    /// <summary>
    /// Encoding of the email is in QuotedPrintable format.
    /// </summary>
    QuotedPrintable = 3,

    /// <summary>
    /// Encoding of the email is in Base64 format.
    /// </summary>
    Base64 = 4,

    /// <summary>
    /// Encoding of the email is in Uue format.
    /// </summary>
    Uue = 5,

}
}
