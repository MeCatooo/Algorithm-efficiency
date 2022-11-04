using System;
using Algorithms;
using Generators;

namespace Algorithm_efficiency
{
    internal class Program
    {
        static void Main(string[] args)
        {
            ISorter[] sorters = { new InsertionSort(), new MergeSort(), new QuickSortClassical(), new QuickSort() };
            var generator = new Generator();
            Console.Write("Przypadek 1: " + new Case(Generator.GenerateFewUniques(200000, 0, 1000), "posortowane", "Próba mała", sorters).Launch());
        }
    }
}
