// Двумекрные массивы
Console.WriteLine("Choose Task");
Console.WriteLine("Task 1: 2D array with random numbers");
Console.WriteLine("Task 2: 2D array where value = m + n");
Console.WriteLine("Task 3: 2D array, if number is odd - make it square");
Console.WriteLine("Task 4: 2D array, if main line - +sum");
int task = Convert.ToInt32(Console.ReadLine());

Console.WriteLine("Enter m and n");
int n = Convert.ToInt32(Console.ReadLine());
int m = Convert.ToInt32(Console.ReadLine());
int[,] array2d = new int[m, n];
switch (task)
{
    case 1:
        Task1();
        break;
    case 2:
        Task2();
        break;
    case 3:
        Task3();
        break;
    case 4:
        Task4();
        break;
    default:
        Console.WriteLine("There is no such task");
        break;
}

void Task1()
{
    Random random = new Random();
    for (int i = 0; i < m; i++)
    {
        for (int j = 0; j < n; j++)
        {
            array2d[i, j] = random.Next(-10, 10);
            Console.Write(array2d[i, j] + " ");
        }
        Console.WriteLine();
    }
}

void Task2()
{
    for (int i = 0; i < m; i++)
    {
        for (int j = 0; j < n; j++)
        {
            array2d[i, j] = i + j;
            Console.Write(array2d[i, j] + " ");
        }
        Console.WriteLine();
    }
}

void Task3()
{
    GetArray(array2d);
    for (int i = 0; i < m; i++)
    {
        for (int j = 0; j < n; j++)
        {
            if (i % 2 == 1 && j % 2 == 1)
                array2d[i, j] = Convert.ToInt32(Math.Pow(array2d[i, j], 2));
            Console.Write(array2d[i, j] + " ");
        }
        Console.WriteLine();
    }
}

void Task4()
{
    int sum = 0;
    GetArray(array2d);
    for (int i = 0; i < m; i++)
    {
        for (int j = 0; j < n; j++)
        {
            if (i == j)
                sum += array2d[i, j];
        }
    }
    Console.WriteLine(sum);
}

int[,] GetArray(int[,] array2d)
{
    for (int i = 0; i < m; i++)
    {
        string[] input = Console.ReadLine().Split(",", StringSplitOptions.RemoveEmptyEntries);
        for (int j = 0; j < n; j++)
        {
            array2d[i, j] = Convert.ToInt32(input[j]);
        }
    }
    return array2d;
}