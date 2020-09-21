using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Reflection;

namespace Les8Exercise1
{
    //Ронжин Л.
    //1. С помощью рефлексии выведите все свойства структуры DateTime
    class Program
    {
        static void Main(string[] args)
        {
            DateTime dateTime = new DateTime();
            var properties = dateTime.GetType().GetProperties();
            Console.WriteLine("Свойства структуры DateTime:");
            int i = 0;
            foreach (var item in properties)
            {
                Console.WriteLine($"{++i}. {item.Name}");
            }
            Console.ReadKey();
        }
    }
}
