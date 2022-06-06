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
    internal class CadastroPessoas
    {
        public string tbNome { get; set; }
        public string tbTelefone { get; set; }
        public string tbCpf { get; set; }
        public  string tbLogin { get; set; }
        public string tbSenha { get; set; }
        public string cbTiposUsuario { get; set; }

        public CadastroPessoas(string tbNome, string tbTelefone, string tbCpf, string tbLogin, string tbSenha, string cbTiposUsuario)
        {
            this.tbNome = tbNome;
            this.tbTelefone = tbTelefone;
            this.tbCpf = tbCpf;
            this.tbLogin = tbLogin;
            this.tbSenha = tbSenha;
            this.cbTiposUsuario = cbTiposUsuario;
        }
        public void MostrarDadosPessoas()
        {
            MessageBox.Show($"Nome: {this.tbNome}");
            MessageBox.Show($"Telefone: {this.tbTelefone}");
            MessageBox.Show($"Cpf: {this.tbCpf}");
            MessageBox.Show($"Login: {this.tbLogin}");
            MessageBox.Show($"Senha: {this.tbSenha}");
            MessageBox.Show($"Tipo de Usuário {this.cbTiposUsuario}");
        }
    }
}
