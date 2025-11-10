using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lesson3
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Random rand = new Random(); // в нашей переменной хранится рандом
            //int value;
            //while (true)
            //{
            //    value = rand.Next(0, 10); // 0 будет учитываться в диапазоне, а 10 нет!
            //    Console.WriteLine(value);
            //    Console.ReadKey(); // нажатие кливиши, чтобы успевать просмотреть, что будет в консоли
            //}

            //Random rand = new Random(); // типы рандома нужно создавать в начале программы, за пределами любого цикла!
            //for (int i = 0; i < 5; i++)
            //{
            //    Console.WriteLine(rand.Next(0, 5));
            //}

            ////Игра угадай число
            //int number; // загаданное компьютером число
            //int lower, higher; // это конкретные случайные числа, которые выступают подсказкой, а не полноценные границы!
            //int triesCount = 5; // количество попыток игрока (присваивается значение 5)
            //int userInput; // будет хранить ввод пользователя
            //Random rand = new Random(); // Создаётся объект класса Random — это инструмент для генерации случайных чисел
            //number = rand.Next(0, 101); // Метод Next(0, 101) генерирует случайное целое число от 0 до 100
            //lower = rand.Next(number - 10, number); // случайное число на 10 меньше загаданного, но не ниже его минус 10
            //higher = rand.Next(number + 1, number + 10); // случайное число на 10 больше загаданного, но не выше его плюс 10
            //Console.WriteLine($"Мы загадали число от 0 до 100, оно > чем {lower}, но < чем {higher}."); //$интерполяция
            //Console.WriteLine($"Что это за число? У вас {triesCount} попыток отгадать.");
            //while (triesCount-- > 0) //  (декремент) уменьшает счётчик попыток с каждым циклом
            //{
            //    Console.Write("Ваш ответ: ");
            //    userInput = Convert.ToInt32(Console.ReadLine()); // преобразует текст в число типа int
            //    if (userInput == number)
            //    {
            //        Console.WriteLine("Вы правы, это было число " + number + "."); // конкатенация строк (соединение с +)
            //        break;
            //    }
            //    else
            //    {
            //        Console.WriteLine("Не верно, попробуйте ещё раз.");
            //    }
            //}
            //if (triesCount < 0) // переменная triesCount начинается с 5, и с каждой итерацией уменьшается на 1 (5 → 4 → 3 → 2 → 1 → 0). Когда значение становится меньше 0, цикл заканчивается. Это позволяет дать игроку ровно 5 попыток.
            //{
            //    Console.WriteLine("Вы проиграли, увы, но повезёт в следующий раз. Это было число " + number + ".");
            //}

            ////Игра гладиаторский бой
            //Random rand = new Random();
            //float health1 = rand.Next(90, 100);
            //int damage1 = rand.Next(7, 35);
            //int armor1 = rand.Next(25, 65);
            //float health2 = rand.Next(80, 150);
            //int damage2 = rand.Next(5, 40);
            //int armor2 = rand.Next(65, 100);
            //Console.WriteLine($"Гладиатор 1 - {health1} здоровья, {damage1} урона, {armor1} брони.");
            //Console.WriteLine($"Гладиатор 2 - {health2} здоровья, {damage2} урона, {armor2} брони.");
            //while (health1 > 0 && health2 > 0)
            //{
            //    health1 -= Convert.ToSingle(rand.Next(0, damage2 + 1)) / 100 * armor1;
            //    health2 -= Convert.ToSingle(rand.Next(0, damage1 + 1)) / 100 * armor2;
            //    Console.WriteLine("Здоровье гладиатора 1: " + health1);
            //    Console.WriteLine("Здоровье гладиатора 2: " + health2);
            //}
            //if (health1 <= 0 && health2 <= 0)
            //{
            //    Console.WriteLine("Ничья. Оба гладиатора погибли.");
            //}
            //else if (health1 <= 0)
            //{
            //    Console.WriteLine("Гладиатор 1 пал.");
            //}
            //else if (health2 <= 0)
            //{
            //    Console.WriteLine("Гладиатор 2 пал.");
            //}

            //Console.WriteLine("Привет, Боб!\nКуда ты вчера делся?\nЯ убежал к ...");// \n - перенос строки
            //Console.WriteLine("Привет, Боб!\nКуда ты вчера делся?\nЯ убежал к ...}\b \b");// \b \b - удаляет лишний символ

            //Console.Clear();//Очистка консоли и курсор в левом верхнем углу
            //Console.ReadKey();

            //Console.Clear();
            //Console.SetCursorPosition(5, 10); //Передвижение курсора в пустой консоли
            //Console.ReadKey();

            //Console.ForegroundColor = ConsoleColor.Green; //изменение цвета текста в консоли 
            //Console.BackgroundColor = ConsoleColor.Red; //изменение цвета фона в консоли 
            //Console.Clear(); //окрас всего окна консоли в красный
            //Console.WindowHeight = 10; //высота консоли
            //Console.WindowWidth = 35; //ширина консоли
            //Console.WriteLine("Привет, Боб!\nКуда ты вчера делся?\nЯ убежал к ...");

            //Массивы
            //int[] cucumbers = new int[10];
            ////Console.WriteLine(cucumbers[0]); //вывод наполнения из 0-го массива
            ////Console.WriteLine(cucumbers.Length);//узнаем длину (размер) массива
            ////cucumbers[7] = 13;//ручное заполнение массива
            //Random rand = new Random(); 
            //for (int i = 0; i < cucumbers.Length; i++)
            //{
            //    cucumbers[i] = rand.Next(0, 101);//заполнение массива рандомными данными
            //    Console.WriteLine(cucumbers[i]);//выведет наполнения всех 10-ти массивов
            //}

            //int[] cucumbers = { 24, 25, 17, 38, 100, int.MaxValue, int.MinValue };//int.MaxValue-макс и мин возможные значения типа int
            //for (int i = 0; i < cucumbers.Length; i++)
            //{
            //    Console.WriteLine(cucumbers[i]);
            //}

            //int[] cucumbers = new int[4] { 4, 1, 6, 2 };//заданный вручную размер и наполнение массива
            //for (int i = 0; i < cucumbers.Length; i++)
            //{
            //    Console.WriteLine(cucumbers[i]);
            //}

            //int[] array = { 2, 3, 4, 7, 8 };
            //int sum = 0;
            //for (int i = 0; i < array.Length; i++)
            //{
            //    sum += array[i];//суммирование всех наполнений массива
            //}
            //Console.WriteLine(sum);

            //int[] array = { 1, 3, 5, 8, 12, 2, -3, 102 };
            //int maxElement = int.MinValue;
            //for (int i = 0; i < array.Length; i++)
            //{
            //    if (maxElement < array[i])//поиск максимального значения из массива
            //    { 
            //        maxElement = array[i];
            //    }
            //}
            //Console.WriteLine(maxElement);

            //Продажа билетов на самолёт
            int[] sectors = { 6, 28, 15, 15, 16 }; //распределение кол-ва мест по сектарам самолета
            bool isOpen = true;//с самого начала программа запущена
            while (isOpen)
            {
                Console.SetCursorPosition(0, 18);//текстовку отправляем вниз по консоли
                for (int i = 0; i < sectors.Length; i++)
                {
                    Console.WriteLine($"В секторе {i + 1} свободно {sectors[i]} мест");//{ i + 1} чтобы не смущать пользователя счётом, начинающимся с 0
                }
                Console.SetCursorPosition(0, 0);
                Console.WriteLine("Регистрация рейса");
                Console.WriteLine("\n\n1 - забронировать места\n\n2 - выход из программы.\n\n");
                Console.Write("Введите номер команды: ");
                switch (Convert.ToInt32(Console.ReadLine()))//конвертируем введённое из консоли в int32
                {
                    case 1://наш int32, введенный пользователем сравниваем с вариантами ответов
                        int userSector, userPlaceAmount;
                        Console.Write("В каком секторе Вы хотите лететь? ");
                        userSector = Convert.ToInt32(Console.ReadLine()) - 1;//конвертируем в int32 введенный в консоли номер сектора, отнимаем 1, чтобы опять же убрать начало счёта секторов с нуля при выборе сектора
                        if (sectors.Length <= userSector || userSector < 0) //проверка на ввод не большего и не меньшего кол-ва секторов, чем у нас есть 
                        {
                            Console.WriteLine("Такого сектора не существует.");
                            break;
                        }
                        Console.Write("Сколько мест Вам необходимо? ");
                        userPlaceAmount = Convert.ToInt32(Console.ReadLine());//конвертируем в int32 введенный в консоли кол-во мест
                        if (userPlaceAmount < 0)
                        {
                            Console.WriteLine("Неверное количество мест.");
                            break;
                        }
                        if (sectors[userSector] < userPlaceAmount || userPlaceAmount < 0)
                        {
                            Console.WriteLine($"В секторе {userSector} недостаточно мест." +
                                $"Остаток {sectors[userSector]}");
                            break;
                        }
                        sectors[userSector] -= userPlaceAmount;
                        Console.WriteLine("Бронирование успешно!");
                        break;
                    case 2:
                        isOpen = false;
                        break;
                }
                Console.ReadKey();
                Console.Clear();
            }



        }
    }
}
