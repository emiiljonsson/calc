// See https://aka.ms/new-console-template for more information


using System;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Welcome to the calculator!");

        while (true)
        {
            Console.WriteLine("Please choose an option below");
            Console.WriteLine("1. +");
            Console.WriteLine("2. -");
            Console.WriteLine("3. *");
            Console.WriteLine("4. /");
            Console.WriteLine("0. Exit");

            Console.Write("Write your option: ");
            int option = int.Parse(Console.ReadLine());

            if (option == 0)
            {
                Console.WriteLine("Thanks for using this calculator, Bye! ");
                break;

            }

            Console.Write("Write the first number: ");
            double num1 = double.Parse(Console.ReadLine());

            Console.Write("Write the second number: ");
            double num2 = double.Parse(Console.ReadLine());

            double result = 0;

            switch (option)
            {

                case 1:
                    result = num1 + num2;
                    break;

                case 2:
                    result = num1 - num2;
                    break;

                case 3:
                    result = num1 * num2;
                    break;

                case 4:
                    if (num2 != 0)
                    {
                        result = num1 / num2;
                    }

                    else
                    {
                        Console.WriteLine("Error: Number can not be divided by 0 (zero)");
                        continue;
                    }

                    break;
                default:
                    Console.WriteLine("Error: Unavailable choice. Try again!");
                    continue;
            }

            Console.WriteLine("Reslut: " + result);

        }
    }
}