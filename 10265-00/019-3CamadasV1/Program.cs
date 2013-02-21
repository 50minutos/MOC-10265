using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using _019_3CamadasV1.Util;

namespace _019_3CamadasV1
{
    class Program
    {
        static void Main(string[] args)
        {
            //UI 
            //BLL
            //DAL Model

            //var p = new Model.Pessoa() { Nome = "Cobra", Sexo = 'F' };
            //BLL.Pessoa.Insert(p);

            //var p = new Model.Pessoa() { Id = 5, Nome = "COBRA", Sexo = 'F' };
            //BLL.Pessoa.Update(p);

            //var p = new Model.Pessoa() { Id = 5 };
            //BLL.Pessoa.Delete(p);

            foreach (var item in BLL.Pessoa.Select())
            {
                Console.WriteLine(item);
            }

            //var p = new Model.Pessoa();

            //var t = p.GetType();

            //Console.WriteLine(t.GetCustomAttributes(typeof(DbAttribute), false)[0]);

            //foreach (var item in t.GetProperties())
            //{
            //    Console.WriteLine(item.Name);
            //    Console.WriteLine(item.GetCustomAttributes(typeof(DbAttribute), false)[0]);
            //}

            Console.ReadKey();
        }
    }
}
