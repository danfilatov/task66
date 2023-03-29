Console.WriteLine("Введите M:");
int numM = int.Parse(Console.ReadLine());

Console.WriteLine("Введите N:");
int numN = int.Parse(Console.ReadLine());

void GapNumberSum (int numM, int numN, int sum)
{
    if (numM > numN) 
    {
        Console.WriteLine($"Сумма натуральных элементов в промежутке от {numM} до {numN}: {sum}"); 
        return;
    }
    sum = sum + (numM++);
    GapNumberSum(numM, numN, sum);
}

GapNumberSum(numM, numN, 0);