using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Buchgeschäft
{
    class Program
    {
        static void Main(string[] args)
        {
            // Test, ob Git funktioniert
            Book b = new Book(25.00m, 5, "The Malta Exchange", "Steve Berry", "78279180012",Category.Thriller);
            Console.WriteLine(b.ToString());

            Newspaper n = new Newspaper(2.99m, 10, "Der Standard",DateTime.Now);
            Console.WriteLine(n.ToString());

            AudioBook ab = new AudioBook(3.99m, 10, "Alea Aquarius 6: Der Fluss des Vergessens", "Tanya Stewner", "1288230239", 536, Category.Fantasy);
            Console.WriteLine(ab.ToString());



            Console.ReadKey();

        }
    }
}
