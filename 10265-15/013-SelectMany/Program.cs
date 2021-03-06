﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace _013_SelectMany
{
    class Program
    {
        static void Main(string[] args)
        {
            Pai[] pais = new Pai[]{
                new Pai(){
                    nome="Agnaldo", 
                    filhos = new Filho[]
                    {
                        new Filho(){ nome="Bruno", sexo='M' }, 
                        new Filho(){nome="Netinho", sexo='M'}, 
                        new Filho(){nome="Pedro", sexo='M'}
                    }
                }, 
                new Pai(){
                    nome="Zé", 
                    filhos = new Filho[]
                    {
                        new Filho(){ nome="Zezinho", sexo='M' }, 
                        new Filho(){nome="Aninha", sexo='F'}
                    }
                } 
            };

            var filhos = pais
                .Where(p => p.nome.Equals("Agnaldo"))
                .SelectMany<Pai, Filho>(pai => pai.filhos);

            ObjectDumper.Write(filhos);

            Console.WriteLine();

            var deNovo = from p in pais
                         from f in p.filhos
                         where p.nome.Equals("Agnaldo")
                         select f;

            ObjectDumper.Write(deNovo);

            Console.ReadKey();
        }
    }

    class Filho
    {
        public String nome;
        public char sexo;
    }

    class Pai
    {
        public String nome;
        public Filho[] filhos;
    }
}