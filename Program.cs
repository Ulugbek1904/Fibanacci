using System;

namespace Fibanacci
{
    public class Program
    {
        public static void Main(string[] args)
        {
            System.Console.Write("Enter end point of fibanacci :");
            int fibanacciEnd = int.Parse(Console.ReadLine());

            int fibanacci1 = 0;
            int fibanacci2 = 1;

            while (fibanacci1 < fibanacciEnd)
            {
                System.Console.Write(fibanacci1 + " ");
                int nextFibanacci = fibanacci1 + fibanacci2;
                fibanacci1 = fibanacci2;
                fibanacci2 = nextFibanacci;
            }



        }
    }

}