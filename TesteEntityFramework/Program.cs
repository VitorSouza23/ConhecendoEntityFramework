using System;
using System.Collections.Generic;
using System.Linq;
using static System.Console;
namespace TesteEntityFramework
{
    class Program
    {
        static void Main(string[] args)
        {
            using (DataBaseContext context = new DataBaseContext())
            {
                //Adicionando um "Customer"
                context.Customers.Add(new Customer { Name = "Teste", Phone = "123", CPF = "987" });
                
                //Adicionando um "Product"
                context.Products.Add(new Product { Name = "Product", Description = "A new Product" });

                context.SaveChanges();

                string query = context.Customers.Where(c => c.Name == "Teste").ToString();
                WriteLine($"Conversão de uma query para string: {query}");

                Product product = context.Products.Where(p => p.Name == "Product").FirstOrDefault();

                WriteLine($"Produto: {product.Name} - Descrição: {product.Description}");
            }
        }
    }
}
