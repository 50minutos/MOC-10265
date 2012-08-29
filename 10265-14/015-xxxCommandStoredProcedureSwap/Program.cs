using System;
using System.Data;
using System.Data.SqlClient;

namespace _015_xxxCommandStoredProcedureSwap
{
    class Program
    {
        static void Main()
        {
            const String cs = @"Data Source=.\SQLEXPRESS;Initial Catalog=AdventureWorks;Integrated Security=true";

            using (var c = new SqlConnection(cs))
            {
                const String cmd = "USP_SWAP";

                using (var k = new SqlCommand(cmd, c))
                {
                    k.CommandType = CommandType.StoredProcedure;

                    k.Parameters.AddWithValue("@X", 10);
                    k.Parameters.AddWithValue("@Y", 20);

                    foreach (SqlParameter p in k.Parameters)
                    {
                        p.Direction = ParameterDirection.InputOutput;
                    }

                    c.Open();

                    k.ExecuteNonQuery();

                    Console.WriteLine("@X = {0}", k.Parameters["@X"].Value);
                    Console.WriteLine("@Y = {0}", k.Parameters["@Y"].Value);

                    c.Close();
                }

                Console.ReadKey();
            }
        }
    }
}

/*
CREATE PROC USP_SWAP
	@X INT OUTPUT, 
	@Y INT OUTPUT
AS
	DECLARE @TMP INT = @X
	SET @X = @Y
	SET @Y = @TMP
*/
