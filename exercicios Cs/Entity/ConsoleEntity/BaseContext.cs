using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;
using System.Data.Entity;

namespace ConsoleEntity
{
    internal class BaseContext : DbContext  //lembre de fazer a importação
    {
        // Construtor
        public BaseContext() : base("BancoDadosVeiculos") { } //instanciando BaseContext com o banco com esse nome

        // duas classes e terão duas tabelas
        public DbSet<Veiculo> Veiculos { get; set; } // coleção
        public DbSet<Modelo> Modelos { get; set; } // coleção
    }
}
