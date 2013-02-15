using System;

namespace _001_PartialClass
{
    public partial class Pessoa
    {
        public int Id { get; set; }
        public String Nome { get; set; }
        public Sexo Sexo { get; set; }
        public bool Fumante { get; set; }
    }
}
