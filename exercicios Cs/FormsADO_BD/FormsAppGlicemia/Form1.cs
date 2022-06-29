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


namespace WindowsFormsApp_ADO_DB
{
    public partial class Form1 : Form
    {

        private string conexaoString = "Data Source=127.0.0.1; Initial Catalog=glicemia_db; User ID=sa; password='1q2w3e4r@#$';language=Portuguese";

        //private string conexaoString = ConfigurationManager.ConnectionStrings["glicemia_db"].ConnectionString;

        public Form1()
        {
            InitializeComponent();
        }

        private void LimparTextBox()
        {
            textBox_idGlicemia.Text = "";
            textBox_valorGlicemia.Text = "";
            textBox_DataMedicao.Text = "";
            textBox_idPaciente.Text = "";
        }

        private void CarregarListView()
        {
            SqlConnection conexao = new SqlConnection(conexaoString);
            conexao.Open();

            string sqlTexto = "SELECT idMedidaGlicemia, valorGlicemia, dataMedida, idPaciente FROM MedidaGlicemia";
            SqlCommand comando = new SqlCommand(sqlTexto, conexao);

            listView_medidasGlicemias.Items.Clear();
            SqlDataReader leitor = comando.ExecuteReader();
            int i = 0;
            while (leitor.Read())
            {
                listView_medidasGlicemias.Items.Add(leitor["idMedidaGlicemia"].ToString());
                listView_medidasGlicemias.Items[i].SubItems.Add(leitor["valorGlicemia"].ToString());
                listView_medidasGlicemias.Items[i].SubItems.Add(leitor["dataMedida"].ToString());
                listView_medidasGlicemias.Items[i].SubItems.Add(leitor["idPaciente"].ToString());
                i++;
            }
            conexao.Close();
        }

        private void button_Conectar_Click_1(object sender, EventArgs e)
        {
            CarregarListView();//Método conecta e carrega a ListView
            button_Conectar.Enabled = false;
        }

        private void button_Adicionar_Click(object sender, EventArgs e)
        {
            SqlConnection conexao = new SqlConnection(conexaoString);
            conexao.Open();
            try
            {
                //Capturado o valor das Variáveis:
                int idMedidaGlicemia = int.Parse(textBox_idGlicemia.Text);
                int valorGlicemia = int.Parse(textBox_valorGlicemia.Text);
                string dataMedida = (textBox_DataMedicao.Text);
                int idPaciente = int.Parse(textBox_idPaciente.Text);

                //Gera sentenças SQL: esses @ são as variáveis acima declaradas.
                //O comando pega esses valores e coloca no Banco de Dados.
               string sqlTexto = "INSERT INTO MedidaGlicemia (idMedidaGlicemia," +
                    " valorGlicemia, dataMedida, idPaciente) " +
                    "VALUES(@idMedidaGlicemia, @valorGlicemia, " +
                    "@dataMedida, @idPaciente)";
                SqlCommand comando = new SqlCommand(sqlTexto, conexao); 
                comando.Parameters.AddWithValue("@idMedidaGlicemia", idMedidaGlicemia);
                comando.Parameters.AddWithValue("@valorGlicemia", valorGlicemia);
                comando.Parameters.AddWithValue("@dataMedida", dataMedida);
                comando.Parameters.AddWithValue("@idPaciente", idPaciente);

                //Executamos um Inset agora _ sentença SQL _ não é consulta
                if (comando.ExecuteNonQuery() != 0)
                {
                    MessageBox.Show("Adicionado com sucesso!" + listView_medidasGlicemias.SelectedItems[0].Text);
                }
            }
            catch (Exception erro)
            {
                MessageBox.Show(erro.Message);
            }

            conexao.Close();

            //Recarregar ListView
            CarregarListView();

            LimparTextBox();
        }

        private void button_Remover_Click(object sender, EventArgs e)
        {
            
            //Remover está relacionado com ListView e a região selecionada

            SqlConnection conexao = new SqlConnection(conexaoString);
            conexao.Open();
            try
            {
                //MessageBox.Show(listView_medidasGlicemias.SelectedItems[0].Text);
                int idMedidaGlicemia = int.Parse(listView_medidasGlicemias.SelectedItems[0].Text);

                //gerar sentenças SQL
                string sqlTexto = "DELETE FROM MedidaGlicemia WHERE idMedidaGlicemia = @idMedidaGlicemia";

                SqlCommand comando = new SqlCommand(sqlTexto, conexao);
                comando.Parameters.AddWithValue("@idMedidaGlicemia", idMedidaGlicemia);

                //executar sentença SQL
                if (comando.ExecuteNonQuery() !=0)
                {
                    MessageBox.Show("Removido com sucesso!" + listView_medidasGlicemias.SelectedItems[0].Text);
                }
            }
            catch (Exception erro)
            {
                MessageBox.Show(erro?.Message);//Podemos trocar essa messangem?
            }
            
            conexao.Close();

            //recarregar ListView
            CarregarListView();
        }
    }
}
