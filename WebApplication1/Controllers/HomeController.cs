using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace WebApplication1.Controllers
{
    public class HomeController : Controller
    {
        // GET: Home
        public ActionResult Index()
        {
            return View();
        }
        public ActionResult Math(int nr1, int nr2)
        {
            var result1 = nr1 + nr2;
            var data = new { status = "ok", result = "result1"};

            return Json(data,JsonRequestBehavior.AllowGet);
        }

    }
}