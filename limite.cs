using System;
using System.Diagnostics;

namespace limite
{
    class Program
    {
        static void Main(string[] args)
        {
            var cron = new Stopwatch();
            cron.Start();
            int[] arreglo = new int[900000000];

            for (int i = 0; i < 100000000; i++)
            {
                ultimo(arreglo);
            }

            cron.Stop();
            Console.WriteLine("Tiempo: " + cron.ElapsedMilliseconds + " ms");

        }

        static public int[] primero(int[] Array)
        {
            Array[0] = 1;
            return Array;
        }

        static public int[] ultimo(int[] Array)
        {
            Array[Array.Length - 1] = 1;
            return Array;
        }
    }
}
