﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tyuiu.AkhmetovRR.Sprint0.Task5.V1.Lib
{
    public class DataService
    {
        public static int Addition(int a, int b)
        {
            return a + b;
        }

        //Пример линейной структуры
        public static int Subtraction(int a, int b)
        {
            return a - b;
        }

        //Пример линейной структуры
        public static int Multiplication(int a, int b)
        {
            return a * b;
        }

        //Пример разветвляющейся структуры 
        public static double Division(int a, int b)
        {
            if (b == 0)
            {
                // Пример создан в целях демонстрации ветвления
                // В реальных проектах нужно использовать Exception
                Console.WriteLine("Переменная b = {0} на ноль делить нельзя", b);
                return -1;
            }
            else
            {
                return a / b;
            }
        }
    }
}
