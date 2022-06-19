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
    //private string conexaoString = "Data Source=127.0.0.1; Initial Catalog=usuario_db; User ID=sa; password='1q2w3e4r@#$';language=Portuguese";
    public partial class FormUsuario : Form
    {
        string conexaoString = "Data Source=127.0.0.1; Initial Catalog=usuario_db; User ID=sa; password='1q2w3e4r@#$';language=Portuguese";

        public FormUsuario()
        {
            InitializeComponent();
        }

        private void FormUsuario_Load(object sender, EventArgs e)
        {
            MessageBox.Show("Cadastro de Usuários!");
        }

        private void LimparTextBox()
        {
            Tb_id_usuario.Text = "";
           Tb_nomeCompleto.Text = "";
        }
        private void CarregarListView()
        {
            SqlConnection conexao = new SqlConnection(conexaoString);
            conexao.Open();
            try
            {

                string sqlTexto = "SELECT  idUsuario, nomeCompleto, email  from Usuario";
                SqlCommand comando = new SqlCommand(sqlTexto, conexao);

                listView_Usuario.Items.Clear();
                SqlDataReader leitor = comando.ExecuteReader();
                int i = 0;
                while (leitor.Read())
                {
                    listView_Usuario.Items.Add(leitor["id_usuario"].ToString());
                    listView_Usuario.Items[i].SubItems.Add(leitor["nomeCompleto"].ToString());
                    listView_Usuario.Items[i].SubItems.Add(leitor["email"].ToString());
                    i++;
                }
                conexao.Close();
            }
            catch (Exception e)
            {
                MessageBox.Show("Problemas de conexão com o Banco de Dados " + e.ToString(), "Alerta");
            }
        }
        private void Bt_Conectar_Click(object sender, EventArgs e)
        {
            CarregarListView();//Método conecta e carrega a ListView
            Bt_Conectar.Enabled = false;
        }

        private void Bt_Adicionar_Click(object sender, EventArgs e)
        {
            Usuario user = new Usuario(int.Parse(Tb_id_usuario.Text), Tb_nomeCompleto.Text, email.Text);
            user.GravarUsuario();
            CarregarListView();
        }
        private void Bt_Remover_Click(object sender, EventArgs e)
        {
            SqlConnection conexao = new SqlConnection(conexaoString);
            conexao.Open();
            try
            {
                int id_usuario = int.Parse(listView_Usuario.SelectedItems[0].Text);

                //gerar sentenças SQL
                string sqlTexto = "DELETE from Usuario Where idUsuario = @idUsuario";

                SqlCommand comando = new SqlCommand(sqlTexto, conexao);
                comando.Parameters.AddWithValue("@id_usuario", id_usuario);

                //executar sentença SQL
                if (comando.ExecuteNonQuery() != 0)
                {
                    MessageBox.Show("Remoção realizada com sucesso.");
                }
            }
            catch (Exception erro)
            {
                MessageBox.Show("Remoção não realizada, tente novamente." + erro);
            }

            conexao.Close();

            CarregarListView();
        }
    }
}



