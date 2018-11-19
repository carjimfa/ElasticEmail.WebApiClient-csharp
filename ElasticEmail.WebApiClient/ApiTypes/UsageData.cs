using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ElasticEmail.WebApiClient.ApiTypes
{

    /// <summary>
    /// Detailed data about daily usage
    /// </summary>
    public class UsageData
    {
        /// <summary>
        /// Date in YYYY-MM-DDThh:ii:ss format
        /// </summary>
        public DateTime Date { get; set; }

        /// <summary>
        /// Number of finished tasks
        /// </summary>
        public int JobCount { get; set; }

        /// <summary>
        /// Overall number of recipients
        /// </summary>
        public int RecipientCount { get; set; }

        /// <summary>
        /// Number of inbound emails
        /// </summary>
        public int InboundCount { get; set; }

        /// <summary>
        /// Number of attachments sent
        /// </summary>
        public int AttachmentCount { get; set; }

        /// <summary>
        /// Size of attachments sent
        /// </summary>
        public long AttachmentsSize { get; set; }

        /// <summary>
        /// Calculated cost of sending
        /// </summary>
        public decimal Cost { get; set; }

        /// <summary>
        /// Number of pricate IPs
        /// </summary>
        public int? PrivateIPCount { get; set; }

        /// <summary>
        /// 
        /// </summary>
        public decimal PrivateIPCost { get; set; }

        /// <summary>
        /// Number of SMS
        /// </summary>
        public int? SmsCount { get; set; }

        /// <summary>
        /// Overall cost of SMS
        /// </summary>
        public decimal SmsCost { get; set; }

        /// <summary>
        /// Cost of templates
        /// </summary>
        public decimal TemplateCost { get; set; }

        /// <summary>
        /// Cost of email credits
        /// </summary>
        public int? EmailCreditsCost { get; set; }

        /// <summary>
        /// Cost of template credit
        /// </summary>
        public int? TemplateCreditsCost { get; set; }

        /// <summary>
        /// Cost of litmus credits
        /// </summary>
        public decimal LitmusCost { get; set; }

        /// <summary>
        /// Cost of 1 litmus credit
        /// </summary>
        public decimal LitmusCreditsCost { get; set; }

        /// <summary>
        /// Daily cost of Contact Delivery Tools
        /// </summary>
        public decimal ContactCost { get; set; }

        /// <summary>
        /// Number of contacts
        /// </summary>
        public long ContactCount { get; set; }

        /// <summary>
        /// 
        /// </summary>
        public decimal SupportCost { get; set; }

        /// <summary>
        /// 
        /// </summary>
        public decimal EmailCost { get; set; }

    }
}
