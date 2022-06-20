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

namespace WindowsFormsAppUsuario
{
    public class Banco
    {
        private string conexaoString = "Data Source=127.0.0.1;Initial Catalog=usuario_db; User ID=sa; password='1q2w3e4r@#$';language=Portuguese";

        private SqlConnection cn;

        private void Conexao()//vincular a string com o cn, bm inicia o cn
        {
            cn = new SqlConnection(conexaoString);
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
            catch (Exception)
            {
                return null;
            }
        }

        public void FecharConexao()
        {
            try
            {
                cn.Close();
            }
            catch (Exception)
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
            catch (Exception)
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
