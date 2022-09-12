using System;

namespace PrintPerfectSquareList;

public static class Program
{
    public static void OnAll()
    {


        List<int> numbers = new()
        {
            1,
            2,
            3,
            4,
            5,
            6,
            7,
            8,
            9,
            10,
            11,
            12,
            13,
            14,
            15,
            16,
            17,
            18,
            19,
            20
        };

        foreach (int number in numbers)
        {
            double answer = Math.Pow(number, 2);
            Console.WriteLine($"{number} squared = {answer}");
        }
    }

    public static void Main(String[] args)
    {
        if (args == null)
        {
            throw new ArgumentNullException(nameof(args));
        }

        OnAll();
    }
}
