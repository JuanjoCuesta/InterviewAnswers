using System;
using System.Collections.Generic;
using System.Linq;

namespace ConsoleApp1
{
    class Program
    {
        

        static void Main(string[] args)
        {
                       
            // Setup AlgorithmFactory and Lists
            List<IAlgorithms> algoList = new List<IAlgorithms>();
            List<AlgorithmResult> algoResults = new List<AlgorithmResult>();
            var algorithmFactory = new AlgorithmFactory();
            var list = RegisterAlgorithms(algorithmFactory);

            do
            {
                // Read in list of integers
                Console.WriteLine("Enter a list of integers (Space seperated)");
                var numbers = ReadNumbers();                

                // Pick an "algorithm" (min, max, mean, first, last). Assume that these "algorithms" are actually really complex algorithms that need to be abstracted away
                Console.Write("Enter chosen algorithm names seperated by a space (");
                
                // Loops the available algorithms for the user and prints them in the console
                foreach(var availableAlgo in list)
                {
                    Console.Write(availableAlgo + " ");
                }
                Console.WriteLine(")");
                var algorithmNames = ReadAlgorithmNames();

                // TODO: get the algorithms based on the entered names
                var i = 0;
                string[] names = new string[algorithmNames.Count()];
                foreach (var name in algorithmNames)
                {
                    // If the algorithm exists on the list, it gets the algorithm and it´s name
                    if (list.Contains(name.ToUpper()))
                    {
                        algoList.Add(algorithmFactory.getInstance(name));
                        names[i] = name;
                        i++;
                    }
                    else Console.WriteLine(name + " is not a valid algorithm.");
                }

                // TODO: run the algorithms
                int[] results = new int[algoList.Count()];
                i = 0;                
                // Calculates each algorithm, and saves the results with it´s name on the List
                foreach(var algorithm in algoList)
                {
                    results[i] = algorithm.Calculate(numbers);
                    algoResults.Add(new AlgorithmResult { algorithmName = names[i], algorithmResult = results[i]});
                    i++;                    
                }                

                // Show the result
                PrintResults(algoResults);

                Console.WriteLine("Quit? (Y/N)");
                if (Console.ReadLine().Trim().ToLower().Equals("y"))
                    break;
                else
                { 
                    // Clear Lists for new running of the programm
                    algoList.Clear();
                    algoResults.Clear();
                }
            }
            while (true);
        }

        static List<string> RegisterAlgorithms(AlgorithmFactory algorithmFactory)
        {
            
            // Creates a List with the available algorithms
            var list = algorithmFactory.getExistingAlgorithms();
            return list;
        }

        static void PrintResults(List<AlgorithmResult> results)
        {
            
            // Loops the List and prints the name and result of the algorithm
            foreach(var res in results)
            {
                Console.WriteLine(res.algorithmName + ": " + res.algorithmResult);
            }
        }

        static IEnumerable<int> ReadNumbers()
        {
            bool isInts = false;

            // Reads the input and captures each number separated by space
            IEnumerable<int> numbersSplitInput = GetUserInput();
            
            // Validates user input, if it´s wrong it asks for new integers
            while (!isInts)
            {
                try
                {
                    isInts = numbersSplitInput.All(i => i is int);
                }
                catch
                {
                    Console.WriteLine("The values entered in the console are not all integers. Please enter a new list of integers (space separated)");
                    numbersSplitInput = GetUserInput();
                }
                
                
            }
            

            return numbersSplitInput;
        }

        static IEnumerable<string> ReadAlgorithmNames()
        {
            var algorithmInput = Console.ReadLine();
            
            // Reads the input and captures each algorithm separated by space
            IEnumerable<string> algorithmSplitInput = algorithmInput.Split(new char[] { ' ' }, StringSplitOptions.RemoveEmptyEntries);
            
            return algorithmSplitInput;
        }

        static IEnumerable<int> GetUserInput()
        {
            var numbersInput = Console.ReadLine();
            IEnumerable<int> numbersSplitInput = numbersInput.Split(new char[] { ' ' }, StringSplitOptions.RemoveEmptyEntries).Select(int.Parse);

            return numbersSplitInput;
        }
    }
}
