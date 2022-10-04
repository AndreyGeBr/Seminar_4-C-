// Найдите произведение пар чисел в одномерном массиве. 
//Парой считаем первый и последний элемент, второй и предпоследний и т.д. 
//Результат запишите в новом массиве.

Console.Clear();

int[] array = CreateArray();
FillArray(array);
PrintArray(array);
int[] arrayPr = Product(array);
PrintArray(arrayPr);





int[] CreateArray()
{
    //Random random = new Random();
    //int size = random.Next(4, 10);
    //int[] array = new int[size];
    int[] array = new int [new Random().Next(4, 10)];
    return array;
}

int[] Product(int[] num)
{
    int[] num2;
    if (num.Length % 2 == 0)
    {
        num2 = new int[num.Length / 2];
        for (int i = 0; i < num.Length/2; i++)
        {
            num2[i] = num[i]*num[num.Length - 1- i];
        }
    }
    else
    {
        num2 = new int[num.Length / 2 + 1];
        for (int i = 0; i < num.Length/2 + 1; i++)
        {
            if (i == num.Length / 2)
            num2[i] = num[i];
            else
            num2[i] = num[i]*num[num.Length - 1 - i];    
        }
    }
    return num2;
}

void FillArray(int[] num)
{
    Random random = new Random();
    for (int i = 0; i < num.Length; i++)
    {
        num[i] = random.Next(0, 11);
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
