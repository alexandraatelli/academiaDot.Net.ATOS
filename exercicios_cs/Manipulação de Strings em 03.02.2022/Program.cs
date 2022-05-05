// See https://aka.ms/new-console-template for more information

/*Exercício desafio de string: Fazer um programa que receba o nome completo de uma pessoa e exiba em maiúsculo o primeiro nome e o último sobrenome dessa pessoa.*/


/// <summary>
/// Armazena o nome completo informado pelo usuário. 
/// </summary>
string nomeCompleto;
/// <summary>
/// Vetor de String recebe o split das palavras do nomeCompleto
/// </summary>
string[] palavras;
/// <summary>
/// Armazena o primeiro nome do nome completo
/// </summary>
string primeiroNome;
/// <summary>
/// Armazena o ultimo sobrenome completo
/// </summary>
string ultimoNome;


Console.Write("\nDigite o seu nome completo: ");
nomeCompleto = Console.ReadLine();
nomeCompleto = nomeCompleto.ToUpper();

//splitar o nome completo por espaço em branco:
palavras = nomeCompleto.Split(" ");

primeiroNome = palavras[0];
ultimoNome = palavras[palavras.Length - 1];

Console.Write("\nSeu primeiro nome é: " + primeiroNome);
Console.Write("\nSeu ultimo sobrenome é: " + ultimoNome + "\n");

