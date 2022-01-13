using System;

namespace Recursivitate2
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] vector = new int[] { 5, 6, 7, 8, 9 };
            Console.WriteLine(Recursivitate2.Maxim(vector, vector.Length -1, int.MinValue));
        }
    }
}
