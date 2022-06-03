Console.WriteLine("Escreva um programa em C# e no Visual Studio que leia o número de um vendedor, o seu salário fixo,  o total de vendas por ele efetuadas e o percentual que ganha sobre o total de vendas. Calcule o salário total do vendedor.Escreva o número do vendedor e o salário total do vendedor.\n");

string codigoVendedor;
float salarioFixo;
float totalVendas;
float percentualVendas;
float SalarioTotalRecebdio;


Console.Clear();


Console.Write("\nDigite o código do vendedor: ");
codigoVendedor = Console.ReadLine();

Console.Write("\n Digite o salário fixo do vendendor código " + codigoVendedor + ": R$ ");
salarioFixo = float.Parse(Console.ReadLine());

Console.Write("\nDigite o total de vendas do vendedor código " + codigoVendedor + " , em reais: R$ ");
totalVendas = float.Parse(Console.ReadLine());

Console.Write("\nDigite o percentual à receber pelo vendedor código " + codigoVendedor + ", com base no total de vendas do mês atual: ");
percentualVendas = float.Parse(Console.ReadLine());

SalarioTotalRecebdio = salarioFixo + (1 + (percentualVendas / 100) * totalVendas);
Console.WriteLine("\nO vendedor código: " + codigoVendedor + " receberá o salário total com as comissões, no valor de: R$ " + SalarioTotalRecebdio.ToString("f") + "\n");


//Abaxo outra forma de apresentar o resultado:

//Console.WriteLine("\nO vendedor código: " + codigoVendedor + " receberá o salário total no valor de: R$ " + (((1 + (percentualVendas / 100) * totalVendas) + salarioFixo).ToString("f")) + " reais.");















