using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Runtime.Serialization.Formatters.Binary;
using System.Windows.Forms;
using System.Xml.Serialization;
using System.IO;


namespace WFSerializaçãoJson
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        List<Paciente> pacientes = new List<Paciente>();

        private bool SaoValidosCampos()
        {
            return !Tb_NomePaciente.Text.Equals("") && !Mtb_DataNascimento.Text.Equals("") && !Mtb_Cpf.Text.Equals("");
        }

        private void LimpaCampos()
        {
            Tb_NomePaciente.Text = String.Empty;
            Mtb_DataNascimento.Text = String.Empty;
            Mtb_Cpf.Text = String.Empty;
        }

        private void Bt_Gravar_Click(object sender, EventArgs e)
        {
            if (SaoValidosCampos())
            {
                try
                {
                    Paciente p = new Paciente(Tb_NomePaciente.Text.ToUpper(), DateTime.Parse(Mtb_DataNascimento.Text), Mtb_Cpf.Text);
                    if (Paciente.JaCadastrado(pacientes, p.NomePaciente))
                    {
                        MessageBox.Show("Paciente já cadastrado");
                    }
                    else
                    {
                        pacientes.Add(p);
                        MessageBox.Show("Paciente cadastrado com sucesso");
                    }

                    LimpaCampos();
                }
                catch (Exception)
                {
                    MessageBox.Show("Data inválida");
                }

            }
            else
            {
                MessageBox.Show("Todos os campos precisam ser preenchidos");
            }
        }

        private void Bt_Serializar_Click(object sender, EventArgs e)
        {
            if (pacientes.Count > 0)
            {
                Serializador.SerializarJSON(pacientes, @"C:\Users\atell\Desktop\Atos\MeusProjAtos.Net\academiaDot.Net\exercicios Cs\Serealização e Criptografia\WFSerializaçãoJson\bin\Debug\pacientes.json");

                Tb_ConteudoArquivo.Text = Arquivo.LerArquivo(@"C:\Users\atell\Desktop\Atos\MeusProjAtos.Net\academiaDot.Net\exercicios Cs\Serealização e Criptografia\WFSerializaçãoJson\bin\Debug\pacientes.json");
            }
            else
            {
                MessageBox.Show("Lista de pacientes vazia!", "Alerta");
            }
        }

        private void Bt_Deserializar_Click(object sender, EventArgs e)
        {
            Serializador.DeserializarJSON(pacientes, @"C:\Users\atell\Desktop\Atos\MeusProjAtos.Net\academiaDot.Net\exercicios Cs\Serealização e Criptografia\WFSerializaçãoJson\bin\Debug\pacientes.json");
        }
    }
}
