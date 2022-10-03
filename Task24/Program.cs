// Программа, которая принимает на вход число A и выдает сумму чисел от 1 до A

Console.Clear();
 
Console.Write("Введите число А: ");
int a= int.Parse(Console.ReadLine()!);

int sum = 0;

for (int i = 1; i <= a; i++)
{
    sum += i;
}

Console.Write($"Сумма чисел от 1 до {a} равна {sum}");
