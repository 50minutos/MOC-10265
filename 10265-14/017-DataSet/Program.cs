using System;
using System.Data;
using System.Diagnostics;

namespace _017_DataSet
{
    class Program
    {
        static void Main()
        {
            var ds = new DataSet("TABELAS");

            var dt = new DataTable("PESSOA");

            ds.Tables.Add(dt);

            dt.Columns.Add("COD_PESSOA", typeof(int));

            dt.Columns.Add(new DataColumn("NOME_PESSOA", typeof(String)));

            var dc = new DataColumn { ColumnName = "SEXO_PESSOA", DataType = typeof(Sexo) };
            dt.Columns.Add(dc);

            var dr = dt.NewRow();

            dr.SetField("COD_PESSOA", 1);
            dr.SetField(1, "ADÃO");
            dr[2] = Sexo.Masculino;

            dt.Rows.Add(dr);

            dr = dt.NewRow();

            dr[0] = 2;
            dr[1] = "EVA";
            dr[2] = Sexo.Feminino;

            dt.Rows.Add(dr);

            Console.WriteLine("DataSet: {0}", ds.DataSetName);

            Console.WriteLine("Tabela: {0}", ds.Tables[0].TableName);

            Console.WriteLine();

            foreach (DataRow linha in ds.Tables[0].Rows)
            {
                foreach (DataColumn coluna in ds.Tables[0].Columns)
                {
                    Console.WriteLine("{0} -> {1}", coluna.ColumnName, linha[coluna]);
                }

                Console.WriteLine();
            }

            const String nomeArquivo = "ds.xml";

            ds.WriteXml(nomeArquivo);

            Process.Start(nomeArquivo);

            Console.ReadKey();
        }
    }
}
