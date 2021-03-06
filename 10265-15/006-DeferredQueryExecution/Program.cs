﻿using System;
using System.Linq;

namespace _006_DeferredQueryExecution
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] numeros = { 1, 25, 40, 29 };

            var resultados = from numero in numeros
                             select Dobro(numero);

            foreach (var item in resultados) //deferred
                Console.WriteLine(item);

            Console.WriteLine("\n");

            for (int i = 0; i < numeros.Length; i++)
                numeros[i]++;

            foreach (var item in resultados.ToList()) //immediate query execution
                Console.WriteLine(item);

            Console.ReadKey();
        }

        static double Dobro(int x)
        {
            Console.WriteLine("calculando {0} * 2", x);

            return x * 2;
        }
    }
}
