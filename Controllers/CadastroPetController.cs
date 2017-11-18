using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace MeetingsPets.Controllers
{
    public class CadastroPetController : Controller
    {
        // GET: CadastroPet
        public ActionResult CadPet()
        {
            ViewBag.Message = "cadastro Pets";
            return View();
        }
    }
}