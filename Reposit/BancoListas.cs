using MeetingsPets.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace MeetingsPets.Reposit
{
    public class BancoListas
    {
        public static IList<Logar> Alunos = new List<Logar>();
        public static IList<Pet> Pets = new List<Pet>();
        public static IList<Usuario> Usuarios = new List<Usuario>();
    }
}