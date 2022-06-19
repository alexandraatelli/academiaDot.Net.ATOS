/*3.Fazer um laço(repetição) que fique solicitando números ao usuário. 
Se o usuário digitar 0 o programa em VS deve parar. 
Caso contrário, o programa em VS deve informar se o número é par ou ímpar e se ele é um número primo.*/

float numero = 1f;
string continua = "s";

Console.Clear();

while (continua == "s" || continua == "S")
{ 
    Console.Write("Digite um número: ");
    numero = float.Parse(Console.ReadLine());

    if (numero == 0)
    {
        Console.WriteLine($"Número inválido! O programa será fechado.");
        Thread.Sleep(1000);
        break;
    }
    else if (numero >= 1 && numero % 2 == 0)
    {
        Console.Write("O número é Par!");
    }
    else
    {
        Console.Write("O número é Ímpar!");
    }

    if (numero % 2 == 1 || numero == 2)
    {
        Console.WriteLine(" e Primo!");
    }

    Console.Write("\nDigite \"s\" se quer digitar outro número: ");
    continua = Console.ReadLine();
}


// Segunda forma para resolver o problema:


float valor = 1f;
bool primo = true;

Console.Clear();

while (valor  !> 0)
{
    Console.WriteLine("Digite um valor.: ");
    valor = float.Parse(Console.ReadLine());

    if (valor % 2 == 0)
    {
        Console.WriteLine("PAR!");
    }
    else
    {
        Console.WriteLine("ÍMPAR");
    }

    for (int i = 2; i < valor; i++)
    {
        if ((valor % i) == 0)
        {
            primo = false;
        }
    }
    Console.WriteLine("É Primo!");
}