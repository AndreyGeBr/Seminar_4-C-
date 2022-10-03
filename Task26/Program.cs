// Программа, которая принимает на вход число и выдает количество цифр в числе

Console.Clear();
 
Console.Write("Введите число: ");
int a = Math.Abs(int.Parse(Console.ReadLine()!));
CountNumbers ();

void CountNumbers ()
{
    int current = a;
    int count = 0;
    while (current > 0)
    {
        current = current / 10;
        count++;
    }
    Console.WriteLine($"Количество цифр в числе {a} равно {count}");
}



