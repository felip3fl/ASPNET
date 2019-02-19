using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using Aula07_Model.Models; //ADD

namespace Aula07_Model.Controllers
{
    public class ClienteController : Controller
    {
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

            return View();
        }
    }
} 