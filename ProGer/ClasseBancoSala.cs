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
    class ClasseBancoSala
    {
        //String de conexão com o banco 
        static string StrConexao = "Data Source=.; Initial Catalog=ProjetoEscolaIdiomaTeste ;Integrated Security=SSPI;";

        //Classe Cadastrar sala junto ao banco de dados
        public static void CadastrarSala(/*int IdSala,*/ string Capacidade, string Televisao, string Computador, string Mesa, string Cadeira, string Lousa, string Projetor)
        {
            SqlConnection Conexao = new SqlConnection(StrConexao);
            try
            {
                Conexao.Open();
                SqlCommand Cmd = new SqlCommand();
                Cmd.Connection = Conexao;
                //Começo do Insert do banco
                Cmd.CommandText = "insert into TabSalaProjeto (CapacidadeSala, TelevisaoSala,ComputadorSala,Mesasala,CadeiraSala,LousaSala,ProjetorSala) Values " +
                                                                   "(@Capacidade, @Televisao,@Computador,@Mesa,@Cadeira,@Lousa,@Projetor)";
                //Começo dos Parameters
                //Cmd.Parameters.Add(new SqlParameter("@IdSala", IdSala));
                Cmd.Parameters.Add(new SqlParameter("@Capacidade", Capacidade));
                Cmd.Parameters.Add(new SqlParameter("@Televisao", Televisao));
                Cmd.Parameters.Add(new SqlParameter("@Computador", Computador));
                Cmd.Parameters.Add(new SqlParameter("@Mesa", Mesa));
                Cmd.Parameters.Add(new SqlParameter("@Cadeira", Cadeira));
                Cmd.Parameters.Add(new SqlParameter("@Lousa", Lousa));
                Cmd.Parameters.Add(new SqlParameter("@Projetor", Projetor));
                Cmd.CommandType = CommandType.Text;
                Cmd.ExecuteNonQuery();
                MessageBox.Show("Sala Cadastrada");
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
