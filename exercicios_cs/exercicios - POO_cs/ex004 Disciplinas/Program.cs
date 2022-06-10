/*Crie uma classe chamada Disciplina que contenha os atributos:
 * nome da disciplina e carga horária. 
 * Tanto o nome da disciplina quanto a carga horária são definidos pelo 
 * construtor da própria classe. 
 * Além do construtor, crie um método para exibir esses dados após a 
 * sua atribuição. O método para exibir os dados deverá ser chamado em 
 * uma outra classe
 */
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ex004_Disciplinas;

namespace ex004_Disciplinas
{
    class Program
    {
        static void Main(string[] args)
        {

            Disciplinas disciplinas = new Disciplinas();

            Console.WriteLine("Digite o nome da Disciplina: ");
            disciplinas.NomeDisciplina = Console.ReadLine();

            Console.WriteLine("Digite a carga horária da Disciplina: ");
            disciplinas.CargaHoraria = int.Parse(Console.ReadLine());

            Console.WriteLine(disciplinas.NomeDisciplina);
            Console.WriteLine(disciplinas.CargaHoraria);

        }
    }
}

  





    
