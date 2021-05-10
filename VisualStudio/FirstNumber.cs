using System;
using System.Collections.Generic;
using System.Linq;

namespace ConsoleApp1
{
    public abstract class FirstNumber
    {        public virtual int GetFirst(IEnumerable<int> numbers)
        {
            var first = numbers.First();
            return first;

        }
    }
}
