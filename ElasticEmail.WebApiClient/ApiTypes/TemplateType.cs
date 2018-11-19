using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ElasticEmail.WebApiClient.ApiTypes
{
    /// <summary>
    /// 
    /// </summary>
    public enum TemplateType : Int32
    {
        /// <summary>
        /// Template supports any valid HTML
        /// </summary>
        RawHTML = 0,

        /// <summary>
        /// Template is created and can only be modified in drag and drop editor
        /// </summary>
        DragDropEditor = 1,

    }
}
