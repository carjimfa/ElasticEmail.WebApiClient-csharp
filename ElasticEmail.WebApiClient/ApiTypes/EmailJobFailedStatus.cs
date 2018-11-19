using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ElasticEmail.WebApiClient.ApiTypes
{
    /// <summary>
    /// </summary>
    public class EmailJobFailedStatus
    {
        /// <summary>
        /// 
        /// </summary>
        public string Address { get; set; }

        /// <summary>
        /// 
        /// </summary>
        public string Error { get; set; }

        /// <summary>
        /// RFC Error code
        /// </summary>
        public int ErrorCode { get; set; }

        /// <summary>
        /// 
        /// </summary>
        public string Category { get; set; }

    }
}
