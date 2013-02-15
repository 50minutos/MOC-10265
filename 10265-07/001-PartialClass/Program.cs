﻿using System;

namespace _001_PartialClass
{
    class Program
    {
        static void Main()
        {
            var p = new Pessoa
            {
                Id = 1,
                Nome = "ADÃO",
                Sexo = Sexo.Masculino,
                Fumante = false
            };

            Console.WriteLine(p);

            Console.WriteLine();

            p.Acordar();
            p.Comer();
            p.Dormir();

            Console.WriteLine();

            var q = new Pessoa(1, "Caim", fumante: true);

            Console.WriteLine(q);

            Console.ReadKey();
        }
    }
}
