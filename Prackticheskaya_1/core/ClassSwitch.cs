using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Prackticheskaya_1.core
{
    internal class ClassSwitch
    {
        static CommandsTasks commandsTasks = new CommandsTasks();
        public void ZOV(int i)
        {
            switch (i)
            {
                case 1:
                    commandsTasks.Task1();
                    break;
                case 2:
                    commandsTasks.Task2();
                    break;
                case 3:
                    commandsTasks.Task3();
                    break;
                case 4:
                    commandsTasks.Task4();
                    break;
                case 5:
                    commandsTasks.Task5();
                    break;
                case 6:
                    commandsTasks.Task6();
                    break;
                case 7:
                    commandsTasks.Task7();
                    break;
                case 8:
                    commandsTasks.Task8();
                    break;
                case 9:
                    commandsTasks.Task9();
                    break;
                case 10:
                    commandsTasks.Task10();
                    break;
                case 11:
                    commandsTasks.Task11();
                    break;
                case 12:
                    commandsTasks.Task12();
                    break;
                case 13:
                    commandsTasks.Task13();
                    break;
                case 14:
                    commandsTasks.Task14();
                    break;
                case 15:
                    commandsTasks.Task15();
                    break;

                default:
                    Console.WriteLine("Напиши номер правильно обмудень.");
                    break;
            }
        }
    }
}
