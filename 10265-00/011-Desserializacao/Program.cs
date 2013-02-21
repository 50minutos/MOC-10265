using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.IO;
using System.Runtime.Serialization.Formatters.Soap;

namespace _011_Desserializacao
{
    class Program
    {
        static void Main(string[] args)
        {
            using (FileStream arquivo = new FileStream("saida.txt", FileMode.Open, FileAccess.Read))
            {
                SoapFormatter formatador = new SoapFormatter();

                String msg = formatador.Deserialize(arquivo).ToString();

                Console.WriteLine(msg);

                Console.ReadKey();
            }
        }
    }
}