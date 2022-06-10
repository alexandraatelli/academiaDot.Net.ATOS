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
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PrimeiroWinForms
    {
        public partial class Form1 : Form
        {
            public Form1()
            {
                InitializeComponent();
            }

            private void BTOk_Click(object sender, EventArgs e)
            {
                //MessageBox.Show("Cliquei no botão OK");
                MessageBox.Show("Nome: " + tbNome.Text + "\ne-mail: " + tbemail.Text + "\nEndereço: " + tbEnd.Text + 
                    "\nBairro: " + tbBairro.Text + "\nCidade: " + tbCidade.Text + "\nTelefone: " + tbTelefone.Text);
               
                MessageBox.Show("Cadastro efetuado!");
                tbNome.Clear();
                tbemail.Clear();
                tbEnd.Clear();
                tbBairro.Text = "";
                tbCidade.Text = "Nova Cidade";
                tbTelefone.Text = "";
                lblMSG.Text = "CADASTRO EFETUADO COM SUCESSO! INSIRA UM NOVO REGISTRO!";
            }

            private void BTCancel_Click(object sender, EventArgs e)
            {
                MessageBox.Show("Cliquei no botão cancelar");
            }

            private void Form1_Load(object sender, EventArgs e)
            {
                MessageBox.Show("Bem vindo a este lindo programa!");
            }
        }
    }
