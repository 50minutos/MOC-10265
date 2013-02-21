using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using _019_3CamadasV1.Util;

namespace _019_3CamadasV1.Model
{
    /// <summary>
    /// classe que representa um objeto da tabela PESSOA do banco DADOS
    /// </summary>
    [Db("PESSOA")]
    class Pessoa
    {
        /// <summary>
        /// representa o campo PESSOA_ID INT IDENTITY PRIMARY KEY
        /// </summary>
        [Db("PESSOA_ID")]
        public int Id { get; set; }

        /// <summary>
        /// campo PESSOA_NOME VARCHAR(50)
        /// </summary>
        [Db("PESSOA_NOME")]
        public String Nome { get; set; }

        /// <summary>
        /// campo PESSOA_SEXO CHAR(1)
        /// </summary>
        [Db("PESSOA_SEXO")]
        public char Sexo { get; set; }

        /// <summary>
        /// representação de uma linha da tabela PESSOA
        /// </summary>
        /// <returns>campos da tabela</returns>
        public override string ToString()
        {
            return String.Format("{0} -> {1} - {2}", Id, Nome, Sexo);
        }
    }
}
