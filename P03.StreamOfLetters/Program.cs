using System;

namespace P03.StreamOfLetters
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string input;
            char symbol;
            string sum = string.Empty;
            int cCounter = 0;
            int oCounter = 0;
            int nCounter = 0;
            string newWord = string.Empty;

            while ((input = Console.ReadLine()) != "End")
            {
                symbol = char.Parse(input);

                if (symbol >= 65 && symbol <= 90 || symbol >= 97 && symbol <= 122)
                {
                    if (symbol == 99)
                    {
                        if (cCounter == 0)
                        {
                            cCounter++;
                        }
                        else
                        {
                            sum += symbol;
                        }
                    }
                    else if (symbol == 111)
                    {
                        if (oCounter == 0)
                        {
                            oCounter++;
                        }
                        else
                        {
                            sum += symbol;
                        }
                    }
                    else if (symbol == 110)
                    {
                        if (nCounter == 0)
                        {
                            nCounter++;
                        }
                        else
                        {
                            sum += symbol;
                        }
                    }

                    if (cCounter == 1 && oCounter == 1 && nCounter == 1)
                    {
                        sum+=" ";
                        newWord = sum;
                        oCounter = 0;
                        cCounter = 0;
                        nCounter = 0;
                    }

                    if (symbol != 99 && symbol != 111 && symbol !=110)
                    {
                        sum += symbol;
                    }

                }

            }
            Console.WriteLine(newWord);
        }
    }
}