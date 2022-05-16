/*1. Faça um programa em VS que solicite um número inteiro positivo ao usuário, validando a entrada de dados 
(informando se ele estiver errado e repetindo a solicitação até que esteja correto). 
Após o programa em VS deve informar todos os números pares existentes entre 1 e o número fornecido pelo usuário.

Exemplo:
Digite um número inteiro positivo: -8
Valor incorreto!
Digite um número inteiro positivo: 8
Numero digitado: 8
Números inteiros pares entre 1 e 8: 2, 4, 6.*/

float numero;

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
                Thread.Sleep(1000);
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

    //Console.Write("\nQuer digitar outro número? ");
   // continua = Console.ReadLine();

