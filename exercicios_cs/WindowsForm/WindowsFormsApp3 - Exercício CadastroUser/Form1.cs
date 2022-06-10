/*Criar uma aplicação utilizando windows form para cadastro de usuários.
 * O sistema deve possuir uma classe usuário e ter todos os atributos necessários
 * para cadastro de um usuário.
 * Atributos: nome, telefone, cpf, login, senha, status(ativo ou inativo), tipo
 * (administrador ou usuário).
 * Crie um formulário para cadastro contendo estes campos para cadastro. Ao clicar 
 * no botão, deve ser instanciado um objeto da classe.*/

using System;
using System.Globalization;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;


namespace WindowsFormsApp3
{
    public partial class FormularioCadastro : Form
    {
        public FormularioCadastro()
        {
            InitializeComponent();
        }

        private void Formulario_Shown(object sender, EventArgs e)
        {
            MessageBox.Show("Bem vindo a Academia .Net Atos!");
        }

        // Evento para o usuário confirmar a saída do Formulário
        private void Formulario_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (MessageBox.Show("Deseja realmente sair?", "Confirmação",
                MessageBoxButtons.YesNo, MessageBoxIcon.Question) ==
                DialogResult.No)
            {
                e.Cancel = true; // esse e. veio do Evento - uma variável
                                 // que carrega algumas propriedades 
                                 // oriundas do método que chamou este
                                 // evento.
            }
        }
        private void tbCancelar_Click(object sender, EventArgs e)
        {
            admUser.ResetText();
            statusAtivOrInat.ResetText();
            tbNome.Clear();
            maskedFone.Clear();
            maskedCpf.Clear();
            tbLogin.Clear();
            tbSenha.Clear();
        }
        private void tbCadastrar_Click_1(object sender, EventArgs e)
        {
            // If para escolha da opção desejada:

            string admUser = "";

            if (admUser == "Administrador")
            {
                MessageBox.Show("Tipo de Acesso: Administrador!");
            }
            if (admUser == "Usuário")
            {
                MessageBox.Show("Tipo de Acesso: Usuário!");
            }

            string statusAtivOrInat = "";

            if (statusAtivOrInat == "Ativo")
            {
                MessageBox.Show("Status Ativo!");
            }
            if (statusAtivOrInat == "Inativo")
            {
                MessageBox.Show("Status Inativo!");
            }

            Pessoas usuario = new Pessoas(admUser, statusAtivOrInat,
                tbNome.Text, maskedFone.Text, maskedCpf.Text, tbLogin.Text,
                tbSenha.Text);

            usuario.MostrarDadosCadastro();

        }
    }
}







             
