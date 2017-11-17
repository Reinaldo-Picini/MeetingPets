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
        public static IList<CadastrarPet> Pets = new List<CadastrarPet>();
        public static IList<CadastrarUsuario> Usuarios = new List<CadastrarUsuario>();
    }
}