using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharp_Lessons
{
    class Program
    {
        static void Main(string[] args)
        {
            int choice = 0;
            All_Task tasks = new All_Task();
            do
            {
                choice = Menu(7);
                switch (choice)
                {
                    case 1:
                        Console.Clear();
                        tasks.Task_1();
                        break;
                    case 2:
                        Console.Clear();
                        tasks.Task_2();
                        break;
                    case 3:
                        Console.Clear();
                        tasks.Task_3();
                        break;
                    case 4:
                        Console.Clear();
                        tasks.Task_4();
                        break;
                    case 5:
                        Console.Clear();
                        tasks.Task_5();
                        break;
                    case 6:
                        Console.Clear();
                        tasks.Task_6();
                        break;
                    case 7:
                        Console.Clear();
                        tasks.Task_7();
                        break;
                }
            }
            while (choice != 0);          
        }

        static int Menu(int n)
        {
            int choice = 0;
        MenuAgain:
            Console.Clear();
            Console.ForegroundColor = ConsoleColor.Green;
            Console.WriteLine("String(Строки):");
            Console.ResetColor();
            for (int i = 1; i <= n; i++) 
            {
                Console.WriteLine($"{i} - Task {i}");
            }
            Console.WriteLine("0 - Exit");
            Console.Write("Please make your choice..");
            try
            {
                choice = int.Parse(Console.ReadLine());
            }
            catch
            {
                Console.ForegroundColor = ConsoleColor.Red;
                Console.Write("\n\n\t\t\t\t\t\tВы должны ввести целое число!");
                Console.ReadKey();
                Console.ResetColor();
                goto MenuAgain;
            }
            return choice;
        }
    }
}
