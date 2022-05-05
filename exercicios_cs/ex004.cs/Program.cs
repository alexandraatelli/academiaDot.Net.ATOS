Console.WriteLine("Faça um programa em C# e no Visual Studio que receba a data na forma DDMMAAAA e imprima na forma AAAAMMDD \n + e AAMMDD. Note que o dia, o mês e o ano devem ser lidos em variáveis diferentes.\n");


Console.WriteLine("\nInício do modo de implementação conforme exercício proposto:");
// Todos os implementos não utilizou a variável do tipo Data

string dia, mes, ano;

Console.WriteLine("\nDigite um dia do mês com 2 digitos: ");
dia = Console.ReadLine();

Console.WriteLine("Digite um mês do ano com 2 digitos: ");
mes = Console.ReadLine();    

Console.WriteLine("Digite o ano desejado com 4 digitos: ");
ano = Console.ReadLine();


// Teste geral:

if ((dia + mes + ano).Length != 8)
{
    Console.WriteLine("Data invalida ou fora do formato!");
    // Garatimos que o dado tem uma sequencia de 8 numeros
}
   
else if (int.Parse(dia) > 30 && (int.Parse(mes) == 4 || int.Parse(mes) == 6 || int.Parse(mes) == 9 || int.Parse(mes) == 11))
    {
        Console.WriteLine("Dia inválido!");
    }

        else if (int.Parse(dia) > 31 && (int.Parse(mes) == 1 || int.Parse(mes) > 3 || int.Parse(mes) == 5 || int.Parse(mes) == 7 || int.Parse(mes) == 8 || int.Parse(mes) == 10 || int.Parse(mes) == 12))
        {
            Console.WriteLine("Data invalido!");
        }

            else if (int.Parse(mes) <= 0 || int.Parse(mes) >= 13)
            {
                Console.WriteLine("Data invalido!");
            }

                else if (int.Parse(dia) > 29 && int.Parse(mes) == 2)
                {
                    Console.WriteLine("Data invalida!");
                }

                    else if ((int.Parse(dia) == 29 && int.Parse(mes) == 2) && !(int.Parse(ano) % 4 == 0 && int.Parse(ano) % 100 != 0))
                    {
                        Console.WriteLine("Data invalida!");
                    }
else
{
    Console.WriteLine("A data digitada é: " + ano + mes + dia);
    Console.WriteLine("A data digitada é: " + ano.Substring(2,2) + mes + dia);

    Console.WriteLine("A data digitada é: " + ano + "/" + mes + "/" + dia);
    Console.WriteLine("A data digitada é: " + ano.Substring(2, 2) + "/" + mes + "/" + dia);
}



/// ///////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////



Console.WriteLine("\nInicio de OUTRO MODO de implementação para se chegar ao resultado do exercício proposto:");


//RESSALTA-SE que realizei essa outra forma, não simplificada, de entendimento de código, para treino, ex: string dia = data.Substring(0, 2)

string data; // Escolhemos a string para ter uma única entrada e para a facilidade de compreensão do usuário.
bool eNumero = true; // variável auxiliar usada para checagem, se os digitos significativos da data são apenas números (DDMMAAAA).

Console.WriteLine("\nEntre com a data no formato DD/MM/AAAA: ");
data = (Console.ReadLine());

       // Testa se string data contêm apenas numeros para as posições significativas:

    for (int i = 0; i < data.Replace("/", "").Length; i++) // inicia com zero pois vai comparar com todos os caracteres da string, motivo
                                                           // que condição é menor e não menor ou igual.
                                                           // Console.WriteLine(data[i]);
                                                           // Length vai retornar o tamanho da string de qualquer tamanho sem                                as barras.
    {
        if (data.Replace("/", "")[i] >= '0' && data.Replace("/", "")[i] <= '9') // A posição i(caracter) está entre zero e nove?
                                                                         
        {
            // Se estiver entre zero e nove, se for numero, não faz nada, pois o que está lendo ainda é número.
        }
        else
        {
            eNumero = false;    // Aqui se for só uma linha o uso de chaves é opcional. Se não for número é falso.
        }
     }

        // Teste geral:
    if (data.Length != 10 || data.Replace("/", "").Length != 8 || eNumero is false)
    {
        Console.WriteLine("Data invalida ou fora do formato!");
        // Garatimos que o dado tem uma sequencia de 8 numeros
    }

    if (int.Parse(data.Substring(0, 2)) > 30 && (int.Parse(data.Substring(3, 2)) == 4 || int.Parse(data.Substring(3, 2)) == 6 || int.Parse(data.Substring(3, 2)) == 9 || int.Parse(data.Substring(3, 2)) == 11))
    {
        Console.WriteLine("Dia inválido!");
}

        else if (int.Parse(data.Substring(0, 2)) > 31 && (int.Parse(data.Substring(3, 2)) == 1 || int.Parse(data.Substring(3, 2)) == 3 || int.Parse(data.Substring(3, 2)) == 5 || int.Parse(data.Substring(3, 2)) == 7 || int.Parse(data.Substring(3, 2)) == 8 || int.Parse(data.Substring(3, 2)) == 10 || int.Parse(data.Substring(3, 2)) == 12))
        {
            Console.WriteLine("Dia Invalido!");
        }

            else if (int.Parse(data.Substring(3, 2)) <= 0 || int.Parse(data.Substring(3, 2)) >= 13)
            {
                Console.WriteLine("Mês invalido!");
            }

                else if (int.Parse(data.Substring(0, 2)) > 29 && int.Parse(data.Substring(3, 2)) == 2)
                {
                    Console.WriteLine("Data invalida");
                }

                    else if ((int.Parse(data.Substring(0, 2)) == 29 && int.Parse(data.Substring(3, 2)) == 2) && !(int.Parse(data.Substring(6, 4)) % 4 == 0 && int.Parse(data.Substring(6, 4)) % 100 != 0))
                    { 
                        Console.WriteLine("Data invalida!");
                    }

    else
    {
        Console.WriteLine("A data digitada é: " + data.Substring(6, 4) + data.Substring(3, 2) + data.Substring(0, 2));
        Console.WriteLine("A data digitada é: " + data.Substring(8, 2) + data.Substring(3, 2) + data.Substring(0, 2));
     }

// Referência: Consultado documentação oficial Microsoft.