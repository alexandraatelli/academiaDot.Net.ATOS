// See https://aka.ms/new-console-template for more information

//Escrever um algoritmo para ler duas notas de um aluno e escrever na tela a palavra “Aprovado” se a média das duas notas for maior ou igual a 7,0. Caso a média seja inferior a 7,0, o programa deve ler a nota do exame e calcular a média final. Se esta média for maior ou igual a 5,0, o programa deve escrever “Aprovado”, caso contrário deve escrever “Reprovado”.

float nota1;
float nota2;
float mediaNotas;
float notaExame;
float mediaFinalposExame;


Console.Clear();

Console.Write("\nDigite a primeira nota: ");
nota1 = float.Parse(Console.ReadLine());

Console.Write("Digite a segunda nota: ");
nota2 = float.Parse(Console.ReadLine());

mediaNotas = (nota1 + nota2) / 2;
Console.WriteLine("A sua média entre as duas notas digitadas é: " + mediaNotas);


    if (mediaNotas >= 7)
    {
        Console.WriteLine("Aprovado!");
    }
        else if (mediaNotas >= 5)
        {
            Console.WriteLine("Você está de exame!\n");
        }
    else
    {
    Console.WriteLine("Reprovado!");
    }

Console.Write("\nDigite a nota do exame realizado: ");
notaExame = float.Parse(Console.ReadLine());

mediaFinalposExame  = (mediaNotas + notaExame) / 2;


    if (mediaFinalposExame >= 7)
    {
        Console.Write("Você foi aprovado. Parabéns!");
    }
    else 
    {
        Console.WriteLine("Reprovado. Lamentamos muito!");
    }

