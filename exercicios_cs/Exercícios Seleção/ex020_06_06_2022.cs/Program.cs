// See https://aka.ms/new-console-template for more information

/*Escreva um algoritmo para o jogo de adivinhação do número secreto. O jogador tem 3 chances e recebe dicas do tipo “é maior” ou “é menor”. 
Plus: você pode gerar o número de forma randomica (função random c#).*/


Random numeroAleatorio = new Random(); //Instância objeto classe random
int numeroGerado = numeroAleatorio.Next(1, 10); //Gera número entre 1 e 10
int numeroDigitado;
int tentativas = 3;

Console.WriteLine("======> " + numeroGerado); //Descomentar para saber o número gerado e testar

Console.WriteLine("Jogo de adivinhação. Você terá " + tentativas + " tentativas. Vamos lá!\n\n");

for (int x = 1; x <= tentativas; x++)
{
    Console.Write("\nTente adivinhar o número entre 1 e 10, essa é sua tentativa nº: " + x + "\n");
    numeroDigitado = int.Parse(Console.ReadLine());

    if (numeroDigitado != numeroGerado)
    {
        if (x != tentativas && numeroDigitado < numeroGerado)
        {
            Console.Write("\nO número digitado é menor que o número secreto!\n");
        }
        else 
        {
            Console.Write("\nO número digitado é maior que o número secreto!\n");
        }
        
        if (x == tentativas)
        {
            Console.WriteLine("\nNão foi desta vez! Tente novamente!\n\n");
            Console.WriteLine("\nO número secreto era: " + numeroGerado + "\n"); 
        }
    }
    else
    {
        Console.WriteLine("\n\nParabéns, você acertou!!!\n");
        break;
    }
}

Console.WriteLine("\n\nFim do jogo!\n");
