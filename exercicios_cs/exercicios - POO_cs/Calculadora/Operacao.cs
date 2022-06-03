using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Calculadora.cs
{
    public class Operacao
    {
        /// <summary>
        /// Atributos. São variáveis;
        /// </summary>
        double n1;
        double n2;

        /// <summary>
        /// Construtor - eu o chamo, no programa principal quando instanciar.
        /// Atalho para criar método construtor = ctor
        /// </summary>
        public Operacao()  
        {
          
        }

        public Operacao(double n1, double n2)
        {
            this.N1 = n1; // O this é usado no N maiusculo. Porque nas variaveis internas geram o get e set
            this.N2 = n2;
        }
        /// <summary>
        /// Métodos para efetuar as operações matemáticas. E fica dentro da classe calculadora pois aqui é o lugar dele.
        /// </summary>
        public double Somar(double n1, double n2)
        {
            return n1 + n2;
        }
        public double Subtrair(double n1, double n2)
        {
            return n1 - n2;
        }
        public double Dividir(double n1, double n2)
        {
            return n1 / n2;
        }
        public double Multiplicar(double n1, double n2)
        {
            return n1 * n2;
        }

        // Marca n1 e n2, click mouse direito, e cria-se o Get e Set automaticamente
        public double N1 { get => n1; set => n1 = value; }
        public double N2 { get => n2; set => n2 = value; }
    }
}