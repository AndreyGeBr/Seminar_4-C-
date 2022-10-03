// Задайте массив. Напишите программу, которая определяет, присутствует ли заданное число в массиве.

Console.Clear();
 
Console.Write("Введите число: ");
int number = int.Parse(Console.ReadLine()!);
int[] array = CreateArray();

PrintArray(array);
if (FindNumber(array, number))
    Console.Write($"Число {number} присутствует в массиве");
else
    Console.Write($"Число {number} отсутствует в массиве");

bool FindNumber(int[] array, int number)
{
    for (int i = 0; i < array.Length; i++)
    {
        if (number == array[i])
        {
            return true;
        }
    } 
    return false;   
}

int[] CreateArray()
{
    int[] array = {6, 7, 19, 345, 3};
    return array;
}

void PrintArray(int[] array)
{
    int count = array.Length;
    Console.Write("[");
    for (int i = 0; i < count; i++)
    {
        Console.Write(array[i]);
        if (i == count - 1)
            Console.WriteLine("]");
        else
            Console.Write(",");
    }
    Console.WriteLine();
} 