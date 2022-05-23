/*8.Faça um programa em VS que solicite um numero inteiro. Se o numero não for inteiro, 
 solicite-o até que seja. após, informe se ele é par ou impar. 
Finalmente, pergunte ao usuário se ele quer repetir o programa em VS.*/

float numero = 0;
string continua = "S";

    while (numero != (int)numero || continua == "S" || continua == "s")
    {
        Console.Clear();
        Console.Write("Digite um número: ");
        numero = float.Parse(Console.ReadLine());

        if (Math.Abs(numero) > Math.Abs((int)numero)) // Extrai a parte inteira - não é Conversão de float para Int. Pergnta-se se o número por exemplo: 7,2 é maior que 7? Se for é porque é flutuante - e neste caso ele é inválido. O Math.Abs veio para comparar a parte absoluta, somente o número inteiro, para manter a lógica.
        {
            Console.WriteLine("Inválido!");
            Thread.Sleep(1500);
        }
        else if (numero % 2 == 0)
        {
            Console.WriteLine($"O número {numero} é PAR!");
            Thread.Sleep(1500);
        }
        else
        {
            Console.WriteLine($"O número {numero} é ÍMPAR");
            Thread.Sleep(1500);
        }


        Console.Write("Digite \"S\" se deseja digitar outro número: ");
        continua = Console.ReadLine();

} 