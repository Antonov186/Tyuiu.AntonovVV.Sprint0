using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Tyuiu.AntonovVV.Sprint0.Task2.V0.Lib;

namespace Tyuiu.AntonovVV.Sprint0.Task2.V0
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Вызов класса из DataService и метода GetMessage
            //из библиотеки Tyuiu.AntonovVV.Sprint0.Task2.V0.Lib
            Console.WriteLine(DataService.GetMessage("Василий"));
            Console.ReadKey();
        }
    }
}
