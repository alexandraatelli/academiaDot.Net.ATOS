Console.WriteLine("Escreva um programa em C# e no Visual Studio para calcular o consumo médio de um automóvel \n" +
    "(medido em Km / l), sendo que são conhecidos a distância totalconsumido percorrida e o volume de combustível \n" +
    "consumido para percorrê-lo \n");



float kmpercorrido = 520;
float totalconsumido = 55;

Console.Clear();    

    Console.WriteLine("\nA média de Km percorrido em litros foi de: " + (kmpercorrido / totalconsumido).ToString("00.00"));



//Não houve necessidade de criar-se uma variável para o resultado solicitado pelo exercício. Diante, das casas decimais extensas, utilizando a consulta na documentação da Microsoft, deixamos somente duas casas apos a vírgula.










