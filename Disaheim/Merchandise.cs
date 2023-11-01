using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Disaheim
{
    public abstract class Merchandise : IValuable
    {

        public string ItemID { get; set; }

        //public Merchandise(string itemID)
        //{
        //    ItemID = itemID;
        //}

        public override string ToString()
        {
            return $"ItemId: {ItemID}";
        }

        public abstract double GetValue();
    }
}
