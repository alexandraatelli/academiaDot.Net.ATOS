using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp2 
{
    class Carro
    {
        public bool arCond;
        public bool dirHidr;
        public bool abs;
        public bool airBg;
        public bool vidElet;
        public int portas;

        public Carro(string modeloCarro, string fabricanteCarro, bool arCond, bool dirHidr, bool abs, bool airBg, bool vidlet, int portas)
        {   // é a variável da classe = o Modelo da Classe é igual o modelo daqui.
            this.ModeloCarro = modeloCarro;
            this.FabricanteCarro = fabricanteCarro;
            this.arCond = arCond;
            this.dirHidr = dirHidr;
            this.abs = abs;
            this.airBg = airBg;
            this.vidElet = vidlet;
            this.portas = portas;
        }

        public string ModeloCarro { get; set; }
        public string FabricanteCarro { get; set; }


        public void MostrarDadosCarro()
        {
            MessageBox.Show($"Carro: {this.ModeloCarro}\nFabricante: {this.ModeloCarro}\nAr Condicionado: {this.ModeloCarro}\nDireção Hidráulica: {this.dirHidr}\nABS: {this.abs}\nAirbag: {this.airBg}\nVidros Elétricos: {this.vidElet}\nPortas: {this.portas}");
        }
    }
}
