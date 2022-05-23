/*6.Faça um programa em VS que solicite ao o usuário que informe a idade e valide a entrada de dados,
ou seja, repita a leitura até que ela esteja correta (maior do que zero). 
Ao final, mostre a idade digitada.*/

int idade = 0;

while (idade <= 0) 
{
    Console.Clear();
    Console.Write("Digite a idade: ");
    idade = int.Parse(Console.ReadLine());

    if (idade == 0)
    {
        Console.WriteLine("Idade inválida! Tente novamente.");
        Thread.Sleep(1000);
    }
    
}  
        Console.WriteLine($"A idade digitada é: {idade} anos!");

    






