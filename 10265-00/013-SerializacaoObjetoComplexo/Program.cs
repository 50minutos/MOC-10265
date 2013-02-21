using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Runtime.Serialization.Formatters.Soap;
using System.Diagnostics;
using System.IO;

namespace _013_SerializacaoObjetoComplexo
{
    class Program
    {
        static void Main(string[] args)
        {
            using (FileStream fileStream = new FileStream("saida.xml", FileMode.Create, FileAccess.Write))
            {
                Pessoa avoMaterno = new Pessoa() { nome = "Zé Diogo" };

                Pessoa meuPai = new Pessoa() { nome = "Antonio" };
                Pessoa minhaMae = new Pessoa() { nome = "Elisa", pai = avoMaterno };

                Pessoa eu = new Pessoa() { nome = "Agnaldo", pai = meuPai, mae = minhaMae };

                SoapFormatter soapFormatter = new SoapFormatter();

                soapFormatter.Serialize(fileStream, eu);

                fileStream.Close();
            }

            Process.Start("saida.xml");
        }
    }

    [Serializable]
    class Pessoa
    {
        public String nome;
        public Pessoa pai;
        public Pessoa mae;
    }
}
