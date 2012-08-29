using System;
using System.Data;
using System.Data.SqlClient;

namespace _014_xxxCommandStoredProcedureOutput
{
    class Program
    {
        static void Main()
        {
            const String cs = @"Data Source=.\SQLEXPRESS;Initial Catalog=AdventureWorks;Integrated Security=true";

            using (var c = new SqlConnection(cs))
            {
                const String cmd = "USP_SOMA_OUTPUT";

                using (var k = new SqlCommand(cmd, c))
                {
                    k.CommandType = CommandType.StoredProcedure;

                    k.Parameters.AddWithValue("@X", 10);
                    k.Parameters.AddWithValue("@Y", 20);

                    var p = new SqlParameter
                    {
                        ParameterName = "@SOMA",
                        Direction = ParameterDirection.Output,
                        SqlDbType = SqlDbType.Int
                    };

                    k.Parameters.Add(p);

                    c.Open();

                    k.ExecuteNonQuery();

                    Console.WriteLine(k.Parameters["@SOMA"].Value);
                    //ou
                    Console.WriteLine(p.Value);

                    c.Close();
                }

                Console.ReadKey();
            }
        }
    }
}

/*
CREATE PROC USP_SOMA_OUTPUT
	@X INT, 
	@Y INT, 
	@SOMA INT OUTPUT
AS
	SET NOCOUNT ON
	
	SET @SOMA = @X + @Y
*/