using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace MeetingsPets.Controllers
{
    public class PrincipalController : Controller
    {
        // GET: Inicial
        public ActionResult Principal()
        {
            ViewBag.Message = "MeetingsPets";
            return View();
        }

    }
}