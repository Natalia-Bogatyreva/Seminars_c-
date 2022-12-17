// Рекурсия.
// Задайте M и N. Вывести все натуральные чсила между ними.

Console.WriteLine("Введите числа:");
int m = Convert.ToInt32(Console.ReadLine());
int n = Convert.ToInt32(Console.ReadLine());

Numbers(m,n);

void Numbers(int m, int n)
{
    if (m>n)
    {
        return;
    }
    Console.WriteLine(m);
    m++;
    Numbers(m,n);
}

