
Console.Write("Ler uma temperatura em graus Celsius e apresentá-la convertida em graus Fahrenheit. \n" +
    "A fórmula da conversão é F=(9*C+160)/ 5.\n\n");


float temperaturaCeusius;

Console.Clear();

Console.Write("\nDigite o valor da temperatura em Celsius: ");
temperaturaCeusius = float.Parse(Console.ReadLine());

Console.Clear();

Console.Write("\nTemperatura em Fahrenheit é: " + ((((temperaturaCeusius * 9) / 5) + 32).ToString("f")) + "\n");


/* float temperaturaFahrenheit = A variável poderia ter sido criada e assim simplicaria o código e daria mais possibilidades no futuro de inverter o cálculo por exemplo:

    temperaturaFahrenheit = (9 * temperaturaCelsius + 160 / 5);
    Console.WriteLine("O valor " + temperaturaCelsius + " em graus Celsius é " + " em Fahrenheit: " + temperaturaFahrenheit); */
