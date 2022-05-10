// See https://aka.ms/new-console-template for more information

/*Faça um programa para uma loja de tintas. O programa deverá pedir o tamanho em metros quadrados da área a ser pintada. Considere que a cobertura da tinta é de 1 litro para cada 3 metros quadrados e que a tinta é vendida em latas de 18 litros, que custam R$ 80,00. Informe ao usuário a quantidades de latas de tinta a serem compradas e o preço total.*/

float areaPintarM2;
int quantLatasTinta;

Console.Clear();

Console.Write("\nDigite a area em M2 a ser pintada: ");
areaPintarM2 = int.Parse(Console.ReadLine());

quantLatasTinta =(int)((areaPintarM2 / 3) / 18); // Parte inteira da divisão
    if ((areaPintarM2 / 3) % 18 > 0)
    {
        quantLatasTinta = quantLatasTinta + 1;
    }

Console.Write("\nA quantidade de latas de tinta para cobrir os " + areaPintarM2 + " é de: " + quantLatasTinta + " lata(s)\n");


