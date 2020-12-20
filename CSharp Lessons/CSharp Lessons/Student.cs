namespace CSharp_Lessons
{
    using System;

    class Student
    {
        int age;
        int[][] rating;
        string firstname, lastname, middlename, group;

        public Student(string f, string l, string m, string g, int a)
        {
            firstname = f;
            lastname = l;
            middlename = m;
            group = g;
            age = a;

            rating = new int[3][];
            rating[0] = RandMarks(Randomizer.GetNumber(4, 13));        // Programming
            rating[1] = RandMarks(Randomizer.GetNumber(4, 13));        // Administrate
            rating[2] = RandMarks(Randomizer.GetNumber(4, 13));        // Design
        }

        int[] RandMarks(int n)
        {
            int[] marks = new int[n];
            for (int i = 0; i < marks.Length; i++)
            {
                marks[i] = Randomizer.GetNumber(5, 11);
            }
            return marks;
        }

        public void GetAvarage()
        {
            int avarage = 0, summ = 0, len;
            Console.Clear();
            Console.WriteLine("Subjects:\n1 - Programming");
            Console.WriteLine("2 - Administrate");
            Console.WriteLine("3 - Design");
            Console.WriteLine("0 - Previous menu");
            Console.Write("Please make your choice...");
            int choice = int.Parse(Console.ReadLine());
            switch (choice)
            {
                case 1:
                    len = rating[0].Length;
                    int[] tmp = new int[len + 1];
                    for (int i = 0; i < len; i++)
                    {
                        summ += rating[0][i];
                    }
                    avarage = summ / len;
                    Console.WriteLine($"Средняя оценка по программированию - {avarage}");
                    break;
                case 2:
                    len = rating[1].Length;
                    int[] tmp1 = new int[len + 1];
                    for (int i = 0; i < len; i++)
                    {
                        summ += rating[1][i];
                    }
                    avarage = summ / len;
                    Console.WriteLine($"Средняя оценка по Администрированию - {avarage}");
                    break;
                case 3:
                    len = rating[2].Length;
                    int[] tmp2 = new int[len + 1];
                    for (int i = 0; i < len; i++)
                    {
                        summ += rating[2][i];
                    }
                    avarage = summ / len;
                    Console.WriteLine($"Средняя оценка по Дизайну - {avarage}");
                    break;
            }
        }

        public void GetMinMax()
        {
            int max = 0, min = 0, len;
            Console.Clear();
            Console.WriteLine("Subjects:\n1 - Programming");
            Console.WriteLine("2 - Administrate");
            Console.WriteLine("3 - Design");
            Console.WriteLine("0 - Previous menu");
            Console.Write("Please make your choice...");
            int choice = int.Parse(Console.ReadLine());
            switch (choice)
            {
                case 1:
                    min = rating[0][0];
                    len = rating[0].Length;
                    int[] tmp = new int[len + 1];
                    for (int i = 0; i < len; i++)
                    {
                        if (rating[0][i] > max)
                        {
                            max = rating[0][i];
                        }
                        if (rating[0][i] < min)
                        {
                            min = rating[0][i];
                        }
                    }
                    Console.WriteLine($"Максимальная оценка по программированию - {max}");
                    Console.WriteLine($"Минимальная оценка по программированию - {min}");
                    break;
                case 2:
                    min = rating[1][0];
                    len = rating[1].Length;
                    int[] tmp1 = new int[len + 1];
                    for (int i = 0; i < len; i++)
                    {
                        if (rating[1][i] > max)
                        {
                            max = rating[1][i];
                        }
                        if (rating[1][i] < min)
                        {
                            min = rating[1][i];
                        }
                    }
                    Console.WriteLine($"Максимальная оценка по Администрированию - {max}");
                    Console.WriteLine($"Минимальная оценка по Администрированию - {min}");
                    break;
                case 3:
                    min = rating[2][0];
                    len = rating[2].Length;
                    int[] tmp2 = new int[len + 1];
                    for (int i = 0; i < len; i++)
                    {
                        if (rating[2][i] > max)
                        {
                            max = rating[2][i];
                        }
                        if (rating[2][i] < min)
                        {
                            min = rating[2][i];
                        }
                    }
                    Console.WriteLine($"Максимальная оценка по Дизайну - {max}");
                    Console.WriteLine($"Минимальная оценка по Дизайну - {min}");
                    break;
            }
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
                    for (int i = 0; i < len; i++)
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