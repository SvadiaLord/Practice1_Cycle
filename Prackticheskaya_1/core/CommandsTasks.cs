﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Prackticheskaya_1.core
{
    internal class CommandsTasks
    {
        static ProverkaType proverkaType = new ProverkaType();
        public void Task1()
        {
            for (int i = 1; i <= 10; i++)
            {
                Console.WriteLine($"Число: {i}");
            }
            return;
        }
        public void Task2()
        {
            for (int i = 2; i <= 20; i++)
            {
                if ((i % 2) == 0)
                {
                    Console.WriteLine($"Число: {i}");
                }
            }
        }
        public void Task3()
        {
            int abc = 0;
            for (int i = 1; i <= 15; i++)
            {
                if ((i % 2) != 0)
                {
                    abc += i;
                }
            }
            Console.WriteLine($"Сумма четных чисел: {abc}");
        }
        public void Task4()
        {
            int abc = proverkaType.Type<int>("Введите число для таблицы умножения: ");
            for (int i = 1; i <= 10; i++)
            {
                Console.WriteLine($"{abc} * {i}={abc * i}");
            }
        }
        public void Task5()
        {
            int abc = proverkaType.Type<int>("Введите число для факториала: ");
            int loh = 1;
            for (int i = 1; i <= abc; i++)
            {
                Console.WriteLine($"Факториал числа {abc} ==> {loh *= i}");
            }
        }
        public void Task6() // ЭТО КАКОЙ-ТО ПИЗДЕЦ Я МАТЕМАТИКУ НЕ ПОНИМАЮ ЧТО ТАКОЕ ПРОСТЫЕ ЧИСЛА
        {
            int abc = proverkaType.Type<int>("Введите число: ");
            for (int i = 1; i <= 10; i++)
            {
                if (abc % i == 0)
                {
                    if (i != 1 || i != abc)
                    {
                        Console.WriteLine($"{abc} - Это не натуральное число");
                    }
                    else
                    {
                        Console.WriteLine($"{abc} - Это натуральное число");
                    }
                }
                else
                {
                    Console.WriteLine($"{abc} - Это не натуральное число");
                }
            }
        }
        public void Task7()
        {
            string Z = null;
            string LOH = Console.ReadLine();
            Console.Write("Введите строку: ");
            for (int i = LOH.Length - 1; i >= 0; i--)
            {
                Z += LOH[i].ToString();
            }
            Console.WriteLine(Z);
        }
        public void Task8()
        {
            string V = Console.ReadLine();
            string Z = "аеёиоуэюя";
            int count = 0;
            int index = 0;
            while (index < V.Length)
            {
                if (Z.Contains(V[index]))
                {
                    count++;
                }
                index++;
            }
            Console.WriteLine($"Количество гласных: {count}");
        }
        public void Task9()
        {
            string Z = null;
            Console.Write("Введите словечко: ");
            string LOH = Console.ReadLine();
            for (int i = LOH.Length - 1; i >= 0; i--)
            {
                Z += LOH[i].ToString();
            }
            Z.ToLower();
            LOH.ToLower();
            if (Z == LOH)
            {
                Console.WriteLine("Я сшитаю ето палиодръъъъъъ");
            }
            else
            {
                Console.WriteLine("Нет.");
            }
        }
        public void Task10()
        {
            string V = Console.ReadLine();
            /* По заданию
            char O = ' ';
            char Z = '_';
            string result = null;
            int index = 0;
            while (index < V.Length)
            {
                if (V[index] == O)
                {
                    result += Z;
                }
                else
                {
                    result += V[index];
                }
                index++;
            }
            Console.WriteLine(result);*/
            V = V.Replace(" ", "_");
            Console.WriteLine(V);

        }
    }
}
