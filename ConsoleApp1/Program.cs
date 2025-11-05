using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.AccessControl;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Console.WriteLine("Привет, мир!");
            //Console.ReadKey();



            ////Основные типы int | float | char | string | bool
            ////Целочисленные типы
            //byte b; // 0 до 255
            //sbyte sb; // -128 до 127
            //short s; //-32768 до 32767
            //ushort us; // 0 до 65535
            //int i; // 02147483648 до 02147483647
            //uint ui; // 0 до 4294672295
            //long l; // long.MaxVelue; long.MixVelue; 0 до 9223372036854775801 
            //ulong ul; //
            ////С плавающей точкой 
            //float f; //до 7 знаков после запятой. Всегда =5.7f
            //double d; //до 15 знаков после запятой. =5.7
            ////Символьный тип
            //char c = 'T'; // ' ';
            ////Строковый тип
            //string str = "Привет!";
            ////Логический тип
            //bool bl;
            //int age = 27; // int age; age = 27;
            //age = 10;



            //// + - * / %
            //float result;
            //int x, y;
            //x = 5;
            //y = 2;
            //result = Convert.ToSingle(x) / y; //Тогда результат будет дробный. Всегда конвертим только 1 из чисел
            //Convert.ToSingle - преобразует заданное значение в число с плавающей запятой одиночной точности
            //Console.WriteLine(result);

            //int timeInMinutes = 130;
            //int hour;
            //int minute;
            //hour = timeInMinutes / 60;
            //minute = timeInMinutes % 60;
            //Console.WriteLine("hours: " + hour);
            //Console.WriteLine("minutes: " + minute); // hours 2; minute 10

            //int age = 18;
            //age = age + 1; //age++; age+=1; age -=1; age *=2; age /=3;

            //int result = 5 + 12 - 5 * 3 - 1 + 5 * 2; //11
            //int result = 5 + (12 - 5) * 3 - 1 + 5 * 2; //35
            // Console.WriteLine(result);



            //// Логические операции == != > >= < <=
            //int age = 18;
            //bool accessIsAllowed;
            //accessIsAllowed = age >= 18;
            //Console.WriteLine(accessIsAllowed); //True

            //bool accessIsAllowed;
            //accessIsAllowed = 5 == 4;
            //Console.WriteLine(accessIsAllowed); //False



            //string greeting = "Привет";
            //string name = "Карина";
            //string message = greeting + ", " + name;
            //Console.WriteLine(message +", рад тебя видеть!");// Привет, Карина, рад тебя видеть!
            //int age = 5;
            //Console.WriteLine("Завтра тебе будет: " + age + 1);//конкатенация текста, age и 1 - получится Завтра тебе будет: 51;
            //Console.WriteLine("Завтра тебе будет: " + (age +1));//получится Завтра тебе будет: 6;


            //int age = 27;
            //string name = "Карина";
            //Console.WriteLine("Ваше имя: " + name + ". Вам " + age + " лет!");// Ваше имя: Карина. Вам 27 лет!
            //Console.WriteLine($"Ваше имя: {name}. Вам {27} лет!");// Ваше имя: Карина. Вам 27 лет! - Интерполяция

            //int age;
            //string input = "15";
            //age = Convert.ToInt32(input);
            //Console.WriteLine(age);// 15


            //float result;
            //int x = 5;
            //int y = 2;
            //result = Convert.ToSingle(x) / y;
            //Console.WriteLine(result);// 2,5

            //int trigger = 1;
            //bool triggerInBoolen = Convert.ToBoolean(trigger);
            //Console.WriteLine(triggerInBoolen);// True
            //Console.WriteLine(trigger);// 1

            //int reconvert = Convert.ToInt32(triggerInBoolen);
            //Console.WriteLine(reconvert);// 1



            ////Работа с консолью
            ////Console.WriteLine();
            ////Console.ReadKey();// вывод и ожидание нажатия клавиши
            ////Console.Write();
            ////Console.ReadLine();// ожидание ввода целой строки
            //Console.InputEncoding = Encoding.Unicode;//для написания текста в консоли кириллицей можно ещё UTF8
            //Console.OutputEncoding = Encoding.Unicode;
            //string name;
            //Console.Write("Введите Ваше имя: ");
            //name = Console.ReadLine();// запись в консоль текста
            //Console.WriteLine($"Ваше имя: {name}");// при наборе текста латиницей
            //int age;
            //Console.WriteLine("Введите Ваш возраст: ");
            //age = Convert.ToInt32(Console.ReadLine());
            //Console.WriteLine($"Вам {age} лет: ");



            ////Инкремент, декремент имеют высший приоритет - то есть скобки в выражении
            //int i = 0;
            //i++; //инкремент увеличивает на 1 (в постфиксной форме!!!) сначала возвращает значение, затем делает операцию
            //i--; //декремент увеличивает на 1
            //Console.WriteLine(i);

            //int i = 0;
            ////++i; // префиксная форма инкремента - сначала выполняет операцию, а затем возвращает значение
            //Console.WriteLine(++i); //i++ будет 0; ++i будет 1

            //int A = 0;
            ////                  1 + 2 + 1 + 1   + "1" + 2+1 * 2 = 516
            //Console.WriteLine(++A + 2 + 1 + A++ + "1" + ++A * 2);// ((++A) + 2 + 1 + (A++) + "1" + (++A) * 2)



            //int health;
            //int armor;
            //int damage;
            //int percentConverter = 100; // для перевода armor в проценты, чтобы получить процент от урона
            //Console.Write("Введите кол-во здоровья: ");// Ctrl+D вставляет по множеству строк
            //health = Convert.ToInt32(Console.ReadLine());
            //Console.Write("Введите кол-во брони: ");
            //armor = Convert.ToInt32(Console.ReadLine());
            //Console.Write("Введите кол-во урона: ");
            //damage = Convert.ToInt32(Console.ReadLine());
            //health -= damage * armor / percentConverter;
            //health -= damage / percentConverter * armor; //int на int не делится, поэтому Convert.ToSingle(damage) и float health
            //Console.WriteLine($"Вам нанесли {damage} урона. У Вас осталось {health} здоровья.");


            int money;
            int food;
            int foodUnitPrice = 10;
            bool isAbleToPay;
            Console.WriteLine("Добро пожаловать в пекарню! Сегодня еда по " + foodUnitPrice + " монет.");
            Console.Write("Сколько у Вас золота? ");// Пишем что будет в консоли
            money = Convert.ToInt32(Console.ReadLine());// конвертируем money в int32 и даём возможность ввода в консоль
            Console.Write("Сколько еды Вам нужно? ");
            food = Convert.ToInt32(Console.ReadLine());
            isAbleToPay = money >= food * foodUnitPrice;// воз-сть заплатить = деньги * стоимость продуктов
            food *= Convert.ToInt32(isAbleToPay);// еда * воз-сть заплатить в виде числа
            money -= food * foodUnitPrice;// из денег вычитаем еду * стоимость еды
            Console.WriteLine($"У Вас в сумке {food} единиц еды и {money} монет.");








        }
    }
}
