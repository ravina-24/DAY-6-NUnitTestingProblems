using System;

namespace DAY_6_NunitTesting
{
    class UC_3_temperatureConversion
    {
        static void Main(string[] args)
        {
            int Temp;
            Console.Write("Enter the Temperature :   ");
            Temp = int.Parse(Console.ReadLine());

            int Options;
            Console.Write("Choose the option 0 or 1 :  ");  // 0 for celcius t0 farenhiet and 1 for farenhiet to celcius 
            Options = int.Parse(Console.ReadLine());

            if (Options == 0)
            {
                int celciusToFarenhiet = ((Temp * 9 / 5) + 32);
                Console.WriteLine("Temperature in celcius to Farenhiet is :" + celciusToFarenhiet + "F");

            }
            else
            {
                int FarenhietToCelcius = ((Temp - 32) * 5 / 9);
                Console.WriteLine("Temperature in celcius to Farenhiet is :" + FarenhietToCelcius + "C");

            }
            Console.ReadLine();
        }
    }
}
            