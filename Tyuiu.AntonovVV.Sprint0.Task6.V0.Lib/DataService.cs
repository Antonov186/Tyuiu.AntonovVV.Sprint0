﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Remoting.Messaging;
using System.Text;
using System.Threading.Tasks;

namespace Tyuiu.AntonovVV.Sprint0.Task6.V0.Lib
{
    public class DataService
    {
        //Пример циклической структуры (цикл с параметрами) for
        public static object AdditionArray(int[] numbers)
        {
            var total = 0;
            for (var i = 0; i < numbers.Length; i++)
            {

                total += numbers[i];

            }
        
            return total;


        }

        //Пример циклической структуры (цикл с предусловием) while
        public static object SubtractionArray(int[] numbers)
        {
            var total = 0;
            int index = 0;

            while (index < numbers.Length)
            {
                total += numbers[index];
                index++;
            }

            return total;


        }

        //Пример циклической структуры (с постусловием) do while
        public static object MultiplicationArray(int[] numbers)
        {
            var total = 1;
            int index = 0;
            do
            {
                total =  total * numbers[index];
                index++;
            }

            while (index < numbers.Length);

            return total;
        }
            
    }
}
