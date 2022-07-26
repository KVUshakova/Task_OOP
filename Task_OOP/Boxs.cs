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
        private double width;
        private double height;                             
        private double depth;
        private double weight;
        public  DateTime DateOfManufacture { get; set; }   //дата производства коробки
        public DateTime ExpirationDateBox { get; set; }       //срок годности коробки
        public double Volume
        {
            get { return width * height * depth; }
        }

        public void СalculationExpirationDateBox()            //вычисление срока годности коробки
        {
            ExpirationDateBox = DateOfManufacture.AddDays(100);
            //Console.WriteLine(ExpirationDate);
        }
    }

}
