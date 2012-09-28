using System;
using System.Linq;

namespace _002_Where
{
    class Program
    {
        static void Main(string[] args)
        {
            var texto = "aqui tem um texto qualquer desde 2011!!!";

            var digitos = from letra in texto
                          where Char.IsDigit(letra)
                          select letra;

            var letras = texto
                .Where(letra => Char.IsLetter(letra));

            var outros = from letra in texto
                         where Char.IsSeparator(letra)
                            || Char.IsPunctuation(letra)
                            || Char.IsSymbol(letra)
                         select letra;

            foreach (var item in digitos)
            {
                Console.Write("{0} ", item);
            }

            Console.WriteLine();

            foreach (var item in letras)
            {
                Console.Write("{0} ", item);
            }

            Console.WriteLine();

            foreach (var item in outros)
            {
                Console.Write("{0} ", item);
            }

            Console.ReadKey();
        }
    }
}
