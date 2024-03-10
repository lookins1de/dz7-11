string OutputNumbers(int m, int n)
{
    if (n == m)
        return $"{m}";
    return OutputNumbers(m, n - 1) + $", {n}";
}


Console.Clear();
Console.Write("Введите 1-e число: ");
int m = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите 2-e число: ");
int n = Convert.ToInt32(Console.ReadLine());
Console.WriteLine(OutputNumbers(m, n));

