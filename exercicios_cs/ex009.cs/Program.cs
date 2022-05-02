Console.WriteLine("Uma loja vende seus produtos no sistema de entrada, mais duas prestações, sendo a entrada maior do que ou igual às duas prestações, que devem ser iguais, inteiras e as maiores possíveis. Por exemplo: se o valor da mercadoria for R$ 270,00, a entrada e as duas prestações são iguais a R$ 90,00; se o valor da mercadoria for R$ 302,75 a entrada é de R$ 102,75 e as duas prestações são iguais a R$ 100,00. Escreva um programa em C# e no Visual Studio, que receba o valor da mercadoria e forneça o valor da entrada e das duas prestações, de acordo com as regras acima. Observe que uma justificativa para a adoção desta regra é que ela facilita a confecção e o conseqüente pagamento dos boletos das duas prestações.");


float valorMercadoria;
float valorEntrada;
float valorParcelas;

Console.Clear();

Console.Write("\nDigite o valor da mercadoria: R$ ");
valorMercadoria = float.Parse(Console.ReadLine());

valorParcelas = (int)valorMercadoria / 3; // extrai a parte inteira utilizando um Casting
valorEntrada = valorParcelas + (valorMercadoria % 3);

Console.WriteLine("\nO valor da entrada será de: R$ " + (valorEntrada).ToString("00.00") + " reais.");
Console.WriteLine("\nO valor das 2 parcelas restantes será de: R$ " + (valorParcelas).ToString("00.00") + " reais cada uma via boleto bancário.");

/* O Casting alterou o tipo de um determinado valor, assim, desconsidera-se a parte que é fracionária e extrai somente a parte inteira. Realizamos o Casting explícito, de forma manual, convertendo um tipo maior em um tipo de menor valor, pois "float -> int".  
Referência: https://www.w3schools.com/cs/cs_type_casting.php */
