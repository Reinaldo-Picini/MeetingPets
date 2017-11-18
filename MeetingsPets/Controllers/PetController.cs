using MeetingsPets.Models;
using MeetingsPets.Repositorio;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace MeetingsPets.Controllers
{
    public class CadastroController : Controller
    {
        // GET: Cadastro
        public ActionResult Index()
        {
            return View();
        }

        public ActionResult Listar()
        {


            IList<Pets> ListaDePets = Banco.Pets;
            return View(ListaDePets);
        }

        public ActionResult Novo()
        {
            return View(new Pets());
        }

        [HttpPost]
        public ActionResult Novo(Pets objPets)
        {
            if (ModelState.IsValid)
            {

                Random p = new Random();
                objPets.PetId = p.Next(1, 99999);
                Banco.Pets.Add(objPets);


                TempData["Mensagem"] = "Gravado com sucesso";

                return RedirectToAction("Listar");
            }
            ViewBag.Mensagem = "Preencha os campos obrigatorios";
            return View(objPets);
        }

        public ActionResult Alterar(int id) // esse id e o da rota, para aparecer na url
        {
            Pets pets = Banco.Pets.First(p => p.PetId == id); // esse id  e a mesma coisa
            return View(pets);
        }


        [HttpPost]
        public ActionResult Alterar(Pets objPet)
        {
            if (ModelState.IsValid)
            {

                //buscar o objeto no banco para poder alterar
                Pets petDoBanco = Banco.Pets.First(p => p.PetId == objPet.PetId);

                //colocando os valos que chegou no objeto novo no objeto que esta no banco

                petDoBanco.NomedoPet = objPet.NomedoPet;
                petDoBanco.Raca = objPet.Raca;
                petDoBanco.Idade = objPet.Idade;
                petDoBanco.Sexo = objPet.Sexo;
                petDoBanco.NomeDono = objPet.NomeDono;
                petDoBanco.Endereco = objPet.Endereco;

                return RedirectToAction("Listar");

            }

            TempData["Mensagem"] = "Preencher todos os campos obrigatirio.";
            return View(objPet);


        }





        public ActionResult Apagar(int id)
        {
            Pets objPets = Banco.Pets.First(p => p.PetId == id);
            return View(objPets);
        }

        [HttpPost]
        public ActionResult Apagar(Pets objPets)
        {
            Pets petBanco = Banco.Pets.First(p => p.PetId == objPets.PetId);

            Banco.Pets.Remove(petBanco);

            return RedirectToAction("Listar");

        }

    }
}