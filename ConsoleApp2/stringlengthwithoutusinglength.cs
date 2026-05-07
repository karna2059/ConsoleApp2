using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp2
{
    internal class stringlengthwithoutusinglength
    {
        static void Main(string[] args)
        {
            Console.Write("Enter a string: ");
            string str = Console.ReadLine();
            int count = 0;
            foreach (char c in str)
            {
                count++;
            }
            Console.WriteLine("Length of the string: " + count);
        }
    }
}
