//using System;
//using System.Collections.Generic;
//using System.Linq;
//using System.Text;
//using System.Threading.Tasks;

//namespace ConsoleApp2
//{
//    internal class Program
//    {
//        static void Main(string[] args)
//        {
//            Console.WriteLine("enter a number");
//            sbyte a = sbyte.Parse(Console.ReadLine());
//            switch (a > 0)
//            {
//                case true:
//                    Console.WriteLine("outer switch block is executed");
//                    Console.WriteLine(a + "is a positive number ");

//                    switch (a % 2 == 0)
//                    {
//                        case true:
//                            Console.WriteLine("inner switch block is executed");
//                            Console.WriteLine(a + "is a even number");
//                            break;
//                        case false:
//                            Console.WriteLine("inner switch block is executed");
//                            Console.WriteLine(a + "is a odd number");
//                            break;
//                    }
//                    break;
//                case false:
//                    Console.WriteLine("outer switch biock is executed");
//                    Console.WriteLine(a + "is a negative number");

//                    switch (a % 2 == 0)
//                    {
//                        case true:
//                            Console.WriteLine("inner block is executed");
//                            Console.WriteLine(a + "is a even number");
//                            break;
//                        case false:
//                            Console.WriteLine("ineer block is executed");
//                            Console.WriteLine(a + "is a odd number");
//                            switch (a % 2 == 0)
//                            {
//                                case true:
//                                    Console.WriteLine("inner block is executed");
//                                    Console.WriteLine(a + "is a even number");
//                                    break;
//                                case false:
//                                    Console.WriteLine("inner block is executed");
//                                    Console.WriteLine(a + "is a odd number");
//                                    break;

//                            }
//                            break;
//                    }
//                    break;

//            }

//        }
//    }
//}

























