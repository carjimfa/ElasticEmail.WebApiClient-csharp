using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ElasticEmail.WebApiClient.ApiTypes
{
    /// <summary>
    /// Basic information about your profile
    /// </summary>
    public class Profile
    {
        /// <summary>
        /// First name.
        /// </summary>
        public string FirstName { get; set; }

        /// <summary>
        /// Last name.
        /// </summary>
        public string LastName { get; set; }

        /// <summary>
        /// Company name.
        /// </summary>
        public string Company { get; set; }

        /// <summary>
        /// First line of address.
        /// </summary>
        public string Address1 { get; set; }

        /// <summary>
        /// Second line of address.
        /// </summary>
        public string Address2 { get; set; }

        /// <summary>
        /// City.
        /// </summary>
        public string City { get; set; }

        /// <summary>
        /// State or province.
        /// </summary>
        public string State { get; set; }

        /// <summary>
        /// Zip/postal code.
        /// </summary>
        public string Zip { get; set; }

        /// <summary>
        /// Numeric ID of country. A file with the list of countries is available <a href="http://api.elasticemail.com/public/countries"><b>here</b></a>
        /// </summary>
        public int? CountryID { get; set; }

        /// <summary>
        /// Phone number
        /// </summary>
        public string Phone { get; set; }

        /// <summary>
        /// Proper email address.
        /// </summary>
        public string Email { get; set; }

        /// <summary>
        /// Code used for tax purposes.
        /// </summary>
        public string TaxCode { get; set; }

    }
}
