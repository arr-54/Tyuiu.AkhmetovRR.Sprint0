﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tyuiu.AkhmetovRR.Sprint0.Task7.V1.Lib
{
    public class DataService
    {
        //Пример циклической структыры (цикл с параметрами) for
        public static int[] AdditionArrays(int[] numOne, int[] numTwo)
        {
            int[] resultArray = new int[5];
            for (var i = 0; i < resultArray.Length; i++)
            {
                resultArray[i] = numOne[i] + numTwo[i];
            }
            return resultArray;
        }
    }
}
