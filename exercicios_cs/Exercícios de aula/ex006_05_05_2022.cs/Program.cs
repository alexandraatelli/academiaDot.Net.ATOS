// See https://aka.ms/new-console-template for more information

/*  Calcular o IMC:
    Fórmula do IMC = peso / (altura * altura)

                               IMC
menor que 18                -> baixo peso
maior que 18 e menor que 25 -> peso normal/ideal
maior que 25 e menor que 30 -> sobrepeso
maior que 30 e menor que 35 -> obesidade grau I
maior que 35 e menor que 39 -> obesidade grau II (severa)
maior que 39                -> obesidade grau III (mórbida)*/

float peso;
float altura;
float imc;

Console.Clear();

Console.Write("Digite seu peso: ");
peso = float.Parse(Console.ReadLine());

Console.Write("Digite sua altura: ");
altura = float.Parse(Console.ReadLine());

imc = peso / (altura * altura);
Console.Write("Seu IMC é: " + imc.ToString("f") + "\n");

if (imc < 18)
{
    Console.Write("Baixo peso\n");
}
    else if (imc > 18 && imc < 25)
    {
        Console.Write("Normal\n");
    }
        else if (imc > 25 && imc < 30)
        {
            Console.Write("Sobrepeso\n");
        }
            else if (imc > 30 && imc < 35)
            {
                Console.Write("Obesidade\n");
            }
else if (imc > 35)
{
    Console.Write("Obesidade Grau Sério!\n");
}

// Referência: http://drrogermoura.com.br/o-que-e-imc Acessado em 06.05.2022

