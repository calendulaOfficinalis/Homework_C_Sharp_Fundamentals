using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _01_DebitCardNum
{
    class Program
    {
        static void Main(string[] args)

        {
            int firstNum = int.Parse(Console.ReadLine());
            int secondNum = int.Parse(Console.ReadLine());
            int thirdNum = int.Parse(Console.ReadLine());
            int forthNum = int.Parse(Console.ReadLine());

            Console.Write("{0:D4} {1:D4} {2:D4} {3:D4}",firstNum,secondNum,thirdNum,forthNum);

        }
    }
}
