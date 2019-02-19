using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Aula_05___Aplicacao_MVC_Conceitos.Controllers
{
    public class HomeController : Controller
    {
        // GET: Home
        public String Index()
        {
            return "Olá mundo";
        }

        public string Inicio()
        {
            return "Teste com um segundo metodo";
        }

        public string Saudacao(int id)
        {
            return "Código recebido da url = " + id.ToString();
        }

    }
}