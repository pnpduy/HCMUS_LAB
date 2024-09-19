using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Lab01_MVC.Controllers
{
    public class HomeController : Controller
    {
        public ActionResult Index()
        {
            string currentPath = Server.MapPath("~");
            if (string.IsNullOrEmpty(currentPath))
            {
                currentPath = "Error!";
            }
            else
            {
                currentPath = "Our Path Is: " + currentPath;
            }
            return View((object)currentPath);
        }

        public ActionResult login(string Message)
        {
            string myKnownQuerystring = Message;
            // This is what I call the mysterious "unknown" query string
            // It is not known because the Controller isn't capturing it
            string myUnknownQuerystring = Request.QueryString["MoreMessage"];
            return View((object)(Message + " - " +myUnknownQuerystring));
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
    }
}