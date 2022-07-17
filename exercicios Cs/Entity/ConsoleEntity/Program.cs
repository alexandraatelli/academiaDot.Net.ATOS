using ConsoleEntity;
/*
string nome = "GLS";

Modelo tmp = new Modelo() { Nome = nome };
tmp.Salvar();

var listaModelos = Modelo.Todos();


foreach (var item in Modelo.Todos())
{
    Console.WriteLine(item.Id);
    Console.WriteLine(item.Nome);
}

/*
var primeiroModelo = listaModelos.First();
Veiculo tmp2 = new Veiculo() { Nome = "Honda", Modelo = primeiroModelo, Ano = 2011 };
tmp2.Salvar();

Console.WriteLine("Lista de Veículos");
foreach (var item in Veiculo.Todos())
{
    Console.WriteLine(item.Id);
    Console.WriteLine(item.Nome);
    Console.WriteLine(item.Modelo.Nome);
}

Console.WriteLine("Total de modelos: " + Modelo.Todos().Count);
foreach (var item in Modelo.Todos())
{
    Console.WriteLine(item.Id + " - " + item.Nome);
}
*/

BaseContext contexto = new BaseContext();
var resultado = contexto.Modelos.Where(n => n.Nome.Contains("GLS")).ToList();
Console.WriteLine(resultado[0].Id);
Console.WriteLine(resultado[0].Nome);
contexto.Modelos.Remove(resultado[0]);


contexto.SaveChanges();

Console.WriteLine("Total de modelos: " + Modelo.Todos().Count);