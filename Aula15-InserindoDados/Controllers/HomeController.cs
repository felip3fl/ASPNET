using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using Aula15_InserindoDados_BLL;

namespace Aula15_InserindoDados.Controllers
{
    public class HomeController : Controller
    {
        // GET: Home
        public ActionResult Index()
        {
            //criei uma instância da classe AlunoBLL
            AlunoBLL _aluno = new AlunoBLL();

            //estou usando o método getAlunos e retornando uma lista de alunos
            List<Aluno> alunos = _aluno.getAlunos().ToList();

            //passando para view
            return View(alunos);
        }
    }
}