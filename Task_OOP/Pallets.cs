using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task_OOP
{
    public class Pallet : Box
    { 
    //{
    //    private Guid id;                                   
    //    private double width;                             
    //    private double height;                            
    //    private double depth;                             
    //    private double weight;                                   
        public DateTime ExpirationDatePallet
        {
            get { return boxes.Min(a => a.ExpirationDateBox); }
            
        }
        public List<Box> boxes { get; set; }


    }
}
