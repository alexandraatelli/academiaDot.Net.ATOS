// See https://aka.ms/new-console-template for more information

/*(3 - Escrever um algoritmo para ler quatro valores inteiros, calcular a sua média, e 
escrever na tela os que são superiores à média). Ajuste o exercício 3 de maneira que mostre os VALORES INFORMADOS em ordem crescente.*/


//Somente os valores informados:
int numero1; 
int numero2;
int numero3;
int numero4;
int aux; // Necessária para troca de valores entre variáveis.

Console.Clear();


Console.Write("\nDigite o primeiro número: ");
numero1 = int.Parse(Console.ReadLine());

Console.Write("\nDigite o segundo número: ");
numero2 = int.Parse(Console.ReadLine());

Console.Write("\nDigite o terceiro número: ");
numero3 = int.Parse(Console.ReadLine());

Console.Write("\nDigite o quarto número: ");
numero4 = int.Parse(Console.ReadLine());

// Implementaçã do algoritmo Bubble Sort.
for (int i = 0; i < 4; i++) // Quatro é o número da quantidade de valores.
{
    // Ficou em ordem crescente por causa da lógica.
    if (numero3 > numero4)
    {
        aux = numero4;
        numero4 = numero3;
        numero3 = aux;
    }
    if (numero2 > numero3)
    {
        aux = numero3;
        numero3 = numero2;
        numero2 = aux;
    }
    if (numero1 > numero2)
    {
        aux = numero2;
        numero2 = numero1;
        numero1 = aux;
    }
}
Console.Write("\n"+ numero1 + " " + numero2 + " " + numero3 + " " + numero4 +"\n");



//Referência: https://blog.betrybe.com/tecnologia/bubble-sort-tudo-sobre/

//Nota: Procurando alternativa, verificou-se o algoritimo Bubble Sorte, originalmente implementado sob vetores, porém, diante do momento atual de aprendizado, utilizamos variáveis nomeadas.