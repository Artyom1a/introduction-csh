﻿internal class Program
{
    static void Main(string[] args)
    {
        Task1();
        Task2();
        Task3();
        Task4();
        Task5();
    }

    #region Задача1
    // Пользователь вводит имя и фамилию. Необходимо создать метод возвращающую строку вида «Привет, {имя} {фамилия}»
    static void Task1()
    {
        System.Console.WriteLine("введите имя");
        string? name = Console.ReadLine();
        System.Console.WriteLine("введите фамилию");
        string? lastname = Console.ReadLine();
        System.Console.WriteLine(HelloMethod(name, lastname));
    }
    static string HelloMethod(string name, string lastname)
    {
        return $"Привет, {name} {lastname}";
    }
    #endregion

    #region Задача 2
    // 2.Напишите метод, который принимает строку в маленьком регистре и возаращает
    // строку, где каждое слово начинается с большого регистра
    // hschool company --> Hschool C ompany
    static void Task2()
    {
        string? str = Console.ReadLine();
        System.Console.WriteLine(ConverterString(str));
    }
    static string ConverterString(string line)
    {
        string[] array1 = line.Split(' ');
        for (int i = 0; i < array1.Length; i++)
        {
            string text = array1[i];
            // преобразования текста 
            text = char.ToUpper(text[0]) + text.Remove(0, 1);
            array1[i] = text;
        }
        return string.Join(' ', array1);

    }
    #endregion

    #region Задача 3 
    // 3. Напишите метод, который принимает статичный массив строк. Необходимо отфильтровать значения и оставить только те, где длина строк до 2 символов.
    //  [“by”, “belarus”, “de”, “ru”, “germany”] -> [“by”, “de”, “ru”]
    static void Task3()
    {
        string[] text = { "by", "belarus", "de", "ru", "germany" };
        Console.WriteLine(string.Join(",", MethodReplace(text)));
    }
    static string[] MethodReplace(string[] text)
    {
        string[] result = new string[100];
        int i = 0;
        foreach (string item in text)
        {
            if (item.Length < 3)
            {
                result[i] += item;
                i++;
            }
        }
        return result;
    }
    #endregion
    #region Задача 4
    // 4. На входе массив. Реализовать метод проверки на то что 
    // в массиве только числа. Метод возвращает true, если в 
    // массиве  только числа и false в противном случае
    static void Task4()
    {
        object[] objs = { 1, 333, 4, "eg", 975 };
        bool result = MethodSearch(objs);
        System.Console.WriteLine(result);
    }
    static bool MethodSearch(object[] array)
    {
        bool reslut = false;
        for (int i = 0; i < array.Length; i++)
        {
            if (array[i] is int number)
            {
                reslut = true;
            }
            else
            {
                reslut = false;
                break;
            }
        }
        return reslut;
    }
    #endregion
    #region Task5 
    //      На входе n количество элементов массива (вводится с клавиатуры). Далее
    // производится заполнение массива с слуйчными числами. Реализуйте два метода
    // для поиска минимального и максимального значения.
    static void Task5()
    {
        int numberareaarray = Convert.ToInt32(Console.ReadLine());
        int min1 = MinMaxarrayelement(numberareaarray);
        System.Console.WriteLine(min1);
    }
    static int MinMaxarrayelement(int numberareaarray)
    {
        int[] array1 = new int[numberareaarray];
        int min = array1[0];

        for (int i = 0; i < numberareaarray; i++)
        {
            array1[i] = new Random().Next();
            System.Console.WriteLine(array1[i]);
        }
        min = array1.Min();
        return min;
    }
    #endregion
}

