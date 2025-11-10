using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lesson4
{
    internal class Program
    {
        static void Main(string[] args)
        {
            ////Многомерные массивы
            //int[,] array;//объявление массива
            //int[,] array2 = new int[2, 3];//объявление и инициализация массива 2 строки, 3 столбца
            //int[,] array3 = {
            //    //0  1  2
            //    { 2, 3, 4 }, //0
            //    { 4, 5, 1 }, //1
            //    { 7, 8, 9 }  //2
            //};
            //int[,] array4 = new int[2, 3] { 
            //    { 9, 8, 7 }, 
            //    { 6, 5, 4 } 
            //};
            //Console.WriteLine(array3[2, 2]);//выведет 9
            //Console.WriteLine(array4[1, 1]);//выведет 5

            //for (int i = 0; i < array3.GetLength(0); i++) //для строк нулевое измерение
            //    {
            //    for (int j = 0; j < array3.GetLength(1); j++)//для столбцов 1-ое измерение
            //        {
            //        Console.Write(array3[i, j] + " ");
            //            //Пока будет выбрана 1 строка (первый for) будет отбираться каждое значение (каждый столбец во втором цикле for))
            //        }
            //    Console.WriteLine();//после выхода из цикла i!=0, j!=0 выводим WriteLine для переноса на следующую строку
            //    }

            //int[,] array3 = new int[6, 4];
            //Random rand = new Random();
            //for (int i = 0; i < array3.GetLength(0); i++) //для строк нулевое измерение
            //{
            //    for (int j = 0; j < array3.GetLength(1); j++)//для столбцов 1-ое измерение
            //    {
            //        array3[i, j] = rand.Next(0, 10);
            //        Console.Write(array3[i, j] + " ");
            //    }
            //    Console.WriteLine();
            //}

            bool isOpen = true;
            string[,] books = {
                { "Александ Пушкин", "Михаил Лермонтов", "Сергей Есенин"},
                { "Роберт Мартин", "Джесси Шелл", "Сергей Тепляков"},
                { "Стивен Кинг", "Говард Лавкрафт", "Брем Стокер" }
            };
            while (isOpen) 
            {
                Console.SetCursorPosition(0, 20);
                Console.WriteLine("\nВесь список авторов:\n");
                for (int i = 0; i < books.GetLength(0); i++)
                {
                    for (int j = 0; j < books.GetLength(1); j++)
                    {
                        Console.Write(books[i, j] + " | ");
                    }
                    Console.WriteLine();
                }
                Console.SetCursorPosition(0, 0);
                Console.WriteLine("Библиотека");
                Console.WriteLine("\n1 - узнать имя автора по индексу книги.\n\n2 - найти книгу по автору.\n\n3 - выход.");
                Console.Write("\nВыбирите пункт меню: ");
                switch (Convert.ToInt32(Console.ReadLine()))
                {
                    case 1://поиск по полке и столбцу
                        int line, column;
                        Console.Write("Введите номер полки: ");
                        line = Convert.ToInt32(Console.ReadLine()) - 1;//-1 из-за начала отсчёта полок с нуля
                        Console.Write("Введите номер стобца: ");
                        column = Convert.ToInt32(Console.ReadLine()) - 1;
                        Console.WriteLine("Это автор: " + books[line, column]);
                        break;
                    case 2:
                        string author;
                        bool authorIsFound = false;
                        Console.Write("Введите автора: ");
                        author = Console.ReadLine();
                        for (int i = 0; i < books.GetLength(0); i++)
                        {
                            for (int j = 0; j < books.GetLength(1); j++)
                            {
                                if (author.ToLower() == books[i, j].ToLower())//проверка на совпадение книг. ToLower - приведение к нижнему регистру
                                {
                                    Console.Write($"Автор {books[i, j] } находится по адресу полка {i + 1}, место {j + 1}.");//+1 чтобы вернуть тот -1, что был выше
                                    authorIsFound = true;
                                }
                            }
                        }
                        if (authorIsFound == false)
                        {
                            Console.WriteLine("Такого автора нет!");
                        }
                        break;
                    case 3:
                        isOpen = false;
                        break;
                    default:
                        Console.WriteLine("Введена неверная команда!");
                        break;
                }
                if (isOpen)
                {
                    Console.WriteLine("\nНажмите любую клавишу для продолжения...");
                }
                Console.ReadKey();//без этой команды список постоянно будет перезаписываться
                Console.Clear();
            }
        }
    }
}
