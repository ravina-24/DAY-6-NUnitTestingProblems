using System;

namespace UC_5_SqrtOfNewtons_sMethod
{
    class Program
    {
        static void Main(string[] args)
        {

            Console.Write("Enter the value of c  :   ");
            double c = double.Parse(Console.ReadLine());




            double t;
           
          
            t = c;

            double epsilon = 1e-15;

            while (Math.Abs(t - c / t) > epsilon * t)
            { 

                    t = (c / t + t)/2.0 ;
            }

            Console.WriteLine("The  value of t is : " + t);

            Console.ReadLine();
        }
    }
}
