/*Console.WriteLine("Um programa para gerenciar os saques de um caixa eletrônico deve possuir algum mecanismo \n" +
    "para decidir o número de notas de cada valor que deve ser disponibilizado para o cliente que \n" +
    "realizou o saque.Um possível critério seria o da “distribuição ótima” no sentido de que as \n" +
    "notas de menor valor fossem distribuídas em número mínimo possível.\n" +
    "Por exemplo, se a quantia solicitada fosse R$ 87, 00 o programa deveria indicar uma nota de R$ 50, 00, \n" +
    "três notas de R$ 10, 00, uma nota de R$ 5, 00 e duas notas de R$ 1, 00. \n" +
    "Escreva um programa que receba o valor da quantia solicitada e retorne a distribuição das notas \n" +
    "de acordo com o critério da distribuição ótima. \n");*/


int valorSaque, resto;
int nota200;
int nota100;
int nota50;
int nota20;
int nota10;
int nota5;
int nota2;


Console.Clear();


Console.Write("Digite o valor do saque: R$ ");
valorSaque = int.Parse(Console.ReadLine());

nota200 = valorSaque / 200;
resto = valorSaque % 200;

nota100 = resto / 100;
resto = resto % 100;

nota50 = resto / 50;
resto = resto % 50;

nota20 = resto / 20;
resto = resto % 20;

nota10 = resto / 10;
resto = resto % 10;

nota5 = resto / 5;
resto = resto % 5;

nota2 = resto / 2;
resto = resto % 2;

    if (resto > 0)
    {
        Console.WriteLine("Valor inválido de acordo com as notas disponíveis no Caixa Eletrônico!");
    }
    else 
    {

        if (nota200 > 0)
        {
            Console.WriteLine(nota200 + " Nota de 200 reais ");
        }

        if (nota100 > 0)
        {
            Console.WriteLine(nota100 + " Nota de 100 reais ");
        }

        if (nota50 > 0)
        {
            Console.WriteLine(nota50 + " Nota de 50 reais ");
        }

        if (nota20 > 0)
        {
            Console.WriteLine(nota20 + " Nota de 20 reais ");
        }

        if (nota10 > 0)
        {
            Console.WriteLine(nota10 + " Nota de 10 reais ");
        }

        if (nota5 > 0)
        {
            Console.WriteLine(nota5 + " Nota de 5 reais ");
        }

        if (nota2 > 0)
        {
            Console.WriteLine(nota2 + " Nota de 2 reais ");
        }
}


// As variáveis de quantidade notas foram definidas para: facilitar a seleção de notas a serem fornecidas ao cliente.
// As notas só serão exibidas após a confirmação de que: é possível a divisão do valor solicitado pelos tipos de nota, situação onde a variável resto for igual a 0 (zero).

