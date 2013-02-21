using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace _019_3CamadasV1.BLL
{
    class Pessoa
    {
        public static void Insert(Model.Pessoa o)
        {
            //todo: aqui vão as regras de negócio

            DAL.Pessoa.Insert(o);
        }

        public static void Update(Model.Pessoa o)
        {
            //todo: aqui vão as regras de negócio

            DAL.Pessoa.Update(o);
        }

        public static void Delete(Model.Pessoa o)
        {
            //todo: aqui vão as regras de negócio

            DAL.Pessoa.Delete(o);
        }

        public static List<Model.Pessoa> Select()
        {
            //todo: aqui vão as regras de negócio

            return DAL.Pessoa.Select();
        }
    }
}
