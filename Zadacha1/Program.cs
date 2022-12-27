// Задача 19
// Напишите программу, которая принимает на вход пятизначное число и проверяет, является ли оно палиндромом.
// 14212 -> нет
// 12821 -> да
// 23432 -> да
Console.WriteLine("Введите пятизначное число: ");
int number = Convert.ToInt32(Console.ReadLine());
int one = number / 10000; // 2 (25252)
int two = number / 1000 - one * 10;  // 25 - 2*10 = 5  (25252)
int four = (number % 100) / 10; // 52 /10 = 5    (25252)
int five = number % 10; //2 (25252)

if (number > 0)
{
    if (Convert.ToString(number).Length == 5)
    {
        if (one == five && two == four)
            Console.WriteLine("Чило палиндром");
        else
            Console.WriteLine("Чило не палиндром");
    }
    else
        Console.WriteLine("Это не пятизначное число.--");
}

else
{
    if (Convert.ToString(number).Length == 6)
    {
        if (one == five && two == four)
            Console.WriteLine("Чило палиндром");
        else
            Console.WriteLine("Чило не палиндром");
    }
    else
        Console.WriteLine("Это не пятизначное число. --");
}



