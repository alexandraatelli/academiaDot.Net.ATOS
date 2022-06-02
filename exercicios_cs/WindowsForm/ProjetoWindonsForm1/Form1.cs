using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ProjetoWindonsForm1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            MessageBox.Show("Bem vindo! Faça o seu Cadastro.");
        }
        private void tbCadastrar_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Preenchido os dados, click em Cadastrar");
            MessageBox.Show($"Nome: {tbNome.Text}\n" +
               $"e-mail: {tbmail.Text}\n" +
               $"Endereço: {tbEnd.Text}\n Bairro: {tbBairro.Text}\n" +
               $"Cidade: {tbCidade.Text}\n" +
               $"Telefone: {tbFone.Text}");
            MessageBox.Show("Cadastro efetuado!");
            tbNome.Clear();
            tbmail.Clear();
            tbEnd.Clear();
            tbBairro.Text = "";
            tbCidade.Text = "Nova Cidade";
            tbFone.Text = "";
            lblMsn.Text = "CADASTRO EFETUADO COM SUCESSO! INSIRA UM NOVO REGISTRO!";
        }
        private void tbCancelar_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Clique em Cancelar para excluir seu cadastro.");
        }

    }

}
