using System;

namespace ConsoleApp26
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Please input a number from 0 - 3 to choose the following menu: ");
            Console.WriteLine("[0] Show all recent files");
            Console.WriteLine("[1] Open new file");
            Console.WriteLine("[2] Open recent file");
            Console.WriteLine("[3] Exit");

            int inputNumpage = int.Parse(Console.ReadLine());
            string[] fliesArray = new string[5] { "", "", "", "", "" };
            Menu();
        }

        static void Menu(ref int files)
        {
            int answer;
            while (true)
            {
                answer = int.Parse(Console.ReadLine());

                if (answer >= 0 || answer <= 3)
                {
                    if (answer == 0)
                    {
                        
                    }
                    if (answer == 1)
                    {
                        Console.WriteLine("");
                    }
                    if (answer == 2)
                    {
                        int input = int.Parse(Console.ReadLine());
                    }
                    if (answer == 3)
                    {
                        Console.WriteLine("End");
                    }
                }
                else
                {
                    Console.WriteLine("Invalid menu number.");
                    Menu();
                }
            }
        }
}
