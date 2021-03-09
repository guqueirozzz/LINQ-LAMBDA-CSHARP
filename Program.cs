using System;
using System.Collections.Generic;
using System.Linq;

namespace Linq_com_Lambda
{
    class Program
    {
        static void Print<T>(string message, IEnumerable<T> collection)
        {
            Console.WriteLine(message);
            foreach (T obj in collection)
            {
                Console.WriteLine(obj);
                Console.WriteLine();
            }
        }
        static void Main(string[] args)
        {
            Category c1 = new Category() { id = 1, name = "Tools", tier = 2 };
            Category c2 = new Category() { id = 2, name = "Computers", tier = 1 };
            Category c3 = new Category() { id = 3, name = "Electronics", tier = 1 };

            List<Product> products = new List<Product>()
            {
                new Product() {id = 1, name = "Computer", price = 1100.00, category = c2},
                new Product() {id = 2, name = "Hammer", price = 90.00, category = c1},
                new Product() {id = 3, name = "TV", price = 1700.00, category = c3},
                new Product() {id = 4, name = "Notebook", price = 1300.00, category = c2},
                new Product() {id = 5, name = "Saw", price = 80.00, category = c1},
                new Product() {id = 6, name = "Tablet", price = 700.00, category = c2},
                new Product() {id = 7, name = "Camera", price = 700.00, category = c3},
                new Product() {id = 8, name = "Printer", price = 350.00, category = c3},
                new Product() {id = 9, name = "Macbook", price = 3500.00, category = c2},
                new Product() {id = 10, name = "Sound bar", price = 700.00, category = c3},
                new Product() {id = 11, name = "Level", price = 70.00, category = c1}

        };
            var r1 = products.Where(x => x.category.tier == 1 && x.price < 900.00);

            Print("Tier 1 and price < 900.00", r1);


            var r2 = products.Where(x => x.category.name == "Tools").Select(x => x.name);
            Print("Names of Products TOOLS", r2);

            var r3 = products.Where(x => x.name[0] == 'C').Select(x => new { x.name, x.price, CategoryName = x.category.name });
            Print("Names started with 'C' and anonymous object ", r3);

            // ordenando por preço e então por nome
            var r4 = products.Where(x => x.category.tier == 1).OrderBy(x => x.price).ThenBy(x => x.name);
            Print("TIER 1 ORDER BY  PRICE THEN BY NAME", r4);

            // pula os dois primeros elementos e depois pega os 4 
            var r5 = r4.Skip(2).Take(4);
            Print("TIER 1 ORDER BY PRICE THEN BY NAME SKIP 2 TAKE 4", r5);

            // Pegando o primeiro produto da coleção.
            var r6 = products.First();
            Console.WriteLine("FIRST TEST 1" + r6);

            // vai dar erro, nao tenho nenhum produto com preço maior que 4k.
            // PAra contornar isso, usar o FirstOrDefault()
            var r7 = products.Where(x => x.price > 4000.00).FirstOrDefault();
            Console.WriteLine("First test 2 " + r7);

            // Single -> retorna apenas 1 elemento
            var r8 = products.Where(x => x.id == 3).SingleOrDefault();
            Console.WriteLine("SINGLE OR DEFAULT TEST1 " + r8);

            var r9 = products.Where(x => x.id == 30).SingleOrDefault();
            Console.WriteLine("SINGLE OR DEFAULT TEST1 " + r9);

            // ********************************************** AULA PARTE 2 ****************************************************



        }
    }
}
