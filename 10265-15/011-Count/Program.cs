using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Con011_Count
{
    class Program
    {
        static void Main(string[] args)
        {
            String texto = "O SQL Server 2008 R2 FOI lançado em maio de algum ano.";

            //var qtdCaracteresNumericos = texto
            //    .Where(c => Char.IsNumber(c))
            //    .Count();

            var qtdCaracteresNumericos = texto
                .Count(c => Char.IsNumber(c));
            
            Console.WriteLine(qtdCaracteresNumericos);

            Console.ReadKey();
        }
    }
}
