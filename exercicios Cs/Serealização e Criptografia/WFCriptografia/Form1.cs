using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Security.Cryptography;
using System.Xml.Serialization;
using System.IO;
using System.Windows.Forms;

namespace WFCriptografia
{
    public partial class Form1 : Form
    {
        Assimetrica a;
        Simetrica s;

        public Form1()
        {
            InitializeComponent();
            a = new Assimetrica();
            s = new Simetrica();

        }

        private void Bt_Criptografar_Click(object sender, EventArgs e)
        {
            string frase, fraseCripto;
            frase = Tb_Frase.Text;
            fraseCripto = a.encrypt(frase);
            Lbl_Cripto.Text = fraseCripto;
        }

        private void Bt_Descriptografar_Click(object sender, EventArgs e)
        {
            string fraseCripto, frase;
            fraseCripto = Lbl_Cripto.Text;
            frase = a.decrypt(fraseCripto);
            Lbl_Descripto.Text = frase;
        }

        private void Bt_CriptoSimetrica_Click(object sender, EventArgs e)
        {
            string fraseCripto, frase, chave;
            chave = Tb_Chave.Text;
            frase = Tb_Frase.Text;
            fraseCripto = s.EncryptData(frase, chave);
            Lbl_Cripto.Text = fraseCripto;
        }

        private void Bt_DescriptoSimetrica_Click(object sender, EventArgs e)
        {
            string frase, fraseCripto, chave;
            chave = Tb_Chave.Text;
            fraseCripto = Lbl_Cripto.Text;
            frase = s.DescryptData(frase, chave);
            Lbl_Cripto.Text = fraseCripto;
        }

    }
}
