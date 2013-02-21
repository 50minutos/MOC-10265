using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data.SqlClient;

namespace _019_3CamadasV1.DAL
{
    class Pessoa
    {
        public static void Insert(Model.Pessoa o)
        {
            var cmd = "INSERT PESSOA VALUES(@PESSOA_NOME, @PESSOA_SEXO)";

            var k = new SqlCommand(cmd);

            k.Parameters.AddWithValue("@PESSOA_NOME", o.Nome);
            k.Parameters.AddWithValue("@PESSOA_SEXO", o.Sexo);

            Sql.Execute(k);
        }

        public static void Update(Model.Pessoa o)
        {
            var cmd = "UPDATE PESSOA SET PESSOA_NOME = @PESSOA_NOME, PESSOA_SEXO = @PESSOA_SEXO WHERE PESSOA_ID = @PESSOA_ID";

            var k = new SqlCommand(cmd);

            k.Parameters.AddWithValue("@PESSOA_NOME", o.Nome);
            k.Parameters.AddWithValue("@PESSOA_SEXO", o.Sexo);
            k.Parameters.AddWithValue("@PESSOA_ID", o.Id);

            Sql.Execute(k);
        }

        public static void Delete(Model.Pessoa o)
        {
            var cmd = "DELETE PESSOA WHERE PESSOA_ID = @PESSOA_ID";

            var k = new SqlCommand(cmd);

            k.Parameters.AddWithValue("@PESSOA_ID", o.Id);

            Sql.Execute(k);
        }

        public static List<Model.Pessoa> Select()
        {
            var cmd = "SELECT * FROM PESSOA";

            var k = new SqlCommand(cmd);

            return Sql.GetData<Model.Pessoa>(k);
        }
    }
}
