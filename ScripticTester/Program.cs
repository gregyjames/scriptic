using System;
using System.Linq;
using System.Text;

namespace ScripticTester
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string[] arr = new[] {"gilbert","apple","beehive","zebra", "application","lion", "cockapoo","purple"};
            scriptic.Functions.Sorting.QuickSort(arr, 0, arr.Length - 1);
            foreach (var letter in arr)
            {
                Console.WriteLine(letter);
            }

            var arrByte = arr.Select(x => Encoding.Default.GetBytes(x));

            foreach (var word in arrByte)
            {
                var compressed = scriptic.Functions.Compression.CompressStream(word);
                var decompressed = scriptic.Functions.Compression.DecompressStream(compressed);
                Console.WriteLine("Original Length: {0} -> Compressed Length: {1} -> Decompressed Length: {2}", word.Length, compressed.Length, decompressed.Length);
            }

            Console.ReadLine();
        }
    }
}
