// See https://aka.ms/new-console-template for more information

Console.WriteLine("\nUma loja vende bicicletas com um acréscimo de 50% sobre o preço de custo. Ela paga a cada vendedor 2 salários mínimos mensais, mais uma comissão de 15% sobre o preço de custo de cada bicicleta vendida.Desenvolva um algoritmo que leia o valor do salário mínimo, o preço de custo de cada bicicleta, o número de bicicletas vendidas pelo vendedor, e, calcule e mostre: o salário do empregado");


//float valor_salario_Minimo;

float salario_minimo;
double valor_custo_bike;
int quantidade_bikes_vendidas;
double salario_vendedor;

//double valor_final_bike = valor_custo_bike + (1 + (50.0 / 100.0));

Console.Clear();


Console.Write("\nDigite o valor do salário mínimo vigente: R$ ");
salario_minimo = float.Parse(Console.ReadLine());

Console.Write("\nDigite o preço de custo da bike: R$ ");
valor_custo_bike = double.Parse(Console.ReadLine());

Console.Write("\nDigite a quantidade de bikes vendidas: ");
quantidade_bikes_vendidas = int.Parse(Console.ReadLine());

Console.WriteLine("\n\nO valor do salário minimo vigente é de: " + salario_minimo.ToString("f"));
Console.WriteLine("\nO preço de custo da bike é de R$ " + valor_custo_bike.ToString("f"));
Console.WriteLine("\nO número de bikes vendidas foi de: " + quantidade_bikes_vendidas);

salario_vendedor = (salario_minimo * 2) + (quantidade_bikes_vendidas * (valor_custo_bike * 0.15));
Console.WriteLine("\nO vendedor recebeu pelas vendas o valor total de: R$ " + salario_vendedor.ToString("f"));























