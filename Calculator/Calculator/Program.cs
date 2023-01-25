
using System;
using System.Runtime.InteropServices;

namespace Calculator
{
    class Program
    {
        static void Main(string[] args)
        {
            bool quit = false;
            while (!quit)
            {
                printMenu();
                string opt = Console.ReadLine();
                if (!opt.Equals("1") && !opt.Equals("2") && !opt.Equals("3") && !opt.Equals("4") && !opt.Equals("x"))
                {
                    Console.WriteLine("Please choose 1 to 4. Press any key to continue...");
                    Console.ReadKey();
                }
                if (opt == "x" || opt == "X")
                {
                    quit = true;
                }
                if (opt == "1" || opt == "2" || opt == "3" || opt == "4")
                {
                    int opt2 = int.Parse(opt);
                    int a, b;
                    Console.Write("Input first number: ");
                    a = int.Parse(Console.ReadLine());
                    Console.Write("Input second number: ");
                    b = int.Parse(Console.ReadLine());
                    SimpleCalculator MyCal = new SimpleCalculator();
                    Console.Write("The result is ");
                    if (opt2 == 1)
                    {
                        Console.WriteLine(MyCal.Add(a, b).ToString());
                    }
                    if (opt2 == 2)
                    {
                        Console.WriteLine(MyCal.Substract(a, b).ToString());
                    }
                    if (opt2 == 3)
                    {
                        Console.WriteLine(MyCal.Multiply(a, b).ToString());
                    }
                    if (opt2 == 4)
                    {
                        float c = MyCal.Divide(a, b);

                        if (c != 0)
                        {
                            Console.WriteLine(c.ToString());
                        }
                    }
                    Console.WriteLine("Press any key to continue...");
                    Console.ReadKey();
                    printMenu();
                }
            }
        }

        static void printMenu()
        {
            Console.Clear();
            Console.WriteLine("Option");
            Console.WriteLine("1. Add");
            Console.WriteLine("2. Substract");
            Console.WriteLine("3. Multiply");
            Console.WriteLine("4. Divide");
            Console.WriteLine("x. exit");
            Console.Write("\nYour options: ");
        }
    }
}