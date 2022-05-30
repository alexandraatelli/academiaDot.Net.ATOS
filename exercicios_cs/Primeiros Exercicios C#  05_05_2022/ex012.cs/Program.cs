// See https://aka.ms/new-console-template for more information

Console.WriteLine("\nUm motorista de taxi deseja calcular o rendimento de seu carro na praça. Sabendo-se que o preço do combustível é de R$6,90. Escreva um algoritmo para ler a marcação do odômetro(marcador de quilometragem) no início do dia; a marcação no final do dia, o número de litros de combustível gasto e o valor total (R$) recebido dos passageiros. Calcule e escreva a média do consumo em Km/l e o lucro líquido do dia. Fórmulas: (Total quilometragem = marcação odômetro final do dia - marcação odômetro inicio do dia) - (Média do consumo = Total quilometragem/ quantidade de combustível gasto) - (Lucro do dia = Valor total recebido - (quantidade de combustível gasto * 6,90)");


float odometroInicial, odometroFinal;
float kmPercorridoDia;
float quantCombustivelDia;
float valorlitroCombus = 6.90f; // ´"f demonstra que o número digitado é um float
float valorRecebidoDia;


Console.Clear();


Console.Write("\nDigite a marcação inicial do odômetro do dia: ");
odometroInicial = float.Parse(Console.ReadLine());

Console.Write("nDigite a marcação final do odômetro do dia: ");
odometroFinal = float.Parse(Console.ReadLine());

kmPercorridoDia = (odometroFinal - odometroInicial);
Console.Write("\nO total de Km percorrido no dia é de: " + kmPercorridoDia + " Km \n");

Console.Write("\nDigite a quantidade total de combustível em litros, gastos no dia: ");
quantCombustivelDia = float.Parse(Console.ReadLine());

Console.Write("\nDigite o valor do combustível por litro do dia: R$ " + valorlitroCombus.ToString("f"));

Console.Write("\nDigite o valor recebido no dia: R$ ");
valorRecebidoDia = float.Parse(Console.ReadLine());

Console.Write("\nA média de consumo de combustível no dia foi de: " + ((kmPercorridoDia / quantCombustivelDia).ToString("f")) + " litros por Km rodado.\n");

Console.Write("\nO lucro do dia obtido foi de: R$ " + ((valorRecebidoDia - (quantCombustivelDia * valorlitroCombus)).ToString("f")) + " reais.\n");


// Outra forma, que poderia ter sido realizado o exercício seria a criação da variável LucroLiquidoDia = (valorRecebidoDia - (quantCombustivelDia * valorlitroCombus) - que seria uma boa prática, possibilitando melhor manutenção do código, se o caso.


