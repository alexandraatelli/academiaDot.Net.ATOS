// See https://aka.ms/new-console-template for more information

/*Faça um programa no VS que receba dados de dois atletas (nome, idade e altura). O programa deve mostrar os dados do atleta mais novo e mais alto.*/

string nomeAtleta1;
string nomeAtleta2;
int idadeAtleta1;
int idadeAtleta2;
float alturaAtleta1;
float alturaAtleta2;

Console.Clear();

Console.Write("\nDigite o nome do atleta1: ");
nomeAtleta1 = (Console.ReadLine());

Console.Write("Digite a idade do atleta1: ");
idadeAtleta1 = int.Parse(Console.ReadLine());

Console.Write("Digite a altura do atleta1: ");
alturaAtleta1 = float.Parse(Console.ReadLine());

Console.Write("\nO atleta1 chama-se " + nomeAtleta1 + ", de idade " + idadeAtleta1 + " anos e tem a altura de: " + alturaAtleta1.ToString("f") + "mts.\n");


Console.Write("\n\nDigite o nome de outro atleta2: ");
nomeAtleta2 = Console.ReadLine();

Console.Write("Digite a idade do atleta2: ");
idadeAtleta2 = int.Parse(Console.ReadLine());

Console.Write("Digite a altura do atleta2: ");
alturaAtleta2 = float.Parse(Console.ReadLine());

Console.Write("\nO atleta1 chama-se " + nomeAtleta2 + ", de idade " + idadeAtleta2 + " anos e tem a altura de: " + alturaAtleta2.ToString("f") + "mts.\n");

if (idadeAtleta1 > idadeAtleta2)
{
    Console.Write("\n\nO atleta " + nomeAtleta2 + " , com " + idadeAtleta2 + " de idade e com " + alturaAtleta2 + " de altura, é, portanto, o atleta mais novo.\n");     
}
    else if (idadeAtleta1 == alturaAtleta2) //hipótese não levantada no pedido do exercício.
    {
        Console.Write("\n\nOs atletas tem a mesma idade!");
    }
else
{
    Console.Write("\n\nO atleta " + nomeAtleta1 + " , com " + idadeAtleta1 + " de idade e com " + alturaAtleta1 + " de altura, é, portanto, o atleta é o mais novo.\n");
}



if(alturaAtleta1 < alturaAtleta2)
{
    Console.Write("\n\nO atleta " + nomeAtleta2 + " , com " + idadeAtleta2 + " de idade e com " + alturaAtleta2 + " de altura, é, portanto, o atleta mais alto.\n");
}
    else if (alturaAtleta1 == alturaAtleta2) //hipótese não levantada no pedido do exercício.
{
    Console.Write("\n\nOs atletas tem a mesma altura!");
}
else
{
    Console.Write("\n\nO atleta " + nomeAtleta1 + " , com " + alturaAtleta1 + " de idade e com " + alturaAtleta1 + " de altura, é, portanto, o atleta é o mais alto.\n");
}