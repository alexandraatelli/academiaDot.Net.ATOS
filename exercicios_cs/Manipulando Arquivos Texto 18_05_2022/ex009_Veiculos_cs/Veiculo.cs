using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ex009_Veiculos_cs
{
   public class Veiculo
    {   // atributo/propriedades - usado como identificador
        public string? placaCarro;
        public readonly object dateHora;

        public Veiculo(string placaCarro, object dateHora)
        {   // método construtor para cadastro dos veiculos
            this.placaCarro = " ";
            this.dateHora = DateHora;
        }

        public Veiculo(string placaCarro)
        {
            this.placaCarro = placaCarro;
        }

        //public string placaCarro { get => placaCarro; set => placaCarro = value; } // agente para conversar
        // com a variável 
        public string PlacaCarro { get => PlacaCarro; } // agente para conversar com a variável placaCarro
        public object DateHora { get => dateHora; }
    }
}



