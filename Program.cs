using System;

namespace AlgorithmWorkout
{
    using AlgorithmWorkout.DynamicProgramming;
    class Program
    {
        static void Main(string[] args)
        {
            MinCost minCost = new MinCost();
            Console.WriteLine(minCost.GetMinCost());
        }
    }
}
