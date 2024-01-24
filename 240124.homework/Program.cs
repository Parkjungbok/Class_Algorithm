namespace _240124.homework
{
    internal class Program
    {
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

        const int INF = 99999;
        static void Main(string[] args)
        {
            int[,] graph2 =
            {//    0    1    2    3    4    5    6     
                { INF, INF, INF, INF, INF, INF, INF },
                { INF, INF, INF, INF, INF, INF, INF },
                { INF, INF, INF, INF, INF, INF, INF },
                { INF, INF, INF, INF, INF, INF, INF },
                { INF, INF, INF, INF, INF, INF, INF },
                { INF, INF, INF, INF, INF, INF, INF },
                { INF, INF, INF, INF, INF, INF, INF },
            };

            Dijkstra.shotpath(graph2, 0, out bool[] visited, out int[] distance, out int[] parents);

            Console.WriteLine("<Dijkstra>");
            PrintDijkstra(distance, parents);
        }
    }
}
