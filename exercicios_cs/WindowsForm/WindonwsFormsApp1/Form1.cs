using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

// Programa em processo de criação - Início 01.06.2022

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
        private void TbCadastrar_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Preenchido os dados, click em Cadastrar");
            MessageBox.Show($"Nome: {tbNome.Text}\n" +
               $"e-mail: {tbmail.Text}\n" +
               $"Telefone: {tbFone.Text}\n" +
               $"Endereço: {tbEnd.Text}\n " +
               $"Bairro: {tbBairro.Text}\n" +
               $"Cidade: {tbCidade.Text}\n " +
               $"CEP: {tbCep.Text}\n" +
               $"Estado:{tbEstado.Text}\n" +
               $"País: {tbPais.Text}");
            MessageBox.Show("Cadastro efetuado!");
            tbNome.Clear();
            tbmail.Clear();
            tbFone.Clear();
            tbEnd.Clear();
            tbBairro.Clear();
            tbCidade.Clear();
            tbEstado.Clear();
            tbCep.Clear();
            tbPais.Clear();
            //tbPais.Text = "";
            LblMsn.Text = "Cadastro efetuado com sucesso! Insira outro registro, se necessário.";
        }
        private void TbCancelar_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Clique em Cancelar para excluir seu cadastro.");
        }

    }

}
