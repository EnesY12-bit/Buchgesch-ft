using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Buchgeschäft
{
    public class Newspaper : Item //sealed
    {
        private DateTime dateOfIssue; //{ get; set; }

        public Newspaper(decimal price, int stock, string title, DateTime dateOfIssue) :base(price,stock,title)
        {
            this.dateOfIssue = dateOfIssue;
        }
        public override string ToString()
        {

            //return $"Newspaper:{Titel} ({dateOfIssue})";
            return $"{GetType().Name}: {Titel} ({dateOfIssue})";
        }
    }
}
