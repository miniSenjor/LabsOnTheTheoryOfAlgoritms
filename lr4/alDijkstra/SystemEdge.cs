using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace alDijkstra
{
    internal class SystemEdge
    {
        public List<Edge> systemEdge;
        public List<int> systemVertex;

        public SystemEdge(Edge edge)
        {
            systemEdge = new List<Edge> { edge };
            systemVertex = new List<int>
            {
                edge.ver1,
                edge.ver2
            };
        }

        public void AddEdge(Edge edge)
        {
            systemEdge.Add(edge);
            if (!systemVertex.Contains(edge.ver1))
                systemVertex.Add(edge.ver1);
            if (!systemVertex.Contains(edge.ver2))
                systemVertex.Add(edge.ver2);
        }

        public bool Contains(int vertex)
        {
            return systemVertex.Contains(vertex);
        }
    }
}
