using System;
using System.Collections.Generic;
using System.Linq;

namespace Algorithm_efficiency
{
    public class Case
    {
        private readonly ISorter[] _algorithms;
        private readonly string _caseName;
        private readonly int[] _data;
        private readonly string _dataType;

        public Case(int[] data, string dataType, string caseName, ISorter[] algorithms)
        {
            _data = data;
            _dataType = dataType;
            _caseName = caseName;
            _algorithms = algorithms;
        }

        public string Launch()
        {
            var results = $"{_caseName} (n = {_data.Length}), {_dataType} \n";
            foreach (var algorithm in _algorithms) results += new Benchmark(algorithm).Launch(_data, 10) + "\n";
            return results;
        }
    }

    public class Results
    {
        private readonly string _algorithmName;
        private readonly double _avg;
        private readonly double _deviation;

        public Results(double[] times, string algorithmName)
        {
            _avg = times.Average();
            _deviation = StandardDeviation(times);
            _algorithmName = algorithmName;
        }

        public override string ToString()
        {
            return $"* {_algorithmName}: t = {Math.Round(_avg, 6)} +/- {Math.Round(_deviation, 6)}";
        }

        private static double StandardDeviation(IEnumerable<double> sequence)
        {
            double result = 0;

            if (!sequence.Any()) return result;
            var average = sequence.Average();
            var sum = sequence.Sum(d => Math.Pow(d - average, 2));
            result = Math.Sqrt(sum / sequence.Count());

            return result;
        }
    }
}