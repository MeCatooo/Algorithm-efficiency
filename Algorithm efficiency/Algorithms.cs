using System;

namespace Algorithm_efficiency
{
    public interface ISorter
    {
        public int[] Sort(int[] arr);
    }

    public class InsertionSort : ISorter
    {
        public int[] Sort(int[] arr)
        {
            var n = arr.Length;
            for (var i = 1; i < n; ++i)
            {
                var key = arr[i];
                var j = i - 1;

                while (j >= 0 && arr[j] > key)
                {
                    arr[j + 1] = arr[j];
                    j = j - 1;
                }

                arr[j + 1] = key;
            }

            return arr;
        }
    }

    public class MergeSort : ISorter
    {
        public int[] Sort(int[] arr)
        {
            return sort(arr, 0, arr.Length - 1);
        }

        private int[] merge(int[] arr, int l, int m, int r)
        {
            // Find sizes of two
            // subarrays to be merged
            var n1 = m - l + 1;
            var n2 = r - m;

            // Create temp arrays
            var L = new int[n1];
            var R = new int[n2];
            int i, j;

            // Copy data to temp arrays
            for (i = 0; i < n1; ++i)
                L[i] = arr[l + i];
            for (j = 0; j < n2; ++j)
                R[j] = arr[m + 1 + j];

            // Merge the temp arrays

            // Initial indexes of first
            // and second subarrays
            i = 0;
            j = 0;

            // Initial index of merged
            // subarray array
            var k = l;
            while (i < n1 && j < n2)
            {
                if (L[i] <= R[j])
                {
                    arr[k] = L[i];
                    i++;
                }
                else
                {
                    arr[k] = R[j];
                    j++;
                }

                k++;
            }

            // Copy remaining elements
            // of L[] if any
            while (i < n1)
            {
                arr[k] = L[i];
                i++;
                k++;
            }

            // Copy remaining elements
            // of R[] if any
            while (j < n2)
            {
                arr[k] = R[j];
                j++;
                k++;
            }

            return arr;
        }

        // Main function that
        // sorts arr[l..r] using
        // merge()
        private int[] sort(int[] arr, int l, int r)
        {
            if (l < r)
            {
                // Find the middle
                // point
                var m = l + (r - l) / 2;

                // Sort first and
                // second halves
                sort(arr, l, m);
                sort(arr, m + 1, r);

                // Merge the sorted halves
                merge(arr, l, m, r);
            }

            return arr;
        }
    }

    public class QuickSortClassical : ISorter
    {
        public int[] Sort(int[] arr)
        {
            return QuickSort(arr, 0, arr.Length - 1);
        }

        private int[] Swap(int[] arr, int i, int j)
        {
            var temp = arr[i];
            arr[i] = arr[j];
            arr[j] = temp;
            return arr;
        }

        /* This function takes last element as pivot, places
             the pivot element at its correct position in sorted
             array, and places all smaller (smaller than pivot)
             to left of pivot and all greater elements to right
             of pivot */
        private int Partition(int[] arr, int low, int high)
        {
            // pivot
            var pivot = arr[high];

            // Index of smaller element and
            // indicates the right position
            // of pivot found so far
            var i = low - 1;

            for (var j = low; j <= high - 1; j++)
                // If current element is smaller
                // than the pivot
                if (arr[j] < pivot)
                {
                    // Increment index of
                    // smaller element
                    i++;
                    Swap(arr, i, j);
                }

            Swap(arr, i + 1, high);
            return i + 1;
        }

        /* The main function that implements QuickSort
                    arr[] --> Array to be sorted,
                    low --> Starting index,
                    high --> Ending index
           */
        private int[] QuickSort(int[] arr, int low, int high)
        {
            if (low < high)
            {
                // pi is partitioning index, arr[p]
                // is now at right place
                var pi = Partition(arr, low, high);

                // Separately sort elements before
                // partition and after partition
                QuickSort(arr, low, pi - 1);
                QuickSort(arr, pi + 1, high);
            }

            return arr;
        }
    }

    public class QuickSort : ISorter
    {
        public int[] Sort(int[] arr)
        {
            Array.Sort(arr);
            return arr;
        }
    }
}