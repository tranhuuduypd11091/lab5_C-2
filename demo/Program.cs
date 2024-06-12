using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace demo
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[] numbers = { 1, 2, 4, 6, 9, 10, 12 };
            int product = numbers.Where(x => x % 2 ==0 ).Aggregate(1,(acc, x)=>acc * x);
             
            Console.WriteLine(" tich cac so chia het cho 2 trong mang la "+ product);
        }
    }
}
