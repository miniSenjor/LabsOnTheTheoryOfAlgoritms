using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace alDijkstra
{
    public  class AlDijkstra
    {
        List<Node> nodes;
        List<Edge> edges;
        public AlDijkstra() 
        {
            nodes = new List<Node>() { };
            edges = new List<Edge>() { };
        }

        public int[,] DGVToArr(DataGridView dgv)
        {
            int i=0, n = dgv.Rows.Count - 1;
            int[,] graph = new int[n, n];
            for (i = 0; i < n-1; i++)
            {
                DataGridViewRow row = dgv.Rows[i];
                for (int j = i+1; j < n; j++)
                {
                    try
                    {
                        DataGridViewCell cell = row.Cells[j+1];
                        graph[i, j] = int.Parse(cell.Value.ToString());
                    }
                    catch
                    {
                        graph[i, j] = 0;
                    }
                }
            }
            return graph;
        }

        public void CreateGraph(int[,] graph)
        {
            nodes.Clear();
            edges.Clear();
            for (int i = 0; i < graph.GetLength(0)-1; i++)
            {
                for (int j = i+1; j<graph.GetLength(1); j++)
                {
                    if (graph[i, j] == 0)
                        continue;

                    Node nodeI, nodeJ;
                    if (!nodes.Any(n => n.number==i))
                    {
                        nodeI = new Node(i);
                        nodes.Add(nodeI);
                    }
                    else
                        nodeI = nodes.FirstOrDefault(n => n.number==i);
                    if (!nodes.Any(n => n.number==j))
                    {
                        nodeJ = new Node(j);
                        nodes.Add(nodeJ);
                    }
                    else
                        nodeJ = nodes.FirstOrDefault(n => n.number == j);

                    if (!nodeI.children.Any(n => n.number == j))
                        nodeI.children.Add(nodeJ);
                    if (!nodeJ.children.Any(n => n.number == i))
                        nodeJ.children.Add(nodeI);

                    Edge edge = new Edge(nodeI, nodeJ, graph[i, j]);
                    nodeI.edgesChilds.Add(edge);
                    nodeJ.edgesChilds.Add(edge);
                    edges.Add(edge);
                }
            }

        }

        public string Algorithm(int nodeStart, int nodeEnd)
        {
            int pathLength = 0;
            bool checkedEnd = false;

            List<Node> ND = nodes;
            if (!nodes.Any(n => n.number == nodeStart) || !nodes.Any(n => n.number == nodeEnd))
                return "Нет введенных вершин";

            Node nodeCurrent = nodes.FirstOrDefault(n => n.number == nodeStart);
            nodeCurrent.pathLength = 0;
            List<Node> notUsedNode = nodes;
            nodes.Remove(nodeCurrent);

            while (notUsedNode.Count > 0)
            {
                Console.WriteLine(nodeCurrent.number);
                foreach(Node n in nodeCurrent.children)
                {
                    if (!notUsedNode.Contains(n))
                        continue;

                    Edge edge = nodeCurrent.edgesChilds.First(e => e.node1.number == nodeCurrent.number && e.node2.number == n.number || e.node1.number == n.number && e.node2.number == nodeCurrent.number);
                    int currentPath = nodeCurrent.pathLength + edge.length;
                    if (n.pathLength == -1)
                        n.pathLength = currentPath;
                    else
                        if (n.pathLength < currentPath)
                            n.pathLength = currentPath;
                }
                notUsedNode.Remove(nodeCurrent);
                if (nodeCurrent.number == nodeEnd)
                {
                    checkedEnd = true;
                    pathLength = nodeCurrent.pathLength;
                    break;
                }
                nodeCurrent = notUsedNode.First();
                foreach (Node n in notUsedNode)
                {
                    if (n.pathLength == -1)
                        continue;
                    if (n.pathLength < nodeCurrent.pathLength)
                        nodeCurrent = n;
                }
            }
            if (!checkedEnd)
                return "1";

            string path = searchPathEndToStart(nodeCurrent, nodeStart, pathLength);
            if (path!=null)
            {
                path += $"длинна пути = {pathLength}";
                return path;
            }
            else
                return "Ошибка поиска пути";
        }

        private string searchPathEndToStart(Node nodeCurrent, int start, int pathLength)
        {
            if (nodeCurrent.number == start)
                return $"{start} ";
            foreach (Edge edge in nodeCurrent.edgesChilds)
            {
                Node child = edge.node1.number != nodeCurrent.number ? (edge.node1) : (edge.node2);
                if (child.pathLength == pathLength - edge.length)
                    return $"{searchPathEndToStart(child, start, child.pathLength)} {child.number}";
            }
            return null;
        }
    }
}
