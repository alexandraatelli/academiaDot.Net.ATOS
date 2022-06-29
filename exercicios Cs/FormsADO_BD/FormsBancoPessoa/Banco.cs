using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Configuration;
using System.Data.SqlClient;


namespace SimplesWindonwFormsBanco
{
    public class Banco
    {
        private string stringConexao = "Data Source=127.0.0.1; Initial Catalog=atosUfn_db; User ID=sa; password='1q2w3e4r@#$';language=Portuguese";
        //private string stringConexao = "ConfigurationManager.ConnectionStrings["atosUfn_db"].ConnectionString";
        //string stringConexao = "Data Source=127.0.0.1;Initial Catalog=atosUfn_db;TrustServerCertificate=True;Integrated Security=True";
        private SqlConnection cn;

        private void Conexao()//vincular a string com o cn, bm inicia o CN
        {
            cn = new SqlConnection(stringConexao);
        }

        public SqlConnection AbrirConexao()
        {
            try
            {
                //tentar fazer algo
                Conexao();
                cn.Open();

                return cn;
            }
            catch (Exception e)
            {
                //faz algo se deu erro
                return null;
            }
        }

        public void FecharConexao()
        {
            try
            {
                cn.Close();
            }
            catch (Exception e)
            {
                return;
            }
        }

        public DataTable ExecutarConsultaGenerica(string sql)
        {
            try
            {
                AbrirConexao();

                SqlCommand command = new SqlCommand(sql, cn);
                command.ExecuteNonQuery();

                SqlDataAdapter adapter = new SqlDataAdapter(command);

                DataTable dt = new DataTable();
                adapter.Fill(dt);//adaptar preenche o datatable com os dados do command

                return dt;
            }
            catch (Exception e)
            {
                return null;
            }
            finally
            {
                FecharConexao();
            }
        }
    }
}

