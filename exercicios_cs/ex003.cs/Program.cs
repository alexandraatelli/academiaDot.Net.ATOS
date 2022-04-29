Console.WriteLine("Exercício 3: Escreva a seqüência de atribuições,\n" +
    "em forma de programa em C# e no Visual Studio, para trocar entre\n" +
    "si os valores de duas variáveis A e B");

//Opção por string tendo em vista que o usuário poderia digitar qualquer letra ou número. 
//Esse exercício também poderia ter sido realizado com o tipo int ou float, desta forma no estaria a seguinte solicitação no Console.Write "Digite um número qualquer", exemplificando.

// Outra observação é a utilização da "string tmp" como ponte para troca das duas variáveis, conforme enunciado do exercício.

Console.Write("Digite uma frase qualquer: ");
string variavel1 = Console.ReadLine();

Console.Write("Digite outra frase qualquer: ");
string variavel2 = Console.ReadLine();

Console.WriteLine("O conteúdo da variavel1 é: " + variavel1);
Console.WriteLine("O conteúdo da variavel2 é: " + variavel2);

Console.WriteLine("Processo de troca de valores entre duas variáveis");

string tmp = variavel1;
variavel1 = variavel2;
variavel2 = tmp;

Console.WriteLine("O conteúdo da variavel1 é: " + variavel1);
Console.WriteLine("O conteúdo da variavel2 é: " + variavel2);
