class Program
{
    static void PrintNumbersFromNTo1(int n)
    {
        if (n < 1)
        {
            return;
        }
        else
        {
            Console.Write(n);
            if (n != 1)
            {
                Console.Write(", ");
            }
            PrintNumbersFromNTo1(n - 1);
        }
    }

    static void Main()
    {
        Console.Write("Введите значение N: ");
        int N = int.Parse(Console.ReadLine());

        Console.Write("Числа от " + N + " до 1: ");
        PrintNumbersFromNTo1(N);

        Console.WriteLine(); // Для перехода на новую строку в конце вывода.
    }
}