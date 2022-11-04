using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Generators
{

    public class Generator
    {
        public static int[] GenerateAlmostSorted(int size, int minVal, int shuffledProcent = 100)
        {
            var a = Enumerable.Range(minVal, size).ToArray();
            var rnd = new Random();
            int sortingPart = shuffledProcent == 0 ? 0 : a.Length * (shuffledProcent / 100);
            for (int i = 0; i < sortingPart; ++i)
            {
                int randomIndex = rnd.Next(a.Length);
                int temp = a[randomIndex];
                a[randomIndex] = a[i];
                a[i] = temp;
            }
            return a;
        }
        public static int[] GenerateRandom(int size, int minVal,int maxVal) => GenerateAlmostSorted(size, minVal, 100);
        public static int[] GenerateFewUniques(int size, int minVal, int maxVal)
        {
            int[] a = new int[size];
            var rnd = new Random();
            for (int i = 0; i < a.Length; i++)
            {
                a[i] = rnd.Next(minVal, maxVal);
            }
            return a;
        }
        public static int[] GenerateSorted(int size, int minVal, int maxVal)
        {
            int[] a = GenerateRandom(size, minVal, maxVal);
            Array.Sort(a);
            return a;
        }
        public static int[] GenerateReversed(int size, int minVal, int maxVal)
        {
            int[] a = GenerateSorted(size, minVal, maxVal);
            Array.Reverse(a);
            return a;
        }

    }
}
