using System;
using System.Data;
using System.Data.SqlClient;

namespace _013_xxxCommandStoredProcedureReturnValue
{
    internal class Program
    {
        private static void Main()
        {
            const String cs = @"Data Source=.\SQLEXPRESS;Initial Catalog=AdventureWorks;Integrated Security=true";

            using (var c = new SqlConnection(cs))
            {
                const String cmd = "USP_SOMA_RETURN";

                using (var k = new SqlCommand(cmd, c))
                {
                    k.CommandType = CommandType.StoredProcedure;

                    k.Parameters.AddWithValue("@X", 10);
                    k.Parameters.AddWithValue("@Y", 20);

                    var p = new SqlParameter
                    {
                        ParameterName = "@RETURN_VALUE",
                        Direction = ParameterDirection.ReturnValue,
                        SqlDbType = SqlDbType.Int
                    };

                    k.Parameters.Add(p);

                    c.Open();

                    k.ExecuteNonQuery();

                    Console.WriteLine(k.Parameters["@RETURN_VALUE"].Value);
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
CREATE PROC USP_SOMA_RETURN
	@X INT, 
	@Y INT
AS
	SET NOCOUNT ON
	
	RETURN @X + @Y
*/

/*
tipos sql x clr: 
http://msdn.microsoft.com/en-us/library/bb386947.aspx
http://50minutos.com.br/post/Tipos-do-SQL-Server-2008-e-seus-correspondentes-no-dot-Net.aspx
*/