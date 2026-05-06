//using System;
//using System.Collections.Generic;
//using System.Linq;
//using System.Text;
//using System.Threading.Tasks;

//namespace ConsoleApp2
//{
//    internal class palindrome
//    {
//        static void  Main(string[] args)
//        {
//            int rem, sum = 0, temp;
//            Console.WriteLine("Enter a number: ");
//            int num = int.Parse(Console.ReadLine());
//            temp = num;
//            while (num > 0)
//            {
//                rem = num % 10;
//                sum = (sum * 10) + rem;
//                num = num / 10;
//            }
//            if (temp == sum)
//            {
//                Console.WriteLine(temp + " is a palindrome");
//            }
//            else
//            {
//                Console.WriteLine(temp + " is not a palindrome");
//            }
//        }
//    }
//}
