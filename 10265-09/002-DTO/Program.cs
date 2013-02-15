using System;

namespace _002_DTO
{
    class Program
    {
        static void Main(string[] args)
        {
            var dto = DTOStore<Contact>.Entidade.CriarDTO();

            dto.Entidade = new Contact { ContactID = 1, FirstName = "Zé", LastName = "da Silva" };

            if (DTOStore<Contact>.Entidade.AdicionarDTO(dto))
            {
                Console.WriteLine(DTOStore<Contact>.I);
                Console.WriteLine("{0} -> {1} {2}", dto.Entidade.ContactID, dto.Entidade.FirstName, dto.Entidade.LastName);
            }

            Console.ReadKey();
        }
    }
}
