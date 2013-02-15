using System;

namespace _001_PartialClass
{
    public partial class Pessoa
    {
        public Pessoa(int id = 0, String nome = "nome não informado", Sexo sexo = Sexo.Masculino, bool fumante = false)
        {
            Id = id;
            Nome = nome;
            Sexo = sexo;
            Fumante = fumante;
        }

        public void Acordar() { Console.WriteLine("Pessoa.Acordar()"); }
        public void Comer() { Console.WriteLine("Pessoa.Comer()"); }
        public void Dormir() { Console.WriteLine("Pessoa.Dormir()"); }

        partial void Pensar(){Console.WriteLine("Pessoa.Nascer()");}
       
        public override string ToString()
        {
            return String.Format("{0} - {1} - {2} - {3}", Id, Nome, Sexo, Fumante);
        }
    }
}
