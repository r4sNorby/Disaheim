using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Disaheim
{
    public class Book : Merchandise
    {
        public string Title { get; set; }
        public double Price { get; set; }

        public Book(string itemID, string title, double price)
        {
            ItemID = itemID;
            Title = title;
            Price = price;
        }

        public Book(string itemID, string title) : this(itemID, title, 0)
        {

        }

        public Book(string itemID) : this(itemID, "", 0)
        {

        }

        public override string ToString()
        {
            return $"ItemId: {ItemID}, Title: {Title}, Price: {Price}";
        }

        public override double GetValue()
        { 
            return Price; 
        }
    }
}
