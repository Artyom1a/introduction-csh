﻿// // // 1. Объявить оперменные и поменять в их значения три раза (string, int, bool, double)

// double peremenya;
// double peremenya1;
// peremenya1 = 4.0;
// peremenya = 2.0;
// peremenya = 3.0;
// peremenya += 2.0;
// peremenya = peremenya1 + peremenya;
// peremenya = -peremenya;
// // -------------
// string peremenya2;
// string peremenya3;
// peremenya3 = "tr";
// peremenya2 = "rt";
// peremenya2 = peremenya2 + peremenya3;
// peremenya2 += peremenya3;
// Console.WriteLine(peremenya2);
// Console.WriteLine("конкатенация+: " + peremenya2 + peremenya3);
// // -------------
// bool peremenya4;
// peremenya4 = true;
// peremenya4 = !true;
// Console.WriteLine(peremenya4);
// peremenya4 = true;
// Console.WriteLine(peremenya4);
// peremenya4 ^= peremenya4;
// Console.WriteLine(peremenya4);
// // -------------
// int peremenya10 = 5;
// peremenya10++;
// ++peremenya10;
// peremenya10 = peremenya10 + 1;
// Console.WriteLine(peremenya10);

// // 2. Произвести все все комбинации неявного преобразования (byte, int, long, float, double, decemel)
// byte peremenya5 = 1;
// int peremenya6 = peremenya5;
// long peremenya7 = peremenya6;
// float peremenya8 = peremenya7;
// double peremenya9 = peremenya8;


// // 3. Произвести все все комбинации явного преобразования (byte, int, long, float, double, decemel)
// byte peremenya11 = 1;
// int peremenya12 = (int)peremenya11;
// long peremenya13 = (long)peremenya12;
// float peremenya14 = (float)peremenya13;
// double peremenya15 = (double)peremenya14;
// decimal peremenya16 = (decimal)peremenya15;
// // 4. Ввести два числа, произвести арифметические над числами и записать результат в первое число (+, -, /, *, %)
// int number = Convert.ToInt32(Console.ReadLine());
// int number2 = Convert.ToInt32(Console.ReadLine());
// number = number + number2;
// number = number - number2;
// number = number / number2;
// number = number * number2;
// number = number % number2;
// 5. Ввести число и увеличить его на 1 всеми доступными способами
// 6. Ввести строку, если строка число найти остаток от деления на 5, в противном случае вывести сообщение, что введено не число
// 7. Ввести две строки, если строки числа вывести их сумму, в противном случае вывести сообщение какие строки не являются числом
// 8. Ввести два числа, если 1 число больше 2, то произвести деление 1 на 2, если 2 больше 1 вывести разность между 2 и 1, в противном случае вернуть 0.0 и результат увеличить на 10 (if-else, тернаный оператор)

// 9. Ввести две строки, если две строки числа то ввести арифметический оператор, b в зависисмоти от арфметического 
// оператора произвести то действие в проитивных случаях произвести вывод сообщений. Сделать проверку на null 
// оператора (if-else, switch, (-)сокращенный switch)
string? str = Console.ReadLine();
string? str1 = Console.ReadLine();
int irt;
int irt1;
if (int.TryParse(str, out irt) && int.TryParse(str1, out irt1))
{
    string? oper = Console.ReadLine();
    if (!String.IsNullOrEmpty(oper))
    {
        switch (oper)
        {
            case "+":
                Console.WriteLine(irt + irt1);
                break;
            case "-":
                Console.WriteLine(irt - irt1);
                break;
            case "/":
                Console.WriteLine(irt / irt1);
                break;
            case "*":
                Console.WriteLine(irt * irt1);
                break;
        }
    }
    else { Console.WriteLine("вы ввели не оператор"); }
}
else { Console.WriteLine("две строки is not числа"); }


// 10. Ввести две строку и произвести сложение данных строк всеми известными способами
// 11. Ввести строку до 5 символов, если строка число то вывести для кажкой цифры в числе кратно оно двум либо нет, то есть 6352 => 6 крастно двум, 3 не кратно двум, 5  не кратно двум, 2  крастно двум (if-else, тернаный оператор)
// 12. Ввести две строки, произвести проврку на пустоту, если строки имеют символы то если первая строка больше
//  второй вывести сумму длин строк, в противном случае разность 2 от первой 
//  (if-else, (-)тернаный оператор, *.Length, string.IsNullorEmpty)
// string? line1 = Console.ReadLine();
// string? line2 = Console.ReadLine();
// if (!String.IsNullOrEmpty(line1))
// {
//     if (!String.IsNullOrEmpty(line2))
//     {
//         if (line1.Length >= line2.Length)
//         { Console.WriteLine(line1.Length + line2.Length); }
//         else
//         { Console.WriteLine(line2.Length - line1.Length); }
//     }
//     else
//     { Console.WriteLine("Строка line2 null или empty"); }
// }
// else
// {
//     Console.WriteLine("Строка line1 null или empty");
// }