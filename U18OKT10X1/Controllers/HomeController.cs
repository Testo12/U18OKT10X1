using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace U18OKT10X1.Controllers
{
    public class HomeController : Controller
    {
        // GET: Home
        public ActionResult Index()
        {
            return View();
        }

        [HttpGet]
        public ViewResult Register()
        {
            return View();
        }

        [HttpGet]
        public ViewResult Register2()
        {
            return View();
        }

        [HttpPost]
        public ViewResult Register(Models.RegisterInfo ri)
        {
            if (ModelState.IsValid == true)
            {
                return View("Sucess", ri);
            }
            else
            {
                return View();

            }
        }
    }
}