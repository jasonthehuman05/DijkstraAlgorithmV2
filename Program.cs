using System;

namespace DijkstraAlgorithmV2 //Dij-kstrer
{
    internal class Program
    {
        static string startNode;
        static string endNode;

        static void Main(string[] args)
        {
            //Takes in the start and end node names
            Console.Write("Enter start node:\n>> ");
            startNode = Console.ReadLine();
            Console.Write("Enter end node:\n>> ");
            endNode = Console.ReadLine();
        }
    }
}
