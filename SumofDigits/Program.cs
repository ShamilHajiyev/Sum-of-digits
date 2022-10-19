using System;

namespace SumofDigits
{
    class Program
    {
        static void Main(string[] args)
        {
            //Task: Verilmiş tam müsbət n ədədinin rəqəmlərinin cəmini tapan alqoritm

            Console.WriteLine("Enter a number:");
            int n = Convert.ToInt32(Console.ReadLine());
            int sum = 0;
            while (n != 0)
            {
                sum += n % 10;
                n /= 10;
            }
            Console.WriteLine("\nSum of digits:\n" + sum);
        }
    }
}
