/* 10 - Animais: 
Crie um programa em C# no qual o usuário deverá informar o nome e o tipo de 3 animais 
de estimação. O programa deverá exibir na tela para o usuário quantos Cachorros, Gatos e Peixes 
foram informados.
Regras que deverão ser seguidas para a implementação do programa:
- Os únicos tipos de animais válidos são Cachorro, Gato, Peixe.
- Caso seja informado um tipo diferente o programa repetir até o usuário digitar 
um tipo válido.
- É obrigatório criar uma classe para representar o Animal.
- A classe deverá possuir dois dados privados (propriedades) para representar as 
características do animal.
- A classe deverá possuir métodos de acesso (propriedade getter e setter) para permitir 
que o usuário armazene/leia os dados dos dois dados privados (propriedades).*/

using ex010_Animais.cs;

string nome;
string tipo;
int quantCachorro = 0;
int quantGato = 0;
int quantPeixe = 0;
int quantDados = 3;

List<Animais> listaAnimais = new List<Animais>();

for (int i = 1; i <= quantDados; i++)
{
    do
    {
        Console.Clear();
        Console.WriteLine("Qual o nome do seu animal?");
        nome = Console.ReadLine().ToUpper();
        Console.WriteLine("Qual o tipo do seu animal?Escolha entre: Cachorro, Gato ou Peixe: ");
        tipo = Console.ReadLine().ToUpper();

        if (tipo.Equals("CACHORRO") || tipo.Equals("GATO") || tipo.Equals("PEIXE"))
        {

            listaAnimais.Add(new Animais(nome, tipo));
        }
        else
        {
            Console.WriteLine("Entrada inválida!");
            Thread.Sleep(1000);
        }
    } while (!tipo.Equals("CACHORRO") && !tipo.Equals("GATO") && !tipo.Equals("PEIXE"));
}

foreach (Animais i in listaAnimais)
{ 
    if (i.Tipo.Equals("CACHORRO"))
    {
        quantCachorro++;
    }
        else if (i.Tipo.Equals("GATO"))
        {
            quantGato++;
        }
            else if (i.Tipo.Equals("PEIXE"))
            {
                quantPeixe++;
            }
}

Console.WriteLine($"Quantidades: {quantCachorro} cachorros; {quantGato} gatos e {quantPeixe} peixes.");