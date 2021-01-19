using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Buchgeschäft
{
    public class Item //abstrakt
    {
        public decimal price; // { get; set; }

        public int stock; // { get; set; }
        public string Titel { get;}

        public Item(decimal price, int stock, string title)
        {
            this.price = price;
            this.stock = stock;
            this.Titel = title;
        }


        public bool TryPurchase(int number)
        {
            stock += number;
            return true;
        }
        public bool TrySell(int number)
        {
            if (number > stock)
            {
                return false;
            }
            else
            {
                stock -= number;
                return true;
            }
        }
       
        // Dies war nur für ein Test
       /* public override string ToString()
        {
            return $"{Titel} kostet {price}";
        }*/
    }
}
