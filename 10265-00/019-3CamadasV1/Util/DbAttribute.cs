using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace _019_3CamadasV1.Util
{
    class DbAttribute : Attribute
    {
        private String nome;

        public DbAttribute(String nome)
        {
            this.nome = nome;
        }

        public override string ToString()
        {
            return nome;
        }
    }
}
