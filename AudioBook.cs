using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Buchgeschäft
{
    sealed class AudioBook : Book
    {
        private int duration;
        public AudioBook(decimal price, int stock, string title, string author, string isbn, int duration,Category category) :base(price, stock, title,author,isbn,category)
        {
            this.duration = duration;
        }
        public override string ToString()
        {
           // return $"AudioBook: {Titel} ({author}, {duration} minutes, {category} ({(int)category})), ISBN:{isbn}";
            return $"{GetType().Name}: {Titel} ({author}, {duration} minutes, {category} ({(int)category}))";
        }
    }
}
