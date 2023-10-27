using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Disaheim
{
    public class MerchandiseRepository
    {
        private List<Merchandise> merchandises = new();

        public void AddMerchandise(Merchandise merchandise)
        {
            merchandises.Add(merchandise);
        }

        public Merchandise GetMerchandise(string itemID)
        {
            return merchandises.Find(i => i.ItemID == itemID);
        }

        public double GetTotalValue(string? type = null)
        {
            Utility utility = new();
            double total = 0.00;
            if (type == null)
            {
                foreach (Merchandise merchandise in merchandises)
                {
                    total += utility.GetValueOfMerchandise(merchandise);
                }
            }
            else
            {
                foreach (Merchandise merchandise in merchandises)
                {
                    if (type == "Amulet")
                    {
                        if (merchandise is Amulet)
                        {
                            total += utility.GetValueOfMerchandise(merchandise);
                        }
                    }
                    else if (type == "Book")
                    {
                        if (merchandise is Book)
                        {
                            total += utility.GetValueOfMerchandise(merchandise);
                        }
                    }
                }
            }

            return total;
        }
    }
}
