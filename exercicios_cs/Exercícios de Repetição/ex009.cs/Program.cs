/*9.Faça um programa em VS para Ler a quantidade de filhos de cada uma das 30 pessoas que 
visitaram o zoológico num determinado dia, imprimindo:
Quantas pessoas tem entre 1 e 3 filhos.
Quantas pessoas tem entre 4 e 7 filhos.
Quantas pessoas tem mais de 8 filhos.
Quantas pessoas não tem filhos.*/

int filhos1_3 = 0;
int filhos4_7 = 0;
int filhos8 = 0;
int filhosZero = 0;
int quantpessoas = 30;
int auxiliar;

Console.Clear();

for (int i = 1; i <= quantpessoas; i++) // Porque a faixa de valores é fixa // Esse laço repete um
                                        // bloco de codigos.
{
    Console.Clear();
    Console.WriteLine(i + " Quantos filhos você tem? "); // executa o laço 30 vezes.
    int.TryParse(Console.ReadLine(), out auxiliar); // Para facilitar a entrada de zero filhos. Evita a perda
                                                    // de dados ao digitar um enter por exemplo.
    //auxiliar = int.Parse(Console.ReadLine()); Testado, houve perda de dados (exception) ao digitar enter.

    if (auxiliar == 0)
    {
        filhosZero = filhosZero + 1;
    }
        else if (auxiliar > 0 && auxiliar <= 3)
        {
            filhos1_3 = filhos1_3 + 1;
        }
            else if (auxiliar > 3 && auxiliar <= 7)
            {
                filhos4_7 = filhos4_7 + 1;
            }
                else if (auxiliar > 7)
                {
                    filhos8 = filhos8 + 1;
                }
}
// Após capturar os dados e atribuir as variáveis, mostra-se os resultados:
Console.WriteLine($"De {quantpessoas} pessoas: {filhosZero} não tem filhos!");
Console.WriteLine($"{filhos1_3} tem de 1 a 3 filhos!");
Console.WriteLine($"{filhos4_7} tem de 4 a 7 filhos!");
Console.WriteLine($"E {filhos8} tem 8 ou mais filhos!");
