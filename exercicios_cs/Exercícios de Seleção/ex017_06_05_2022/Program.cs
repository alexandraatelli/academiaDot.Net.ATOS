// See https://aka.ms/new-console-template for more information

/*Faça um algoritmo que leia o tamanho dos lados de um triangulo (lado a, b e c), e então diga se esses lados podem ou não formar um triangulo. Para que os lados formem um triângulo, todos os lados devem ser menores ou iguais a soma dos outros dois lados. Caso os lados forem um triangulo, diga se o mesmo é equilátero (todos os lados iguais), isoceles(somente 2 lados são iguais) ou escaleno(os 3 lados são diferentes).*/

float ladoA;
float ladoB;
float ladoC;

Console.Clear();

Console.Write("Digite o lado A: ");
ladoA = float.Parse(Console.ReadLine());

Console.Write("\nDigite o lado B: ");
ladoB = float.Parse(Console.ReadLine());

Console.Write("\nDigite o lado C: ");
ladoC = float.Parse(Console.ReadLine());


if (ladoA == ladoB && ladoB == ladoC)
    {
        Console.Write("\nÉ um Triângulo Equilátero!\n");
    }
    else if (ladoA != ladoB && ladoB != ladoC)
    {
        Console.Write("\nÉ um Escaleno!\n");
    }
        else if (ladoA == ladoB || ladoA == ladoC || ladoB == ladoC) 
            {
                Console.Write("\nÉ um Isóceles!\n");
            }

           