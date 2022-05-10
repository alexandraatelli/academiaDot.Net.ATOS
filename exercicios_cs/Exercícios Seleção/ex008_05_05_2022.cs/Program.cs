// See https://aka.ms/new-console-template for more information

/*Faça um programa no VS que receba o código, nome, salário base e o total de vendas de um funcionário. Caso o total de vendas seja acima de R$ 500,00, adicionar ao seu salário final 5% do total de vendas. Caso o total de vendas seja mais que R$ 1000,00, adicionar ao seu salário final 7% do total de vendas. E por fim, se o total de vendas seja maior que R$ 5000,00, adicionar ao seu salário final mais 10% do total de vendas.*/

int codigo;
string nome;
float salarioBase = 1200.00F;
float totalVendas;


Console.Clear();


Console.Write("\nDigite o código do funcionário: ");
codigo = int.Parse(Console.ReadLine());

Console.Write("\nDigite o NOME do funcionário cadastrado no código nº " + codigo + ": ");
nome = (Console.ReadLine());

Console.Write("\nDigite o salário base do funcionário código nº " + codigo + ": R$ ");

    if (float.Parse(Console.ReadLine()) < salarioBase) //Regra de Negócios - ninguem pode ganhar menos de 1 salário mínimo vigente (CLT)
    {
        Console.WriteLine("\nSalário inválido! O salário mínimo vigente é de: R$ " + salarioBase + ". Reinicie o aplicativo.\n");
        Environment.Exit(0);
       //https://docs.microsoft.com/pt-br/dotnet/api/system.environment.exit?view=net-6.0
}

Console.Write("\nDigite o total de vendas efetuadas pelo funcionário codigo nº " + codigo + ": R$ ");
totalVendas = float.Parse(Console.ReadLine());


   if (totalVendas > 500.00 && totalVendas <= 1000.00)
    {
    Console.WriteLine("\nO funcionário tem a receber o salário total de R$ " + (salarioBase + (totalVendas * 0.05)).ToString("f") + " incluso a comissão de 5% sobre o valor total das vendas.");
    }

       else if (totalVendas > 1000.00 && totalVendas <= 5000.00)
        {
        Console.WriteLine("\nO funcionário tem a receber o salário total de R$ " + (salarioBase + (totalVendas * 0.07)).ToString("f") + " incluso a comissão de 7% sobre o valor total das vendas.");
        }

           else if (totalVendas > 5000.00)
            {
            Console.WriteLine("\nO funcionário tem a receber o salário total de R$ " + (salarioBase + (totalVendas * 0.1)).ToString("f") + " incluso a comissão de 10% sobre o valor total das vendas.");
            }
 
/*O valor do salário base do funcionário é o mesmo que o valor do salário mínimo vigente, estipulado por Lei Federal (regras de negócio).       

Caso o total de vendas seja acima de R$ 500,00, adicionar ao seu salário final 5% do total de vendas.
Caso o total de vendas seja mais que R$ 1000,00, adicionar ao seu salário final 7% do total de vendas.
E por fim, se o total de vendas seja maior que R$ 5000,00, adicionar ao seu salário final 10% do 
total de vendas. */

