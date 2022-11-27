using System;
using System.IO;
using System.Collections.Generic;

namespace DijkstraAlgorithmV2 //Dij-kstrer
{
    internal class Program
    {
        static Dictionary<string, Node> nodeDictionary = new Dictionary<string, Node>(); //Contains all the nodes
        static HashSet<string> unvisitedNodes = new HashSet<string>(); //Contains any unvisited nodes. HashSets don't allow duplicates
        static List<Route> routes = new List<Route>();

        static string startNode;
        static string endNode;

        static void Main(string[] args)
        {
            //Takes in the start and end node names
            Console.Write("Enter start node:\n>> ");
            startNode = Console.ReadLine();
            Console.Write("Enter end node:\n>> ");
            endNode = Console.ReadLine();

            //Set the start node cost to 0
            nodeDictionary[startNode].Cost = 0;
        }

        static void CheckNode(NodeQueue queue, string destNode)
        {
            if(queue.Count == 0) { return; } //Since the queue is empty, we can return to the program.

            foreach(Route route in routes.FindAll(rt => rt.From == queue.First.Value.Name)) //Find all routes departing from the first node in t'queue
            {

            }
        }

        static void LoadGraph()
        {
            if (!File.Exists("graph.csv"))
            {
                throw new FileNotFoundException("File not found");
            }

            //Load graph file
            string[] file = File.ReadAllLines("graph.csv");
            foreach(string s in file)
            {
                //Converts string into the contained parameters (from, to, cost)
                string[] param = s.Split(", ");
                var (from, to, dist) = (param[0], param[1], double.Parse(param[2]));

                //Adds any non-existing nodes to the dict
                if (nodeDictionary.ContainsKey(from)){ nodeDictionary.Add(from, new Node(from)); }
                if (nodeDictionary.ContainsKey(to)){ nodeDictionary.Add(to, new Node(to)); }

                //Adds the nodes to the HashTable as unvisited nodes. Duplicates are ignored
                unvisitedNodes.Add(from);
                unvisitedNodes.Add(to);

                //Add the route to the list of possible routes
                routes.Add(new Route(from, to, dist));
            }
        }
    }
}
