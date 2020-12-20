namespace CSharp_Lessons
{
    using System;

    class All_Task
    {
        public void Pause()
        {
            Console.ForegroundColor = ConsoleColor.Yellow;
            Console.Write("\n\n\t\t\t\t\t\tPress any key to continue...");
            Console.ReadKey();
            Console.ResetColor();
        }

        public void Task_1()
        {
            /*
             1.	Пользователь вводит строку. Проверить, является ли эта строка палиндромом.
                Палиндромом называется строка, которая одинаково читается слева направо и справа налево.
                Довод, шалаш...
             */
            Console.Write(" Введите любую строку: ");
            string str = Console.ReadLine();
            string newstr = "";
            for (int i = str.Length - 1; i >= 0; i--)
            {
                newstr += str[i];
            }
            if (str == newstr)
            {
                Console.WriteLine(" Ваша строка является палиндромом!!!");
            }
            else if (str != newstr)
            {
                Console.WriteLine(" Ваша строка не является палиндромом... ");
            }
            Pause();
        }

        public void Task_2()
        {
            // 2.	Пользователь вводит строку. Удалить все цифри из строки.
            Console.Write(" Введите любую строку: ");
            string str = Console.ReadLine();

            string newstr = "";
            for (int i = 0; i < str.Length; i++)
            {
                if (!char.IsDigit(str[i]))
                {
                    newstr += str[i];
                }
            }
            Console.WriteLine($" Строка без цифр: {newstr}");
            Pause();
        }

        public void Task_3()
        {
            //3.   Создать метод, принимающий введенную пользователем строку и выводящий на экран статистику
            //     по этой строке. Статистика должна включать общее количество символов, количество букв
            //     (сколько в верхнем регистре и сколько в нижнем),
            //      количество цифр и количество пробельных символов.

            Console.Write("Bведите любую строку: ");
            string text = Console.ReadLine();    // hello world
            StrStatistic(text);
            Pause();
        }

        void StrStatistic(string str)
        {
            int count = 0, countLetter = 0, countUpper = 0, countLower = 0, countNumbers = 0, countSpaces = 0;
            for (int i = 0; i < str.Length; i++)
            {
                count++;
                if (char.IsDigit(str[i]))
                {
                    countNumbers++;
                }
                if (char.IsLetter(str[i]))
                {
                    countLetter++;
                }
                if (char.IsUpper(str[i]))
                {
                    countUpper++;
                }
                if (char.IsLower(str[i]))
                {
                    countLower++;
                }
                if (char.IsWhiteSpace(str[i]))
                {
                    countSpaces++;
                }
            }
            Console.WriteLine($"\nСтатистика по введенной строке:\nК-во цифр в строке: {countNumbers}\n" +
                $"К-во букв в строке: {countLetter}\nК-во больших букв: {countUpper}\nК-во маленьких букв: {countLower}\n " +
                $"К-во пробелов: {countSpaces}\nК-во всех символов: {count}");
        }

        public void Task_4()
        {
            /*
             4.	Пользователь вводит строку и символ. 
             В строке найти все вхождения этого символа и перевести его в верхний регистр, 
             а также удалить часть строки, начиная с последнего вхождения этого символа и до конца.
             */
            Console.Write(" Введите любую строку: ");
            string str = Console.ReadLine();
            Console.Write(" введите любой символ: ");
            char symbol = char.Parse(Console.ReadLine());
            int countSymbol = 0;
            for (int i = 0; i < str.Length; i++)
            {
                if (str[i] == symbol)
                {
                    countSymbol++;
                }
            }

            if (countSymbol > 0)
            {
                Console.ForegroundColor = ConsoleColor.Green;
                Console.WriteLine($" Символ '{symbol}' есть в тексте {countSymbol} раз!");
                Console.ResetColor();
                string str2 = str.Replace(symbol, Convert.ToChar(Convert.ToInt32(symbol) - 32));
                Console.WriteLine($"\nИзменненый текст: {str2}");
            }
            else
            {
                Console.ForegroundColor = ConsoleColor.Red;
                Console.WriteLine($" Символ '{symbol}' есть в тексте {countSymbol} раз!");
                Console.ResetColor();
            }
            int indexLast = str.LastIndexOf(symbol);
            Console.WriteLine($"\nИндекс последнего символа: {indexLast}");
            string remove = str.Remove(indexLast, str.Length - indexLast);
            Console.WriteLine($"\nИзменнёный  текст: {remove}");
            Pause();
        }

        public void Task_5()
        {
            /*
             5.	Ввести строку с клавиатуры и реализовать интерфейс
                для работы со строкой. Возможности интерфейса:
                Отображение текста на экран.
 	            Количество символов в тексте.
 	            Поиск заданного слова - по итогам показывать статистику(сколько раз встречается и на каких позициях).
 	            Замена слова на новое слово.
 	            Удаление слова.
             */
            Console.Write(" Введите любую строку: ");
            string str = Console.ReadLine();
            Console.Write(" Введите любое слово: ");
            string word = Console.ReadLine(), NewWord = string.Empty;
            int choice = 0, i = 0, y = -1, z = -1;
            do
            {
                Console.Clear();
                Console.WriteLine(" 1 - Отображение текста на экран");
                Console.WriteLine(" 2 - Количество символов в тексте ");
                Console.WriteLine(" 3 - Поиск заданного слова - по итогам показывать статистику(сколько раз встречается и на каких позициях)");
                Console.WriteLine(" 4 - Замена слова на новое слово ");
                Console.WriteLine(" 5 - Удаление слова");
                Console.WriteLine(" 0 - выход");
                Console.Write("Сделайте ваш выбор:  ");
                choice = int.Parse(Console.ReadLine());
                switch (choice)
                {
                    case 1:
                        Console.Clear();
                        Console.WriteLine($"Ваша веденная строка: {str}");
                        Pause();
                        break;
                    case 2:
                        Console.Clear();
                        Console.WriteLine($" Длина веденной строки: {str.Length}");
                        Pause();
                        break;
                    case 3:
                        Console.Clear();
                        if (str.Contains(word) == true)
                        {
                            Console.WriteLine($" Слово - {word}  есть в данном тексте... ");
                        }
                        else
                        {
                            Console.WriteLine($" Слово - {word}   не встречается в данном тексте...");
                        }
                        while (i != -1)
                        {
                            i = str.IndexOf(word, y + 1);
                            y = i;
                            z++;
                            if (y != -1)
                            {
                                Console.WriteLine($" Позиция слова: {y}");

                            }
                        }
                        Console.WriteLine($" Слово {word} есть в текущей строке {z} раз");
                        Pause();
                        break;
                    case 4:
                        Console.Write(" Введите новое слово: ");
                        NewWord = Console.ReadLine();
                        str = str.Replace(word, NewWord);
                        Console.WriteLine($" изменёное слово {str}");
                        Pause();
                        break;
                    case 5:
                        str = str.Replace(NewWord, "");
                        Console.WriteLine($" Слово {NewWord} успешно удалено со строки!");
                        Pause();
                        break;
                }
            } while (choice != 0);
        }

        public void Task_6()
        {
            /*
             Реализовать класс, описывающий студента и предусмотреть в нем следущие моменты: фамилия, имя, отчество,
             группа, возраст, масив(рваный) оценок по программированию
             администрированию и дизайну(от 5 до 10). Также добавить методы по работе с перечисленными даными: 
             возможность установки/получения оценки, получение
             среднего балла по заданому предмету, получения максимальной
             и минимальной оценки, распечатка данных о студенте.
             */
            Console.Write("Input First name: ");
            string fName = Console.ReadLine();
            Console.Write("Input Last name: ");
            string lName = Console.ReadLine();
            Console.Write("Input midlle name: ");
            string mName = Console.ReadLine();
            Console.Write("Input group: ");
            string group = Console.ReadLine();
            Console.Write("Input age: ");
            int age = int.Parse(Console.ReadLine());
            Student student = new Student(fName, lName, mName, group, age);
            int choice = 0;
            do
            {
                Console.Clear();
                Console.WriteLine("1 - Установки/получения оценки");
                Console.WriteLine("2 - Получение среднего балла по заданому предмету");
                Console.WriteLine("3 - Получения максимальной и минимальной оценки");
                Console.WriteLine("4 - Распечатка данных о студенте.");
                Console.Write("Please make your choice...");
                choice = int.Parse(Console.ReadLine());
                switch (choice)
                {
                    case 1:
                        Console.Write("Input mark: ");
                        int mark = int.Parse(Console.ReadLine());
                        student.SetMark(mark);
                        Pause();
                        break;
                    case 2:
                        Console.Clear();
                        student.GetAvarage();
                        Pause();
                        break;
                    case 3:
                        Console.Clear();
                        student.GetMinMax();
                        Pause();
                        break;
                    case 4:
                        Console.Clear();
                        student.Print();
                        Pause();
                        break;
                }
            }
            while (choice != 0);
        }

        public void Task_7()
        {
            /*
             Описать класс, представляющий круг. Предусмотреть методы для создания обьектов, вычисления площади круга, 
             длины окружности и проверки попадания заданной точки внутрь круга. 
             Написать программу, демонстрирующую все разработанные элементы класса.
            */
            Console.Write("Input radius: ");
            int radius = int.Parse(Console.ReadLine());
            Circle circle = new Circle(radius);
            double area = circle.Area();
            double l = circle.Length();
            Console.WriteLine($"Area of a Circle: {area}\nLength of a circle: {l}");
            Console.Write("Input X: ");
            double x = double.Parse(Console.ReadLine());
            Console.Write("Input Y: ");
            double y = double.Parse(Console.ReadLine());
            bool result = circle.CheckPoint_In(x, y);
            if(result == true)
            {
                Console.ForegroundColor = ConsoleColor.Green;
                Console.WriteLine("Данная точка попадает во внутрь круга!!!");
                Console.ResetColor();
            }
            else
            {
                Console.ForegroundColor = ConsoleColor.Red;
                Console.WriteLine("Данная точка НЕ попадает во внутрь круга...");
                Console.ResetColor();
            }
            Pause();
        }
    }
}
