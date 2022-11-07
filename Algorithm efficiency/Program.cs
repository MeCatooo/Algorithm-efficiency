using System;

namespace Algorithm_efficiency
{
    internal class Program
    {
        private static void Main(string[] args)
        {
            ISorter[] sorters = { new InsertionSort(), new MergeSort(), new QuickSortClassical(), new QuickSort() };


            Console.WriteLine("Przypadek 1: " + new Case(Generator.GenerateRandom(20, 0, 1000), "random",
                "próba mała", sorters).Launch());
            Console.WriteLine("Przypadek 2: " + new Case(Generator.GenerateSorted(20, 0, 1000), "sorted",
                "próba mała", sorters).Launch());
            Console.WriteLine("Przypadek 3: " + new Case(Generator.GenerateReversed(20, 0, 1000), "reversed",
                "próba mała", sorters).Launch());
            Console.WriteLine("Przypadek 4: " + new Case(Generator.GenerateAlmostSorted(20, 0, 50), "almost sorted",
                "próba mała", sorters).Launch());
            Console.WriteLine("Przypadek 5: " + new Case(Generator.GenerateFewUniques(20, 0, 10), "few unique",
                "próba mała", sorters).Launch()); 
            
            Console.WriteLine("Przypadek 6: " + new Case(Generator.GenerateRandom(2000, 0, 1000), "random",
                "próba średnia", sorters).Launch());
            Console.WriteLine("Przypadek 7: " + new Case(Generator.GenerateSorted(2000, 0, 1000), "sorted",
                "próba średnia", sorters).Launch());
            Console.WriteLine("Przypadek 8: " + new Case(Generator.GenerateReversed(2000, 0, 1000), "reversed",
                "próba średnia", sorters).Launch());
            Console.WriteLine("Przypadek 9: " + new Case(Generator.GenerateAlmostSorted(2000, 0, 50), "almost sorted",
                "próba średnia", sorters).Launch());
            Console.WriteLine("Przypadek 10: " + new Case(Generator.GenerateFewUniques(2000, 0, 10), "few unique",
                "próba średnia", sorters).Launch());
            
            Console.WriteLine("Przypadek 11: " + new Case(Generator.GenerateRandom(10000, 0, 1000), "random",
                "próba duża", sorters).Launch());
            Console.WriteLine("Przypadek 12: " + new Case(Generator.GenerateSorted(10000, 0, 1000), "sorted",
                "próba duża", sorters).Launch());
            Console.WriteLine("Przypadek 13: " + new Case(Generator.GenerateReversed(10000, 0, 1000), "reversed",
                "próba duża", sorters).Launch());
            Console.WriteLine("Przypadek 14: " + new Case(Generator.GenerateAlmostSorted(10000, 0, 50), "almost sorted",
                "próba duża", sorters).Launch());
            Console.WriteLine("Przypadek 15: " + new Case(Generator.GenerateFewUniques(10000, 0, 10), "few unique",
                "próba duża", sorters).Launch());

        }
    }
}