//using System;
//using System.Collections.Generic;
//using System.Linq;
//using System.Text;
//using System.Threading.Tasks;

//namespace ConsoleApp2
//{
//    internal class leftpyramid
//    {
//        static void Main(string[] args)
//        {
//            Console.WriteLine("enter a number");
//            int rows = Convert.ToInt32(Console.ReadLine());
//            for (int i = 1; i <= rows; i++)
//            {
//                for (int j = 1; j <= rows - i; j++)
//                {
//                    Console.Write(" ");
//                }
//                for (int k = 1; k <= i; k++)
//                {
//                    if(i==1||i==rows||k==1||k==i)
//                    {
//                         Console.Write("*");
//                    }
//                    else
//                    {
//                        Console.Write(" ");
//                    }
                   
//                }
//                Console.WriteLine();
//            }
//        }
//    }
//}
