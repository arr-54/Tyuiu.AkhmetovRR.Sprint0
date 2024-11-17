using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
namespace Tyuiu.AkhmetovRR.Sprint0.Task1.V1
{
    class Program
    {
        static void Main(string[] args)
        {
            //Вывод на консоль строку Hello, World!
            Console.WriteLine("Hello, World!");

            //Объявляем переменные
            string name = "Роман";
            int age = 22;

            //Вывод на консоль строку 
            Console.WriteLine("Здравствуйте меня зовут " + name + " мне " + age + " лет.");

            //Ожидание нажатия клавиши, нужно чтобы окно консоли не закрывалось
            Console.ReadKey();
        }
    }
}
