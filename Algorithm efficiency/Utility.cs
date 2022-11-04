using Algorithms;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Algorithm_efficiency
{
    public class Case
    {
        private int[] data;
        private string dataType;
        private string caseName;
        private ISorter[] algorithms;

        public Case(int[] data, string dataType, string caseName, ISorter[] algorithms)
        {
            this.data = data;
            this.dataType = dataType;
            this.caseName = caseName;
            this.algorithms = algorithms;
        }

        public string Launch()
        {
            string results = $"{caseName} (n = {data.Length}), {dataType} \n";
            foreach(var algorithm in algorithms)
            {
                results += new Benchmark(algorithm).Launch(data, 10) + "\n";
            }
            return results;
        }
    }
    public class Results
    {
        private double avg;
        private double deviation;
        private string algorithmName;
        public Results(double[] times, string algorithmName)
        {
            avg = times.Average();
            deviation = StandardDeviation(times);
            this.algorithmName = algorithmName;
        }
        public override string ToString()
        {
            return $"* {algorithmName}: t = {Math.Round(avg,6)} +/- {Math.Round(deviation,6)}";
        }

        private static double StandardDeviation(IEnumerable<double> sequence)
        {
            double result = 0;

            if (sequence.Any())
            {
                double average = sequence.Average();
                double sum = sequence.Sum(d => Math.Pow(d - average, 2));
                result = Math.Sqrt((sum) / sequence.Count());
            }
            return result;
        }
    }
}
