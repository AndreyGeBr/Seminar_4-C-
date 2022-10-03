// Task32
//Программа замены элементов массива: положительные элементы замените на соответствующие отрицательные и наоборот

int[] array = CreateArray();
PrintArray(array);
ReverseArray(array);
PrintArray(array);


int[] CreateArray()
{
    int[] array = {2, -5, -8, 4, 5};
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

void InverseArray(int[] array)
{
    for (int i = 0; i < array.Length; i++)
    {
        array[i] = - array[i];
    }
}