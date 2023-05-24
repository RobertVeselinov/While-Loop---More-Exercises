using System;

namespace P01.Dishwasher
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int cleaner = int.Parse(Console.ReadLine()) * 750;
            string input;
            int quantityDishes;
            int i = 1;
            int cleanDishes = 0;
            int cleanPots = 0;
            int fullCleaner = cleaner;



            while ((input = Console.ReadLine()) != "End")
            {
                quantityDishes = int.Parse(input);

                if (i % 3 == 0)
                {
                    cleaner -= quantityDishes * 15;
                    cleanPots+=quantityDishes;
                }
                else
                {
                    cleaner -= quantityDishes * 5;
                    cleanDishes+=quantityDishes;
                }
                if (cleaner < 0)
                {
                    break;
                }
                i++;
            }
            if (cleaner >= 0)
            {
                Console.WriteLine("Detergent was enough!");
                Console.WriteLine($"{cleanDishes} dishes and {cleanPots} pots were washed.");
                Console.WriteLine($"Leftover detergent {cleaner} ml.");
            }
            else
            {
                Console.WriteLine($"Not enough detergent, {Math.Abs(cleaner)} ml. more necessary!");
            }
        }
    }
}
