﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;

namespace EnumExample
{
    class Program
    {
        static void Main(string[] args)
        {            
            Console.WriteLine("Sun = {0}", (int)DaysEnum.Sun);
            Console.WriteLine("Mon = {0}", (int)DaysEnum.Mon);
            Console.WriteLine("Tue = {0}", (int)DaysEnum.Tue);
            Console.WriteLine("Wed = {0}", (int)DaysEnum.Wed);
            Console.WriteLine("Thu = {0}", (int)DaysEnum.Thu);
            Console.WriteLine("Fri = {0}", (int)DaysEnum.Fri);
            Console.WriteLine("Sat = {0}", (int)DaysEnum.Sat);
            Console.ReadKey();



            IEnumerable<DaysEnum> list = new List<DaysEnum>() { DaysEnum.Mon, DaysEnum.Tue, DaysEnum.Wed, DaysEnum.Thu, DaysEnum.Fri };


            Console.WriteLine("\n\nWorking days:");
            foreach (DaysEnum day in list)
            {
                Console.WriteLine(Enum.GetName(typeof(DaysEnum), day));
            }
            Console.ReadKey();


            // ... is equivalent with: 
            Console.WriteLine("\n\nWorking days:");
            using (var enumerator = list.GetEnumerator())
            {
                while (enumerator.MoveNext())
                {
                    DaysEnum day = enumerator.Current;
                    Console.WriteLine(Enum.GetName(typeof(DaysEnum), day));
                }
            }
            Console.ReadKey();


            // How to get description attribute:
            Console.WriteLine("\n\nWorking days - enum description:");
            foreach (DaysEnum day in list)
            {
                var dayDescription = EnumHelper.EnumTypeDescription(day);
                Console.WriteLine(dayDescription);
            }
            Console.ReadKey();


            Console.WriteLine("\n\nFirst twenty numbers in Fibonacci series:");
            var helper = new EnumHelper();
            var fibonacci = helper.Fibonacci();
            var firstFibonacci = helper.FirstTwenty(fibonacci);
            foreach (var n in firstFibonacci)
            {
                Console.WriteLine(n);
            }
            Console.ReadKey();


        }

        
    }
}
