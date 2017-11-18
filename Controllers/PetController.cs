using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace MeetingsPets.Controllers
{
    public class PetController : Controller
    {
        // GET: Pet
        public ActionResult CadPet()
        {
            return View();
        }
    }
}