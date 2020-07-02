using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace WEB.Controllers
{
    public class AdminController : Controller
    {
        // GET: Admin
        public ActionResult Index()
        {
            return View();
        }
        public ActionResult Login()
        {
            return View();
        }
        [HttpPost]
        public ActionResult Login(FormCollection fc)
        {
            return RedirectToAction("Dashboard", "Admin");
        }
        public ActionResult Dashboard()
        {
            Session["View"] = "Dashboard";
            return View();
        }
        public ActionResult Product()
        {
            Session["View"] = "Product";
            return View();
        }
        public ActionResult ProductCate()
        {
            Session["View"] = "Other";
            return View();
        }
        public ActionResult ListUser()
        {
            Session["View"] = "ListUser";
            return View();
        }
        public ActionResult Manager()
        {
            Session["View"] = "Other";
            return View();
        }
        public ActionResult Chart()
        {
            Session["View"] = "Other";
            return View();
        }
        public ActionResult Order()
        {
            Session["View"] = "Order";
            return View();
        }
        public ActionResult Income()
        {
            Session["View"] = "Income";
            return View();
        }
    }
}