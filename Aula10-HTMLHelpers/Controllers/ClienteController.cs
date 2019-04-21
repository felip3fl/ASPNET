using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using Aula10_HTMLHelpers.Models;

namespace Aula10_HTMLHelpers.Controllers
{
    public class ClienteController : Controller
    {

        public ActionResult index()
        {
            return View(); 
        }

        // GET: Cliente
        public ActionResult Detalhe()
        {
            //Logica de acesso aos dados usando entidades
            //ado .net , entity framework, NHibernate

            Cliente cliente = new Cliente()
            {
                CliendId = 200,
                Nome = "Felipe",
                Email = "felip3.fl@gmail.com",
                Telefone = "11 6666-6666"
            };

            return View(cliente);
        }

        [HttpPost]
        public ActionResult SalvarCliente(Cliente cli)
        {
            //Outra forma que pode ser feita para pegar os dados no ActionResult
            //public ActionResult SalvarCliente(int CliendId, string Nome, string Email, string telefone)

            return null;
        }
    }
}