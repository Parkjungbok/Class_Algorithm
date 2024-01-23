﻿namespace _10.Search
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // 순차탐색
            int[] array = new int []{ 1, 3, 4, 6, 4, 2, 5, 7, 0 };

            int indexOf = Array.IndexOf(array, 2);
            int result = Searching.SequentialSearch(array, 2);
            Console.WriteLine($"순차탐색 결과 위치 : {indexOf}");
            Console.WriteLine($"구현한 결과 위치 : {result}");


            // 이진탐색 (정렬되 있을때만 옳바르게 나옴)
            Console.WriteLine("정렬 전");
            int binarySearch;
            int result2;

            binarySearch = Array.BinarySearch(array, 2);
            result2 = Array.BinarySearch(array, 2);
            Console.WriteLine($"정렬 전 이진탐색 결과 : {binarySearch}");
            Console.WriteLine($"정렬 전 이진탐색 결과 : {result}");

            Array.Sort(array);

            Console.WriteLine("정렬 후");

            binarySearch = Array.BinarySearch(array, 2);
            result2 = Array.BinarySearch(array, 2);
            Console.WriteLine($"정렬 전 이진탐색 결과 : {binarySearch}");
            Console.WriteLine($"정렬 전 이진탐색 결과 : {result}");

            // 그래프 탐색
            bool[,] graph = new bool[8, 8]
            {
                { false,  true, false, false, false, false, false, false },
                {  true, false,  true, false, false,  true, false, false },
                { false,  true, false, false,  true,  true, false, false },
                { false, false, false, false, false,  true, false, false },
                { false, false,  true, false, false, false,  true,  true },
                { false,  true,  true,  true, false, false, false, false },
                { false, false, false, false,  true, false, false, false },
                { false, false, false, false,  true, false, false, false },
            };

            // DFS 탐색
            bool[] dfsVisited;
            int[] dfsPath;
            Searching.DFS(in graph, 0, out dfsVisited, out dfsPath);
            Console.WriteLine("<DFS>");
            PrintGraphSearch(dfsVisited, dfsPath);
            Console.WriteLine();

            // BFS 탐색
            bool[] bfsVisited;
            int[] bfsPath;
            Searching.BFS(in graph, 0, out bfsVisited, out bfsPath);
            Console.WriteLine("<BFS>");
            PrintGraphSearch(bfsVisited, bfsPath);
            Console.WriteLine();

        }
        private static void PrintGraphSearch(bool[] visited, int[] path)
        {
            Console.WriteLine($"{"Vertex",8}{"Visit",8}{"Path",8}");

            for (int i = 0; i < visited.Length; i++)
            {
                Console.WriteLine($"{i,8}{visited[i],8}{path[i],8}");
            }
        }
    }
}
