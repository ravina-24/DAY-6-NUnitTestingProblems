using System;

namespace UC_4_MonthlyPayment
{
    class UC_4_MonthlyPayment
    {
        static void Main(string[] args)
        {

            double P; //principal

            Console.Write("Enter the Principal :   ");
            P = double.Parse(Console.ReadLine());


            double Y;  // year 

            Console.Write("Enter the number of year :  ");
            Y = double.Parse(Console.ReadLine());

            double R; // rate 
            Console.Write("Enter the Rate: ");
            R = double.Parse(Console.ReadLine());

            double n = 12 * Y;
            double r = R / (12 * 100);

            double Monthlypayment = (P * r*Math.Pow(1+r, n)) /(Math.Pow(1 + r ,n)-1);

            Console.WriteLine("Monthly payments is   : " + Monthlypayment);
            Console.ReadLine();


        }
    }
}
