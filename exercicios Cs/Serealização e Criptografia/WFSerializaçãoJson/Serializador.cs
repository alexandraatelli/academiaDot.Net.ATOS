using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Runtime.Serialization.Formatters.Binary;
using System.Windows.Forms;
using System.Xml.Serialization;
using System.IO;
using Newtonsoft.Json;

namespace WFSerializaçãoJson
{
    public class Serializador
    {
        public static void SerializarJSON(List<Paciente> lista, string dadosArquivo)
        {
            try
            {
                StreamWriter procurador = new StreamWriter(dadosArquivo);

                JsonSerializer serializadorJSON = new JsonSerializer();
                serializadorJSON.Formatting = Formatting.Indented;


                JsonWriter escritorJSON = new JsonTextWriter(procurador);
                serializadorJSON.Serialize(escritorJSON, lista);

                procurador.Close();
                escritorJSON.Close();

                MessageBox.Show("Sucesso para serializar com JSON");
            }
            catch (Exception ex)
            {
                MessageBox.Show("Erro: " + ex.Message);
            }
        }

        public static void DeserializarJSON(List<Paciente> lista, string dadosArquivo)
        {
            try
            {
                string json = File.ReadAllText(@dadosArquivo);
                lista.Clear();

                lista.AddRange(JsonConvert.DeserializeObject<List<Paciente>>(json));

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

        internal static void deserializarJSON(List<Paciente> pacientes, string v)
        {
            throw new NotImplementedException();
        }
    }
}
