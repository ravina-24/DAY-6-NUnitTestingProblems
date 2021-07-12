using System;

namespace UC_6_ToBinaryCoversion
{
    class UC_6_toBinary
    {
        static void Main(string[] args)
        {
            int Num;
            Console.Write("Enter the Decimal Number : ");
            Num = int.Parse(Console.ReadLine());

            int[] BinaryArray = new int[32];

            int i = 0;
            while (Num>0)
            {
                BinaryArray[i] = Num % 2;
                Num = Num / 2;
                i++;


            }
            int j = 0;
            for (j = i - 1; j >= 0; j--)
            {
                Console.WriteLine("Binary Conversion :" + BinaryArray[j]);
            }

            Console.ReadLine();




             }
           
        }
      
    }

