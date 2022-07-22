using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task_OOP
{
    public class Pallets : Boxs
    {
        private Guid palletId;                                   //id паллеты
        private double palletWidth;                              //ширина паллеты
        private double palletHeight;                             //высота паллеты
        private double palletDepth;                              //глубина паллеты
        private double palletWeight;                             //вес паллеты

        private DateTime expirationDatePallets;
        
        public DateTime ExpirationDatePallets
        {
            get { return /*дописать*/ }
        }

        public double VolumePallet { get; set; }

        public void СalculationVolumePallet()                    //вычисление объема коробки
        {
            VolumePallet = VolumeBox.
            //Console.WriteLine(VolumeBox);
            return;
        }



    }
}
