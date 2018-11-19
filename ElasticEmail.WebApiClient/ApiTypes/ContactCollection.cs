using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ElasticEmail.WebApiClient.ApiTypes
{
    /// <summary>
    /// Collection of lists and segments
    /// </summary>
    public class ContactCollection
    {
        /// <summary>
        /// Lists which contain the requested contact
        /// </summary>
        public List<ApiTypes.ContactContainer> Lists { get; set; }

        /// <summary>
        /// Segments which contain the requested contact
        /// </summary>
        public List<ApiTypes.ContactContainer> Segments { get; set; }

    }
}
