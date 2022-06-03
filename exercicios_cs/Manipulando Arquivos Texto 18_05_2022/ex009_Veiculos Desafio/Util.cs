using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ex009_Veiculos_cs
{
    internal class Util // uso interno no meu programa
    {
        public static void exibirLista(string frase, List<Veiculo> lista) // aqui fim, escrito lista, sempre
                                                                          // deixar um epaço "> lista)"
        {
            Console.WriteLine(frase);
            foreach (Veiculo i in lista) // percorrer a lista e ver se o carro está nela
            {
                Console.WriteLine(i.PlacaCarro + " - " + DateTime.Now.ToString("f")); // mostra data e hora local
            }                                                                         // do sistema, ou seja,
        }                                                                             // a hora real do meu país
 
        public static void carregarLista(List<Veiculo> lista)// sempre dar espaço antes lista, Carrega a lista
        {
            StreamReader leitor;
            string nomeArquivo = "cadastroVeiculos.dat"; // inicia com minúsculo. Vamos carregar após ler
            string[] vetorDados;
            
            try
            {
                leitor = new StreamReader(nomeArquivo); // nome da variável entre parentes
                do
                {
                    vetorDados = leitor.ReadLine().Split(";"); // placa; dataHora
                    lista.Add(new Veiculo(vetorDados[0], DateTime.Parse(vetorDados[1])));
                } while (leitor.EndOfStream); //repete-se a leitura da linha até que o leitor não
                                              //chegue no final do arquivo
                leitor.Close(); // método que fecha o leitor
            }   
            catch (Exception e)
            {
                Console.WriteLine("Arquivo de veículos com problemas ou inexistente!" + e.Message);
            }
        }
                
        private static bool jaCadastrado(Veiculo objeto, List<Veiculo>lista) // verifica se o veiculo
                                                                             // já está cadastrado na lista
        {
            foreach (Veiculo i in lista)
            {
                if (objeto.PlacaCarro.Equals(i.PlacaCarro)) // vê se a Placa do Carro já existe na lista
                    {
                        return true;
                    }
                }
                return false;
        }
        private static void gravarArquivo(Veiculo objeto) // cadastrar o objeto
        {
            try
            {
                StreamWriter escritor = new StreamWriter("cadastroVeiculos.dat", true);

                escritor.WriteLine(objeto.PlacaCarro + ";" + objeto.DataHora);
                escritor.Flush();// salva a lista
                escritor.Close();// finaliza
            }
            catch (Exception e)
            {
                Console.WriteLine("Arquivo de Cadastro de Veiculos com problemas!" + e.Message);
            }
        }
        
        public static void cadastrarVeiculo(string frase, List<Veiculo> lista) 
        {
            Console.WriteLine(frase); // Digitar a placa do veiculo - placaCarro
            string placaCarro;
            
            do
            {
                Console.Write("Digite a placa do veiculo: ");
                placaCarro = Console.ReadLine();
                if (placaCarro.Length == 7) // placa com 7 digitos - fora isso dá inválido
                {
                    break;
                }
                else
                {
                    Console.WriteLine("Placa inválida, fique atento a quantidade de dígitos");
                }
            
            } while (true);

            DateTime dataHora = DateTime.Now; // sistema capturou a data e hora atual no momento
                                              // do cadastro do veículo

            Veiculo objeto = new Veiculo(placaCarro, dataHora); // lá no construtor do veiculo está esperando
                                                                // uma placa e uma hora que é string

            if (!Util.jaCadastrado(objeto, lista))// o objeto da linha 95
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
    }
}
