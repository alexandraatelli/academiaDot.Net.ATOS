using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ex009_Veiculos_cs
{
    internal class Util
    {
        private static string CadastroVeiculos;

        public static void exibirLista(string frase, List<Veiculo> lista)
        {
            Console.WriteLine(frase);
            foreach (Veiculo i in lista)
            {
                Console.WriteLine(i.placaCarro + " - " + DateTime.Now.ToString("f"));
            }
        }
        public static void carregarLista(List<Veiculo>lista)
        {
            StreamReader leitor;
            string nomeArquivo = CadastroVeiculos;
            string[] vetorDados;
            
            try
            {
                leitor = new StreamReader(nomeArquivo);
                do
                {
                    vetorDados = leitor.ReadLine().Split(";"); // placa; dataHora
                    lista.Add(new Veiculo(vetorDados[0], vetorDados[1]));
                } while (leitor.EndOfStream); //repete-se a leitura da linha até que o leitor não chegue no final do arquivo
            }
            
            catch (Exception e)
            {
                Console.WriteLine("Arquivo de veículos com problemas ou inexistente!");
            }

        }

        internal static void CadastrarVeiculo(string v, object? cadastrarVeiculo)
        {
            throw new NotImplementedException();
        }

        internal static void exibirLista(string v, object? cadastrarVeiculo)
        {
            throw new NotImplementedException();
        }

        private static bool jaCadastradro(Veiculo objeto, List<Veiculo>lista)
        {
            foreach (Veiculo i in lista)
            {
                if (objeto.placaCarro.Equals(i.placaCarro))
                    {
                        return true;
                    }
                }
                return false;
        }
        
        private static void gravarArquivo(Veiculo objeto)
        {
            try
            {
                StreamWriter escritor = new StreamWriter("CadastroVeiculos.dat", true);

                escritor.WriteLine(objeto.placaCarro + ";" + objeto.dateHora);
                escritor.Flush();
                escritor.Close();
            }
            catch (Exception e)
            {
                Console.WriteLine("Arquivo de Cadastro de Veiculos com problemas!");
            }
        }
        
        public static void CadastrarVeiculo(string frase, List<Veiculo> lista)
        {
            Console.WriteLine(frase);
            string placaCarro;
            string[] vetorDados;
            do
            {
            Console.Write("Digite a placa do veiculo: ");
                placaCarro = Console.ReadLine();
            vetorDados = placaCarro.Split(',');
                if (vetorDados.Length < 2)
                {
                    Console.WriteLine("Digite as letras e numero da placa do veículo");
                }
                else
                {
                    break;  
                }
            } while (true);

            Veiculo objeto = new(placaCarro: placaCarro);

            if (!Util.jaCadastradro(placaCarro, lista))
            {
                lista.Add(objeto);
                //gravar no arquivo
                Util.gravarArquivo(objeto);
            }
            else
            {
                Console.WriteLine("Veículo já está na base de dados!");
            }
        }

        private static bool jaCadastradro(string placaCarro, List<Veiculo> lista)
        {
            throw new NotImplementedException();
        }
    }
}
