using FluentValConversion.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace FluentValConversion.MVC.Controllers
{
    public class PersonController : Controller
    {
        public ActionResult Index()
        {
            return View();
        }

        public ActionResult Create()
        {
            return View();
        }

        [HttpPost]
        public ActionResult Create(Person person)
        {
            if(!ModelState.IsValid)
            {
                return View("Create", person);
            }

            TempData["notice"] = "Success";
            return RedirectToAction("Index");
        }
    }
}