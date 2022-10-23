// Задача 23. Напишите программу, которая принимает на вход число (N) и выдаёт таблицу кубов чисел от 1 до N.
// 3 -> 1, 8, 27
// 5 -> 1, 8, 27, 64, 125

Console.Clear();

void Triple(int N)
{
    int i=1;
    while (i<=N)
    {           
        if (i<N)
        {
            Console.Write($"{Math.Pow(i,3)}, ");
        }
        if (i==N)
        {
            Console.Write($"{Math.Pow(i,3)}");
        }
        i++;
    }
}

Console.WriteLine("Введите число");
int number = Convert.ToInt32(Console.ReadLine());
if(number<=0)
{
    Console.ForegroundColor = ConsoleColor.DarkRed;
    Console.WriteLine("Пожалуйста, введите число от 1 и больше");
    Console.ResetColor();
}
Triple(number);
