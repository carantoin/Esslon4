try
{
    Console.WriteLine("Введите трёхзначное число:");
    int a = int.Parse(Console.ReadLine());
    if (a < 100 || a > 999)
    {
        Console.WriteLine("Введите трёхзначное число!");
    }
    else
    {
        int n = (a % 100) * 10 + a / 100;
        Console.WriteLine($"n={n}");
    }
}
catch
{
    Console.WriteLine("Введите правильные данные!");
}