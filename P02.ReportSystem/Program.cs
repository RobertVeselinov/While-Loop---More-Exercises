using System;

namespace P02.ReportSystem
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int neededSum = int.Parse(Console.ReadLine());
            int pricePerObject;
            string input;
            int i = 0;
            double sum = 0;
            int paymentsCard = 0;
            int paymentsCash = 0;
            int sumCard = 0;
            int sumCash = 0;

            while ((input = Console.ReadLine()) != "End")
            {
                pricePerObject = int.Parse(input);
                i++;

                if (i % 2 ==0) 
                {
                    
                    if (pricePerObject < 10)
                    {
                        Console.WriteLine("Error in transaction!");
                    }
                    else
                    {
                        sumCard += pricePerObject;
                        paymentsCard++;
                        sum += pricePerObject;
                        Console.WriteLine("Product sold!");

                    }
                }
                else
                {
                    if (pricePerObject > 100)
                    {
                        Console.WriteLine("Error in transaction!");
                    }
                    else
                    {
                        sumCash += pricePerObject;
                        paymentsCash++;
                        sum += pricePerObject;
                        Console.WriteLine("Product sold!");
                    }
                }

                if (sum >= neededSum)
                {
                    break;
                }

            }
            if (sum >= neededSum)
            {
                Console.WriteLine($"Average CS: {(double)sumCash / paymentsCash:f2}");
                Console.WriteLine($"Average CC: {(double)sumCard / paymentsCard:f2}");
            }
            else if (input == "End")
            {
                Console.WriteLine("Failed to collect required money for charity.");
            }
        }
    }
}
