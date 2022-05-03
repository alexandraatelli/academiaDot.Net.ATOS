Console.WriteLine("Escreva um programa em C# e no Visual Studio para calcular a média aritmética entre quatro números quaisquer.");

// Utilizado float uma vez que, a digitação do número é cargo do usuário, o que poderia ser números inteiros ou decimais por exemplo.

float numero1;
float numero2;
float numero3;
float numero4;
//float media_aritimetica;

Console.WriteLine("Informe o primeiro número: ");
numero1 = float.Parse(Console.ReadLine());

Console.WriteLine("Informe o segundo número: ");
numero2 = float.Parse(Console.ReadLine());

Console.WriteLine("Informe o terceiro número: ");
numero3 = float.Parse(Console.ReadLine());

Console.WriteLine("Informe o quarto número: ");
numero4 = float.Parse(Console.ReadLine());

Console.WriteLine("A média aritmética dos 4 valores é: " + ((numero1 + numero2 + numero3 + numero4) / 4));

//media_aritimetica = (numero1 + numero2 + numero3 + numero4) / 4;

// Console.WriteLine("A média dos 4 valores é: " + media_aritimetica);