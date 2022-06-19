/*1.Faça um programa que leia um número inteiro n, inteiro e positivo e mostre a seguinte soma: S = 1 + 1 / 2 + 1 / 3 + 1 / 4 + 1 / 5....1 / n*/

int numero;
float soma = 0; 

Console.Clear();

Console.Write("Digite um número inteiro e positivo: ");
int.TryParse(Console.ReadLine(), out numero);

if (numero > 0)
{
    for (int i = 1; i <= numero; i++)
    {
        soma = soma + ((float)1 / i); // Aqui é um acumulador. Aqui entrou a soma.
    }

    Console.WriteLine(soma);
}
else
{
    Console.WriteLine("Numero inválido! Deve ser maior que zero.");
}

/*Notas:

Console.WriteLine(i); para conferir o funcionamento do for. Porque eu preciso que ele vá de 1 até o número digitado.
Console.WriteLine(1 / i); // Gerando os números (divisões), não tá somando aqui.
Console.WriteLine((float)1 / i); // Agora faço divisão que um dos operandos é float. (Fazer Teste de Mesa).
soma = soma + ((float)1 / i); // Aqui é um acumulador. Aqui entrou a soma.
Console.WriteLine($"1/ {i} = " + (float)1 / i);

A divisão de 2 inteiros dá inteiro, não considera os decimais pós vírgula. Por isso, que se forçou a divisão
em float, porque assim, ele considera a expressão toda para o cálculo.*/
