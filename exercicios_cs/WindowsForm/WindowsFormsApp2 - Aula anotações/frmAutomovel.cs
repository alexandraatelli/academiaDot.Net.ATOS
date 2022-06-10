using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

// EXERCÍCIO ADMINISTRADO PELO PROFESSOR ACADEMIA ATOS EM AULA

namespace WindowsFormsApp2
{
    public partial class frmAutomovel : Form
    {
        static List<Carro> carros = new List<Carro>();
        public frmAutomovel()
        {
            InitializeComponent();
        }
        private void tbLimpar_Click_1(object sender, EventArgs e)
        {
            FabricCarro.Clear();
            ModeloCarro.Clear();

            foreach (int checados in lbOpcionais.CheckedItems)
            {
                lbOpcionais.SetItemChecked(checados, false);
            }
            cbQuantPortas.ResetText();
            dgAutomoveis.Rows.Clear();
        }
        private void tbSalvar_Click_1(object sender, EventArgs e)
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
            carros.Add(car);
            //car.MostrarDadosCarro();
            //mostraListaCarros();
            dgAutomoveis.Rows.Add(ModeloCarro.Text, FabricCarro.Text, arCond, dirHidr, abs, airBg, vidElet, portas);
        }

        static void mostraListaCarros()
        {
            foreach (Carro car in carros)
            {
                MessageBox.Show($"Carro: {car.ModeloCarro}\nFabricante: { car.FabricanteCarro}\nAr Condicionado: { car.arCond}\nDireção Hidráulica: { car.dirHidr}\nABS: { car.abs}\nAirbag: {car.airBg}\nVidros Elétricos: { car.vidElet}\nPortas: { car.portas}");
            }
        }

        private void bt_CarregarDados_Click(object sender, EventArgs e)
        {
            dgAutomoveis.Rows.Clear();
            foreach (Carro car in carros)
            {
                dgAutomoveis.Rows.Add(car.ModeloCarro, car.FabricanteCarro,
                    car.arCond, car.dirHidr, car.abs, car.airBg,
                    car.vidElet, car.portas);
            }
        }
    }
}   
