using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SingletoneDesignPattern
{
    class Counter
    {
        private int counter = 0;
        private static Counter oCounter = null;

        public Counter()
        {

        }

        public static Counter GetInstance()
        {
            if (oCounter == null)
            {
                oCounter = new Counter();
                oCounter.counter = oCounter.counter + 1;
                return oCounter;
            }
            return oCounter;
        }

        public void Increment()
        {
            counter++;
        }

        public void Decrement()
        {
            counter--;
        }
        public void DisplayValue()
        {
            Console.WriteLine("Visitor Number :"+ counter);
        }
    }
}
