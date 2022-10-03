// Программа, которая принимает на вход число N и выдает произведение чисел от 1 до N

Console.Clear();
 
Console.Write("Введите число N: ");
int n = int.Parse(Console.ReadLine()!);

int result = 1;

for (int i = 1; i <= n; i++)
{
    result *= i;
}

Console.Write($"Произведение чисел от 1 до {n} равна {result}");