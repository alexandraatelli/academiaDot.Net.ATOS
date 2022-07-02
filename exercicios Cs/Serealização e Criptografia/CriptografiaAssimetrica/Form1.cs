using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CriptografiaAssimetrica
{
    using WFCriptografia;
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

        private void btnCriptografia_Click(object sender, EventArgs e)
        {
            string frase, fraseCripto;
            frase = tbFrase.Text;
            Assimetrica a = new Assimetrica();
            fraseCripto = a.encrypt(frase);
            lblCripto.Text = fraseCripto;
        }

        private void btnDescriptografar_Click(object sender, EventArgs e)
        {
            string fraseCripto, frase;
            fraseCripto = lblCripto.Text;
            frase = a.decrypt(fraseCripto);
            lblDescripto.Text = frase;
        }

        private void btnCriptoSimetrico_Click(object sender, EventArgs e)
        {
            string fraseCripto, frase, chave;
            chave = txbChave.Text;
            frase = tbFrase.Text;
            fraseCripto = s.EncryptData(frase, chave);
            lblCripto.Text = fraseCripto;
        }

        private void btnDescriptoSimetrico_Click(object sender, EventArgs e)
        {
           
        }
    }
}
