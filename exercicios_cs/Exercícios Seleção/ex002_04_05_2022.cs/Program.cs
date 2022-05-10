// See https://aka.ms/new-console-template for more information

/*Faça um algoritmo para ler um número e verificar se ele é par ou ímpar. */

int numero;

Console.Clear();

Console.WriteLine("Digite um número qualquer; ");
numero = Convert.ToInt32(Console.ReadLine());

if (numero % 2 == 0)
{
    Console.WriteLine("O número digitado é PAR");
}
else
{
    Console.WriteLine("O número digitado é ÍMPAR");
}