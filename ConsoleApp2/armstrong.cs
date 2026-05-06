//using System;
//using System.Collections.Generic;
//using System.Linq;
//using System.Text;
//using System.Threading.Tasks;

//namespace ConsoleApp2
//{
//    internal class armstrong
//    {
//        static void Main(string[] args)
//        {
//            Console.WriteLine("enter a number");
//            int num =Convert.ToInt32(Console.ReadLine());
//            int rem,temp,sum=0;
//            temp = num;
//            while(num>0)
//            {
//                rem=num%10;
//                sum=sum+(rem*rem*rem);
//                num=num/10;
//            }
//            if(temp==sum)
//            {
//                Console.WriteLine(temp+" is an Armstrong number");
//            }
//            else
//            {
//                Console.WriteLine(temp+" is not an Armstrong number");
//            }
//        }
//    }
//}
