using System;
using System.Collections.Generic;
using System.Linq;

namespace ConsoleApp1
{
    internal class FirstAlgo: FirstNumber, IAlgorithms
    {
        public int Calculate(IEnumerable<int> numbers)
        {
            var first = GetFirst(numbers);
            return first;
        }        
    }
}
