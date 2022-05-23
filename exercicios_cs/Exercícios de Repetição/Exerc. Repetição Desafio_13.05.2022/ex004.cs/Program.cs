/*4.Faça um algoritmo que leia uma lista de números inteiros positivos terminada pelo número 0 (zero). 
Ao final, o algoritmo deve mostrar a média aritmética de todos os números lidos (excluindo o zero).*/

int numero = 0;
int acumulador = 0;
int quantNumerosDigitados = 0;

do
{
    Console.Clear();
    Console.WriteLine("Digite um número inteiro e positivo: ");
    numero = int.Parse(Console.ReadLine());
    quantNumerosDigitados = quantNumerosDigitados + 1; // quantidades de numeros digitados - provenientes da quantidade do laço de repetição.

    acumulador = acumulador + numero;

} while (numero > 0);

Console.WriteLine(quantNumerosDigitados - 1); // Conferência da "quantidade números digitados - 1" porque: foi a quantidade de ciclos do while, e, ele somou + 1 quando passou pelo zero, e, o zero deve ser excluido do calculo da média. (considera somente o número de valores válidos).
Console.WriteLine(acumulador); // Conferência da soma.
Console.WriteLine((float)acumulador / (quantNumerosDigitados - 1)); // acumulador é a soma dos valores digitados.