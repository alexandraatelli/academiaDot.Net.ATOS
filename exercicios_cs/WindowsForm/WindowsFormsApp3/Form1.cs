using System;
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
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void TbCadastrar_Click(object sender, EventArgs e)
        {
            bool usuario = false, administrador = true;
            string tiposUsuario;

            foreach (string tipo in cbTiposUsuario.CheckedItems)
            {
                if (tipo == "Usuário")
                {
                    usuario = true;
                }
                if (tipo == "Administrador")
                {
                    administrador = true;
                }
            }
            tiposUsuario = "";
            if (cbTiposUsuarios.Text == "Usuário") tiposUsuario = "Usuário";
            if (cbTiposUsuarios.Text == "Administrador") tiposUsuario = "Administrador";

            CadastroPessoas cp = new CadastroPessoas(tbNome.Text, tbTelefone.Text, tbCpf.Text, tbLogin.Text, tbSenha.Text, tiposUsuario);
            cp.MostrarDadosPessoas();
        }
        private void TbLimpar_Click(object sender, EventArgs e)
        {
            tbNome.Clear();
            tbTelefone.Clear();
            tbCpf.Text.Clear();
            tbLogin.Text.Clear();
            tbSenha.Text.Clear();

            foreach (int checados in cbTiposUsuarios.CheckedIndices)
            {
                cbTiposUsuarios.SetItemChecked(checados, false);
            }
            cbTiposUsuarios.ResetText();
        }
    }
}
