using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Buchgeschäft
{
   internal class Book : Item 
    {
        protected string author; // { get; set; }
        private string isbn; //{ get; set; }
        public Category category;

        public Book(decimal price, int stock, string title, string author, string isbn, Category catecory) : base(price,stock,title)
        {
            this.author = author;
            this.isbn = isbn;
            this.category = catecory;
        }

        public override string ToString()
        {
           // return $"Book: {Titel} ({author} {c} ({e}))";
            return $"{GetType().Name}: {Titel} ({author}, {category} ({(int)category})";
        }
    }
    public enum Category
    {
        History = 10,
        Thriller = 20,
        Fantasy = 30,
        Food = 40,
        Children = 50
    }
}
