using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TelegramBot1
{
    class Program
    {
        static void Main(string[] args)
        {
            string userName = "";
            string userCommand;
            bool botIsRunning = true;
            string version = "1.0";
            string createDate = "17.11.2025";

            Console.WriteLine("Добро пожаловать в бот! Вам доступны команды: /start, /help, /info, /exit, /statistic");

            while (botIsRunning == true)
            {
                Console.WriteLine("Введите команду: ");
                userCommand = Console.ReadLine();

                switch (userCommand)
                {
                    case "/start":
                        Console.WriteLine("Введите своё имя: ");
                        userName = Console.ReadLine();
                        Console.WriteLine($"Приветствую, {userName}");

                        break;
                    case "/help":
                        Console.WriteLine($"Этот бот предназначен для отслеживания поступления телеметрии в систему. Для этого проверьте, что Вы ввели имя, после этого можно перейти в раздел 5 - statistic TM");
                        break;
                    case "/info":
                        Console.WriteLine($"Версия ТГ-бота: {version}; дата создания: {createDate}");
                        break;
                    case "/exit":
                        botIsRunning = false;
                        break;
                    case "/statistic":
                        Console.WriteLine($"{userName}, статистика по источникам данных: ");
                        Console.WriteLine("Источник 1: 95% параметров корректны и обновляются");
                        Console.WriteLine("Источник 2: 91% параметров корректны и обновляются");
                        break;
                    default:  //все остальные команды
                        if (userCommand.StartsWith("/echo"))
                        {
                            //проверка есть ли имя
                            if (string.IsNullOrEmpty(userName))
                            {
                                Console.WriteLine("Для команды /echo нужно имя. Введите ваше имя:");
                                userName = Console.ReadLine();
                                Console.WriteLine($"Отлично, {userName}!");
                            }
                            string textToEcho = userCommand.Substring(5);
                            Console.WriteLine($"Вы сказали: {textToEcho}");
                        }
                        else
                        {
                            Console.WriteLine("Неизвестная команда!");
                        }
                    break;
                }
            }
        }

    }
}

