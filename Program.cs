using System;

namespace GamblingProblem
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Welcome to the gambling problem");
            GamblingSimulation gamblingSimulation = new GamblingSimulation();
            gamblingSimulation.WinOrLoose();
        }
    }
}
