using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace MeetingsPets.Controllers
{
    public class InicialController : Controller
    {
        // GET: Inicial
        public ActionResult Principal()
        {
            return View();
        }
        public ActionResult Index()
        {
            return View();
        }

    }
}