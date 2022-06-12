using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WindowsFormsGaragem
{
    internal class Veiculo
    {
        string placa; // 7 caracteres -> verificar
        string dataEntrada;
        string horaEntrada;
        string dataSaida;
        string horaSaida;
        int tempoPermanencia; // calculado em minutos
        double valorCobrado;

        /// <summary>
        /// Construtor é utilizado para leitura e popilar a lista
        /// </summary>
        /// <param name="placa">identificação do veículo</param>
        /// <param name="dataEntrada">Data do sistema para a entrada do veículo</param>
        /// <param name="horaEntrada">Hora do sistema para a entrada do veículo</param>
        public Veiculo(string placa, string dataEntrada, string horaEntrada)
        {
            this.Placa = placa;
            this.DataEntrada = dataEntrada;
            this.HoraEntrada = horaEntrada;
        }
        public Veiculo(string placa, string dataEntrada, string HoraEntrada,
            string dataSaida, string horaSaida, int tempoPermanencia,
            double valorCobrado) : this(placa, dataEntrada, HoraEntrada)
        {
            this.DataSaida = dataSaida;
            this.HoraSaida = horaSaida;
            this.TempoPermanencia = tempoPermanencia;
            this.ValorCobrado = valorCobrado;
        }

        public void RealizarCobranca(double valorHora)
        {
            //Transformar em minutos:
            //int horaEntrada = "8:14"; -> 8*60+14 = 494 minutos (ponto de entrada)
            //int horaSaida = "10:15"; -> 10*60+15 = 615 minutos (ponto de entrada)
            string[] vetorDados = HoraEntrada.Split(':');
            int hora = int.Parse(vetorDados[0]);
            int minutos = int.Parse(vetorDados[1]);
            int entrada = hora * 60 + minutos;

            vetorDados = HoraSaida.Split(':');
            hora = int.Parse(vetorDados[0]);
            minutos = int.Parse(vetorDados[1]);
            int saida = hora * 60 + minutos;

            this.TempoPermanencia = saida - entrada;
            double resultado = (double)this.TempoPermanencia / 60;
            double qtdHorasNaGaragem = Math.Ceiling(resultado);

            this.ValorCobrado = (int)qtdHorasNaGaragem * valorHora;

            /* Outra forma de realizar a operação:
            gerarDataHora("entrada");
            Console.WriteLine("Entrada: " + dataEntrada + "||" + horaEntrada);
            gerarDataHora("saida");
            Console.WriteLine("Saida: " + dataSaida + "||" + horaSaida);
            double resultado = (double)121 / 60;
            Console.WriteLine(resultado);
            Console.WriteLine(Math.Ceiling(resultado));
            DateTime dataHoraEntrada = DateTime.Now;
            Console.ReadLine();
            DateTime dataHoraSaida = DateTime.Now;
            Console.WriteLine(dataHoraSaida - dataHoraEntrada);
            */
        }

        // Limita quantidade de lugares vagos até quantidade máxima de veiculos suportada
        public static bool TemLugar(List<Veiculo> lista, int tamanhoGaragem)
        {
            return lista.Count < tamanhoGaragem;
        }

        /// <summary>
        /// Método que gera a data e hora para entrada ou saída de veículo
        /// </summary>
        /// <param name="tipo">entrada para gerar a data e hora de entrada; saída para gerar data e hora de saída</param>
        public void GerarDataHora(string tipo)
        {
            DateTime dateTime = DateTime.Now;
            string[] vetorDados = dateTime.ToString().Split(' ');
            switch (tipo)
            {
                case "entrada":
                    this.DataEntrada = vetorDados[0];
                    this.HoraEntrada = vetorDados[1];
                    break;
                case "saida":
                    this.DataSaida = vetorDados[0];
                    this.HoraSaida = vetorDados[1];
                    break;
                default:
                    break;
            }
        }
        public string Placa { get => placa; set => placa = value; }
        public string DataEntrada { get => dataEntrada; set => dataEntrada = value; }
        public string HoraEntrada { get => horaEntrada; set => horaEntrada = value; }
        public string DataSaida { get => dataSaida; set => dataSaida = value; }
        public string HoraSaida { get => horaSaida; set => horaSaida = value; }
        public int TempoPermanencia { get => tempoPermanencia; set => tempoPermanencia = value; }
        public double ValorCobrado { get => valorCobrado; set => valorCobrado = value; }

        public static int Localizado(string placa, List<Veiculo> lista)
        {
            foreach (Veiculo i in lista)
            {
                if (i.Placa.Equals(placa))
                {
                    return lista.IndexOf(i);
                }
            }
            return -27; // codigo do Esc = veículo não localizado
        }
    }
}
