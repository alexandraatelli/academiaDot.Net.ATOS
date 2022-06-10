/*#12
Imagine um jogo com asteroides e uma nave de ataque, que deve destruir os asteróides que voam em todas as direções. Dessa forma, crie um programa em C# que represente
uma lista de asteroides que deveriam ser 'inseridos' no jogo. Para isso, faça uma classe que contenha os atributos (privados) posição x, posição y (do asteroide em
um plano cartesiano), tamanho do asteroide(1 a 10), velocidade do asteroide(1 a 5) e energia(1 a 5).Para esses atributos privados, gerar os métodos de acesso
(propriedades getter e setter). Além disso, implementar 3 construtores (sobrecarga): um vazio, outro passando todos os parâmetros de um objeto tipo Asteroide, e um 
terceiro que constrói um asteroide com posição x e posição y. 
O programa principal (main) deve conter a lista de Asteroides, preenchida pelo usuário. Nesse programa principal, construir um método de classe que exiba todos os
asteróides da lista.*/

using ex012_Asteroides.cs;

List<Asteroide> listA = new List<Asteroide>();

int posicaox = 0;
int posicaoy = 0;
int tamanhoo = 0;
int velocidadee = 0;
int energiaa = 0;

for (int i = 0; i < 3; i++)
{
    Console.Clear();
    Console.Write("Digite a posição X do Asteróide: ");
    posicaox = int.Parse(Console.ReadLine());

    Console.Write("Digite a posição Y do Asteróide: ");
    posicaoy = int.Parse(Console.ReadLine());

    Console.Write("Digite o tamanho do Asteróide: Escolha de 1 a 10 por favor: ");
    tamanhoo = int.Parse(Console.ReadLine());

    Console.Write("Digite a velocidade do Asteróide: Escolha de 1 a 5 por favor: ");
    velocidadee = int.Parse(Console.ReadLine());
    Console.Write("Digite a energia do Asteróide: Escolha de 1 a 5 por favor: ");
    energiaa = int.Parse(Console.ReadLine());

    listA.Add(new Asteroide(posicaox, posicaoy, tamanhoo, velocidadee, energiaa));
}
    for (int i = 0; i < listA.Count; i++)
    {
        Console.WriteLine(listA[i].ExibirAsteroides());
    }
