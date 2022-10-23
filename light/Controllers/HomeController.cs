using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace light.Controllers
{
    public class HomeController : Controller
    {
        // GET: Home
        public ActionResult Index()
        {
            return View();
        }
        [Route("AdminPage")]
        public ActionResult AdminPage()
        {
            return View();
        }
        [Route("Login")]
        public ActionResult Login()
        {
            return View();
        }
        [Route("Register")]
        public ActionResult Register()
        {
            return View();
        }
    }
}