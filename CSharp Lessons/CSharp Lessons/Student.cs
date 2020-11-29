using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharp_Lessons
{
    class Student
    {
        string firstname, lastname, middlename, group;
        int age;
        int[][] rating;

        public Student(string f, string l, string m, string g, int a)
        {
            firstname = f;
            lastname = l;
            middlename = m;
            group = g;
            age = a;

            rating = new int[3][];
            rating[0] = new int[6] { 2, 4, 5, 3, 4, 4 };              // Programming
            rating[1] = new int[10] { 9, 3, 2, 1, 2, 3, 4, 3, 5, 6 }; // Administrate
            rating[2] = new int[5] { 4, 4, 4, 5, 6 };                 // Design
        }

        public void SetMark(int mark)
        {
            Console.WriteLine("Subjects:\n1 - Programming");
            Console.WriteLine("2 - Administrate");
            Console.WriteLine("3 - Design");
            Console.WriteLine("0 - Previous menu");
            Console.Write("Please make your choice...");
            int subject = int.Parse(Console.ReadLine());
            switch (subject)
            {
                case 1:
                    int len = rating[0].Length;
                    int[] tmp = new int[len + 1];
                    for(int i = 0; i< len; i++)
                    {
                        tmp[i] = rating[0][i];
                    }
                    tmp[len] = mark;
                    len++;
                    rating[0] = tmp;
                    break;
                case 2:
                    int len1 = rating[1].Length;
                    int[] tmp1 = new int[len1 + 1];
                    for (int i = 0; i < len1; i++)
                    {
                        tmp1[i] = rating[1][i];
                    }
                    tmp1[len1] = mark;
                    len1++;
                    rating[1] = tmp1;
                    break;
                case 3:
                    int len2 = rating[2].Length;
                    int[] tmp2 = new int[len2 + 1];
                    for (int i = 0; i < len2; i++)
                    {
                        tmp2[i] = rating[2][i];
                    }
                    tmp2[len2] = mark;
                    len2++;
                    rating[2] = tmp2;
                    break;
            }
        }

        public void Print()
        {
            Console.WriteLine($"{firstname} {lastname} {middlename} {group} {age}");
            Console.Write("\n Оценки по программированию: ");
            for (int i = 0; i < rating[0].Length; i++)
            {
                Console.Write($" {rating[0][i]}");
            }
            Console.Write("\n Оценки по администрированию: ");
            for (int i = 0; i < rating[1].Length; i++)
            {
                Console.Write($" {rating[1][i]}");
            }
            Console.Write("\n Оценки по дизайну: ");
            for (int i = 0; i < rating[2].Length; i++)
            {
                Console.Write($" {rating[2][i]}");
            }
        }
    }
}
