﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace MeetingsPets.Controllers
{
    public class UsuarioController : Controller
    {
        // GET: Usuario
        public ActionResult CadUsuario()
        {
            ViewBag.Message = "Cadastro de Usuários";
            return View();
        }

        public ActionResult Logar()
        {
            return View();
        }
    }
}