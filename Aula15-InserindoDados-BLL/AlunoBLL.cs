using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Configuration;
using System.Data.SqlClient;
using System.Data;

namespace Aula15_InserindoDados_BLL
{
    public class AlunoBLL
    {
        public IEnumerable<Aluno> getAlunos()
        {
            string connectionString =
                ConfigurationManager.ConnectionStrings["FelipeConexaoSQLServer"].ConnectionString;

            //lista de objeto tipo Aluno
            List<Aluno> alunos = new List<Aluno>();

            try
            {

                #region Retornando Lista de Alunos no banco de dados

                //using - o CON vai morrer quando acabar esse bloco
                using (SqlConnection con = new SqlConnection(connectionString))
                {
                    //GetAlunos é a minha procesure
                    SqlCommand cmd = new SqlCommand("GetAlunos", con);
                    cmd.CommandType = CommandType.StoredProcedure;
                    con.Open();
                    SqlDataReader rdr = cmd.ExecuteReader();

                    #region Preenchendo os dados do aluno no objeto
                    while (rdr.Read())
                    {
                        Aluno aluno = new Aluno();
                        aluno.Id = Convert.ToInt32(rdr["Id"]);
                        aluno.Nome = rdr["Nome"].ToString();
                        aluno.Email = rdr["Email"].ToString();
                        aluno.Idade = Convert.ToInt32(rdr["Idade"]);
                        aluno.DataInscricao = Convert.ToDateTime(rdr["DataInscricao"]);
                        aluno.Sexo = rdr["Sexo"].ToString();
                        alunos.Add(aluno);
                    }
                    #endregion

                }
                return alunos;

                #endregion

            }
            catch (Exception)
            {

                throw;
            }

        }

        public void IncluirAluno(Aluno aluno)
        {
            string connectionString = ConfigurationManager.ConnectionStrings["FelipeConexaoSQLServer"].ConnectionString;
            try
            {
                using (SqlConnection con = new SqlConnection(connectionString))
                {
                    SqlCommand cmd = new SqlCommand("IncluirAluno", con);
                    cmd.CommandType = CommandType.StoredProcedure;

                    SqlParameter paramNome = new SqlParameter();
                    paramNome.ParameterName = "@Nome";
                    paramNome.Value = aluno.Nome;
                    cmd.Parameters.Add(paramNome);

                    SqlParameter paramEmail = new SqlParameter();
                    paramEmail.ParameterName = "@Email";
                    paramEmail.Value = aluno.Email;
                    cmd.Parameters.Add(paramEmail);

                    SqlParameter paramIdade = new SqlParameter();
                    paramIdade.ParameterName = "@Idade";
                    paramIdade.Value = aluno.Idade;
                    cmd.Parameters.Add(paramIdade);

                    SqlParameter paramDataInscricao = new SqlParameter();
                    paramDataInscricao.ParameterName = "@DataInscricao";
                    paramDataInscricao.Value = aluno.DataInscricao;
                    cmd.Parameters.Add(paramDataInscricao);

                    SqlParameter paramSexo = new SqlParameter();
                    paramSexo.ParameterName = "@Sexo";
                    paramSexo.Value = aluno.Sexo;
                    cmd.Parameters.Add(paramSexo);

                    con.Open();
                    cmd.ExecuteNonQuery();
                }
            }
            catch
            {
                throw;
            }
        }

    }
}
