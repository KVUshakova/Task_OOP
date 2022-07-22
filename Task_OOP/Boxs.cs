using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task_OOP
{
    public class Boxs
    {
        private Guid boxId;                                   //id коробки
        private double boxWidth;                              //ширина коробки
        private double boxHeight;                             //высота коробки
        private double boxDepth;                              //глубина коробки
        private double boxWeight;                             //вес коробки

        public  DateTime DateOfManufactureBox { get; set; }   //дата производства коробки
        public DateTime ExpirationDateBox { get; set; }       //срок годности коробки
        public double VolumeBox { get; set; }                 //объем коробки



        public void СalculationVolumeBox()                    //вычисление объема коробки
         {
             VolumeBox = boxWidth * boxHeight * boxDepth;
             //Console.WriteLine(VolumeBox);
             return;
         }
        public void СalculationExpirationDateBox()            //вычисление срока годности коробки
        {
            ExpirationDateBox = DateOfManufactureBox.AddDays(100);
            //Console.WriteLine(ExpirationDate);
            return;
        }
    }

}
