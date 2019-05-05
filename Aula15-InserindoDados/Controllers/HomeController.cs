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

        // GET
        [ActionName("Create")] //para qual Action o post da View vai procurar
        public ActionResult Create_Get()
        {
            return View();
        }

        [HttpPost]
        [ActionName("Create")] //para qual Action o post da View vai procurar
        public ActionResult Create_Post(Aluno aluno)
        {
            if (ModelState.IsValid)
            {
                AlunoBLL alunobll = new AlunoBLL();
                alunobll.IncluirAluno(aluno);
                return RedirectToAction("Index");
            }
            return View();
        }

        //GET
        public ActionResult Edit(int id)
        {
            AlunoBLL alunoBLL = new AlunoBLL();
            Aluno aluno = alunoBLL.getAlunos().Single(x => x.Id == id);

            return View(aluno);
        }

        [HttpPost]
        [ActionName("Edit")]
        public ActionResult Edit_Post([Bind(Exclude ="Nome")]Aluno aluno)
        {
            AlunoBLL alunobll = new AlunoBLL();

            //bucando o nome, já que no Bind não retorna o NOME
            aluno.Nome = alunobll.getAlunos().Single(x => x.Id == aluno.Id).Nome;

            if (ModelState.IsValid)
            {
                alunobll.AtualizarAluno(aluno);
                return RedirectToAction("Index");
            }
            return View(aluno);
        }

        public ActionResult Delete(int id)
        {
            AlunoBLL alunoBLL = new AlunoBLL();
            //alunoBLL.DeletarAluno(id);
            //return RedirectToAction("Index");

            Aluno aluno = alunoBLL.getAlunos().Single(x => x.Id == id);
            return View(aluno);
        }

        [HttpPost]
        public ActionResult Delete(Aluno aluno)
        {
            if (ModelState.IsValid)
            {
                AlunoBLL alunobll = new AlunoBLL();
                alunobll.DeletarAluno(aluno.Id);
                return RedirectToAction("Index");
            }
            return View(aluno);
        }

    }
}