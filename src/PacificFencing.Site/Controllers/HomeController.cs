using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using PacificFencing.Core;

namespace PacificFencing.Site.Controllers
{
    public class HomeController : Controller
    {
        public ActionResult Index()
        {
            return View();
        }

        [HttpPost]
        public ActionResult Index(RequestAQuoteModel model)
        {
            if (ModelState.IsValid)
            {
                EmailUtility.SendEmail(model);
                return RedirectToAction("Confirmation");
            }
            return View(model);
        }

        public ActionResult Confirmation()
        {
            return View();
        }
    }
}