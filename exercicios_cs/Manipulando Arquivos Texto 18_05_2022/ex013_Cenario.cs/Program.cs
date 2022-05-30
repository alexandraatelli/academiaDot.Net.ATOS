/*013 - Crie uma classe para representar um item de cenário, com os atributos privados de:
 * descrição(string);
 * data de criação(date - https://docs.microsoft.com/en-us/dotnet/api/system.datetime.date?view=net-6.0); e
 * altura(float).

*Crie os métodos públicos necessários para sets e gets, o construtor básico e também um método 
*para imprimir todos dados de um item de cenário. 

* Por fim, crie um método para calcular a quanto tempo o item foi criado, além de um programa 
* em C# para testar a classe criada.*/


using ex013_Cenario.cs;

string descricao;
DateTime dataDeCriacao;
float altura;

Console.Clear();

Console.Write("Digite a descrição do Cenário: ");
descricao = Console.ReadLine();

Console.Write("Digite a data de criação do Cenário: ");
dataDeCriacao = DateTime.Parse(Console.ReadLine());

Console.WriteLine("Digite a altura do Cenário: ");
altura = float.Parse(Console.ReadLine());


Cenario item = new Cenario(descricao, dataDeCriacao, altura);

Console.WriteLine(item.ExibirItem());
item.TempoCriacao();



