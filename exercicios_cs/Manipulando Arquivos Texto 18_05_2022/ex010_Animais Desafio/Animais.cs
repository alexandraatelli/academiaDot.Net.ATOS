using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ex010_Animais.cs
{
    class Animais
    {
        // atributos/propriedades - identificador
        private string nome;
        private string tipo;

        public Animais() { }
        public Animais(string nome, string tipo)
        {
            this.Nome = nome;
            this.Tipo = tipo;
        }

        public string Nome { get => nome; set => nome = value; }
        public string Tipo { get => tipo; set => tipo = value; }

        public void ExibirDados()
        {
            Console.WriteLine($"Nome: {Nome}\nTipo: {Tipo}\n");
        }
    }
}