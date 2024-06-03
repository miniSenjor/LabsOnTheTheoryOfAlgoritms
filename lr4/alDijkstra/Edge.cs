using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace alDijkstra
{
    internal class Edge : IComparable<Edge>
    {
        public int node1, node2, length;
        public Edge(int ver1, int ver2, int length)
        {
            this.node1 = ver1;
            this.node2 = ver2;
            this.length = length; 
        }
        public int CompareTo(Edge other)
        {
            if (other == null) return 1;
            return length.CompareTo(other.length);
        }
    }
}
