Console.WriteLine("Escreva um programa em C# e no Visual Studio para calcular o consumo médio de um automóvel \n" +
    "(medido em Km / l), sendo que são conhecidos a distância totalconsumido percorrida e o volume de combustível \n" +
    "consumido para percorrê-lo \n");



float kmPercorrido = 520;
float totalConsumidoCombust = 55;

Console.Clear();    

    Console.WriteLine("\nA média de Km percorrido em litros foi de: " + (kmPercorrido / totalConsumidoCombust).ToString("f"));



//Não houve necessidade de criar-se uma variável para o resultado solicitado pelo exercício, porém, no caso de aproveitamento futuro do valor dessa variável, recomenda-se a criação da variável media do Km percorrido por litros de combustível gasto.
//Diante, das casas decimais extensas, utilizando a consulta na documentação da Microsoft, deixamos somente duas casas apos a vírgula.











