using System;
using System.Diagnostics;

namespace Algorithm_efficiency
{
    public class Benchmark
    {
        private readonly ISorter _algorithm;

        public Benchmark(ISorter algorithm)
        {
            _algorithm = algorithm;
        }

        public TimeSpan Launch(int[] data)
        {
            var stopwatch = new Stopwatch();
            stopwatch.Restart();
            stopwatch.Start();
            _algorithm.Sort(data);
            stopwatch.Stop();
            return stopwatch.Elapsed;
        }

        public Results Launch(int[] data, int times)
        {
            var results = new double[times];
            for (var i = 0; i < times; i++) results[i] = Launch(data).TotalMilliseconds;
            return new Results(results, _algorithm.GetType().Name);
        }
    }
}