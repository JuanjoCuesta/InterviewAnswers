using System;
using System.Collections.Generic;
using System.Linq;

namespace ConsoleApp1
{
    internal class AlgorithmFactory
    {
        // Gets the instance based on the algorithm name
        public IAlgorithms getInstance(string algorithmName)
        {
            algorithmName = algorithmName.ToUpper();
            switch (algorithmName)
            {
                case "MIN":
                    return new MinAlgo();
                case "MAX":
                    return new MaxAlgo();
                case "MEAN":
                    return new MeanAlgo();
                case "FIRST":
                    return new FirstAlgo();
                case "LAST":
                    return new LastAlgo();
                default:
                    Console.WriteLine("This algorithm is not implemented.");
                    throw new NotImplementedException();
            }
        }

        // List with all the available algorithms in the current programm
        public List<string> getExistingAlgorithms()
        {
            var list = new List<string> { "MIN", "MAX", "MEAN", "FIRST", "LAST" };
            return list;

        }
    }
}