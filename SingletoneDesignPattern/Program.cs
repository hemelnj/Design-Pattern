using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SingletoneDesignPattern
{
    class Program
    {
        static void Main(string[] args)
        {

            var oCounter1 = Counter.GetInstance();
            oCounter1.DisplayValue();
            oCounter1.Increment();
            oCounter1.Increment();
            oCounter1.DisplayValue();

            Console.WriteLine("Object No Two Creation");
            var oCounter2 = Counter.GetInstance();
            oCounter1.DisplayValue();
            oCounter2.Decrement();
            oCounter2.DisplayValue();
            Console.ReadLine();

        }
    }
}
