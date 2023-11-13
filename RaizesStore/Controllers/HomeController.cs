using RaizesStore.DataAcces;
using RaizesStore.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace RaizesStore.Controllers
{
    public class HomeController : BaseActionResult
    {
        public ActionResult Index()
        {
            List<ServicesViewModel> list = _services;
            IndexSharedViewModel model = new IndexSharedViewModel { 
                services = list            
            }; 
            return View(model);
        }

        public ActionResult About()
        {
            ViewBag.Message = "Your application description page.";

            return View();
        }
        [HttpPost]
        public ActionResult SendMail(IndexSharedViewModel model)
        {
            return View();
        }
        [HttpPost]
        public ActionResult Login(IndexSharedViewModel model)
        {
            return View();
        }

        [HttpPost]
        public ActionResult Register(IndexSharedViewModel model)
        {
            return View();
        }

    }
}