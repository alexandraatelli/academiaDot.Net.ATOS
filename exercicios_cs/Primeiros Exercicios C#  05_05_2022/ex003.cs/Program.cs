Console.WriteLine("Exercício 3: Escreva a seqüência de atribuições,em forma de programa em C# e no Visual Studio, \n" +
    "para trocar entre si dos valores de duas variáveis A e B");

//Optamos uma variável do tipo string, tendo em vista que o usuário poderia digitar qualquer letra ou número. 
//Esse exercício também poderia ter sido realizado com o tipo int ou float, realizando as conversões necessárias.
// Outra observação é a utilização da "string tmp" como ponte para troca das duas variáveis, de acordo enunciado do exercício.

string variavelA;
string variavelB;

Console.Clear();

Console.WriteLine("\nProcesso de troca de valores entre duas variáveis\n");

Console.Write("\nDigite uma frase qualquer: ");
variavelA = Console.ReadLine();

Console.Write("\nDigite outra frase qualquer: ");
variavelB = Console.ReadLine();

string tmp = variavelA;
variavelA = variavelB;
variavelB = tmp;

Console.Write("\nO conteúdo da variavelA é: " + variavelA);
Console.Write("\nO conteúdo da variavelB é: " + variavelB + "\n");


