// На семинаре рассмотрели задачи по перевороту массива и варианты перевода числа из 10 в 2 систсемы исчесления.
// Два способа - через цикл и обратный вывод и через рекурсию.
Console.WriteLine("Input task");
int n = Convert.ToInt32(Console.ReadLine());
if (n == 1)
    Task1();
else if (n == 2)
    Task2();
else if (n == 3)
    Task3();
else if (n == 4)
    Task4();

void Task1()
{
    Console.WriteLine("Enter numbers with commas");
    string[] array = Console.ReadLine().Split(',', StringSplitOptions.RemoveEmptyEntries);
    Console.WriteLine(Triangle(Convert.ToInt32(array[0]), Convert.ToInt32(array[1]), Convert.ToInt32(array[2])));
}

void Task2()
{
    int number = Convert.ToInt32(Console.ReadLine());
    Console.WriteLine(number + " " + DecimalToBinary(number));
    RecursionDecToBin(number);
}

void Task3()
{
    Console.WriteLine("Enter the N");
    int n = Convert.ToInt32(Console.ReadLine());
    Fib(n);
}

void Task4()
{
    int[] array = new int[8];
    for (int i = 0; i < array.Length; i++)
    {
        array[i] = new Random().Next(-10, 10);
    }
    Console.WriteLine(String.Join(",", array));
    CopyArray(array);
}

bool Triangle(int a, int b, int c)
{
    if (a + b > c && a + c > b && b + c > a)
        return true;
    else return false;
}

string DecimalToBinary(int number)
{
    string output = "";
    while (number > 0)
    {
        output += number % 2;
        number /= 2;
    }
    char[] array = output.ToCharArray();
    Array.Reverse(array);
    return new String(array);
}

void RecursionDecToBin(int number)
{
    if (number == 0)
        return;
    RecursionDecToBin(number / 2);
    Console.Write(number % 2);
}

void Fib(int n)
{
    int firstNumber = 0;
    int secondNumber = 1;
    int res = 0;
    Console.WriteLine(firstNumber + " ");
    Console.WriteLine(secondNumber + " ");
    for (int i = 0; i < n - 2; i++)
    {
        res = firstNumber + secondNumber;
        firstNumber = secondNumber;
        secondNumber = res;
        Console.Write(res + " ");
    }
}

void CopyArray(int[] array)
{
    int[] copyArray = new int[array.Length];
    for (int i = 0; i < array.Length; i++)
    {
        copyArray[i] = array[i];
    }
    Console.WriteLine(string.Join(",", copyArray));
}