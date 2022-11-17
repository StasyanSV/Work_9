// Задайте значение N. Напишите программу, которая выведет все чётные числа в промежутке от N до 1. Выполнить с помощью рекурсии.
// N = 5 -> "4, 2"
// N = 8 -> "8, 6, 4, 2,"

void NumbersChoice(int num)
{
    if (num <= 1) return;
    else
    {
        if (num % 2 == 0)
        {
            Console.Write($"{num} ");
            NumbersChoice(num - 1);
        }
        else NumbersChoice(num - 1);
    }
}


Console.Write("Введите число N: ");
int number = int.Parse(Console.ReadLine()!);
NumbersChoice(number);
