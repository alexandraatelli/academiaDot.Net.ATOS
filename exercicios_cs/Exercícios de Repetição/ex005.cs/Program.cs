/*5.Modifique o programa em VS anterior para aceitar votos nulos 
(qualquer nome diferente de FIM, JOAO, ZECA e BRANCO). 
Ao final, informe o nome do candidato vencedor, o número de votos nulos 
e o número de pessoas que votaram.*/

string voto; //ZECA, JOAO, BRANCO
int votoZeca = 0;
int votoJoao = 0; // não é João com o "Til.
int votoBranco = 0;
int votoNulo = 0;

do
{
    Console.Clear();
    Console.Write("Digite o nome do seu candidato, ou BRANCO, ou FIM para encerrar: ");
    voto = Console.ReadLine().ToUpper();

    switch (voto)
    {
        case "JOAO":
            votoJoao++;
            break;
        case "ZECA":
            votoZeca++;
            break;
        case "BRANCO":
            votoBranco++;
            break;
       // case "NULO":
          //  votoNulo++;
         //   break;
        case "FIM":
            Console.WriteLine("Programa encerrado");
            break;
        default:
                votoNulo++;
            break;
    }

    Console.WriteLine("Obrigado por votar nessas eleições!");
   // Console.ReadKey();

} while (voto != "FIM");


if (votoJoao > votoZeca)
{
    Console.WriteLine($"O candidato vencedor foi o João, com {votoJoao} voto(s). Do total de eleitores nessas eleições: {votoNulo} foram voto(s) nulo(s) no computo geral!");
}
else
{
    Console.WriteLine($"O candidato vencedor foi o Zeca, com {votoZeca} voto(s). Do total de eleitores nessas eleições: {votoNulo} foram voto(s) nulo(s) no computo geral!");
}

int totalEleitores = (votoJoao + votoZeca + votoBranco + votoNulo);
Console.WriteLine($"Total de eleitores votando foi de: {totalEleitores:D} eleitores.");
Console.ReadLine();
