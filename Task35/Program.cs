// Задайте одномерный массив из 123 случайных чисел. Найдите количество элементов массива, значения которых лежат в отрезке [10,99].

Console.Clear();

int size = 123;
int[] array = new int[size];
FillArray(array);
// PrintArray(array);
int c = GetCount(array);
Console.WriteLine($"Количество элементов массива в отрезке [10,99] равно {c}");

int GetCount(int[] num)
{
    int count = 0;
    for (int i = 0; i < num.Length; i++)
    {
        if (num[i] > 9 && num[i] < 100)
        count ++;
    }
    return count;
}


void FillArray(int[] num)
{
    Random random = new Random();
    for (int i = 0; i < num.Length; i++)
    {
        num[i] = random.Next(0, 201);
    }
} 

void PrintArray(int[] num)
{
    int count = num.Length;
    Console.Write("[");
    for (int i = 0; i < count; i++)
    {
        Console.Write(num[i]);
        if (i == count - 1)
            Console.WriteLine("]");
        else
            Console.Write(",");
    }
    Console.WriteLine();
} 
