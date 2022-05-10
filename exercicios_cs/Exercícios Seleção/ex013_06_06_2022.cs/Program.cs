// See https://aka.ms/new-console-template for more information

/*Tendo como dado de entrada a altura (h) de uma pessoa, construa um programa no VS que calcule 
seu peso ideal, utilizando as seguintes fórmulas:
Para homens: (72.7 * h) - 58int
Para mulheres: (62.1 * h) - 44.7*/


float altura;

Console.Clear();

Console.Write("\nDigite sua altura: ");
altura = float.Parse(Console.ReadLine());

Console.Write("\nSe você for mulher seu peso ideal é de: " + ((62.1 * altura) - 44.7).ToString("f") + "\n"); 

Console.Write("\nSe você for homem seu peso ideal é de: " + ((72.7 * altura) - 58).ToString("f") + "\n");

