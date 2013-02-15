using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Diagnostics;
using System.Linq;
using System.Text;

namespace _004_T4
{
    internal class Program
    {
        private static void Main(string[] args)
        {
            //MostrarTextBlock();
            //MostrarStatementBlock();
            //MostrarExpressionBlock();
            //MostrarClassFeatureBlock();
            //MostrarTemplateDirective();
            //MostrarOutputDirective();
            //MostrarImportDirective();
            //MostrarIncludeDirective();
            //MostrarParameterDirective();
            
            Console.ReadKey();
        }

        private static void MostrarTextBlock() { Console.WriteLine("veja o arquivo Block.tt"); }
        private static void MostrarStatementBlock() { Console.WriteLine("veja o arquivo Statement.tt"); }
        private static void MostrarExpressionBlock() { Console.WriteLine("veja o arquivo Expression.tt"); }
        private static void MostrarClassFeatureBlock() { Console.WriteLine("veja o arquivo ClassFeature.tt"); }
        private static void MostrarTemplateDirective() { Console.WriteLine("veja o arquivo Template.tt"); }
        private static void MostrarOutputDirective() { Console.WriteLine("veja o arquivo Output.tt"); }
        private static void MostrarImportDirective() { Console.WriteLine("veja o arquivo Import.tt"); }
        private static void MostrarIncludeDirective() { Console.WriteLine("veja os arquivos Include.tt e Arquivo.txt"); }
        private static void MostrarParameterDirective() { Console.WriteLine("veja os arquivos Parameter.tt, Session.tt e CallContext.tt"); }


    }
}
