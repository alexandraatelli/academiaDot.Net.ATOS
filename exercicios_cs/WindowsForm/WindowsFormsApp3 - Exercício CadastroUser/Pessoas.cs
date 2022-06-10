/*Criar uma aplicação utilizando windows form para cadastro de usuários.
 * O sistema deve possuir uma classe usuário e ter todos os atributos necessários
 * para cadastro de um usuário.
 * Atributos: nome, telefone, cpf, login, senha, status(ativo ou inativo), tipo
 * (administrador ou usuário).
 * Crie um formulário para cadastro contendo estes campos para cadastro. Ao clicar 
 * no botão, deve ser instanciado um objeto da classe.*/

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
    class Pessoas
    {
        //Atributos da Classe: 
        public string admUser;
        public string statusAtivOrInativ;
        public string tbnome;
        public string maskedFone;
        public string maskedCpf;
        public string tbLogin;
        private string tbSenha;
        
        //Propriedades dos atributos da Classe:
        public Pessoas(string admUser, string statusAtivOrInativ, string tbNome, string maskedFone, string maskedCpf, string tbLogin, string tbSenha)
        {
            this.AdmUser = admUser;
            this.StatusAtivOrInativ = statusAtivOrInativ;
            this.TbNome = tbNome;
            this.MaskedFone = maskedFone;
            this.MaskedCpf = maskedCpf;
            this.TbLogin = tbLogin;
            this.TbSenha = tbSenha;
                    
        }

        // Visibilidade (get,set)
        public string AdmUser { get ; set; }
        public string StatusAtivOrInativ { get; set; }
        public string TbNome { get; set; }
        public string MaskedFone { get; set; }
        public string MaskedCpf { get; set; }
        public string TbLogin { get; set; }
        public string TbSenha { get; set; }

        public void MostrarDadosCadastro()
        {
            MessageBox.Show($"Tipo: {this.AdmUser}\n " +
                $"Status: {this.StatusAtivOrInativ}\n" +
                $"Nome: {this.TbNome}\n" +
                $"Telefone: {this.MaskedFone}\n" +
                $"CPF: {this.MaskedCpf}\n" +
                $"Login: {this.TbLogin}\n" +
                $"Senha: {this.TbSenha}");
        }   
    }
}
