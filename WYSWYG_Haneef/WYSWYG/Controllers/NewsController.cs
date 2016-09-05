using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Web;
using System.Web.Mvc;
using WYSWYG.Models;

namespace WYSWYG.Controllers
{
    public class NewsController : Controller
    {
        //
        // GET: /News/
        public ActionResult Index()
        {
        News newscontent = new News();
         return View();
        }

        [HttpPost]
        public ActionResult Index(News model)
            {
        
            //save content

            //save title
            //save news content

            // note that system will save entire image in one field. You may need a big field length in db 
            //return RedirectToAction("NewsDisplay", new { Title = model.Title, Content = WebUtility.HtmlEncode(model.Content) });

            return View("NewsDisplay", model);
            }


	}
}