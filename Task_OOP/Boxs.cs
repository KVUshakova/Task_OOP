using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task_OOP
{
    public class Boxs
    {
        private Guid idBox;                                 //id паллеты
        private double widthBox;                            //ширина паллеты
        private double heightBox;                           //высота паллеты
        private double depthBox;                            //глубина паллеты
        private double weightBox;                           //вес паллеты

        public static DateTime DateOfManufacture { get; set; }   //дата производства
        public static DateTime ExpirationDate { get; set; }      //срок годности


        public static void СalculationExpirationDate()           //вычисление срока годности
        {
            ExpirationDate = DateOfManufacture.AddDays(100);
            //Console.WriteLine(ExpirationDate);
            return;
        }
    }

}
