// See https://aka.ms/new-console-template for more information

//Escreva um algoritmo que leia 3 valores pelo teclado e então informe qual o maior deles.

float valor1;
float valor2;
float valor3;

Console.Clear();

Console.Write("Digite o primeiro valor: \n");
valor1 = float.Parse(Console.ReadLine());

Console.Write("Digite o segundo valor: \n");
valor2 = float.Parse(Console.ReadLine());

Console.Write("Digite o terceiro valor: \n");
valor3 = float.Parse(Console.ReadLine());

if (valor1 > valor2 && valor1 > valor3)
{
    Console.WriteLine("\nO maior valor é: " + valor1 + "\n");
}
else if (valor2 > valor3)
{
    Console.WriteLine("\nO maior valor é: " + valor2 + "\n");
}
else
{
    Console.WriteLine("\nO maior valor é: " + valor3 + "\n");
}
