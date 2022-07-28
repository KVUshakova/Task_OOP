using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task_OOP
{
    public class Box
    {
        private Guid id;
        public double Width { get; set; }
        public double Height { get; set; }
        public double Depth { get; set; }
        public double Weight { get; set; }
        public DateTime DateOfManufacture { get; set; }
        public DateTime ExpirationDateBox
        {
            get { return DateOfManufacture.AddDays(100); }
        }
        public double Volume
        {
            get { return Width * Height * Depth; }
        }
    }

}
