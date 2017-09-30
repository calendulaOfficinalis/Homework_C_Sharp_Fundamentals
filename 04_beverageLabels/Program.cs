using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _04_beverageLabels
{
    class Program
    {
        static void Main(string[] args)
        {
            string beverageName = Console.ReadLine();
            int volume = int.Parse(Console.ReadLine());
            double energy100 = double.Parse(Console.ReadLine());
            double sugar100 = double.Parse(Console.ReadLine());

            var energy = volume * energy100 / 100;
            var sugar = volume * sugar100 / 100;

            Console.WriteLine($"{volume}ml {beverageName}:");
            Console.WriteLine($"{energy}kcal, {sugar}g sugars");


    
        }
    }
}
