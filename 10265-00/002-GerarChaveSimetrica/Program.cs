using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Security.Cryptography;

namespace _002_GerarChaveSimetrica
{
    class Program
    {
        static void Main(string[] args)
        {
            //criptografia 
            //algoritmo de criptografia
            //mensagem
            //mensagem cifrada
            //chave de criptografia

            //ponta solta

            //abcdefghijklmnopqrstuvwxyz
            //paranoia e bom para senhas, entendeu?
            //parnoiebmshtd ucfgjklqvwxyz
            //puacrfngojikelbqmvswhxtydz -> chave

            //mensagem = opabeleza
            //cifrada =  bqpurkrzp
            //           opabeleza

            //abcdefghijklmnopqrstuvwxyz
            //opabeleza - original
            //bberqssgk - cifrada com rotação da chave
            //puacrfngojikelbqmvswhxtydz 1
            //zpuacrfngojikelbqmvswhxtyd 2
            //dzpuacrfngojikelbqmvswhxty 3
            //ydzpuacrfngojikelbqmvswhxt 4
            //tydzpuacrfngojikelbqmvswhx 5
            //xtydzpuacrfngojikelbqmvswh 6
            //hxtydzpuacrfngojikelbqmvsw 7
            //whxtydzpuacrfngojikelbqmvs 8
            //swhxtydzpuacrfngojikelbqmv 9

            /*
                XOR - eXclusive OR (algoritmo)
             
                6   - 0000 0110 (msg)
                2   - 0000 0010 (chave)
                6^2 - 0000 0100 -> 4 (msg cifrada)
                4^2 - 0000 0110 -> 6 (msg)
            */

            /*
               Algoritmos
               ----------
               DES: DESCryptoServiceProvider 
               RC2: RC2CryptoServiceProvider 
               Rijndael: RijndaelManaged 
               TripleDES: TripleDESCryptoServiceProvider 
            */

            //criação de chaves simétricas
            var tdes = new TripleDESCryptoServiceProvider();

            Console.WriteLine(tdes.IV); //64 bits
            Console.WriteLine(tdes.Key); //192 bits

            Console.WriteLine();

            Console.WriteLine(tdes.IV.GetString());

            Console.WriteLine();

            Console.WriteLine(tdes.Key.GetString());

            tdes.GenerateIV();
            tdes.GenerateKey();

            Console.WriteLine();
            Console.WriteLine();

            byte[] meuIV = { 12, 23, 54, 65, 23, 76, 87, 89 };
            byte[] minhaChave = { 12, 23, 54, 65, 23, 76, 87, 189, 112, 123, 154, 165, 123, 176, 187, 189, 102, 230, 254, 5, 213, 167, 178, 9 };

            tdes.IV = meuIV;
            tdes.Key = minhaChave;

            Console.WriteLine(tdes.IV.GetString());

            Console.WriteLine();

            Console.WriteLine(tdes.Key.GetString());

            Console.ReadKey();
        }
    }
}
