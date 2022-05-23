/* 2 - Crie uma classe Carro com os atributos: modelo, marca, cor e placa. Crie um método para definir os atributos, outro método para ligar o carro e outro método para desligar o carro.*/

Carro c = new Carro();

public class Carro
{
    public string marca;
    public string modelo;
    public string cor;
    public string placa;

    public bool ligado;
  
    public void inserirCarro(string BMW, string X5, string Black, string BMW1000)
    {
        marca = BMW;
        modelo = X5;
        cor = Black;
        placa = BMW1000;
    }
    public void ligar()
    {
        Console.WriteLine("O carro está sendo ligado!");
        ligado = true;
    }
    public void desligar()
    {
        Console.WriteLine("O carro está sendo desligado!");
        ligado = true;
    }
}


