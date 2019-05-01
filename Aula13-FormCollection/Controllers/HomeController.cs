using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Aula13_FormCollection.Controllers
{
    public class HomeController : Controller
    {
        // GET: Home
        public ActionResult Index()
        {
            return View();
        }

        [HttpPost]
        public ActionResult Index(FormCollection formulario)
        {
            foreach (string chave in formulario)
            {
                Response.Write("Chave = " + chave + " ");
                Response.Write("Valor = " + formulario[chave]);
                Response.Write("<br/>");
            }
            return View();
        }
    }
}