using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _240124.homework
{
    internal class Dijkstra
    {
        const int INF = 99999;
        public static void shotpath(int[,] graph2, int start, out bool[] visited, out int[] parent, out int[] distance)
        {
            int size = graph2.GetLength(0);
            visited = new bool[size];
            parent = new int[size];
            distance = new int[size];

            for (int i = 0; i < size; i++)
            {
                visited[i] = false;
                distance[i] = INF;
                parent[i] = -1;
            }
            distance[start] = 0;

            for (int i = 0; i < size; i++)
            {
                
            }
        }
    }
}
