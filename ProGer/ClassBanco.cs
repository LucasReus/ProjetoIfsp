using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace ProGer
{
    public static class ClassBanco
    {
        const string Caminho = "Data Source=.; Initial Catalog=NomeDoBanco; Integrated Security=SSPI;";

        public static void CadastrarAluno(
            int Matricula,
            string Nome)
        {
            SqlConnection Conexao = new SqlConnection(Caminho);

            try
            {
                Conexao.Open();
                SqlCommand Cmd = new SqlCommand();
                Cmd.Connection = Conexao;
                Cmd.CommandText =
                    "INSERT INTO Alunos (Matricula_Aluno, Nome_Aluno) " +
                    "VALUES " +
                    "(@Matricula, @Nome)";

                Cmd.Parameters.Add(new SqlParameter("@Matricula", Matricula));
                Cmd.Parameters.Add(new SqlParameter("@Nome", Nome));

                Cmd.CommandType = CommandType.Text;
                Cmd.ExecuteNonQuery();
            }
            catch (Exception Ex)
            {
                MessageBox.Show(Ex.Message);
            }
            finally { Conexao.Close(); }
        }
    }
}
