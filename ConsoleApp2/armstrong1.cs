//using System;
//using System.Collections.Generic;
//using System.Linq;
//using System.Text;
//using System.Threading.Tasks;

//namespace ConsoleApp2
//{
//    internal class armstrong1
//    {
//        static void Main(string[] args)
//        {
//            int rem, temp, sum = 0;
//            Console.WriteLine("enter anumber");
//            int num = Convert.ToInt32(Console.ReadLine());
//            temp = num;
//            while (num > 0)
//            {
//                rem = num % 10;
//                sum=(sum)+(rem*rem*rem);
//                num = num / 10;
//            }
//            if (temp == sum)
//            {
//                Console.WriteLine("the number is an Armstrong number");
//            }
//            else
//            {
//                Console.WriteLine("the number is not an Armstrong number");
//            }
//        }
//    }
//}
