
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ex012_Asteroides.cs
{
    class Asteroide
    {
        private int PosicaoX;
        private int PosicaoY;
        private int Tamanho;
        private int Velocidade;
        private int Energia;

        public int Posicao1X { get => PosicaoX; set => PosicaoX = value; }
        public int Posicao1Y { get => PosicaoY; set => PosicaoY = value; }
        public int Tamanho1 { get => Tamanho; set => Tamanho = value; }
        public int Velocidade1 { get => Velocidade; set => Velocidade = value; }
        public int Energia1 { get => Energia; set => Energia = value; }

        public Asteroide()
        {

        }
        public Asteroide(int posix, int posiy, int tamanho, int velocidade, int energia)
        {
            this.PosicaoX = PosicaoX;
            this.PosicaoY = PosicaoY;
            this.Tamanho1 = tamanho;
            this.Velocidade1 = velocidade;
            this.Energia1 = energia;
        }
        public Asteroide(int posix, int posiy)
        {
            this.Posicao1X = PosicaoX;
            this.Posicao1Y = PosicaoY;
        }

        public string ExibirAsteroides()
        {
            return "Posição X: " + this.Posicao1X + "\nPosição Y: " + this.Posicao1Y + "\nTamanho do asteroide: " + this.Tamanho1 + "\nVelocidade: " + this.Velocidade1 + "\nEnergia: " + this.Energia1 + "\n-";
        }
    }
}
