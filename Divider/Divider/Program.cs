using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Divider
{
    class DivideIt
    {
        static void Main(string[] args)
        {
            int i, j;
            string temp;
            Console.WriteLine("Enter the first integer");
            temp = Console.ReadLine();
            i = Convert.ToInt32(temp);
            Console.WriteLine("Enter the second integer");
            temp = Console.ReadLine();
            j = Convert.ToInt32(temp);
            try
            {
               int k = i / j;
               Console.WriteLine("The result fo the division: {0}", k);
            }
            catch(DivideByZeroException)
            {
                Console.WriteLine("Division of {0} by zero", i);
            }
        }
    }
}
