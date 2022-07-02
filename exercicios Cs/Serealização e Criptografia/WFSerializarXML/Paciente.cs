using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WFSerializarXML
{
    [Serializable]
    public class Paciente
    {
        string nomePaciente;
        DateTime dataNascimento;
        string cpf;

        public Paciente()
        {
        }

        public Paciente(string nomePaciente, DateTime dataNascimento, string cpf)
        {
            this.NomePaciente = nomePaciente;
            this.DataNascimento = dataNascimento;
            this.Cpf = cpf;
        }

        public string NomePaciente { get => nomePaciente; set => nomePaciente = value; }

        public DateTime DataNascimento { get => dataNascimento; set => dataNascimento = value; }

        public string Cpf { get => cpf; set => cpf = value; }

        public static bool JaCadastrado(List<Paciente> lista, string nome)
        {
            foreach (Paciente paciente in lista)
            {
                if (paciente.NomePaciente == nome) return true;
            }
            return false;
        }
     
    }
}

