﻿// 1.
// Ввести строку. Если эта равна “hschool”, вывести true. В противном случае false.
// Добавить проверки для строк . Удалить лишние пробелы

string? stroka = Console.ReadLine();
if (!string.IsNullOrEmpty(stroka))
{
    Console.WriteLine(stroka.ToLower().Trim() == "hschool");
}
else { Console.WriteLine("Вы ввели пустую строку"); }
// ______________________________________________________________________
// 2.Ввести строку. Проверить является ли это число или строка. Если число, то
// выяснить, четное или нет. Если это строка то преобразовать строку в массив, где
// каждый символ один элемент массива hschool ’ => [‘h’, ‘s’, ‘c’, ‘h’, ‘o’, ‘o’, ‘l’]
string? text = Console.ReadLine();
if (!string.IsNullOrEmpty(text))
{
    if (double.TryParse(text, out double number))
    {
        Console.WriteLine(number % 2 == 0 ? "чётное" : "не чётное");
    }
    else
    {
        string[] result = text.Split(".");
        Console.WriteLine(result.Length);
    }
}












