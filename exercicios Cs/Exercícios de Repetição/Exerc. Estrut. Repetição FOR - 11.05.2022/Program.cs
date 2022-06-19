int i;

Console.WriteLine("\nIncremento:");

for (i = 0; i <= 10; i++)
{
    Console.Write("i vale: " + i + "\n");
}

Console.WriteLine("\nDecremento");

for (i = 20; i >= 5; i--)
{
    Console.Write("i vale "+ i + "\n");
}


Console.Write("\nFor com If:\n");

int inicio, fim;

Console.Write("Digite o número  do início: ");
inicio = int.Parse(Console.ReadLine());

Console.Write("Digite o número do fim: ");
fim = int.Parse(Console.ReadLine());

if (inicio > fim)
{
    for (i = inicio; i >= fim; i--)
    {
        Console.Write("i vale " + i + "\n");

    }

}
        else if (inicio < fim)
        {
            for (i = inicio; i <= fim; i++)
            {
                Console.Write("i vale " + i + "\n");
            }
        }
else
{
    Console.Write("Os valores são iguais!\n");
}


int x;

Console.Write("\nX pulando X:");
Console.Write("\nDigite x: ");
x = int.Parse(Console.ReadLine());

for (i = 0; i <= 100; i = i + x) //i+=x
    { 
        Console.WriteLine("i vale " + i);
    }

Console.Write("\nX dividindo X:");
Console.Write("\nDigite x: ");
x = int.Parse(Console.ReadLine());

for (i = 0; i <= 100; i++) //i+=x
    {
        if (i % x == 0)
        Console.WriteLine(i + " é divisivel por " + x);
    }


// Ler tabuada

int tabuada;
Console.Write("\nTabuada: ");
Console.Write("Digite a tabuada desejada: ");
tabuada = int.Parse(Console.ReadLine());

for (i = 0; i<= 10; i++) //i+=x
{
    Console.WriteLine(i + " x " + tabuada + " = " + i*tabuada); 
}