CConsole.WriteLine("Exercício 3: Escreva a seqüência de atribuições, em forma de programa em C# e no Visual Studio, \n" +
    "para trocar entre si os valores de duas variáveis A e B");

// Optamos por uma variável do tipo string, tendo em vista que o usuário poderia digitar qualquer letra ou número,
// uma vez que o resultado seria o mesmo, ou seja, a troca dos valores das duas variáveis entre sí.
// Também poderiamos realizá-lo com outro tipo de variável, como o int ou float, desta forma, no Console.Write
// estariamos solicitado exatamente: "Digite um número qualquer" e não uma frase, por exemplo.

// Oservação: a utilização da "variável tmp" fez a ponte para troca das duas variáveis, conforme enunciado do exercício.


Console.Clean();

Console.WriteLine("Processo de troca de valores entre duas variáveis");

Console.Write("\nDigite uma frase qualquer: ");
string variavel1 = Console.ReadLine();

Console.Write("\nDigite outra frase qualquer: ");
string variavel2 = Console.ReadLine();

string tmp = variavel1;
variavel1 = variavel2;
variavel2 = tmp;

Console.WriteLine("O conteúdo da variavel1 é: " + variavel1);
Console.WriteLine("O conteúdo da variavel2 é: " + variavel2);


