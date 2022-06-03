// See https://aka.ms/new-console-template for more information

//Escrever um algoritmo para ler a quantidade de horas aula dadas por dois professores e o valor por hora recebido por cada um deles. Mostrar na tela qual dos professores tem o maior salário total.

int quantHorasAulasProfA;
int quantHorasAulasProfB;
float valorHoraAula = 100;
float valorRecebidoProfA;
float valorRecebidoProfB;

Console.Clear();


Console.Write("\nDigite a quantidade de horas aulas realizadas pelo Professor A: ");
quantHorasAulasProfA = int.Parse(Console.ReadLine());

Console.Write("\nDigite a quantidade de horas aulas realizadas pelo Professor B: ");
quantHorasAulasProfB = int.Parse(Console.ReadLine());


valorRecebidoProfA = quantHorasAulasProfA * valorHoraAula;
Console.Write("\nO valor recebido pelo Professor A pelas " + quantHorasAulasProfA + " aulas, perfaz o total de: R$ " + valorRecebidoProfA.ToString("f") + " reais.\n");


valorRecebidoProfB = quantHorasAulasProfB * valorHoraAula;
Console.Write("\nO valor recebido pelo Professor B pelas " + quantHorasAulasProfB + " aulas, perfaz o total de: R$ " + valorRecebidoProfB.ToString("f") + " reais.\n");



