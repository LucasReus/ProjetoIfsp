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
    class ClasseBancoProfessor
    {

        //String de conexão com o banco 
        static string StrConexao = "Data Source=.; Initial Catalog=ProjetoEscolaIdiomaTeste ;Integrated Security=SSPI;";

        //Classe Cadastrar sala junto ao banco de dados
        public static void CadastrarProfessor(string NomeProfessor,string CpfProfessor,string RgProfessor,string CtpsProfessor,
            string SexoProfessor,string EstadoCivilProfessor,string DataNascimentoProfessor,string FilhosProfessor,string LogradouroProfessor,
            string BairroProfessor,string CidadeProfessor,string CepProfessor,string NumeroLogradouroProfessor,string DataAdmissaoProfessor, string GraduacaoProfessor,string StatusProfessor/*string FotoProfessor*/)
        {
            SqlConnection Conexao = new SqlConnection(StrConexao);
            try
            {
                Conexao.Open();
                SqlCommand Cmd = new SqlCommand();
                Cmd.Connection = Conexao;
                //Começo do Insert do banco
                Cmd.CommandText = "insert into TabProjetoProfessor (NomeProfessor,CpfProfessor,RgProfessor,CtpsProfessor,SexoProfessor,EstadoCivilProfessor,DataNascimentoProfessor,FilhosProfessor,LogradouroProfessor,BairroProfessor,CidadeProfessor,CepProfessor,NumeroLogradouroProfessor,DataAdmissaoProfessor,GraduacaoProfessor,StatusProfessor) Values " +
                                                                   "(@NomeProfessor,@CpfProfessor,@RgProfessor,@CtpsProfessor,@SexoProfessor,@EstadoCivilProfessor,@DataNascimentoProfessor,@FilhosProfessor,@LogradouroProfessor,@BairroProfessor,@CidadeProfessor,@CepProfessor,@NumeroLogradouroProfessor,@DataAdmissaoProfessor,@GraduacaoProfessor,@StatusProfessor)";
                //Começo dos Parameters
                //Cmd.Parameters.Add(new SqlParameter("@IdSala", IdSala));
                Cmd.Parameters.Add(new SqlParameter("@NomeProfessor", NomeProfessor));
                Cmd.Parameters.Add(new SqlParameter("@CpfProfessor", CpfProfessor));
                Cmd.Parameters.Add(new SqlParameter("@RgProfessor", RgProfessor));
                Cmd.Parameters.Add(new SqlParameter("@CtpsProfessor", CtpsProfessor));
                Cmd.Parameters.Add(new SqlParameter("@SexoProfessor", SexoProfessor));
                Cmd.Parameters.Add(new SqlParameter("@EstadoCivilProfessor", EstadoCivilProfessor));
                Cmd.Parameters.Add(new SqlParameter("@DataNascimentoProfessor", DataNascimentoProfessor));
                Cmd.Parameters.Add(new SqlParameter("@FilhosProfessor", FilhosProfessor));
                Cmd.Parameters.Add(new SqlParameter("@LogradouroProfessor", LogradouroProfessor));
                Cmd.Parameters.Add(new SqlParameter("@BairroProfessor", BairroProfessor));
                Cmd.Parameters.Add(new SqlParameter("@CidadeProfessor", CidadeProfessor));
                Cmd.Parameters.Add(new SqlParameter("@CepProfessor", CepProfessor));
                Cmd.Parameters.Add(new SqlParameter("@NumeroLogradouroProfessor", NumeroLogradouroProfessor));
                Cmd.Parameters.Add(new SqlParameter("@DataAdmissaoProfessor", DataAdmissaoProfessor));
                Cmd.Parameters.Add(new SqlParameter("@GraduacaoProfessor", GraduacaoProfessor));
                Cmd.Parameters.Add(new SqlParameter("@StatusProfessor", StatusProfessor));
                //Cmd.Parameters.Add(new SqlParameter("@FotoProfessor", FotoProfessor));
                Cmd.CommandType = CommandType.Text;
                Cmd.ExecuteNonQuery();
                MessageBox.Show("Professor Cadastrado");
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
