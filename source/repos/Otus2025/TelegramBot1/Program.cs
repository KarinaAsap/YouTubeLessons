namespace TelegramBot1
{
    class Program
    {
        static string version = "2.0";
        static List<string> listOfTasks = []; //список задач
        static string? userName; //может быть nullable, далее будет проверка на is null
        static bool botIsRunning = true;
        static string? input; //может быть nullable, хранит всю строку, как её ввёл пользователь
        static string? argument;
        static List<string> listOfAvailableCommands =
            [
            "/start",
            "/help",
            "/info",
            "/exit",
            "/statistic",
            "/addtask",
            "/showtask",
            "/removetask"
        ];
        static void Main(string[] args)
        {
            Console.WriteLine($"Добро пожаловать в бот!\n\rВам доступны команды:");
            listOfAvailableCommands.ForEach(c => Console.WriteLine(c));
            while (botIsRunning)
            {
                Console.WriteLine("Введите команду: ");
                input = Console.ReadLine();
                if (input is null || string.IsNullOrWhiteSpace(input)) //игнорируем пустые строки
                    continue;

                var parts = input.Split(' ', 2, StringSplitOptions.RemoveEmptyEntries);//разбиваем на команду и аргумент (максимум 2 части)
                var command = parts[0]; //команда до пробела, например: /echo
                argument = parts.Length > 1 ? parts[1] : ""; //введённое после /echo

                if (string.IsNullOrWhiteSpace(userName) && command != "/start" && command != "/exit") //проверка на пустое имя 
                {
                    Console.WriteLine("Пожалуйста, сначала введите имя через команду /start.");
                    continue; //пропускаем switch и ждём новую команду
                }

                switch (command)
                {
                    case "/start":
                        ProcessStart();
                        break;

                    case "/help":
                        ProcessHelp();
                        break;

                    case "/info":
                        ProcessInfo();
                        break;

                    case "/exit":
                        ProcessExit();
                        break;

                    case "/statistic":
                        ProcessStatistic();
                        break;

                    case "/echo":
                        ProcessEcho();
                        break;

                    case "/addtask":
                        ProcessAddTask();
                        break;

                    case "/showtask":
                        ProcessShowTask();
                        break;

                    case "/removetask":
                        ProcessShowTask();
                        ProcessRemoveTask();
                        break;

                    default:
                        Console.WriteLine("Неизвестная команда!");
                        break;
                }
            }
        }
        private static void ProcessStart()
        {
            while (true)
            {
                Console.WriteLine("Введите своё имя: ");
                userName = Console.ReadLine();
                if (!string.IsNullOrWhiteSpace(userName))
                    break; //если имя валидно — выходим

                Console.WriteLine("Имя не может быть пустым. Попробуйте снова.");
            }
            Console.WriteLine($"Приветствую, {userName}! Чем могу помочь?");
        }
        private static void ProcessHelp()
        {
            Console.WriteLine("Этот бот предназначен для отслеживания поступления телеметрии в систему. Для этого проверьте, что Вы ввели имя, после этого можно перейти в раздел /statistic.\nКоманда /start предназначена для знакомства с пользователем.\nКоманда /help описывает структуру телеграм-бота.\nКоманда /info показывает версию и дату создания телеграм-бота.\nКоманда /echo показывает введённый Вами текст.\nКоманда /addtask позволяет добавлять задачи в список.\nКоманда /showtask позволяет отобразить список всех добавленных задач.\nКоманда /removetask позволяет удалять задачи по номеру в списке.");
        }
        private static void ProcessInfo()
        {
            Console.WriteLine($"Версия ТГ-бота: {version}, дата создания: 17.11.2025");
        }
        private static void ProcessExit()
        {
            botIsRunning = false;
        }
        private static void ProcessStatistic()
        {
            Console.WriteLine("Статистика по источникам данных: ");
            Console.WriteLine("Источник 1: 95% параметров корректны и обновляются");
            Console.WriteLine("Источник 2: 95% параметров корректны и обновляются");
        }
        private static void ProcessEcho()
        {
            if (string.IsNullOrWhiteSpace(userName)) //статический метод, проверяющий строку на null, пустой или из пробелов
            {
                Console.WriteLine("Для команды /echo нужно имя. Введите его при помощи команды - /start");
                return; //выходим при отсутствии имени
            }
            if (string.IsNullOrWhiteSpace(argument))
            {
                Console.WriteLine("После команды /echo нужно написать текст");
                return; //выходим при отсутствии текста
            }
            Console.WriteLine($"{userName}, Вы сказали: {argument}");
        }
        private static void ProcessAddTask()
        {
            Console.WriteLine("Пожалуйста, введите описание задачи:");
            string? taskDescription = Console.ReadLine(); //может быть nullable, считываем ввод пользователя
            if (string.IsNullOrWhiteSpace(taskDescription))
            {
                Console.WriteLine("Пустую задачу добавить нельзя.");
                return; //выходим из метода после сообщения
            }
            listOfTasks.Add(taskDescription); //добавляем непустую задачу в список
            Console.WriteLine($"Задача \"{taskDescription}\" добавлена."); //экранирование кавычек через \"\"
        }
        private static void ProcessShowTask()
        {
            if (listOfTasks.Count == 0)
            {
                Console.WriteLine("Список задач пуст.");
            }
            Console.WriteLine("Ваши задачи:");
            for (int i = 0; i < listOfTasks.Count; i++)
            {
                Console.WriteLine($"{i + 1}. {listOfTasks[i]}"); //i начинается с 0, поэтому для “человеческого” номера пишем i + 1
            }
        }
        private static void ProcessRemoveTask()
        {
            Console.WriteLine("Введите номер задачи для удаления:");
            string? inputNumber = Console.ReadLine(); //читаем ввод как строку (может быть null)
            if (!int.TryParse(inputNumber, out int taskNumber)) //пытаемся безопасно преобразовать строку в число
            {
                Console.WriteLine("Нужно ввести число.");
                return;
            }
            int index = taskNumber - 1; //переводим номер задачи в индекс списка. Пользователь видит задачи с 1,2,3..., а в индексы 0,1,2...
            if (index < 0 || index >= listOfTasks.Count) //проверяем, что индекс в допустимых границах списка
            {
                Console.WriteLine("Задачи с таким номером нет.");
                return;
            }
            string removedTask = listOfTasks[index]; //запоминаем текст удаляемой задачи, чтобы показать его пользователю
            listOfTasks.RemoveAt(index); //удаляем задачу по индексу из списка
            Console.WriteLine($"Задача \"{removedTask}\" удалена."); //сообщаем пользователю, что именно было удалено
        }
    }
}