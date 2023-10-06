using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Disaheim
{
    public class Amulet
    {
        public string ItemID { get; set; }
        public string Design { get; set; }
        public Level Quality { get; set; }

        public Amulet(string itemID, Level quality, string design)
        {
            ItemID = itemID;
            Design = design;
            Quality = quality;
        }

        public Amulet(string itemID, Level quality) : this(itemID, quality, "Ikke angivet")
        {

        }

        public Amulet(string itemID) : this(itemID, Level.low, "Ikke angivet")
        {

        }

        public override string ToString()
        {
            return base.ToString();
        }
    }
}
