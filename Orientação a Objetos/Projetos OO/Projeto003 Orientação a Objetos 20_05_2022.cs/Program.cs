/* 3 - Escreva uma classe Pessoa contendo todos os atributos de uma pessoa. Faça métodos para apresentar os dados.*/

Pessoa p = new Pessoa();


public class Pessoa 
{

    public bool falando;


    public void falar()
    {
        Console.WriteLine("A pessoa está sendo compelida a falar!");
        falando = true;
    }
    public void calada()
    {
        Console.WriteLine("A pessoa está sendo compelida a se calar!");
            falando = false;
    }
    public bool estafalando()
    {
       return falando;
    }

}

    







