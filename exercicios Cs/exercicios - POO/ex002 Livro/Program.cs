using ClasseLivro;

Console.WriteLine("Estamos no nosso projeto que trabalharemos com livros!");
String t, a;
int pag, ano, ed;
Console.WriteLine("Digite o título do livro: ");
t = Console.ReadLine();
Console.WriteLine("Digite o autor do livro: ");
a = Console.ReadLine();
Console.WriteLine("Digite a quantidade de páginas: ");
pag = int.Parse(Console.ReadLine());
Console.WriteLine("Digite o ano de publicação do livro: ");
ano = int.Parse(Console.ReadLine());
Console.WriteLine("Digite a edição do livro: ");
ed = int.Parse(Console.ReadLine());
ClasseLivro.Livro l1 = new ClasseLivro.Livro(t, a, pag, ano, ed); // Só ta enviando os valores, quanto ela vale.
l1.apresentaInfoLivro();

