// See https://aka.ms/new-console-template for more information

/*Escreva um algoritmo que leia o placar de um jogo da primeira fase da copa do Brasil. Caso o time de fora tenha ganho o jogo por mais de 2 gols de diferença, mostre na tela uma mensagem indicando que o time de fora já se classificou para a próxima fase. Caso contrário, mostre uma mensagem indicando que os dois times irão se enfrentar novamente em um novo jogo. ex: time da casa 4 x 3 time de fora, mostra "Os dois times se enfrentarão em um novo jogo" ex2: time da casa 1 x 3 time de fora, mostra "O time de fora já se classificou" plus: caso ocorra um segundo jogo, leia o placar desse novo jogo e então diga quem passou de fase.*/

int timeCasa;
int timeFora;


Console.Clear();


Console.Write("\nDigite a quantidade gols do time da Casa: ");
timeCasa = int.Parse(Console.ReadLine());

Console.Write("\nDigite a quantidade gols do time de Fora: ");
timeFora = int.Parse(Console.ReadLine());

if ((timeCasa - timeFora) >= 2)
{
    Console.Write("\nO time da Casa está classificado!\n");
}
    else if (timeFora - timeCasa > 1)
    {
        Console.Write("\nO time de Fora foi classificado!\n");
    }
        else if (timeCasa - timeFora == 1)
        {
            Console.Write("\nHaverá novo jogo! 2ª Rodada!\n");

            Console.Write("\nDigite a quantidade gols do time da Casa 2ª rodada: \n");
            timeCasa = int.Parse(Console.ReadLine());

            Console.Write("\nDigite a quantidade gols do time de Fora 2ª rodada: \n");
            timeFora = int.Parse(Console.ReadLine());

            if (timeCasa > timeFora)
            {
                Console.Write("\nO time da casa passou de fase - foi classificado!\n");
            }
                else if (timeCasa < timeFora)
                {
                    Console.Write("\nO time de fora passou de fase - foi classificado!\n");
                }
                    else if (timeCasa == timeFora)
                    {
                        Console.Write("\nJogo Empatado! Vai para os Penalts.\n");
                    }
        }
            else if (timeCasa == timeFora)
            {
                Console.Write("\nJogo Empatado! Vai para os Penalts.\n");
            }