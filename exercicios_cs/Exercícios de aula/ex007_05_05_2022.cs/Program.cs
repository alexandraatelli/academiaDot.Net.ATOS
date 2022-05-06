// See https://aka.ms/new-console-template for more information

/*Faça um programa em C# e no VS para receber uma frase qualquer e uma palavra de pesquisa.
O programa deve avaliar se a palavra aparece na frase, informando o usuário via mensagem, como por 
exemplo, A palavra encontra-se na frase ou A palavra não se encontra na frase.*/

string frase;
string palavraPesquisa;

Console.Clear();

Console.WriteLine("Digite uma frase qualquer: ");
frase = Console.ReadLine();

Console.WriteLine("A frase que você digitou é: " + frase);

Console.WriteLine("Digite a frase de pesquisa: ");
palavraPesquisa = Console.ReadLine();

Console.WriteLine("A palavra que você digitou a ser pesquisada na frase é: " + frase.Contains(palavraPesquisa));

