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
    public partial class CadastroPessoa : Form
    {
        public CadastroPessoa()
        {
            InitializeComponent();
        }

        private void Bt_Salvar_Click(object sender, EventArgs e)
        {
            /*
            string nome = Tb_Nome
            int idade = Tb_Idade
            string cpf = Tb_Cpf
            string endereco = Tb_Endereco
            string bairro = Tb_Bairro
            string cep = Tb_Cep
            string cidade = Tb_Cidade
            */

            //Puxa o que foi atribuito na Tela Gráfica do Forms, por isso p recebe os Tbs_:
            Pessoa p = new Pessoa(Tb_Nome.Text, int.Parse(Tb_Idade.Text), Tb_Cpf.Text,
            Tb_Endereco.Text, Tb_Bairro.Text, Tb_Cep.Text, Tb_Cidade.Text);

            MessageBox.Show($" Nome: {p.nome};\n Idade: {p.idade};\n CPF: {p.cpf};\n Endereço: {p.endereco};\n Bairro: {p.bairro};\n CEP: {p.cep};\n Cidade: {p.cidade}.");
            Tb_Nome.Text = ""; // Limpa Tela
            Tb_Idade.Text = "";
            Tb_Cpf.Text = "";
            Tb_Endereco.Text = "";
            Tb_Bairro.Text = "";
            Tb_Cep.Text = "";
            Tb_Cidade.Text = "";
            p.GravarPessoa();
        }
    }
}

// Neste exercícios não foi realizado o tratamento para fechar o formulário principal.