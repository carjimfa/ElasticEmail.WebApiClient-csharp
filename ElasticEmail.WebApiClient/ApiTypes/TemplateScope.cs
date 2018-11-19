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
    public enum TemplateScope : Int32
    {
        /// <summary>
        /// Template is available for this account only.
        /// </summary>
        Private = 0,

        /// <summary>
        /// Template is available for this account and it's sub-accounts.
        /// </summary>
        Public = 1,

    }
}
