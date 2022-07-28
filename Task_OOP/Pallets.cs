using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task_OOP
{
    public class Pallet : Box
    {                                    
        public DateTime ExpirationDatePallet
        {
            get { return Boxes.Min(e => e.ExpirationDateBox); }
            
        }

        public double Weight
        {
            get { return Boxes.Sum(w => w.Weight) + 30; ; }
        }

        public List<Box> Boxes { get; set; }

        public double Volume => (Width * Height * Depth) + Boxes.Sum(v => v.Volume);




    }
}
