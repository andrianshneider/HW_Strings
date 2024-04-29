using System.Xml.Linq;

internal class Program
{

    private static void Main(string[] args)
    {
        Console.WriteLine("Домашнее задание 'Коллекции'");
        Console.WriteLine("Выберите выполняемую задачу:");
        Console.WriteLine("1 - конкатенация, 2 - вывод имени и возраста, 3 - вывод информационной строки,");
        Console.WriteLine("4 - вывод первых пяти символов, 5 -объединение, 6 - поиск и замена:");
        Console.WriteLine("");

        //вызов метода (задачи), выбранной пользователем

        var TaskNumber = Console.ReadLine();

        //создание класса StringHW, содержащего методы для выполнения задач

        var stringHW = new HW_Strings.StringHW();


        switch (TaskNumber)
        {
            case "1":
                Console.WriteLine("Конкатенация строк:");
                Console.WriteLine("Введите первую строку:");
                var str1 = Console.ReadLine();
                Console.WriteLine("Введите вторую строку:");
                var str2 = Console.ReadLine();
                stringHW.Task1_ConcatenateStrings(str1, str2); //вызов метода класса для задачи 1
                break;

            case "2":
                Console.WriteLine("Вывод строки с именем и возрастом:");
                Console.WriteLine("Введите имя:");
                var str = Console.ReadLine();

                bool input;
                int age;

                do
                {
                    Console.WriteLine("Введите возраст (больше нуля):");
                    input = int.TryParse(Console.ReadLine(), out var value);
                    age = value;
                }
                while (!input | age <= 0); 

                stringHW.Task2_GreetUser(str, age);//вызов метода класса для задачи 2
                break;

            case "3":
                Console.WriteLine("Вывод информации о строке:");
                do
                {
                    Console.WriteLine("Введите строку:");
                    str = Console.ReadLine();
                }
                while (string.IsNullOrEmpty(str));

                stringHW.Task3_GetStringInfo(str);//вызов метода класса для задачи 3
                break;

            case "4":
                Console.WriteLine("Вывод первых 5 символов строки:");
                do
                {
                    Console.WriteLine("Введите строку:");
                    str = Console.ReadLine();
                }
                while (string.IsNullOrEmpty(str));
                Console.WriteLine($"Результат: { stringHW.Task4_GetSubstring(str)}");//вызов метода класса для задачи 4
                break;

            case "5":
                {
                    Console.WriteLine("Объединение массива строк в предложение:");
                    bool stop = false; //переменная для окончания цикла ввода строк в массив
                    
                    String[] ArrayOfStr = new string[1]; //массив строк

                    do
                    {
                        string strToArray;
                        do
                        {
                            Console.WriteLine("Введите строку для добавления в массив:");
                            strToArray = Console.ReadLine();
                        }
                        while (string.IsNullOrEmpty(strToArray));
                        ArrayOfStr[ArrayOfStr.Length-1] = strToArray;

                        Console.WriteLine("");
                        Console.WriteLine("Введите 1, чтобы добавить следующую строку, другое значения для прекращения ввода:");

                        var a = Console.ReadLine();

                        if (a == "1") { stop = false; Array.Resize(ref ArrayOfStr, ArrayOfStr.Length + 1); } else { stop = true; }
                    }
                    while (!stop);
                    Console.WriteLine(stringHW.Task5_ArrayToSentence(ArrayOfStr));//вызов метода класса для задачи 5
                }
                break;

            case "6":
                Console.WriteLine("Поиск и замена в строке:");
                string inputString;
                string wordToReplace;
                string replacementWord;

                //ввод строки
                do
                {
                    Console.WriteLine("Введите строку:");
                    inputString = Console.ReadLine();
                }
                while (string.IsNullOrEmpty(inputString));

                //ввод слова, подлежащего замене
                do
                {
                    Console.WriteLine("Введите заменяемое слово:");
                    wordToReplace = Console.ReadLine();
                }
                while (string.IsNullOrEmpty(wordToReplace));

                //ввод заменяющего слова
                do
                {
                    Console.WriteLine("Введите слово, на которое нужно заменить:");
                    replacementWord = Console.ReadLine();
                }
                while (string.IsNullOrEmpty(replacementWord));

                Console.WriteLine(stringHW.Task6_Replacement(inputString, wordToReplace, replacementWord));//вызов метода класса для задачи 6

                break;

            default:
                Console.WriteLine("Введено некорректное значение, попробуйте еще раз.");
                break;
        }
    }
}