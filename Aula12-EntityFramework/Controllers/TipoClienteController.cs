using Aula12_EntityFramework.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Aula12_EntityFramework.Controllers
{
    public class TipoClienteController : Controller
    {
        // GET: TipoCliente
        public ActionResult Index()
        {
            using (ClienteContext clienteContext = new ClienteContext())
            {
                List<Tipo> tiposCliente = clienteContext.Tipos.ToList();
                return View(tiposCliente);
            }
        }
    }
}