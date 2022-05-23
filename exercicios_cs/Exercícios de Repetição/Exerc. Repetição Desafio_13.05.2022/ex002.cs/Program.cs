//2.Imprima uma tabela de conversão de polegadas para centímetros, de 1 a 20. Considere que Polegada = Centímetro * 2,54.

Console.Clear();    

for (int i = 1; i <= 20; i++)
{
    Console.WriteLine($"{i}\" = " + i * 2.54); 
}

// Aqui escrevemos o valor de i, não alteramos o valor dele. Esse igual na string é uma mensagem e não para alteração de valores. Aqui estamos concatenado informações.