using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace CVApplication.Controllers
{
    public class CVController : Controller
    {
        // GET: CV
        [HttpGet]
        public ActionResult Index()
        {
            return View();
        }

        [HttpGet]
        public ActionResult Personal()
        {
            return View();
        }

        [HttpGet]
        public ActionResult Educational()
        {
            return View();
        }

        [HttpGet]
        public ActionResult Project()
        {
            return View();
        }

        [HttpGet]
        public ActionResult Reference()
        {
            return View();
        }
    }
}