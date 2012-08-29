using System;
using System.Linq;

namespace _003_OrderBy
{
    class Program
    {
        static void Main(string[] args)
        {
            String[] palavrasDaFrase = "Por que o SQL Server Saturday Night é aos sábados ? E por que é à noite ? Mistéééério ! ! !".Split(new char[] { ' ', '?' }, StringSplitOptions.RemoveEmptyEntries);

            //var palavras = from palavra in palavrasDaFrase
            //               orderby palavra.Length //ascending//descending
            //               select palavra;

            var palavras = palavrasDaFrase.OrderByDescending(p => p.Length);

            //var palavras = palavrasDaFrase
            //                    .OrderBy(p => p.Length)
            //                    .ThenBy(p => p);

            foreach (var p in palavras)
                Console.WriteLine(p);

            Console.ReadKey();
        }
    }
}
