using System;
using System.Collections.Generic;
using System.Linq;

namespace ConsoleApp1
{
    internal class LastAlgo: IAlgorithms
    {
        public int Calculate(IEnumerable<int> numbers)
        {
            var last = numbers.Last();
            return last;
        }
    }
}
