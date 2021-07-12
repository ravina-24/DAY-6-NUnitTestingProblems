using System;

namespace UC_2_DayOfWeek
{
    class UC_2_DayofWeek
    {
        static void Main(string[] args)
        {
            int date;
            Console.Write("Enter the date :  ");
            date = int.Parse(Console.ReadLine());
            if ( date >= 1 || date < 31 )
            {
                Console.WriteLine("Days are between 1 to 31 ");
                

            }
            


            int month;
            Console.Write("Enter the Month:   ");
            month = int.Parse(Console.ReadLine());
            if (month >= 1 || month <= 12) 
            {
                Console.WriteLine("Months are between 1 to 12 ");

            }



            int year;
            Console.Write("Enter the Year : ");
            year = int.Parse(Console.ReadLine());


            int year1 = (year - (14 - month) / 12);
            int x = (year1 + year1 / 4 - year1 / 100 + year1 / 400);  //checking leap or not 
            int month1 = (month + 12 * ((14 - month) / 12) - 2);

            int date1 = ((date + x + 31 * month1 / 12) % 7);
            

            if (date1 == 0)
            { 
                Console.WriteLine("Sunday");

            }
            else if ( date1 == 1)
            {
                Console.WriteLine("Monday");

            }
            else if ( date1  == 2)
            {
                Console.WriteLine("Tuesday");
            }
            else if ( date1 ==  3)
            {
                Console.WriteLine("Wednesday");

            }
            else if ( date1 == 4)
            {
                Console.WriteLine("Thursday");
            }
            else if ( date1 == 5 )
            {
                Console.WriteLine("Friday");

            }
            else 
            {
                Console.WriteLine("Saturday");
            }
            Console.ReadLine();
        }
    }
}
