/*3.Fazer um laço(repetição) que fique solicitando números ao usuário. 
Se o usuário digitar 0 o programa em VS deve parar. 
Caso contrário, o programa em VS deve informar se o número é par ou ímpar e se ele é um número primo.*/

float numero;

Console.Clear();

//do
{
    Console.Write("Digite um número: ");
    float.TryParse(Console.ReadLine(), out numero);

    if (numero == 0)
    {
        Console.Write("Número inválido. O programa será fechado!");
        Thread.Sleep(1000);
      
    }
} //while (numero >= 1);

    for (int i = 1; i >= numero; i++)
    {
        if (i % 2 == 0)
        {
            Console.WriteLine($"São pares os números {i}.");
        }
            else if (i % 2 != 0)
            {
                Console.WriteLine($"São ímpares os números {i}.");
            }
                else if (i == i)
                {
                    Console.WriteLine($"São primos os números {i}.");
                }
    }   



/*float numero;
string continua = "s";

while (continua == "S" || continua == "s")
{

    do// marcação para saber qual é o bloco de código que devo iniciar de novo, caso a condição no while seja verdadeira.
    {
        Console.Clear();//Limpa Console
        Console.Write("\nDigite um número positivo e inteiro: ");
        float.TryParse(Console.ReadLine(), out numero);
        // Console.Write(numero);
        // Console.Write(numero == (int)numero);

        if (!(numero >= 0 && numero == (int)numero)) // Para que a mensagem seja enviada na digitação de números fora do permitido.
        {
            Console.WriteLine("Número invalido!");
            Thread.Sleep(2000);
        }

    } while (!(numero >= 0 && numero == (int)numero)); //Ele precisa estar na condição de ser igual ou maior que zero e precisa que ele seja inteiro. Se ele não for isso, se ele me retornar um false, eu invertido a saida lógica com a negação para ele perguntar de novo - ou seja fazer o loop considerando como verdade...pois o while refaz o loop enquanto verdade.

    // Só entra no for quando o numero certo for digitado lá em cima... enquato não digitar o número correto, ele fica no loop no bloco.

    for (int i = 1; i <= numero; i++) // tem um int aqui porque estou declarando e inicializando com zero a variável. E porque ela desaparece quando acaba o for? Cadê o i? porque essa variável tá presa no contexto do for. Ela só tem vida dentro do for.
    {
        // Console.WriteLine(i);//Mostrar os números do for de 1 até o numero digitado.

        if (i % 2 == 0)
        {
            Console.WriteLine($"São pares os números {i}."); // mostra somente os números PAR entre 1 e o número digitado pelo usuário.
        }
    }

    Console.Write("\nQuer digitar outro número? ");
    continua = Console.ReadLine();
}*/
