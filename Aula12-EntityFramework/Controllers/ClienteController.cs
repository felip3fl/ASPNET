using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using Aula12_EntityFramework.Models;

namespace Aula12_EntityFramework.Controllers
{
    public class ClienteController : Controller
    {
        // GET: Cliente
        public ActionResult Index(int TipoId)
        {
            using(ClienteContext clienteContext = new ClienteContext())
            {
                List<Cliente> clientes = clienteContext.Clientes.Where(cli => cli.TipoId == TipoId).ToList();

                return View(clientes);
            }
        }

        public ActionResult Detalhes(int id)
        {
            using (ClienteContext clienteContext = new ClienteContext())
            {
                Cliente clientes = clienteContext.Clientes.Single(cli => cli.ClienteId == id);

                return View(clientes);
            }
        }
    }
}