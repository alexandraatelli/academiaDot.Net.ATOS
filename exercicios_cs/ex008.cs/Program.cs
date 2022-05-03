
Console.Write("Ler uma temperatura em graus Celsius e apresentá-la convertida em graus Fahrenheit. \n" +
    "A fórmula da conversão é F=(9*C+160)/ 5.\n\n");


float tempCeusius;

Console.Clear();

Console.Write("\nDigite o valor da temperatura em Celsius: ");
tempCeusius = float.Parse(Console.ReadLine());

Console.Clear();

Console.Write("\nTemperatura em Fahrenheit é: " + ((((tempCeusius * 9) / 5) + 32).ToString("f")) + "\n");

