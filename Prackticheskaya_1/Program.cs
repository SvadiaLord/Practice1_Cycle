using Prackticheskaya_1.core;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Prackticheskaya_1
{
    // Ничто не истинно. Всё дозволено...
    internal class Program
    {
        static ProverkaType proverkaType = new ProverkaType();
        static ClassSwitch classSwitch = new ClassSwitch();
        static void Main(string[] args)
        {
            while (true)
            {
                Console.WriteLine("#1: Числа от 1 до 10.\n#2: Все четные числа от 2 до 20.\n#3: Сумма всех нечетных чисел от 1 до 15.\n#4: Таблица умножения для цифрЫ.\n#5: Найти факториал заданного числа.\n#6: Вывести на экран все простые числа в заданном диапазоне (цикл while).\n#7: Перевернуть строку используя цикл for.\n#8: Подсчитать количество гласных в строке.\n#9: Проверить является ли слово Палиодромом.\n#9: Заменить все проблемы в строке на подчеркивание (цикл while).\n#10: Заменить все пробелы на нижнее подчеркивание.\n#11: Вывести на экран строку в обратном порядке.\n#12: Число фибоначчи.\n#13: Угадай число.\n#14: Числа, кратные 3 и 5.\n#15: Вывод Hello World 10 раз.");
                classSwitch.ZOV(proverkaType.Type<int>("Введите номер задания: "));
                Console.ReadKey();
                Console.Clear();
            }
        }
    }
}
