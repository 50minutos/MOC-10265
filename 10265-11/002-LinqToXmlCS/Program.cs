using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Xml;
using System.Xml.Linq;

namespace _002_LinqToXmlCS
{
    class Program
    {
        static void Main(string[] args)
        {
            var doc = new XDocument(
                new XDeclaration("1.0", "utf-8", "yes"),
                new XElement("Agenda",
                new XComment("Exemplo XML"),
                new XAttribute("Tipo", "Pessoal"),
                    new XElement("Contato",
                        new XAttribute("Nome", "Agnaldo"),
                            new XElement("email", "agnaldo@50minutos.com.br"),
                            new XElement("telefone", "11-1234-4321")),
                    new XElement("Contato",
                        new XAttribute("Nome", "Netinho"),
                        new XElement("email", "netinho@50minutos.com.br"),
                        new XElement("telefone", "11-1234-4321")),
                    new XElement("Contato",
                        new XAttribute("Nome", "Renata"),
                        new XElement("email", "renata@50minutos.com.br"),
                        new XElement("telefone", "11-5432-7070"))));

            Console.WriteLine(doc.ToString());

            Console.ReadKey();
        }
    }
}
