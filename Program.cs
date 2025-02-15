using System;
using System.Collections.Generic;

namespace project
{

    class Program
    {

        static void Main()
        {
            Console.Write("Перевод строки – \n\n");

            // Строчный комментарий
            /*
                Огромный
                комментарий!
            */
            // Console.Write("Комментарий");
            Console.Write("Текст");

            int age = 45;
            string name = "A";
            bool isActive = false;
            decimal size = 178;
            float weight = 789;
            string? lastName = null;
            char symbol = 'd';

            float someValue = 4.56f;
            someValue = 67.5f;

            double otherValue = -786782.78f;

            short height = -30678;
            byte position = 255;
            long bigNumber = 9223372036854775807;

            // See https://aka.ms/new-console-template for more information
            Console.WriteLine("Hello, World!");
            Console.WriteLine(age);
            Console.WriteLine(name);
            Console.WriteLine(isActive);
            Console.WriteLine(size);
            Console.WriteLine(weight);
            Console.WriteLine(lastName);
            Console.WriteLine(someValue);
            Console.WriteLine(height);
            Console.WriteLine(position);
            Console.WriteLine(bigNumber);
            Console.WriteLine(otherValue);
            Console.WriteLine(symbol);

            Console.WriteLine(position - age);

            for (int i = 0; i < 5; i++)
                Console.WriteLine(i);

            // array
            char[] chars = new char[3];
            chars[0] = 'a';
            chars[1] = 'b';
            chars[2] = 'c';

            int[] numbers = new int[] { 1, 2, 3, 4, 5 };
            int[] y = { 1, 2, 3 };

            Console.WriteLine(chars);
            Console.WriteLine(numbers);
            foreach (int num in numbers)
            {
                Console.WriteLine(num);
            }

            foreach (int num in y)
            {
                Console.WriteLine(num);
            }

            int[,,] x = { { { 1, 3 }, { 4, 5 } }, { { 1, 3 }, { 4, 5 } } };
            x[0, 1, 1] = 6;
            foreach (int num in x)
            {
                Console.WriteLine("num");
                Console.WriteLine(num);
            }

            List<string> words = new List<string>();
            words.Add("bingo");
            words.Add("major");

            foreach (string word in words)
            {
                Console.WriteLine(word);
            }


            // Получение данных
            Console.ReadLine();
        }

        public static void Print()
        {
            Console.WriteLine("");
        }
    }

}
