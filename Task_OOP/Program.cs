using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task_OOP
{
     class Program 
    {
        static void Main(string[] args)
        {
            Box box = new();
            box.DateOfManufacture = new DateTime(2022, 01, 01);
            box.СalculationExpirationDateBox();

            Pallet pallet = new();
            Console.WriteLine(pallet.ExpirationDatePallet);


        }
    }
}