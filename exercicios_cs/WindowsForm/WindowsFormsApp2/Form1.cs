using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp2
{
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
        }
        private void tbLimpar_Click(object sender, EventArgs e)
        {
            FabricCarro.Clear();
            ModeloCarro.Clear();

            foreach (int checados in lbOpcionais.CheckedItems)
            {
                lbOpcionais.SetItemChecked(checados, false);
            }
            cbQuantPortas.ResetText();
        }

        private void tbSalvar_Click(object sender, EventArgs e)//Método inicia letra Maiúscula - Variável do método.
        {
            bool arCond = false, dirHidr = false, abs = false, airBg = false, vidElet = false;
            int portas;

            foreach (string opcionais in lbOpcionais.CheckedItems)
            {
                if (opcionais == "Ar Condicionado")
                {
                    arCond = true;
                }
                if (opcionais == "Direção Hidráulica")
                {
                    dirHidr = true;
                }
                if (opcionais == "Freio ABS")
                {
                    abs = true;
                }
                if (opcionais == "Air bag")
                {
                    airBg = true;
                }
                if (opcionais == "Air bag")
                {
                    vidElet = true;
                }
            }
            portas = 0;
            if (cbQuantPortas.Text == "2 Portas") portas = 2;
            else if (cbQuantPortas.Text == "4 Portas") portas = 4;
            else if (cbQuantPortas.Text == "6 Portas") portas = 6;
            Carro car = new Carro(ModeloCarro.Text, FabricCarro.Text, arCond, dirHidr, abs, airBg, vidElet, portas);
            car.MostrarDadosCarro();
        }
    }
}

