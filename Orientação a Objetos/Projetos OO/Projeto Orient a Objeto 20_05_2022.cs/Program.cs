//Projeto OO - 001 - Orientação a Objeto:

//*********isso fica dentro da Main:********
        
                                                                 // Crio objeto chamado l do tipo Lampada
Lampada l = new Lampada();                                      // chamando o construtor desta lampada. // l é o nome da variável criada.
l.ligar();                                                      // esse método mostra que a lampada está sendo ligada.
l.potencia = 9;
Console.WriteLine($"O atributo ligado é = {l.ligada}. E a Potência é = {l.potencia}!");
l.desligar();
Console.WriteLine($"O atributo ligado é = {l.ligada}. E a Potência é = {l.potencia}!");
double n;
n = l.retornaPotencia();
Console.WriteLine($"A potência da lampada cadastrada é {l.retornaPotencia()}.");   // aqui estou lidando com metodo, e não atributo, por isso
                                                                                   // tem os parenteses () --> {l.retornaPotencia()}; 
Console.WriteLine($"Retorno da função estaLigada ? {l.estaLigada()}");
l.ligar();
l.desligar();
if (l.estaLigada())
{
    Console.WriteLine($"A lâmpada está ligada!");
}
else
{
    Console.WriteLine($"A lâmpada está desligada!");
}
// fim da Main
                                                                
//***********Abaixo fica fora da Main:******//
public class Lampada                                                            // nome da classe sempre inicia com letra Maiúscula
                       
                                                                                  // Métodos:
                                                                                           // visibilidade (public ou private ou protected)
                                                                                          // tipo de retorno --> void não retorna nada
                                                                                         // tipo de retorno int --> retorna  um inteiro
                                                                                        // tipo de retorno double --> retorna um double
{
    public bool ligada;                                                         // Só defini se é true or false. Isso é o nosso atributo.
    public double potencia;
    public void ligar() 
    {
        Console.WriteLine("A lâmpada está sendo ligada!");
        ligada = true; 
    }
    public void desligar() 
    {
        Console.WriteLine("A lâmpada está sendo desligada!");
        ligada = false; 
    }
    public double retornaPotencia()
    {
        return potencia;
    }
    public bool estaLigada()                                                // é um método que retorna boolean e mostra se é true or false
    { 
        return ligada; 
    }
 }

