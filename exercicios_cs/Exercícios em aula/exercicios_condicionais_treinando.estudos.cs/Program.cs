
//Exercício: Escolher a Operação a ser realizada - Calculadora


double numero1, numero2, resultado;
int op;

Console.Clear();

Console.WriteLine("Digite um número: ");
numero1 = Double.Parse(Console.ReadLine());
numero2 = Double.Parse(Console.ReadLine());
Console.WriteLine("\nEscolha a operação: \n1. Soma\n2. Subtração\n3. Multiplicação\n4.  Divisão\n5. Potência\n\nEscolha: ");
op = int.Parse(Console.ReadLine());

if (op == 1)
{
    resultado = numero1 + numero2;
    Console.WriteLine("Soma = " + resultado);
}
    else if (op == 2)
    {
        resultado = numero1 - numero2;
        Console.WriteLine("Subtração = " + resultado);
    }
    else if (op == 3)
    {
        resultado = numero1 * numero2;
        Console.WriteLine("Multiplicação = " + resultado);
    }
    else if (op == 4)
    {
        resultado = numero1 / numero2;
        Console.WriteLine("Divisão = " + resultado);
    }
    else if (op == 5)
    {
        resultado = Math.Pow(1, 2);
        Console.WriteLine("Potência = " + resultado);
    }
else
{
    Console.WriteLine("Opção Inválida!");

}






