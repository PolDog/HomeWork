void PrintNaturalsNumber(int min,int max,int n)
{
    if (n >=min )
    {
        PrintNaturalsNumber(min,max,n -1);
        Console.Write($"[{n}] ");
    }
}

System.Int64 AkkermanFunction(System.Int64 n, System.Int64 m)
{
    
    while (n != 0)
    {
        if (m == 0)
        {
            m = 1;
        }
        else
        {
            m = AkkermanFunction(n, m - 1);
        }
        n = n - 1;
    }
    return m + 1;  
    
    
}

void PrintNormal(int[] num, int i)
{
    if (i >=0)
    {
        PrintNormal(num, i - 1);
        Console.Write($"[{num[i]}] ");
    }
}

void PrintRevers(int[] num, int i)
{
    if (i < num.Length)
    {
        PrintRevers(num, i + 1);
        Console.Write($"[{num[i]}] ");
    }
}
//==============================================================================
Console.WriteLine();
Console.WriteLine("---=== Задача 1 ===---");
int min = 1;
int max = 15;
int num = max;
Console.WriteLine($"Значение min= {min}");
Console.WriteLine($"Значение max= {max}");
PrintNaturalsNumber(min, max,num);
Console.WriteLine();
Console.WriteLine();
//==============================================================================
Console.WriteLine("---=== Задача 2 ===---");
System.Int64 n = 3;
System.Int64 m = 1 ;
Console.WriteLine($"Значение функции Аккермана для n={n} и m={m} состовляет {AkkermanFunction(n, m)}");
Console.WriteLine();
//==============================================================================
Console.WriteLine("---=== Задача 3 ===---");
int[] numbers = { 10, 20, 30, 40, 50, 60 };
Console.WriteLine($"Заданный массив:");
PrintNormal(numbers, numbers.Length-1);
Console.WriteLine();
Console.WriteLine($"Реверсивный массив:");
PrintRevers(numbers,0);

