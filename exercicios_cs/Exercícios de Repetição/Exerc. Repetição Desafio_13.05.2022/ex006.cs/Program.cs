/*6.Faça um programa que leia um número n e imprima se ele é primo ou não. (um número primo tem apenas 2 divisores: 1 e ele mesmo! O número 1 não é primo!!!)*/

int numero = 1;

Console.Clear();
Console.WriteLine("Digite um número qualquer: ");
numero = int.Parse(Console.ReadLine());

    if (numero % 2 == 1 || numero == 2)
    {
        Console.WriteLine($"O número {numero} é Primo!");
    }
    else
    {
        Console.WriteLine("O número não é Primo!");
    }
