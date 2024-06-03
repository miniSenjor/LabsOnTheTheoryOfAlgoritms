using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace alDijkstra
{
    internal class Node
    {
        public int number;
        public List<Node> children = new List<Node>();
        public List<Edge> edgesChilds = new List<Edge>();
        public int pathLength;
        public Node(int number) 
        {
            this.number = number;
            pathLength = -1;
        }
    }
}
