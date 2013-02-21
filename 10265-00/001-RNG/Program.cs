using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Security.Cryptography;

namespace _001_RNG
{
    class Program
    {
        static void Main(string[] args)
        {
            var rng = new RNGCryptoServiceProvider();

            var a = new byte[16];

            for (int i = 0; i < 10; i++)
            {
                //rng.GetBytes(a);
                rng.GetNonZeroBytes(a);

                foreach (var item in a)
                {
                    Console.Write("{0,4}", item);
                }

                Console.WriteLine();
            }

            //algoritmo de criptografia: trocar letras de lugar de acordo com uma chave pré-definida

            //bcfjkmpqrsuvwxyzagnldoetih -> chave de criptografia
            //abcdefghijklmnopqrstuvwxyz

            //atacar o inimigo -> mensagem 
            //blbfbgyrxrwrpy -> mensagem cifrada (encriptada, criptografada)
            //atacaroinimigo -> mensagem decifrada (decriptada)

            Console.ReadKey();
        }
    }
}
