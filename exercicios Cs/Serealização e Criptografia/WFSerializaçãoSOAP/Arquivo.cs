using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WFSerializaçãoSOAP
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
