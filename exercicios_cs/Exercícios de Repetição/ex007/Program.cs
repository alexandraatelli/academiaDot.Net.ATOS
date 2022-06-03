/*7.Faça um programa em VS que solicite o nome, a idade e o salário de uma pessoa. 
A cada solicitação, teste se o usuário informou um valor válido. 
Por exemplo: se o nome for não for lido corretamente (ou seja, se estiver em branco ou se for um número), 
informe que ele está incorreto e saia do programa em VS. 
Se o nome for lido corretamente, solicite a idade. Se ela for incorreta (menor ou igual a zero), 
informe que está errada e saia. Se estiver correta, solicite o salário. 
Se ele estiver incorreto (menor ou igual a zero), informe que está incorreto e saia. 
Se estiver correto, mostre todos os valores lidos.*/

string nome = "";
int idade = 0;
string auxiliar;
float salario = 0F;

do
{

    Console.Clear();
    Console.Write($" Digite seu nome: ");
    nome = Console.ReadLine();

    if (nome == " " || nome.All(char.IsNumber) == true) // Testa se todos os caracteres são númericos. 
    {
        Console.WriteLine("Nome inválido! Digite novamente.");
        Thread.Sleep(1500);

    }
} while (nome == " " || nome.All(char.IsNumber));

do
{
    Console.Write("Digite a idade: ");
    auxiliar = Console.ReadLine();
    if (auxiliar.All(char.IsNumber) == true) // Todos que estão na auxiliar são numéricos?
    {
        idade = int.Parse(auxiliar); // Se sim, então jogue o contéudo da auxiliar como inteiro para idade.
    }
    if (idade <= 0)
    {
        Console.WriteLine("Idade inválida! Digite novamente.");
        Thread.Sleep(1500);
    }
} while (idade <= 0);

do
{                                                          
    Console.Write("Digite o salário: ");                    
    auxiliar = Console.ReadLine();                          
                                                           
    if (auxiliar.Replace(',', '0').All(char.IsNumber) == true) 
    {
        salario = float.Parse(auxiliar); // então jogue o contéudo da auxiliar, enxergando a vírgula como número, com o uso do Parse, para variável salário - porque a vírgula para float.Parse é correta.
    }
    if (salario <= 0)
    {
        Console.WriteLine("Valor inválido! Digite novamente.");
        Thread.Sleep(1500);
    }
} while (salario <= 0);

    Console.WriteLine($"{nome} tem {idade} anos de idade e recebe um salário de {salario:C} reais!");


//Referências:  https://docs.microsoft.com/pt-br/dotnet/api/system.string.replace?view=net-6.0
//https://docs.microsoft.com/pt-br/dotnet/api/system.char.isnumber?view=net-6.0


 /* Notas Explicativas:

 * Porque auxiliar: auxiliar = Console.ReadLine();?
 
 * R: Testado com uma variável auxiliar, antes da conversão para float. A variável auxiliar (que é um objeto 
 * string) retornou  um outro objeto string (Replace), que substituiu a vírgula pelo zero (0), através do método
 * Replace. 
 * 
 * Uma vez que retorna objeto string, automaticamente, se ele pe objeto string, recebe todos os métodos do 
 * objeto string, e, junto ao All, verificou-se se todo o contéudo é numérico, para então: jogar o contéudo da 
 * auxiliar, enxergando a vírgula como número, com o uso do Parse, para variável salário - porque a vírgula 
 * para float.Parse é correta.

        auxiliar = Console.ReadLine();

        if (auxiliar.Replace(',', '0').All(char.IsNumber) == true)
        {
            salario = float.Parse(auxiliar); */