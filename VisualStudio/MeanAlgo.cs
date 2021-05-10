using System;
using System.Collections.Generic;
using System.Linq;

namespace ConsoleApp1
{
    internal class MeanAlgo: IAlgorithms
    {
        public int Calculate(IEnumerable<int> numbers)
        {
            var mean = (int)numbers.Average();
            return mean;
        }
    }
}
