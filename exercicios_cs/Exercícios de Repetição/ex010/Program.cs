/*10.Ler nome, sexo e idade de 50 pessoas e após imprimir:
Número de pessoas do sexo masculino.
Número de pessoas do sexo feminino.
Número de pessoas com idade inferior a 30 anos.
Número de pessoas com idade superior a 60 anos.
Média de idade das mulheres.*/

int quantpessoas = 6;
int idade = 0;
int idadeTrinta = 0;
int idadeSessenta = 0;
int idadeIntermediaria = 0;
int feminino = 0;
int masculino = 0;
float idadeMulheres = 0;
string sexo;

for (int i = 1; i <= quantpessoas; i++)
{
     do
     {
        Console.Clear();
        Console.WriteLine("Digite F (feminino) ou M (masculino), para informar o seu sexo: ");
        sexo = Console.ReadLine().ToLower();

        Console.WriteLine("Qual a idade: ");
        int.TryParse(Console.ReadLine(), out idade);

        if (sexo != String.Empty)
        {

            if (sexo == "f")
            {
                feminino = feminino + 1;
                idadeMulheres = idadeMulheres + idade;
            }
                else if (sexo == "m")
                {
                    masculino = masculino + 1;
                }
                    if (idade > 0 && idade < 30)
                    {
                        idadeTrinta = idadeTrinta + 1;
                    }
                        else if (idade > 60)
                        {
                            idadeSessenta = idadeSessenta + 1;
                        }
            else
            {
                idadeIntermediaria = idadeIntermediaria + 1;
            }
        }

     } while (string.IsNullOrEmpty(sexo));
}

Console.WriteLine($"{masculino} pessoas são do sexo masculino!");
Console.WriteLine($"{feminino} pessoas são do sexo feminino!");
Console.WriteLine($"{idadeTrinta} pessoas tem a idade inferior a 30 anos!");
Console.WriteLine($"{idadeSessenta} pessoas tem a idade superior a 60 anos!");
Console.WriteLine($"{idadeIntermediaria} pessoas tem a idade superior a 30 anos e inferior a 60!");
Console.WriteLine($"A média de idade das mulheres é de: {idadeMulheres / feminino}");

