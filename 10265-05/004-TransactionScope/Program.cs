using System;
using System.Transactions;
using _001_AW;

namespace _004_TransactionScope
{
    class Program
    {
        static void Main(string[] args)
        {
            using (var e = new AdventureWorksEntities())
            {
                using (var ts = new TransactionScope())
                {
                    try
                    {
                        var c = new Contato
                                            {
                                                Nome = "Adão",
                                                Sobrenome = "da Silva",
                                                PasswordHash = "abc",
                                                PasswordSalt = "xyz",
                                                rowguid = Guid.NewGuid(),
                                                DataDeAlteracao = DateTime.Now
                                            };

                        e.Contatos.AddObject(c);

                        e.SaveChanges();

                        Console.WriteLine("inseri o contato {0}", c.ContactID);

                        var f = new Funcionario { ContactID = c.ContactID};

                        e.Funcionarios.AddObject(f);

                        e.SaveChanges();

                        ts.Complete();
                    }
                    catch (Exception ex)
                    {
                        Console.WriteLine("\n{0} -> {1}\n\n\n", ex.GetType().Name, ex.Message);

                        if (ex.InnerException != null)
                        {
                            Console.WriteLine("{0} -> {1}", ex.InnerException.GetType().Name, ex.InnerException.Message);
                        }
                    }
                }

                Console.ReadKey();
            }
        }
    }
}
