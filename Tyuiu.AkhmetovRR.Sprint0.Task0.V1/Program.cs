using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tyuiu.AkhmetovRR.Sprint0.Task0.V1
{
    class Program
    {
        static void Main(string[] args)
        {
            if (args is null)
            {
                throw new ArgumentNullException(nameof(args));
            }
            // Область вызова классов и методов главной программы
            Console.ReadKey();
        }
    }
}
