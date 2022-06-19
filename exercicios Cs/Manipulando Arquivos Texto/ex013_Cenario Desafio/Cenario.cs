using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ex013_Cenario.cs
{
    internal class Cenario
    {
        private string Descricao;
        private DateTime DataDeCriacao;
        private float Altura;

        public string Descricao1 { get => Descricao; set => Descricao = value; }
        public DateTime DataDeCriacao1 { get => DataDeCriacao; set => DataDeCriacao = value; }
        public float Altura1 { get => Altura; set => Altura = value; }

        public Cenario(string descricao, DateTime dataDecriacao, float altura)
        {
            this.Descricao1 = descricao;
            this.DataDeCriacao1 = dataDecriacao;
            this.Altura1 = altura;
        }

        public string ExibirItem()
        {
            return "Descrição: " + this.Descricao1 + "\nData de criação: " + this.DataDeCriacao1 + "\nAltura: " + Altura1 + "\n-";
        }

        public void TempoCriacao()
        {
            Console.Write("Este item foi criado há ");
            Console.WriteLine(DateTime.Now - this.DataDeCriacao1);
        }
    }
}