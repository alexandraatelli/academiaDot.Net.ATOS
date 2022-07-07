using ConsoleApp_EntityFramework_CodeFirst;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using ConsoleApp_EntityFramework_CodeFirst;

using (var contexto = new ClienteContext())
{
    string opcao;
    do
    {
        Console.WriteLine("1 - Cadastrar Cliente");
        Console.WriteLine("2 - Listar Clientes");
        Console.WriteLine("3 - Remover Cliente");
        Console.WriteLine("4 - Sair");
        opcao = Console.ReadLine();

        switch (opcao)
        {
            case "1":
                Console.Write("Digite um nome: ");
                string nome = Console.ReadLine();

                Console.Write("Digite um Email: ");
                string email = Console.ReadLine();

                Console.Write("Digite o Cpf: ");
                string cpf = Console.ReadLine();
                contexto.Clientes.Add(new Cliente(nome, email, cpf));
                contexto.SaveChanges();
                break;

            case "2":
                Console.WriteLine("Clientes Cadastrados!");
                foreach (var i in contexto.Clientes)
                {
                    Console.WriteLine("Nome: " + i.Nome);
                    Console.WriteLine("Email: " + i.Email);
                    Console.WriteLine("Cpf: " + i.Cpf);
                }
                break;
            case "3":
                Console.WriteLine("Digite email para busca: ");
                string emailPesquisa = Console.ReadLine();

                var resultado = contexto.Clientes.Where(p => p.Email.Equals(emailPesquisa)).ToList();

                if (resultado.Count > 0)
                {
                    Console.Write("Achou...." + resultado[0].Nome);

                    contexto.Clientes.Remove(resultado[0]);
                    contexto.SaveChanges();
                }
                else
                {
                    Console.WriteLine("Cliente não localizado por este email!!");
                }
                break;
            case "4":
                break;
            default:
                Console.WriteLine("Opção inválida");
                break;
        }

        /*
        Console.WriteLine("Iniciando o programa!...");
        // Comentar se já adicionados ao banco:
       //contexto.Clientes.Add(new Cliente("Alexandra Atelli", "alexandra@ufn.edu.br", "00000000000"));
       //contexto.Clientes.Add(new Cliente() { Nome = "Zacarias", Email = "zacarias@ufn.edu.br" });

      // contexto.SaveChanges(); // olha o código conversando com SQLServer

        var quantidade_clientes = contexto.Clientes.Count();
        Console.WriteLine("Quantidade de clientes" + quantidade_clientes);
        contexto.Clientes.First().Email = "aleatelli@ufn.edu.br";
        contexto.SaveChanges();

        foreach (var cliente in contexto.Clientes) // contexto é o sistema
        {
            Console.WriteLine("Nome:" + cliente.Nome);
            Console.WriteLine("Email" + cliente.Email);
            Console.WriteLine("Cpf" + cliente.Cpf);
        }

        var consulta = contexto.Clientes.Where(p => p.Nome.Contains("Alexandra")).ToString();

        var listaClientes = contexto.Clientes.Where(p => p.Nome.Contains("Alexandre")).ToList();

        foreach (var item in listaClientes)
        {
            Console.WriteLine(item.Email + " - " + item.Id);
        }

        contexto.Clientes.Remove(listaClientes[1]);
        contexto.SaveChanges();

        foreach (var item in listaClientes)
        {
            Console.WriteLine(item.Email + " - " + item.Id);
        }*/
    }while (true);
}
