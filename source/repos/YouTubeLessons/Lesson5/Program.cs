using System;

namespace Lesson5
{
    class Program
    {
        static void Main(string[] args)
        {
            //int[] array = new int[3];
            //int[] tempArray = new int[5];
            //array = tempArray;//создаем ссылку одного массива на другой, т.е. теперь они вссылаются на одну область памяти. Сами массивы являются ссылками на области памяти
            //array[0] = 5;//задаём нулевому элементу массива значение 5
            //Console.WriteLine(tempArray[0]);//выводим нулевой элемент массива, равный 5


            //int[] petrovich = new int[3];
            //int[] ivanovich = new int[5];
            //int[] sidorovich; //пустой массив
            //petrovich = ivanovich;
            //petrovich[0] = 5;
            //petrovich[1] = 3;
            //sidorovich = petrovich;
            //sidorovich[2] = 7;
            //sidorovich[0] = 10;
            //Console.WriteLine(ivanovich[0]);
            //Console.WriteLine(ivanovich[1]);
            //petrovich = new int[10]; //абсолютно новый массив, но старая ссылка на область памяти ещё осталась в ivanovich и sidorovich. Когда никто ссылку не использует, массив сгорает

            ////расширение массива
            //int[] bag = new int[1];
            //bag[0] = 12;
            //int[] tempBag = new int[bag.Length + 1];
            //for (int i = 0; i < bag.Length; i++)
            //{
            //    tempBag[i] = bag[i];
            //    //Console.WriteLine(tempBag[i] + " - значение из сумки.");
            //    Console.WriteLine(bag[i] + " первый цикл");
            //}
            //Console.WriteLine();
            ////Console.WriteLine(tempBag[tempBag.Length - 1] + " - последнее значение временного хранилища.");
            //tempBag[tempBag.Length - 1] = 56;
            //bag = tempBag;
            //for (int i = 0; i < bag.Length; i++)
            //{
            //    Console.WriteLine(bag[i] + " второй цикл");
            //}


            ////Бродилка
            //Console.CursorVisible = false;//отключить мерцание курсора
            //char[,] map = //двумерный массив типа char
            //{
            //    {'#','#','#','#','#','#','#','#','#','#','#','#','#','#','#','#','#','#','#','#','#','#'},
            //    {'#',' ',' ',' ','#','#','#',' ',' ',' ',' ',' ',' ',' ',' ',' ',' ',' ',' ',' ',' ','#'},
            //    {'#','X',' ',' ',' ',' ',' ',' ',' ',' ',' ','X',' ',' ',' ',' ',' ',' ',' ',' ',' ','#'},
            //    {'#',' ',' ',' ',' ',' ',' ','#',' ',' ',' ',' ',' ',' ',' ',' ','#','#','#',' ',' ','#'},
            //    {'#',' ',' ','#',' ',' ',' ',' ',' ',' ',' ',' ',' ','#',' ',' ',' ',' ',' ',' ',' ','#'},
            //    {'#',' ',' ','#',' ',' ',' ',' ',' ',' ',' ',' ',' ','#',' ',' ',' ',' ',' ','X',' ','#'},
            //    {'#',' ',' ','#',' ',' ',' ','X',' ',' ',' ',' ',' ',' ',' ',' ',' ',' ',' ',' ',' ','#'},
            //    {'#',' ',' ','#',' ',' ',' ',' ',' ',' ',' ',' ',' ',' ',' ','X',' ',' ',' ',' ',' ','#'},
            //    {'#',' ',' ','#','X',' ',' ',' ',' ','#',' ',' ','X',' ',' ',' ',' ',' ',' ','#',' ','#'},
            //    {'#',' ',' ',' ',' ',' ',' ',' ',' ',' ',' ',' ',' ',' ',' ',' ',' ',' ',' ','#',' ','#'},
            //    {'#',' ',' ',' ',' ',' ',' ',' ',' ',' ',' ','#',' ',' ',' ',' ',' ',' ',' ','#',' ','#'},
            //    {'#','X',' ',' ','#',' ',' ',' ',' ',' ',' ','#',' ',' ',' ',' ',' ',' ','#',' ',' ','#'},
            //    {'#',' ',' ',' ',' ',' ',' ',' ',' ',' ',' ','#',' ',' ','#',' ',' ',' ','#',' ',' ','#'},
            //    {'#',' ',' ',' ',' ',' ',' ',' ',' ',' ',' ',' ',' ',' ',' ',' ',' ',' ',' ',' ',' ','#'},
            //    {'#',' ','X',' ',' ',' ',' ',' ','X',' ',' ',' ',' ',' ','#',' ',' ',' ',' ',' ',' ','#'},
            //    {'#','#','#','#','#','#','#','#','#','#','#','#','#','#','#','#','#','#','#','#','#','#'}
            //};
            //int userX = 6, userY = 6;
            //char[] bag = new char[1];//сумка для сокровищ, одномерный массив на 1 ячейку
            //while (true)
            //{
            //    Console.SetCursorPosition(0, 20);
            //    Console.Write("Сумка: ");
            //    for (int i = 0; i < bag.Length; i++)
            //    {
            //        Console.Write(bag[i] + " ");
            //    }
            //    Console.SetCursorPosition(0, 0);
            //    for (int i = 0; i < map.GetLength(0); i++)//т.к. массив двумерный обращаемся сначала к одному измерению
            //    {
            //        for (int j = 0; j < map.GetLength(1); j++)//затем к другому мзмерению
            //        {
            //            Console.Write(map[i, j]);
            //        }
            //        Console.WriteLine();
            //    }
            //    Console.SetCursorPosition(userY, userX);//координаты карты перевернули - X это Y, Y это X
            //    Console.Write('@');//персонаж
            //    ConsoleKeyInfo charKey = Console.ReadKey();//ConsoleKeyInfo тип данных, читаем с ввода с консоли
            //    switch (charKey.Key)
            //    {
            //        case ConsoleKey.UpArrow:
            //            if (map[userX - 1, userY] != '#') //-1 это свдиг вверх
            //            {
            //                userX--;
            //            }
            //                break;
            //        case ConsoleKey.DownArrow:
            //            if (map[userX + 1, userY] != '#') //+1 это свдиг вниз
            //            {
            //                userX++;
            //            }
            //            break;
            //        case ConsoleKey.LeftArrow:
            //            if (map[userX, userY - 1] != '#') //-1 это свдиг влево
            //            {
            //                userY--;
            //            }
            //            break;
            //        case ConsoleKey.RightArrow:
            //            if (map[userX, userY + 1] != '#') //+1 это свдиг вправо
            //            {
            //                userY++;
            //            }
            //            break;
            //    }
            //    if (map[userX, userY] == 'X')
            //    {
            //        map[userX, userY] = 'o';//откопали сокровище, оставляем о
            //        char[] tempBag = new char[bag.Length + 1];//расширение нашего одномерного массива bag
            //        for (int i = 0; i < bag.Length; i++)
            //        {
            //            tempBag[i] = bag[i];//каждому элементу временной сумки присваиваем значение одномерной сумки bag
            //        }
            //        tempBag[tempBag.Length - 1] = 'X';//последнему элементу временной сумки (который по умолчанию 0, т.к. он больше одномерной сумки bag) присвоем X-сокровище
            //        bag = tempBag;//старую сумку удаляем
            //    }
            //    Console.Clear();//чтобы карта не зарисовывала персонажа
            //}



            ////тип String это массив char-ов, но доступ только для чтения, не записи!
            //string line = "Привет!";
            //Console.WriteLine(line[1]);//выведет р


            //int[] numbers = { 0, 1, 2, 3, 4, 5, 6, 7, 8, 9 };
            //for (int i = 0; i < numbers.Length; i++)
            //{
            //    Console.WriteLine(numbers[i]);//берем весь массив numbers и по его индексу i выводим все его значения
            //}
            //foreach (int number in numbers)//берём каждый элемент во всём массиве, не обращаяся по индексу. Foreach когда нам не нужны индексы. Он работает быстро и без счётчиков
            //{
            //    Console.Write(number + " ");
            //}


            ////ФУНКЦИИ - набор именованных блоков, которые имеют список именованных параметров (аргументов) на вход и что-то передают на выход. Аргумент - то, что функция получает, параметр - то, что хочет получить
            //string userInput = "AAAsssSaaa";
            //userInput.ToLower();//ToLower - встроенная функция, приводящая все буквы к нижнему регистру

            //Console.WriteLine("Привет!");
            //Console.WriteLine("Ты здесь?");
            //ConsoleColor defaultColor = Console.ForegroundColor;//defaultColor - здесь теперь лежит цвет нашего шрифта в консоли
            //Console.ForegroundColor = ConsoleColor.Red;//чтобы следующее сообщение вывелось красным
            //Console.WriteLine("Нет соединения с инетрнетом.");
            //Console.ForegroundColor = defaultColor;//чтобы вернуть обратно белый цвет текста
            //Console.WriteLine("Странно..."); //здесь нужен повторяющийся код! Для того, чтобы не задавать цвет текста красный после каждого сообщения, нужно задать функцию вне класса MAIN!
            Console.WriteLine("Привет!");
            Console.WriteLine("Ты здесь?");
            WriteError("Нет соединения с интернетом!");//вставляем ту функцию, которая красит текст в те места, где его нужно окрасить
            Console.WriteLine("Странно...");
            WriteError("Интернет не оплачен.");//здесь в скобках это аргумент! Это передаётся функцией
        }
        static void WriteError(string text) //функция может возвращать значения абсолютно любого типа, но также может ничего не возвращать - void (пустота). Здесь в скобках string text это параметр!
        {
            ConsoleColor defaultColor = Console.ForegroundColor;//defaultColor - здесь теперь лежит цвет нашего шрифта в консоли
            Console.ForegroundColor = ConsoleColor.Red;//чтобы следующее сообщение вывелось красным
            Console.WriteLine(text);
            Console.ForegroundColor = defaultColor;//чтобы вернуть обратно белый цвет текста
        }
    }
}
