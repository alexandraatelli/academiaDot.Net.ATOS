// See https://aka.ms/new-console-template for more information

/* Faça um algoritmo para calcular e mostrar a área de um triângulo a partir dos valores 
da base e da altura lidos pelo teclado: Área do triangulo = (base * altura) / 2; 
Teste se a base ou a altura digitada não foi igual a zero.*/


float baseTriangulo;
float alturaTriangulo;

Console.Clear();


Console.Write("\nDigite a base do triangulo: ");
baseTriangulo = float.Parse(Console.ReadLine());
    if (baseTriangulo != 0)
    {
        Console.WriteLine("A base do triangulo é: " + baseTriangulo + ", portanto não é igual a zero! ");
    }

Console.Write("\nDigite a altura do triangulo: ");
alturaTriangulo = float.Parse(Console.ReadLine());
    if (alturaTriangulo != 0)
    {
        Console.WriteLine("A altura do triangulo é: " + alturaTriangulo + ", portanto não é igual a zero! ");
    }

float areaTriangulo = (baseTriangulo * alturaTriangulo) / 2;
Console.WriteLine("\nA área do tringulo é: " + areaTriangulo);


