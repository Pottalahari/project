using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Web;
using System.Web.Mvc;

namespace project.Controllers
{
    public class HomeController : Controller
    {
        

        public ActionResult Index()
        {
            return View();
        }

        //public ActionResult About()
        //{
        //    ViewBag.Message = "Your application description page.";

        //    return View();
        //}

        //public ActionResult Contact()
        //{
        //    ViewBag.Message = "Your contact page.";

        //    return View();
        //}
        public ActionResult Project()
        {
            return View();
        }
        public ActionResult Role()
        {
            return View();
        }
        public ActionResult Task()
        {
            return View();
        }
        public ActionResult Login()
        {
            return View();
        }
        public ActionResult Register()
        {
            return View();
        }
        public ActionResult AssignTask()
        {
            return View();
        }
        public ActionResult UpdateTask()
        {
            return View();
        }
        public ActionResult ProjecManagement()
        {
            return View();
        }

    }
}