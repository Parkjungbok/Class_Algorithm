using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _240123.homework
{
    internal class Searching
    {
        public static void BFS(in bool[,] graph, int start, out bool[] e, out int[] j)
        {
            e = new bool[graph.GetLength(0)];
            j = new int[graph.GetLength(0)];

            for (int i = 0; i < graph.GetLength(0); i++)
            {
                e[i] = false;
                j[i] = -1;
            }

            SearchNode(graph, start, e, j);
        }

        public static void SearchNode(in bool[,] graph, int start, out bool[] e, out int[] j)
        {
            e[start] = true;
            for(int i = 0; i < graph.GetLength(0);i++)
            {
                if (graph[start, i] && !e[i])
                {
                    j[i] = start;
                    SearchNode(graph, start, e, j);
                }
            }
        }
    }
}
