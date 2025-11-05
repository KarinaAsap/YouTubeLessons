using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            ////Операторы условий
            //int age;
            //Console.Write("Введите свой возраст: ");
            //age = Convert.ToInt32(Console.ReadLine());//Консоль возвратит нам строку, поэтому нужна конвертация в int
            //if (age >= 18)
            //{
            //    Console.WriteLine("Добро пожаловать в наш бар!");
            //    Console.WriteLine("Что будете пить?");
            //}
            //else
            //{
            //    Console.WriteLine("Вы слишком юны");
            //    Console.WriteLine("Приходите к нам через: " + (18 - age) + " лет.");
            //}
            //Console.WriteLine("За условным оператором");


            //string dayOfWeek;
            //Console.WriteLine("Введите день недели: ");
            //dayOfWeek = Console.ReadLine();
            //if (dayOfWeek == "понедельник")
            //{
            //    Console.WriteLine("Проходим курсы");
            //}
            //else if (dayOfWeek == "вторник")
            //{
            //    Console.WriteLine("Делаем домашнее задание");
            //}


            // Логическое И || &&
            // x | y | x && y true ->1 false -> 0
            // 1 | 1 |    1
            // 1 | 0 |    0
            // 0 | 1 |    0
            // 0 | 0 |    0

            // Логическое ИЛИ ||
            // x | y | x && y true ->1 false -> 0
            // 1 | 1 |    1
            // 1 | 0 |    1
            // 0 | 1 |    1
            // 0 | 0 |    0

            //int money = 500;
            //int level = 10;
            //if (money >= 500 || level > 9)
            //{
            //    Console.WriteLine("Проходи! Добро пожаловать в гильдию!");
            //}
            //else
            //{
            //    Console.WriteLine("Вас выпнули за дверь!");
            //}


            ////Оператор switch
            //string dayOfWeek;
            //dayOfWeek = Console.ReadLine();
            //switch (dayOfWeek)
            //{
            //    case "понедельник":
            //    case "суббота":
            //    case "воскресенье":
            //        Console.WriteLine("Идём в кино");
            //        Console.WriteLine("Едим попкорн");
            //        break;
            //    case "вторник":
            //        Console.WriteLine("Проходим курс");
            //        break;
            //    case "среда":
            //        Console.WriteLine("Изучаем switch");
            //        break;
            //    case "четверг":
            //        Console.WriteLine("Проектируем приложение");
            //        break;
            //    case "пятница":
            //        Console.WriteLine("Выходной");
            //        break;
            //    default:// Проверка на верность введенной в консоли информации
            //        Console.WriteLine("Я такого дня не знаю");
            //        break;
            //}


            //string password = "123qwe";
            //string userInput;
            //Console.Write("Введите пароль: ");
            //userInput = Console.ReadLine();
            //if (userInput == password)
            //{
            //    Console.WriteLine("Пароль принят. Доступ в систему разрешен!");
            //}
            //else 
            //{
            //    Console.WriteLine("Неверный пароль!");
            //}


            //float rublesInWallet;
            //float dollarsInWallet;
            //int rubToUsd = 64, usdToRub = 66;
            //float exchangeCurrencyCount;
            //string desiredOperation;
            //Console.WriteLine("Добро пожаловать в обменник валют!");
            //Console.Write("Введите баланс рублей: ");
            //rublesInWallet = Convert.ToSingle(Console.ReadLine());//float в Single
            //Console.Write("Введите баланс долларов: ");
            //dollarsInWallet = Convert.ToSingle(Console.ReadLine());//float в Single
            //Console.WriteLine("Выберите необходимую операцию.");
            //Console.WriteLine("1 - обменять рубли на доллары.");
            //Console.WriteLine("2 - обменять доллары на рубли.");
            //Console.Write("Ваш выбор: ");
            //desiredOperation = Console.ReadLine();// без конвертации, потому что с консоли придет строка, и desiredOperation у нас string
            //switch (desiredOperation)
            //{
            //    case "1":
            //        Console.WriteLine("Обмен рублей на доллары");
            //        Console.Write("Сколько вы хотите обменять? ");
            //        exchangeCurrencyCount = Convert.ToSingle(Console.Read());
            //        if (rublesInWallet >= exchangeCurrencyCount)// Проверка хватит ли денег на обмен
            //        {
            //            rublesInWallet -= exchangeCurrencyCount;
            //            dollarsInWallet += exchangeCurrencyCount / rubToUsd;
            //        }
            //        else
            //        {
            //            Console.WriteLine("Недопустимое количество рублей");
            //        }
            //        break;
            //    case "2":
            //        Console.WriteLine("Обмен долларов на рубли");
            //        Console.Write("Сколько вы хотите обменять? ");
            //        exchangeCurrencyCount = Convert.ToSingle(Console.Read());
            //        if (dollarsInWallet >= exchangeCurrencyCount)// Проверка хватит ли денег на обмен
            //        {
            //            dollarsInWallet -= exchangeCurrencyCount;
            //            rublesInWallet += exchangeCurrencyCount / usdToRub;
            //        }
            //        else
            //        {
            //            Console.WriteLine("Недопустимое количество долларов");
            //        }
            //        break;
            //    default:
            //        Console.WriteLine("Выбрана неверная операция.");
            //        break;
            //}
            //Console.WriteLine($"Ваш баланс: {rublesInWallet} рублей и " + $"{dollarsInWallet} долларов.");


            //Цикл WHILE
            //int age;
            //Console.Write("Введите ваш возраст: ");
            //age = Convert.ToInt32(Console.ReadLine());
            //while (age-- > 0)//декремент можно установить рядом с условием while (age-- >0)
            //{
            //    Console.WriteLine("С днём рождения!");
            //    //    age--;//декремент - если напишем в консоли 10, выйдет 10 поздравлений
            //    //}
            //    //можно с break, тогда программа остановится после указанного кол-ва попыток
            //    if (age == 8)//если введем 12, то выведет 4 поздравления
            //    {
            //        break;
            //    }
            //}
            //Цикл CONTINUE
            //int age;
            //Console.Write("Введите ваш возраст: ");
            //age = Convert.ToInt32(Console.ReadLine());
            //while (age-- > 0)
            //{
            //    if (age == 8)
            //    {
            //        continue;//пропуск итераций. При вводе числа, всегда выведет на 1 меньше
            //    }
            //    Console.WriteLine(age);
            //}
            //Цикл FOR
            //for (int i = 0; i < 4; i++) //прибавление двойки i += 2
            //{
            //    Console.WriteLine(i);
            //}

            //int age;
            //Console.Write("Введите ваш возраст: ");
            //age = Convert.ToInt32(Console.ReadLine());
            //for (int i = 0; i <= age; i++)
            //{
            //    Console.WriteLine($"С днём рождения! Вам исполнилось {i} лет.");
            //}

            //for (int i = 0; i < 100; i += 2)
            //{ 
            //    if (i == 0) 
            //    {
            //        continue;
            //    }
            //Console.WriteLine(i);//выведет все чётные числа начиная с 2 до 98
            //}


            //int triesCount = 5;
            //string password = "123456";
            //string userInput;
            //for (int i = 0; i < triesCount; i++) 
            //{
            //    Console.WriteLine("Введите пароль: ");
            //    userInput = Console.ReadLine();
            //    if (userInput == password)
            //    {
            //        Console.WriteLine("Вы в системе!");
            //        break;//в случае успешного ввода пароля, прекращаем цикл
            //    }
            //    else
            //    {
            //        Console.WriteLine("Введен неверный пароль!");
            //        Console.WriteLine($"У вас осталось попыток: " + (triesCount - (i + 1)));//+1 чтобы было не x-0 попыток, а x-1
            //    }
            //}


            //float money;
            //int years;
            //int percent;
            //Console.Write("Введите количество денег, внесенных на вклад: ");
            //money = Convert.ToSingle(Console.ReadLine());
            //Console.Write("На сколько лет открыть вклад? ");
            //years = Convert.ToInt32(Console.ReadLine());
            //Console.Write("Под какой процент открыть вклад? ");
            //percent = Convert.ToInt32(Console.ReadLine());
            //for (int i = 0; i < years; i++) 
            //{
            //    money += money / 100 * percent;
            //    Console.WriteLine("В этом году у вас " + money);
            //    Console.ReadKey();//по нажатию клавиши
            //}


            //int playerHealth = 100;
            //int playerDamage = 5;
            //int enemyHealth = 50;
            //int enemyDamage = 10;//Ничья
            //while (playerHealth > 0 && enemyHealth > 0)
            //{
            //    playerHealth -= enemyDamage;
            //    enemyHealth -= playerDamage;
            //    Console.WriteLine(playerHealth + " игрок.");
            //    Console.WriteLine(enemyHealth + " противник.");
            //}
            //if (playerHealth <= 0 && enemyHealth <= 0)
            //{
            //    Console.WriteLine("Ничья. :|");
            //}
            //else if (enemyHealth <= 0)
            //{
            //    Console.WriteLine("Победа игрока! :)");
            //}
            //else if (playerHealth <= 0)
            //{
            //    Console.WriteLine("Победа противника! :(");
            //}
        }
    }
}
