using System;

namespace UC_1_VendingMahine
{
    class UC_1_VendingMachine
    {
        static void Main(string[] args)
        {
            Console.WriteLine("......Welcome to Vending Machine Application.......");

            int Rupees;
            Console.Write("Enter the rupees  :   ");
            Rupees = int.Parse(Console.ReadLine());


            int i = 0;


            int[] Notes = { 1000, 500, 100, 50, 10, 5, 2, 1 };

            int[] TotalNotes = new int [] { 1000, 500, 100, 50, 10, 5, 2, 1 };

            for (i = 0; i < 8; i++)
            {
                if (Rupees >=Notes[i])
                {
                    Notes[i] = Rupees / Notes[i];
                    Rupees = Rupees - TotalNotes[i] * Notes[i];

                    Console.WriteLine("Total  notes should be return    :" + Notes[i] + ":" + TotalNotes[i]);

               
                   
                }
              

            }


            Console.ReadLine();

        }
    }
}
