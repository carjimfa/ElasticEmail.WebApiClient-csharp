using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ElasticEmail.WebApiClient.ApiTypes
{

    /// <summary>
    /// </summary>
    public enum QuestionType : Int32
    {
        /// <summary>
        /// 
        /// </summary>
        RadioButtons = 1,

        /// <summary>
        /// 
        /// </summary>
        DropdownMenu = 2,

        /// <summary>
        /// 
        /// </summary>
        Checkboxes = 3,

        /// <summary>
        /// 
        /// </summary>
        LongAnswer = 4,

        /// <summary>
        /// 
        /// </summary>
        Textbox = 5,

        /// <summary>
        /// Date in YYYY-MM-DDThh:ii:ss format
        /// </summary>
        Date = 6,

    }
}
