// See https://aka.ms/new-console-template for more information

/*Faça um programa em C# e no VS para receber uma frase qualquer e uma palavra de pesquisa.
O programa deve avaliar se a palavra aparece na frase, informando o usuário via mensagem, como por 
exemplo, A palavra encontra-se na frase ou A palavra não se encontra na frase.*/

string frase;
string palavraPesquisa;

Console.Clear();

Console.Write("\nDigite uma frase qualquer: ");
frase = Console.ReadLine();

Console.Write("\nA frase que você digitou é: " + frase);

Console.Write("\nDigite a frase de pesquisa: ");
palavraPesquisa = Console.ReadLine();

//StringComparison.OrdinalIgnoreCase: Específica explicitamente as regras de comparação de cadeia de caracteres, neste caso, para Case Insensitive. 

if (frase.Contains(palavraPesquisa, StringComparison.OrdinalIgnoreCase)) 
{
    Console.WriteLine("\nO techo informado consta na frase digitada.\n");
}
else
{
    Console.Write("\nO trecho digitado não consta na frase.\n");
}


//Referência: https://docs.microsoft.com/pt-br/dotnet/standard/base-types/best-practices-strings