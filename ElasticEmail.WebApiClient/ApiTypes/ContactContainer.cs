using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ElasticEmail.WebApiClient.ApiTypes
{

    /// <summary>
    /// List's or segment's short info
    /// </summary>
    public class ContactContainer
    {
        /// <summary>
        /// ID of the list/segment
        /// </summary>
        public int ID { get; set; }

        /// <summary>
        /// Name of the list/segment
        /// </summary>
        public string Name { get; set; }

    }
}
