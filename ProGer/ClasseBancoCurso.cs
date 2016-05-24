using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.Data;
using System.Windows.Forms;

namespace ProGer
{
    class ClasseBancoCurso
    {
        //String de conexão com o banco 
        static string StrConexao = "Data Source=.; Initial Catalog=ProjetoEscolaIdiomaTeste ;Integrated Security=SSPI;";

        //Classe Cadastrar Curso junto ao banco de dados
        public static void CadastarCurso(int IdCurso, string NomeCurso, string PrecoCurso, string NivelCurso, string DescricaoCurso)
        {
            SqlConnection Conexao = new SqlConnection(StrConexao);
            try
            {
                ///pega ai joao
                Conexao.Open();
                SqlCommand Cmd = new SqlCommand();
                Cmd.Connection = Conexao;
                //Começo do Insert do banco
                Cmd.CommandText = "Insert Into TabCursoProjeto (IdCurso,NomeCurso,preco,nivel,descrisao) Values " +
                                                                   "(@IdCurso, @NomeCurso,@PrecoCurso,@NivelCurso,@DescricaoCurso)";
                //Começo dos Parameters
                Cmd.Parameters.Add(new SqlParameter("@IdCurso", IdCurso));
                Cmd.Parameters.Add(new SqlParameter("@NomeCurso", NomeCurso));
                Cmd.Parameters.Add(new SqlParameter("@PrecoCurso", PrecoCurso));
                Cmd.Parameters.Add(new SqlParameter("@NivelCurso", NivelCurso));
                Cmd.Parameters.Add(new SqlParameter("@DescricaoCurso", DescricaoCurso));
                Cmd.CommandType = CommandType.Text;
                Cmd.ExecuteNonQuery();
                MessageBox.Show("Curso Cadastrado");
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            finally
            {
                Conexao.Close();
            }
        }
    }
}
