using System;

namespace _005_TipoAnonimo
{
    class Program
    {
        static void Main(string[] args)
        {
            var carro = new { Placa = "ABC1234", Cor = "Vermelho", Ano = 2011 };

            Console.WriteLine("{0} - {1} - {2}", carro.Placa, carro.Cor, carro.Ano);
            Console.WriteLine(carro);
            Console.WriteLine(carro.GetType());

            var pessoa = new { Nome = "Adão", Sexo = 'M', Idade = 30 };

            Console.WriteLine("{0} - {1} - {2}", pessoa.Nome, pessoa.Sexo, pessoa.Idade);
            Console.WriteLine(pessoa);
            Console.WriteLine(pessoa.GetType());

            var outroCarro = new { Placa = "XYZ1234", Cor = "Azul", Ano = 1999 };
          
            Console.WriteLine("{0} - {1} - {2}", outroCarro.Placa, outroCarro.Cor, outroCarro.Ano);
            Console.WriteLine(outroCarro);
            Console.WriteLine(outroCarro.GetType());

            Console.ReadKey();
        }
    }
}
