using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Runtime.Serialization.Formatters.Binary;
using System.Windows.Forms;
using System.Xml.Serialization;
using System.Runtime.Serialization.Formatters.Soap;
using Newtonsoft.Json;
using System.IO;

namespace WFSerializaçãoSOAP
{
    internal class Serializador
    {
        public static void SerializarSOAP(List<Paciente> lista, string dadosArquivo)
        {
            try
            {
                FileStream procurador = new FileStream(@dadosArquivo, FileMode.Create);

                SoapFormatter serializadorSOAP = new SoapFormatter();

                serializadorSOAP.Serialize(procurador, lista);
                procurador.Close();

                MessageBox.Show("Sucesso para serializar com SOAP", "Alerta");

            }
            catch (Exception ex)
            {
                MessageBox.Show("Erro: " + ex.Message);
            }
        }

        public static void DeserializarSOAP(List<Paciente> lista, string dadosArquivo)
        {
            try
            {
                using (var procurador = new FileStream(@dadosArquivo, FileMode.Open))
                {
                    SoapFormatter serializadorSOAP = new SoapFormatter();
                    lista.Clear();
                    lista.AddRange((List<Paciente>)serializadorSOAP.Deserialize(procurador));
                }

                string resposta = "";
                foreach (Paciente i in lista)
                {
                    resposta = resposta + i.NomePaciente + "\n";
                }

                MessageBox.Show(resposta, "Alerta");
            }
            catch (Exception ex)
            {
                MessageBox.Show("Erro: " + ex.Message);
            }
        }
    }
}
