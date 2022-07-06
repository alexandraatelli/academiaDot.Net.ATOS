using ConsoleApp_EntityFramework_CodeFirst;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp_EntityFramework_CodeFirst
{
    public class ClienteContext : DbContext
    {
        public DbSet<Cliente> Clientes { get; set; } // lista
    }
}
