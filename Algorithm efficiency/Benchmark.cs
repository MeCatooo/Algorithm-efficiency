using Algorithms;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Algorithm_efficiency
{
    public class Benchmark
    {
        private ISorter algorithm;
        public Benchmark(ISorter algorithm)
        {
            this.algorithm = algorithm;
        }
        public TimeSpan Launch(int[] data)
        {
            var stopwatch = new Stopwatch();
            stopwatch.Restart();
            stopwatch.Start();
            algorithm.Sort(data);
            stopwatch.Stop();
            return stopwatch.Elapsed;
        }
        public Results Launch(int[] data, int times)
        {
            double[] results = new double[times];
            for (int i = 0; i < times; i++)
            {
                results[i] = Launch(data).TotalSeconds;
            }
            return new Results(results, algorithm.GetType().Name);
        }
    }
}
