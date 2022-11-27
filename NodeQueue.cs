using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DijkstraAlgorithmV2
{
    internal class NodeQueue: LinkedList<Node> //The node queue will allow me to prioritise routes based on their lowest cost.
    {
        public void AddToQueue(Node node)
        {
            if(this.Count == 0) //If the queue is empty, we add the node to the start of the queue
            {
                this.AddFirst(node);
            }
            else //Find the nodes correct place in the queue
            {
                if(node.Cost >= this.Last.Value.Cost)//It is the most expensive node. Put it at the end
                {
                    this.AddLast(node);
                }
                else
                {
                    for(LinkedListNode<Node> listNode = this.First; listNode != null; listNode = listNode.Next)//Loop through until a more expensive
                                                                                                               //node is found, and add the current node
                                                                                                               //after it
                    {
                        if(node.Cost <= listNode.Value.Cost)
                        {
                            this.AddBefore(listNode, node);
                            break;
                        }
                    }
                }
            }
        }

        public bool ContainsNode(string nodeName) //Tests the queue to see if the inputted node is already queued to be tested. If it is not, it returns false
        {
            for (LinkedListNode<Node> cNode = this.First; cNode != null; cNode = cNode.Next)
            {
                if(cNode.Value.Name == nodeName) { return true; }
            }
            return false;
        }
    }
}
