using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ElasticEmail.WebApiClient.ApiTypes
{
    /// <summary>
    /// List of Lists, with detailed data about its contents.
    /// </summary>
    public class List
    {
        /// <summary>
        /// ID number of selected list.
        /// </summary>
        public int ListID { get; set; }

        /// <summary>
        /// Name of your list.
        /// </summary>
        public string ListName { get; set; }

        /// <summary>
        /// Number of items.
        /// </summary>
        public int Count { get; set; }

        /// <summary>
        /// ID code of list
        /// </summary>
        public Guid? PublicListID { get; set; }

        /// <summary>
        /// Date of creation in YYYY-MM-DDThh:ii:ss format
        /// </summary>
        public DateTime DateAdded { get; set; }

        /// <summary>
        /// True: Allow unsubscribing from this list. Otherwise, false
        /// </summary>
        public bool AllowUnsubscribe { get; set; }

        /// <summary>
        /// Query used for filtering.
        /// </summary>
        public string Rule { get; set; }

    }
}
