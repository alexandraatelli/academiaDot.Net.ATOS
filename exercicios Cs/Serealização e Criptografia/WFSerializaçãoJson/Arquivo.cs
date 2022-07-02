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
    public class Arquivo
    {
        public static string LerArquivo(string dadosArquivo)
        {
            using (var leitor = new StreamReader(dadosArquivo))
            {
                return leitor.ReadToEnd();
            }
        }
    }
}
