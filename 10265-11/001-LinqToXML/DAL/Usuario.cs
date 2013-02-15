using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Xml.Linq;

namespace _001_LinqToXML.DAL
{
    public class Usuario
    {
        private static String ARQUIVO = @"App_Data\Usuario.xml";

        public static void Insert(Model.Usuario u)
        {
            var xml = XDocument.Load(ARQUIVO);

            XElement linha = new XElement
            (
                "linha",
                new XAttribute("user", u.User),
                new XAttribute("password", u.Password)
            );

            if (xml.Descendants("linha")
                .SingleOrDefault<XElement>(x => x.Attribute("user")
                                                    .Value
                                                    .Equals(u.User)) == null)
            {
                xml.Descendants("linhas").First<XElement>().Add(linha);
            }

            xml.Save(ARQUIVO);
        }

        public static void Update(Model.Usuario u)
        {
            var xml = XDocument.Load(ARQUIVO);

            xml.Descendants("linha")
                .SingleOrDefault<XElement>(x => x.Attribute("user")
                                                    .Value
                                                    .Equals(u.User))
                .Attribute("password")
                .Value = u.Password;

            xml.Save(ARQUIVO);
        }

        public static void Delete(Model.Usuario u)
        {
            var xml = XDocument.Load(ARQUIVO);

            xml.Descendants("linha")
                .SingleOrDefault<XElement>(x => x.Attribute("user")
                                                    .Value
                                                    .Equals(u.User))
                .Remove();

            xml.Save(ARQUIVO);

        }

        public static List<Model.Usuario> GetAll()
        {
            List<Model.Usuario> retorno = new List<Model.Usuario>();

            var xml = XDocument.Load(ARQUIVO);

            foreach (var item in xml.Descendants("linha"))
            {
                retorno.Add(new Model.Usuario()
                {
                    User = item.Attribute("user").Value,
                    Password = item.Attribute("password").Value
                });
            }

            return retorno;
        }

        public static Model.Usuario GetByUser(String user)
        {
            return GetAll().Find(o => o.User == user);
        }
    }
}
