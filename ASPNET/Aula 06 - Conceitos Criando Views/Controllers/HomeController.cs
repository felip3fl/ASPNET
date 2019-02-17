using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Aula_06___Conceitos_Criando_Views.Controllers
{
    public class HomeController : Controller
    {
        // GET: Home
        public ActionResult Index()
        {

            //USANDO VIEWDATA
            ViewData["Nome"] = "Felip3FL";            ViewData["Email"] = "felip3.fl@gmail.com";
            ViewData["Curso"] = "ASP .NET MVC";
            ViewData["DataInicio"] = new DateTime(2019, 02, 17);

            //USANDO VIEWBAG
            ViewBag.Nome = "Felip3FL";            ViewBag.Email = "felip3.fl@gmail.com";
            ViewBag.Curso = "ASP .NET MVC";
            ViewBag.DataInicio = new DateTime(2019, 02, 17);

            //RETORNAR UMA LISTA NO VIEWBAG
            ViewBag.Paises = new List<string>()
            {
                "Brasil",
                "Canada",
                "China",
                "US"
            };

            //RETORNAR UMA LISTA NO VIEWDATA
            ViewData["Paises"] = new List<string>()
            {
                "Brasil",
                "Canada",
                "China",
                "US"
            };

            return View();
        }


    }
}