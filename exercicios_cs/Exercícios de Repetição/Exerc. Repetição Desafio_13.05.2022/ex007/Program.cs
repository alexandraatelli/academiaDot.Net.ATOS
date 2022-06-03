/*7.Os dois primeiros números da sequência de Fibonacci são 0 e 1. Os próximos números dessa sequência podem ser calculados como sendo a soma dos dois números anteriores. Os primeiros números de Fibonacci são: 0, 1, 1, 2, 3, 5, 8, 13, 21, 34, 55, 89, 144, 233, … Escreva um algoritmo que leia um número pelo teclado N, e então mostre os N primeiros números da sequência de Fibonacci.*/

int fib1 = 0;
int fib2 = 1;
int auxiliar;
int quatNumeroFib = 0;

Console.Write("Digite um número: ");
quatNumeroFib = int.Parse(Console.ReadLine());

if (quatNumeroFib == 1)
{
    Console.WriteLine(fib1);
}
else if (quatNumeroFib == 2)
{
    Console.WriteLine(fib1);
    Console.WriteLine(fib2);
}
else if (quatNumeroFib > 2)
{
    Console.WriteLine(fib1);
    Console.WriteLine(fib2);
    for (int i = 1; i <= (quatNumeroFib - 2); i++)
    {
        auxiliar = fib1;
        fib1 = fib2;
        fib2 = fib1 + auxiliar;
        Console.WriteLine(fib2);
    }
}





