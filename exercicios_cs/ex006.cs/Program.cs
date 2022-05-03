Console.WriteLine("Escreva um programa em C# e no Visual Studio que leia os dados para o parafuso A e para o parafuso B, isto é, o código, a quantidade de peças e o valor unitário de cada parafuso e a porcentagem de IPI(única) a ser acrescentada.");

string codParafA;
string codParafB;
int quantParafA;
int quantParafB;
float valorUnitParafA;
float valorUnitParafB;
float porcentIPI;


Console.Clear();


Console.Write("\nDigite o código do Parafuso A: ");
codParafA = Console.ReadLine();

Console.Write("\nDigite a quantidade do Parafuso A: ");
quantParafA = int.Parse(Console.ReadLine());

Console.Write("\nDigite o valor unitário do Parafuso A: R$ ");
valorUnitParafA = float.Parse(Console.ReadLine());



Console.Write("\n\nDigite o código do Parafuso B: ");
codParafB = Console.ReadLine();

Console.Write("\nDigite a quantidade do Parafuso B: ");
quantParafB = int.Parse(Console.ReadLine());

Console.Write("\nDigite o valor unitário do Parafuso B: R$ ");
valorUnitParafB = float.Parse(Console.ReadLine());



Console.Write("\n\nDigite a porcentagem da aliquota do IPI para o produto - parafuso: ");
porcentIPI = float.Parse(Console.ReadLine());



Console.WriteLine("\nO custo total do parafuso A para " + quantParafA + " unidades é de: R$ " + ((quantParafA * valorUnitParafA) * (1 + (porcentIPI / 100))) + " reais, já incluso a aliquota do IPI de " + porcentIPI + " %.");


Console.WriteLine("\nO custo total do parafuso B para " + quantParafB + " unidades é de: R$ " + ((quantParafB * valorUnitParafB) * (1 + (porcentIPI / 100))) + " reais, já incluso a aliquota do IPI de " + porcentIPI + " %. ");



// Nota: (1 + (porcentIPI / 100) - foi a forma adotada para o cálculo da aplicação do IPI sobre o valor total do produto.

