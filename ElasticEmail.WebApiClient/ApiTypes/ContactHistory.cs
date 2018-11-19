using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ElasticEmail.WebApiClient.ApiTypes
{
    /// <summary>
    /// History of chosen Contact
    /// </summary>
    public class ContactHistory
    {
        /// <summary>
        /// ID of history of selected Contact.
        /// </summary>
        public long ContactHistoryID { get; set; }

        /// <summary>
        /// Type of event occured on this Contact.
        /// </summary>
        public string EventType { get; set; }

        /// <summary>
        /// Numeric code of event occured on this Contact.
        /// </summary>
        public ApiTypes.ContactHistEventType EventTypeValue { get; set; }

        /// <summary>
        /// Formatted date of event.
        /// </summary>
        public string EventDate { get; set; }

        /// <summary>
        /// Name of selected channel.
        /// </summary>
        public string ChannelName { get; set; }

        /// <summary>
        /// Name of template.
        /// </summary>
        public string TemplateName { get; set; }

        /// <summary>
        /// IP Address of the event.
        /// </summary>
        public string IPAddress { get; set; }

        /// <summary>
        /// Country of the event.
        /// </summary>
        public string Country { get; set; }

        /// <summary>
        /// Information about the event
        /// </summary>
        public string Data { get; set; }

    }
}
