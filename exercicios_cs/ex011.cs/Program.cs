
Console.WriteLine("Escreva um algoritmo para ler o número de eleitores de um município, o número de votos brancos, nulos e válidos. Calcule e escreva o percentual que cada um representa em relação ao total de eleitores.");

int totEleitores;
int votosValidos;
int votosBranco;
int votosNulo;


Console.Clear();


Console.Write("\nDigite o número total de eleitores do município: ");
totEleitores = int.Parse(Console.ReadLine());

Console.Write("\nDigite o total de votos em branco: ");
votosBranco = int.Parse(Console.ReadLine());

Console.Write("\nDigite o número de votos nulos: ");
votosNulo = int.Parse(Console.ReadLine());


votosValidos = totEleitores - (votosBranco + votosNulo);

if ((votosBranco + votosNulo) > totEleitores)
{
    Console.Write("\nOs dados informados estão inconsistentes! Total de votos ultrapassam o total de eleitores.\n");
}
else
{

    Console.Write("\nO total de votos válido é de: " + votosValidos + " e representa " + ((100 * votosValidos) / totEleitores) + "% do total de eleitores.\n");

    Console.Write("\nO total de votos em branco é de: " + votosBranco + " e representa " + ((100 * votosBranco) / totEleitores) + "% do total de eleitores.\n");

    Console.Write("\nO total de votos nulos é de: " + votosNulo + " e representa " + ((100 * votosNulo) / totEleitores) + "% do total de eleitores.\n");
}

// Nota: Embora tenha sido solicitado no exercício a entrada pelo usuário de todos os tipos de votos (válidos, branco e nulos), além do total de eleitores, optamos por computar o total de votos válidos de forma dedutiva, ou seja, não teve a inclusão do valor pelo usuário, o que traz inclusive mais segurança.





