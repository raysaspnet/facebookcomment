using FBComment.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace FBComment.Controllers
{
    public class HomeController : Controller
    {
        public ActionResult Index()
        {

            return View();
        }

        public ActionResult About()
        {
            ViewBag.Message = "Your application description page.";

            return View();
        }

        public ActionResult Contact()
        {
            ViewBag.Message = "Your contact page.";

            return View();
        }
        [HttpPost]
        public string Contact(HttpPostedFileBase file)
        {
            if (file != null && file.ContentLength > 0)
            {
                //var img = new BayImageClient();
                //return img.POSTBayImage(file, file.FileName);
            }
            return "";
        }
    }
}