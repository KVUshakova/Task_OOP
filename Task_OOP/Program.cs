﻿using System;
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
            Boxs boxs = new();
            boxs.DateOfManufactureBox = new DateTime(2022, 01, 01);
            boxs.СalculationExpirationDateBox();
            boxs.СalculationVolumeBox();

        }
    }
}