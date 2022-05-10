// See https://aka.ms/new-console-template for more information

/*Escrever um algoritmo para ler quatro valores inteiros, calcular a sua média, e 
escrever na tela os que são superiores à média.*/

int numero1;
int numero2;
int numero3;
int numero4;
int media;

Console.Clear();


Console.Write("\nDigite o primeiro número: ");
numero1 = int.Parse(Console.ReadLine());

Console.Write("\nDigite o segundo número: ");
numero2 = int.Parse(Console.ReadLine());

Console.Write("\nDigite o terceiro número: ");
numero3 = int.Parse(Console.ReadLine());

Console.Write("\nDigite o quarto número: ");
numero4 = int.Parse(Console.ReadLine());

media = (numero1 + numero2 + numero3 + numero4) / 4;
Console.WriteLine("\nA média é de: " + media);


if (numero1 > media)
{
    Console.Write("\nO primeiro número digitado: " + numero1 + " - é maior que a média.\n");
}
    if (numero2 > media)
    {
        Console.Write("\nO segundo número digitado: " + numero2 + " - é maior que a média.\n");
    }
        if (numero3 > media)
        {
            Console.Write("\nO terceiro número digitado: " + numero3 + " - é maior que a média.\n");
        }
            if (numero4 > media)
            {
                Console.Write("\nO quarto número digitado: " + numero4 + " - é maior que a média.\n");
            }