using System;
using System.Collections.Generic;
using System.Linq;

namespace ConsoleApp1
{
    internal class MaxAlgo: FirstNumber, IAlgorithms
    {
        public int Calculate(IEnumerable<int> numbers)
        {
            var max = GetFirst(numbers);
            foreach (var num in numbers)
            {
                if (num > max)
                {
                    max = num;
                }
            }

            return max;
        }
    }
}

