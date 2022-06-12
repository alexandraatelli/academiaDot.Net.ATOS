using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WindowsFormsGaragem
{
    internal class Persistencia
    {
        public static void GravarNoArquivoEntrada(List<Veiculo> lista)
        {
            StreamWriter escritor = new StreamWriter("veiculosEntrada.dat");

            foreach (Veiculo i in lista)
            {
                escritor.WriteLine(i.Placa + ";" + i.DataEntrada + ";" + i.HoraEntrada);
            }
            escritor.Close();
        }
        public static void GravarNoArquivoSaida(List<Veiculo> lista)
        {
            StreamWriter escritor = new StreamWriter("veiculosSaida.dat");

            foreach (Veiculo i in lista)
            {
                escritor.WriteLine(i.Placa + ";" + i.DataEntrada + ";" + i.HoraEntrada + ";" + i.DataSaida + ";" + i.HoraSaida + ";" + i.TempoPermanencia + ";" + i.ValorCobrado);
            }
            escritor.Close();
        }

        public static void LerArquivoEntrada(List<Veiculo> lista)
        {
            StreamReader leitor = new StreamReader("veiculoSaida.dat");
            string linha;
            string[] vetorDados;

            do
            {
                linha = leitor.ReadLine();
                vetorDados = linha.Split(';');
                lista.Add(new Veiculo(vetorDados[0], vetorDados[1], vetorDados[2], vetorDados[3], vetorDados[4], int.Parse(vetorDados[5]),
                    double.Parse(vetorDados[6])));
            } while (!leitor.EndOfStream);
        }
    }
}
