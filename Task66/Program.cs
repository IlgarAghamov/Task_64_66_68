class Program
{
    static void Main()
    {
        Console.Write("Введите значение M: ");
        int M = int.Parse(Console.ReadLine());

        Console.Write("Введите значение N: ");
        int N = int.Parse(Console.ReadLine());

        int sum = 0;

        for (int i = M; i <= N; i++)
        {
            sum += i;
        }

        Console.WriteLine("Сумма натуральных чисел от " + M + " до " + N + " равна " + sum);
    }
}