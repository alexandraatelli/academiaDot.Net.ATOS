using Calculadora.cs;

///<summary>
/// instanciação do objeto - utilizando "new"
/// </summary>
Operacao operacao = new Operacao();

double resultado;
resultado = operacao.Somar(2, 3); //Passando parametro, e chamar o método da classe, retornado um resultado
Console.WriteLine(resultado);

///<summary>
///instanciando outro objeto e utilizando os métodos da classe Operacao
/// </summary>
Operacao operacao1 = new Operacao(10, 20);
Console.WriteLine("Atributos da Classe (Objeto operacao1: " + operacao1.N1 + " " + operacao1.N2);

resultado = operacao1.Somar(2, 3);
Console.WriteLine(resultado);

resultado = operacao1.Subtrair(2, 3);
Console.WriteLine(resultado);

resultado = operacao1.Dividir(2, 3);
Console.WriteLine(resultado);

resultado = operacao1.Multiplicar(2, 3);
Console.WriteLine(resultado);

