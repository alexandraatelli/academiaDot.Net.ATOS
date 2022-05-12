// See https://aka.ms/new-console-template for more information

/*Faça um programa no VS que receba uma hora, dividida em 2 variáveis (uma para hora e outra para minutos). O programa deve exibir se a hora digitada está ou não válida. Lembre que usaremos o padrão de hora com 24h, de 0 a 23.*/

int hora = 0;
int minuto = 0;


Console.Clear();

Console.Write("\nDigite a hora desejada: ");
hora = int.Parse(Console.ReadLine());
if (hora >= 0 && hora <= 23)
{
    Console.Write("\n" + hora + " é válido.\n");
}
else
{
    Console.Write("\n" + hora + " é inválido. Entre com um valor válido: de 0 à 23.\n");
    Environment.Exit(0);
    //https://docs.microsoft.com/pt-br/dotnet/api/system.environment.exit?view=net-6.0
}

Console.Write("\nDigite o minuto desejado: ");
minuto = int.Parse(Console.ReadLine());
if (minuto >= 0 && minuto <= 30)
{
    Console.Write("\n" + minuto + " é válido.\n");
}
else
{
    Console.Write("\n" + minuto + " é inválido. Entre com um valor válido: de 0 à 30.\n");
    Environment.Exit(0);
    //https://docs.microsoft.com/pt-br/dotnet/api/system.environment.exit?view=net-6.0
}

Console.Write("\nPortanto: " + hora.ToString("00") + ":" + minuto.ToString("00") + "h/min.(Usando formatação de número)\n"); 

Console.Write("\nPortanto: " + Convert.ToString(hora).PadLeft(2, '0') + ":" + Convert.ToString(minuto).PadLeft(2, '0') + "h/min.(Usando PadLeft)\n");


// O PadLeft é um método da classe String. Assim para que o use no tipo inteiro, primeiro devo convertê-lo em string. Por isso usamos o Convert.ToString. Após usamos o método PadLeft para que preencha à esquerda com o padrão determinado, no caso caracter '0' - zero, para o comprimento determinado, que no caso foi 2.


//Referência:   https://docs.microsoft.com/pt-br/dotnet/standard/base-types/custom-numeric-format-strings 
//              https://docs.microsoft.com/pt-br/dotnet/api/system.string.padleft?view=net-6.0




