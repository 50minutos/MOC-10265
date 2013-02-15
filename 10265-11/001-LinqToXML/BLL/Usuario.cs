using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace _001_LinqToXML.BLL
{
    public class Usuario
    {
        public static void Insert(Model.Usuario u)
        {
            //lógica de negócios aqui
            DAL.Usuario.Insert(u);
        }

        public static void Update(Model.Usuario u)
        {
            //lógica de negócios aqui
            DAL.Usuario.Update(u);
        }

        public static void Delete(Model.Usuario u)
        {
            //lógica de negócios aqui
            DAL.Usuario.Delete(u);
        }

        public static List<Model.Usuario> GetAll()
        {
            //lógica de negócios aqui
            return DAL.Usuario.GetAll();
        }

        public static Model.Usuario GetByUser(String user)
        {
            //lógica de negócios aqui
            return DAL.Usuario.GetByUser(user);
        }
    }
}
