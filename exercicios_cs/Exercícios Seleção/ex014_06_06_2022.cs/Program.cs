// See https://aka.ms/new-console-template for more information

/*Faça um programa que peça o tamanho de um arquivo para download (em MB) e a velocidade de um link de Internet (em Mbps). Em seguida, calcule e informe o tempo aproximado de download do arquivo usando este link (em minutos).

1 MB = (1024 * 1024 * 8) = 8.388.608 bits
1 Mb = 1.000.000 bits*/

float tamanhoArquivo;
float capacidadeLink;

Console.Clear();

Console.Write("\nDigite o tamanho do arquivo em MB: ");
tamanhoArquivo = float.Parse(Console.ReadLine());

Console.Write("\nDigite a capacidade do Link em Mbps: ");
capacidadeLink = float.Parse(Console.ReadLine()) * 1000000; // cada MB vale 1 milhão.
capacidadeLink = ((capacidadeLink / 8) / 1024) / 1024; // convertido capacidade do link em MB.

Console.Write("\nO tempo aproximado de download do arquivo será de: " + ((tamanhoArquivo / capacidadeLink) / 60).ToString("f") + " minutos.\n");

// dividiu MB por MB, e, dividiu o resultado por 60, para achar em minutos.

/*
Digite o tamanho do arquivo em MB: 45
Digite a capacidade do Link em Mbps: 12040 equivale a um link de 10Gbs - compatível com a capacidade do "float"
O tempo aproximado de download do arquivo será de: 0,00 minutos.*/

