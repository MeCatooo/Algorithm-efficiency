using System;
using System.Linq;

namespace Algorithm_efficiency
{
    public class Generator
    {
        public static int[] GenerateAlmostSorted(int size, int minVal, int shuffledPercent = 100)
        {
            var array = Enumerable.Range(minVal, size).ToArray();
            for (var i = 0; i < array.Length * shuffledPercent / 100; i++)
            {
                var index1 = new Random().Next(0, array.Length);
                var index2 = new Random().Next(0, array.Length);
                (array[index1], array[index2]) = (array[index2], array[index1]);
            }

            return array;
        }

        public static int[] GenerateRandom(int size, int minVal, int maxVal)
        {
            return GenerateAlmostSorted(size, minVal);
        }

        public static int[] GenerateFewUniques(int size, int minVal, int maxVal)
        {
            var a = new int[size];
            var rnd = new Random();
            for (var i = 0; i < a.Length; i++) a[i] = rnd.Next(minVal, maxVal);
            return a;
        }

        public static int[] GenerateSorted(int size, int minVal, int maxVal)
        {
            var a = GenerateRandom(size, minVal, maxVal);
            Array.Sort(a);
            return a;
        }

        public static int[] GenerateReversed(int size, int minVal, int maxVal)
        {
            var a = GenerateSorted(size, minVal, maxVal);
            Array.Reverse(a);
            return a;
        }
    }
}