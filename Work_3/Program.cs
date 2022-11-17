// Напишите программу вычисления функции Аккермана с помощью рекурсии. Даны два неотрицательных числа m и n.
// m = 2, n = 3 -> A(m,n) = 9
// m = 3, n = 2 -> A(m,n) = 29

Console.Clear();

int AkkermanFunc(int m, int n)
{
    if (m == 0) return n + 1;
    if (m > 0 && n == 0) return AkkermanFunc(m - 1, 1);
    if (m > 0 && n > 0) return AkkermanFunc(m - 1, AkkermanFunc(m, n - 1));
    return AkkermanFunc(m, n);
}

Console.Write("Введите число m: ");
int m = int.Parse(Console.ReadLine());
Console.Write("Введите число n: ");
int n = int.Parse(Console.ReadLine());
Console.WriteLine(AkkermanFunc(m,n));