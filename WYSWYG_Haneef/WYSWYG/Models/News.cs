using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace WYSWYG.Models
    {
    public class News
        {
            public string Title { get; set; }
            [AllowHtml]
            public string Content { get; set; }
            
        }
    }



