using System;
using System.Collections.Generic;
using System.Linq;

namespace ConsoleApp1
{
    internal class MinAlgo: FirstNumber, IAlgorithms
    {
        public int Calculate(IEnumerable<int> numbers)
        {
            var min = GetFirst(numbers);
            foreach (var num in numbers)
            {
                if (num < min)
                {
                    min = num;
                }
            }

            return min;
        }
    }
}
