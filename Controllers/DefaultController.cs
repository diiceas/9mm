using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using System.IO;
using System.Net.Mail;
using System.Net;

namespace razor_9mm.Controllers
{
    public class DefaultController : Controller
    {   
        public DefaultController()
        { 
        }

        public ActionResult Index()
        {
            ViewBag.pageName = "Main";
            return View();
        }

        public ActionResult Audio()
        {
            ViewBag.pageName = "Audio";
            return View();
        }

        public ActionResult Video()
        {
            ViewBag.pageName = "Video";
            return View();
        }

        public ActionResult Info()
        {   
            ViewBag.pageName = "Info";
            return View();
        }

        public ActionResult News(int? skin = null)
        {
            ViewBag.pageName = "News";
            return View();
        }

        public ActionResult Gallery()
        {
            string[] files = System.IO.Directory.EnumerateFiles(Server.MapPath("~/Content/9mm_orig/")).Select(path => new FileInfo(path).Name).ToArray();
            ViewBag.files = files;
            ViewBag.pageName = "Gallery";
            return View();
        }
    }
}