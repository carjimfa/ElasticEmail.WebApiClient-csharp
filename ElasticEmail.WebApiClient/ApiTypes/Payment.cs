﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ElasticEmail.WebApiClient.ApiTypes
{

    /// <summary>
    /// Detailed information about existing money transfers.
    /// </summary>
    public class Payment
    {
        /// <summary>
        /// Date in YYYY-MM-DDThh:ii:ss format
        /// </summary>
        public DateTime Date { get; set; }

        /// <summary>
        /// Amount of money in transaction
        /// </summary>
        public decimal Amount { get; set; }

        /// <summary>
        /// Source of URL of payment
        /// </summary>
        public string Source { get; set; }

    }
}
