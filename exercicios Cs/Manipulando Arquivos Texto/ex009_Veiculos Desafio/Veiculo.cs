using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ex009_Veiculos_cs
{
   public class Veiculo
    {   // atributo/propriedades - usado como identificador
        string placaCarro;
        DateTime dataHora;
        public Veiculo(string placaCarro, DateTime dataHora)
        {   // método construtor para cadastro dos veiculos
            this.placaCarro = placaCarro; // esta placa - daqui de dentro - a placa que está no meu escopo
            this.dataHora = dataHora;
        }
        /*public Veiculo(string placaCarro) // construtor para cadastrar a placaCarro
        {
            this.placaCarro = placaCarro;
        }*/
        public string PlacaCarro { get => placaCarro; set => placaCarro = value; } // agente para conversar
                                                                                   // com a variável 
        public object DataHora { get => dataHora; }
    }
}



