using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ex004_Disciplinas
{
    class Disciplinas
    {
        public string nomeDisciplina;
        public int cargaHoraria;

        public string NomeDisciplina { get; set; }
        public string CargaHoraria { get; set; }
    }

    public Disciplinas(string nomeDisciplina, int cargaHoraria)
    {
        this.NomeDisciplina = nomeDisciplina;
        this.CargaHoraria = cargaHoraria;
    }
    public ExibirDados()
    {
        

    }
}


