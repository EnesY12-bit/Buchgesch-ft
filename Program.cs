﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using BookstoreLibrary;

namespace Buchgeschäft
{
   class Program
    {
        static void Main(string[] args)
        {


            // Test, ob Git funktioniert
            List<Item> daten = new List<Item>();

            Book b = new Book(25.00m, 5, "The Malta Exchange", "Steve Berry","", Category.Thriller);
            Console.WriteLine(b.ToString());
            daten.Add(b);

            Newspaper n = new Newspaper(2.99m, 10, "Der Standard",DateTime.Now);
            Console.WriteLine(n.ToString());
            daten.Add(n);

            AudioBook ab = new AudioBook(3.99m, 10, "Alea Aquarius 6: Der Fluss des Vergessens", "Tanya Stewner", "", 536, Category.Fantasy);
            Console.WriteLine(ab.ToString());
            daten.Add(ab);

            Console.WriteLine($"3+3={BookstoreLibary.Bookstore.Add(3, 3)}");

            Console.ReadKey();

        }
    }
}
