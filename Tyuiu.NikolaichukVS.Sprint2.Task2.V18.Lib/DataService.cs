﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using tyuiu.cources.programming.interfaces.Sprint2;

namespace Tyuiu.NikolaichukVS.Sprint2.Task2.V18.Lib
{
    public class DataService : ISprint2Task2V18
    {
        public bool CheckDotInShadedArea(int x, int y)
        {
            bool res;

            if ((x >= 3) && (x <= 5) && (y >= 3) && (y <= 5) && (x >= 2) && (x <= 5) && (y >= 6) && (y <= 7) && (x >= 6) && (x <= 8) && (y >= 5) && (x <= 9) && (x >= 6) && (x <= 7) && (y >= 10) && (y <= 11) && (x >= 3) && (x <= 5) && (y == 11) && (x == 7) && (y == 12) && (x >= 9) && (x <= 12) && (y >= 8) && (y <= 9) && (x >= 11) && (x <= 12) && (y >= 10) && (y <= 11) && (x ==13) && (y == 9) && (x >= 12) && (x <= 13) && (y >= 6) && (y <= 7) && (x ==12) && (y >= 3) && (y <= 5))
            {
                res = true;
            }
            else
            {
                res = false;
            }

            return res;
        }
    }
}
