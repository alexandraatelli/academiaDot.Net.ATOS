
Console.WriteLine("Escreva um programa em C# e no Visual Studio para calcular a média aritmética entre dois números quaisquer.\n");

// O tipo float foi utilizado pois não se sabe o que o usuário pode digitar, se, numero inteiro ou decimal por exemplo.

// Tudo é objeto no C# - https://docs.microsoft.com/pt-br/dotnet/csharp/fundamentals/types/
// Você tem um objeto "float" quqe trabalha com valores com casa decimal, que é o float.


float numero1; 
float numero2;
float mediaAritmetica;


Console.Clear(); // Limpa a tela para execução fora da IDE.

Console.Write("\nDigite um número qualquer: ");
numero1 = float.Parse(Console.ReadLine()); // "float" é objeto e o "Parse" é o método que é equivalente a uma função. 
                                           // "Função é um conjunto de instruções com entradas e uma saída, pois pode ter
                                           // vários parâmetros de entrada.

Console.Write("\nDigite um segundo número qualquer: ");
numero2 = float.Parse(Console.ReadLine());

mediaAritmetica = (numero1 + numero2) / 2;

Console.Write("\nA média aritmética dos valores é de: " + mediaAritmetica);

// Nota: Qualquer operação que tiver como origem o Console.ReadLine que não for string, deve-se convertê-la ao tipo apropriado:
// int, float, data....


// outra forma de apresentar o resultado:

Console.WriteLine("\n\nA média aritmética dos valores é de: " + (numero1 + numero2) / 2 + " (sem variável de resultado)"); 


