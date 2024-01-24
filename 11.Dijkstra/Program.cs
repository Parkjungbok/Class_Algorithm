using System.IO;

namespace _11.Dijkstra
{
    internal class Program
    {
        const int INF = 99999;
        static void Main(string[] args)
        {
            int[,] graph =
            {//    0    1    2    3    4    5    6    7    8    9    10   11   12   13   14   15   16   17
                { INF,   6,   6, INF, INF, INF, INF,   7, INF, INF, INF, INF, INF, INF, INF, INF, INF, INF }, 
                {   6, INF, INF, INF, INF,   9, INF, INF, INF, INF, INF, INF, INF, INF, INF, INF, INF, INF }, 
                {   6, INF, INF,   7, INF, INF,   8, INF, INF, INF, INF, INF, INF, INF, INF, INF, INF, INF }, 
                { INF, INF,   7, INF, INF, INF, INF, INF, INF, INF, INF, INF, INF, INF, INF, INF, INF,   3 }, 
                { INF, INF, INF, INF, INF,   2, INF,   7,   8, INF, INF, INF, INF, INF, INF, INF, INF, INF }, 
                { INF,   9, INF, INF,   2, INF,   1, INF, INF,   2, INF, INF, INF, INF, INF, INF, INF, INF }, 
                { INF, INF,   8,   8, INF,   1, INF, INF, INF,   2,   8, INF, INF, INF, INF, INF, INF, INF }, 
                {   7, INF, INF, INF,   7, INF, INF, INF,   4, INF, INF,   5, INF, INF,   5, INF, INF, INF }, 
                { INF, INF, INF, INF,   8, INF, INF,   4, INF,   3, INF, INF,   4, INF, INF, INF, INF, INF }, 
                { INF, INF, INF, INF, INF,   2,   2, INF,   3, INF,   5, INF,   1, INF, INF, INF, INF, INF }, 
                { INF, INF, INF, INF, INF, INF,   8, INF, INF,   5, INF, INF, INF, INF, INF, INF, INF,   7 }, 
                { INF, INF, INF, INF, INF, INF, INF,   5, INF, INF, INF, INF, INF, INF,   3, INF, INF, INF }, 
                { INF, INF, INF, INF, INF, INF, INF, INF,   4,   1, INF, INF, INF, INF, INF,   4,   7, INF }, 
                { INF, INF, INF, INF, INF, INF, INF, INF, INF, INF, INF, INF, INF, INF, INF, INF,   1, INF }, 
                { INF, INF, INF, INF, INF, INF, INF,   5, INF, INF, INF,   3, INF, INF, INF,   2, INF, INF }, 
                { INF, INF, INF, INF, INF, INF, INF, INF, INF, INF, INF, INF,   4, INF,   2, INF,   3,   6 },
                { INF, INF, INF, INF, INF, INF, INF, INF, INF, INF, INF, INF,   7,   1, INF,   3, INF, INF },
                { INF, INF, INF,   3, INF, INF, INF, INF, INF, INF,   7, INF, INF, INF, INF,   6, INF, INF }, 

            };

            Dijkstra.ShortestPath(graph, 0, out bool[] visited, out int[] distance, out int[] parents);

            Console.WriteLine("<Dijkstra>");
            PrintDijkstra(distance, parents);

        }

        private static void PrintDijkstra(int[] distance, int[] path)
        {
            Console.WriteLine($"{"Vertex",8}{"Visit",8}{"Path",8}");

            for (int i = 0; i < distance.Length; i++)
            {
                Console.Write($"{i,8}");

                if (distance[i] >= INF)
                    Console.Write($"{"INF",8}");
                else
                    Console.Write($"{distance[i],8}");

                if (path[i] < 0)
                    Console.WriteLine($"{"X",8}");
                else
                    Console.WriteLine($"{path[i],8}");
            }
        }
    }
}
