using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Disaheim
{
    public class Amulet : Merchandise
    {
        public static double LowQualityValue = 12.5;
        public static double MediumQualityValue = 20.0;
        public static double HighQualityValue = 27.5;

        public string Design { get; set; }
        public Level Quality { get; set; }

        public Amulet(string itemID, Level quality, string design)
        {
            ItemID = itemID;
            Design = design;
            Quality = quality;
        }

        public Amulet(string itemID, Level quality) : this(itemID, quality, "")
        {

        }

        public Amulet(string itemID) : this(itemID, Level.medium, "")
        {

        }

        public override string ToString()
        {
            return $"ItemId: {ItemID}, Quality: {Quality}, Design: {Design}";
        }

        public override double GetValue()
        {
            return Quality switch
            {
                Level.low => LowQualityValue,
                Level.medium => MediumQualityValue,
                Level.high => HighQualityValue,
                _ => 0
            };
        }
    }
}
