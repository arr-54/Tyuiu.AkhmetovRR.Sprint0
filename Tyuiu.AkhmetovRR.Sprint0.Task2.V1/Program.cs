using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

//Подключение пространство имен из библиотеки классов
using Tyuiu.AkhmetovRR.Sprint0.Task2.V1.Lib;

namespace Tyuiu.AkhmetovRR.Sprint0.Task2.V1
{
    class Program
    {
        static void Main(string[] args)
        {
            //Вызов класса DataService и метода GetMessage
            //из библиотеки Tyuiu.AkhmetovRR.Sprint0.Task2.V1.Lib 
            Console.WriteLine(DataService.GetMessage("Роман"));
            Console.ReadKey();
        }
    }
}
