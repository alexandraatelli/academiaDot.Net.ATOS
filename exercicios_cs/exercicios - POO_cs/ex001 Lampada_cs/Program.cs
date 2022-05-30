
using CLasseLampada;

int p1;
String m1;
Console.WriteLine("Olá mundo!!! Aqui, vamos cadastrar lampadas com o objetivo nenhum");
Console.WriteLine("Digite a potencia da lampada: ");
p1 = int.Parse(Console.ReadLine());
Console.WriteLine("Digite a marca da lampada");
m1 = Console.ReadLine();
Lampada l = new Lampada(p1, m1);
l.ligar();
l.desligar();


