using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DijkstraAlgorithmV2
{
    internal class Node
    {
        public string Name { get; private set; }
        public double Cost { get; set; }
        public Node PreviousNode { get; set; }

        public Node(string name, double cost = int.MaxValue, Node prevNode = null)
        {
            Name = name;
            Cost = cost;
            PreviousNode = prevNode;
        }
    }
}
