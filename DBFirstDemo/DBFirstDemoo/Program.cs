using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DBFirstDemoo
{
    internal class Program
    {
        static void Main(string[] args)
        {
            using (var db = new LojaEntities())
            {
                // Criando clientes e pedidos
                Cliente cliente1 = new Cliente()
                {
                    Nome = "Smeagol",
                    Email = "smeagol@gollum.com"
                };
                db.Clientes.Add(cliente1);
                db.SaveChanges();

                Cliente cliente2 = new Cliente()
                {
                    Nome = "Harry Potter",
                    Email = "harry@potter.com"
                };
                db.Clientes.Add(cliente2);
                db.SaveChanges();

                Cliente cliente3 = new Cliente()
                {
                    Nome = "Thanos",
                    Email = "thanos@inevitavel.com"
                };
                db.Clientes.Add(cliente3);
                db.SaveChanges();

                cliente1.Pedidoes.Add(new Pedido
                {
                    Item = "Precioso",
                    Preco = 1000
                });

                cliente2.Pedidoes.Add(new Pedido
                {
                    Item = "Nimbus 2000",
                    Preco = 10000
                });

                cliente3.Pedidoes.Add(new Pedido
                {
                    Item = "Joias do Infinito",
                    Preco = 500000
                });

                db.SaveChanges();

                // LINQ = LANGUAGE INTERGRATED QUERY
                var query = from c in db.Clientes.Include("Pedidoes")
                            select c;

                foreach (var clientes in query)
                {
                    Console.WriteLine($"cliente: {clientes.Nome}");
                    Console.WriteLine("Pedidos:");
                    Console.WriteLine("=========");
                    foreach (var p in clientes.Pedidoes)
                    {
                        Console.WriteLine($"Item: {p.Item}, Preco: {p.Preco}");
                    }
                }

                Console.WriteLine("Precione qualquer tecla...");
                Console.ReadKey();
                // Felipe Rocha
            }
        }
    }
}
