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
        public ActionResult Create()
        {
            return View();
        }

        //[HttpPost]
        //public ActionResult Create(FormCollection formulario)
        //{

        //    //Incluir informações postadas
        //    Aluno aluno = new Aluno();
        //    aluno.Nome = formulario["Nome"];
        //    aluno.Email = formulario["Email"];
        //    aluno.Idade = Convert.ToInt32(formulario["Idade"]);
        //    aluno.DataInscricao = Convert.ToDateTime(formulario["DataInscricao"]);
        //    aluno.Sexo = formulario["Sexo"];

        //    AlunoBLL alunoBLL = new AlunoBLL();
        //    alunoBLL.IncluirAluno(aluno);

        //    return RedirectToAction("Index");
        //}

        #region Recebendo dados atraves da URL
        [HttpPost]
        public ActionResult Create(string nome, string email, int idade, DateTime dataInscricao, string sexo)
        {


            Aluno aluno = new Aluno();
            aluno.Nome = nome;
            aluno.Email = email;
            aluno.Idade = Convert.ToInt32(idade);
            aluno.DataInscricao = Convert.ToDateTime(dataInscricao);
            aluno.Sexo = sexo;

            AlunoBLL alunoBLL = new AlunoBLL();
            alunoBLL.IncluirAluno(aluno);

            return RedirectToAction("Index");
        }
        #endregion


    }
}