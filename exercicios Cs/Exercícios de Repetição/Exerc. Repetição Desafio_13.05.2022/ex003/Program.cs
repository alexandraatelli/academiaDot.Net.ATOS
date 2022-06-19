//3.Dado um limite inferior e superior, calcule a soma de todos os números pares contidos nesse intervalo. 

int limiteInferior = 1;
int limiteSuperior = 8;
int soma = 0;

// For usado, pois sabe-se a faixa de valores a percorrer.

for (int i = limiteInferior; i <= limiteSuperior; i++)
{
    if (i % 2 == 0)
    {
        soma = soma + i;
    }
}

Console.WriteLine($"A soma de todos os números pares é: {soma}");