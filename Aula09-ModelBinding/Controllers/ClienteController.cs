using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using Aula09_ModelBinding.Models;

namespace Aula09_ModelBinding.Controllers
{
    public class ClienteController : Controller
    {
        // GET: Cliente
        public ActionResult Index()
        {
            return View();
        }

        [HttpPost]
        public ActionResult Index(Cliente cliente)
        {
            //model binding vai criar uma instância de Cliente
            return View("ExibirDados", cliente);
        }

        public ActionResult ExibirDados(Cliente cliente)
        {
            return View(cliente);
        }

    }
}