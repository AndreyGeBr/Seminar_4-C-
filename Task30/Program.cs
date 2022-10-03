// Программа, которая принимает на вход число, создает массив данного размера, заполняет его нулями и единицами в случайном порядке и выводит в консоль

/* Console.Clear();
 
Console.Write("Введите размер массива: ");
int arrayLenght = int.Parse(Console.ReadLine()!);

int[] array = new int[arrayLenght];

FillArray(array);
PrintArray(array);

void FillArray(int[] array)
{
    Random randGenerator = new Random();
    for (int i = 0; i < array.Length; i++)
    {
        array[i] = randGenerator.Next(0,2);
    }
}

void PrintArray(int[] array)
{
    for (int i = 0; i < array.Length; i++)
    {
        Console.Write($"{array[i]} ");
    }
} */



Random random = new Random();
int size = random.Next(4, 10);
int[] numbers = new int[size];
Console.WriteLine ($"Размер массива {size}");
FillArray(numbers);
PrintArray(numbers);

void FillArray(int[] num)
{
    Random random = new Random();
    for (int i = 0; i < num.Length; i++)
    {
        num[i] = random.Next(0, 2);
    }
} 

void PrintArray(int[] num)
{
    for (int i = 0; i < num.Length; i++)
    {
        Console.Write($"{num[i]} ");
    }
}





