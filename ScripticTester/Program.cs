using System;
namespace ScripticTester
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] arr = new[] {"g","a","b","x"};
            scriptic.Functions.Sorting.Quick_Sort(arr, 0, arr.Length -1);
            foreach (var letter in arr)
            {
                Console.WriteLine(letter);
            }

            Console.ReadLine();
        }
    }
}
