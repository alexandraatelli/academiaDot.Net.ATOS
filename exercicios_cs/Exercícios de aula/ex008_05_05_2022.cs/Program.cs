// See https://aka.ms/new-console-template for more information

/*Faça um programa no VS que receba o código, nome, salário base e o total de vendas de um funcionário. Caso o total de vendas seja acima de R$ 500,00, adicionar ao seu salário final 5% do total de vendas. Caso o total de vendas seja mais que R$ 1000,00, adicionar ao seu salário final 7% do total de vendas. E por fim, se o total de vendas seja maior que R$ 5000,00, adicionar ao seu salário final 10% do total de vendas.*/

int codigo;
string nome;
float salarioBase;
float totalVendas;


Console.Clear();


Console.Write("\nDigite o código do funcionário: ");
codigo = int.Parse(Console.ReadLine());

Console.Write("Digite o NOME do funcionário cadastrado no código nº " + codigo + ": ");
nome = (Console.ReadLine());

Console.Write("Digite o salário base do funcionário código nº " + codigo + ": R$ ");
salarioBase = float.Parse(Console.ReadLine());
    if (salarioBase < 1200.00)
    {
        Console.WriteLine("Salário inválido!");
    }

Console.Write("Digite o total de vendas efetuadas pelo funcionário codigo nº " + codigo + ": R$ ");
totalVendas = float.Parse(Console.ReadLine());


   if (totalVendas > 500.00 && totalVendas <= 1000.00)
    {
    Console.WriteLine("\nO funcionário tem a receber o salário total de R$ " + (salarioBase + (totalVendas * 5 / 100)).ToString("f") + " incluso a comissão de 5% sobre o valor total das vendas.");
    }

       else if (totalVendas >= 1000.00 && totalVendas < 5000.00)
        {
        Console.WriteLine("\nO funcionário tem a receber o salário total de R$ " + (salarioBase + (totalVendas * 7 / 100)).ToString("f") + " incluso a comissão de 7% sobre o valor total das vendas.");
        }

           else if (totalVendas >= 5000.00)
            {
            Console.WriteLine("\nO funcionário tem a receber o salário total de R$ " + (salarioBase + (totalVendas * 10 / 100)).ToString("f") + " incluso a comissão de 10% sobre o valor total das vendas.");
            }
 
/*O valor do salário base do funcionário é o mesmo que o valor do salário mínimo vigente, estipulado por Lei Federal (regras de negócio).       

Caso o total de vendas seja acima de R$ 500,00, adicionar ao seu salário final 5% do total de vendas.
Caso o total de vendas seja mais que R$ 1000,00, adicionar ao seu salário final 7% do total de vendas.
E por fim, se o total de vendas seja maior que R$ 5000,00, adicionar ao seu salário final 10% do 
total de vendas. */

