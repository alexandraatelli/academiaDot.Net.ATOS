﻿using ConsoleApp_EntityFramework_CodeFirst;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp_EntityFramework_CodeFirst
{
    [Table ("Cliente")]
    public class Cliente
    {
        public int Id { get; set; }
        public string Nome { get; set; }
        public string Email { get; set; }
        public string Cpf { get; set; }
    
        public Cliente()
        {

        }

        public Cliente(string nome, string email, string cpf)
        {
            Nome = nome;
            Email = email;
            Cpf = cpf;
        }
    }
}
