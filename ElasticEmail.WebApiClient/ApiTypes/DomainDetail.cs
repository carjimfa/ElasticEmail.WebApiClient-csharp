using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ElasticEmail.WebApiClient.ApiTypes
{

    /// <summary>
    /// Domain data, with information about domain records.
    /// </summary>
    public class DomainDetail
    {
        /// <summary>
        /// Name of selected domain.
        /// </summary>
        public string Domain { get; set; }

        /// <summary>
        /// True, if domain is used as default. Otherwise, false,
        /// </summary>
        public bool DefaultDomain { get; set; }

        /// <summary>
        /// True, if SPF record is verified
        /// </summary>
        public bool Spf { get; set; }

        /// <summary>
        /// True, if DKIM record is verified
        /// </summary>
        public bool Dkim { get; set; }

        /// <summary>
        /// True, if MX record is verified
        /// </summary>
        public bool MX { get; set; }

        /// <summary>
        /// 
        /// </summary>
        public bool DMARC { get; set; }

        /// <summary>
        /// True, if tracking CNAME record is verified
        /// </summary>
        public bool IsRewriteDomainValid { get; set; }

        /// <summary>
        /// True, if verification is available
        /// </summary>
        public bool Verify { get; set; }

        /// <summary>
        /// 
        /// </summary>
        public ApiTypes.TrackingType Type { get; set; }

        /// <summary>
        /// 0 - NotValidated, 1 - Validated successfully, 2 - Invalid, 3 - Broken (tracking was frequnetly verfied in given period and still is invalid). For statuses: 0, 1, 3 tracking will be verified in normal periods. For status 2 tracking will be verified in high frequent periods.
        /// </summary>
        public ApiTypes.TrackingValidationStatus TrackingStatus { get; set; }

        /// <summary>
        /// </summary>
        public ApiTypes.CertificateValidationStatus CertificateStatus { get; set; }

        /// <summary>
        /// </summary>
        public string CertificateValidationError { get; set; }

        /// <summary>
        /// </summary>
        public ApiTypes.TrackingType? TrackingTypeUserRequest { get; set; }

    }
}
