using System.Numerics;
using System.Runtime.Serialization.Formatters;
using System.Threading;
using System;
using System.Numerics;



internal class Program
{
    static void Main(string[] args)
    {
        long [] numbers = new long [10];
        Random random = new Random();
        for (long i = 0; i < numbers.Length; i++)
        {
            numbers[i] = random.Next(1, 101);
        }

        Thread[] threads = new Thread[numbers.Length];

        for (long i = 0; i < numbers.Length; i++)
        {
            long num = numbers[i];
            threads[i] = new Thread(() => CalculateFactorial(num));
            threads[i].Start();
        }
        foreach (var thread in threads)
            thread.Join();
        {
            Console.WriteLine("рахування закінчено");
        }
        static void CalculateFactorial(long num)
        {
            BigInteger Factorial = 1; 
            for (long i = 1; i <= num; i++)
            { Factorial *= i; }
            Console.WriteLine($"Факторіал числа: {num}! = {Factorial}");
        }

    }
}
