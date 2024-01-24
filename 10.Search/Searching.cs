using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;

namespace _10.Search
{
    internal class Searching
    {
        // 순차 탐색
        // 자료구조에서 순차적으로 찾고자 하는 데이터를 탐색
        // 시간복잡도 - 0(n)
        public static int SequentialSearch<T>(IList<T> list, T item) where T : notnull
        {
            for (int i = 0; i < list.Count; i++)
            {
                if (list[i].Equals(item))
                {
                    return i;
                }
            }
            return -1;
        }

        // 이진 탐색
        // 정렬이 되어있는 자료구조에서 2분할을 통해 데이터를 탐색
        // 단, 이진 탐색은 정렬이 되어 있는 자료에만 올바른 결과를 도출
        // 시간복잡도 - 0(logn)

        public static int BinarySearch<T>(IList<T> list, T item) where T : IComparable<T>
        {
            int low = 0;        // 작은 위치는 0부터
            int high = list.Count - 1;
            while (low <= high)     // 둘의 위치가 어긋나지 않았으면 계속 반복
            {
                int mid = (low + high) / 2;     // 중간위치는 앞뒤 더하고 나누기2
                int compare = list[mid].CompareTo(item);

                if (compare < 0)
                    low = mid + 1;
                else if (compare > 0)
                    high = mid - 1;
                else
                    return mid;
            }
            return -1;
        }


        // 깊이 우선 탐색
        // 그래프의 분기를 만났을 때 최대한 깊이 내려간 뒤,
        // 분기의 탐색을 마쳤을 때 다음 분기를 탐색
        // 스택을 통해 구현

        public static void DFS(bool[,] graph, int start, out bool[] visited, out int[] parents)
        {
            visited = new bool[graph.GetLength(0)];
            parents = new int[graph.GetLength(0)];

            for (int i = 0; i < graph.GetLength(0); i++)
            {
                visited[i] = false;
                parents[i] = -1;
            }

            SearchNode(graph, start, visited, parents);
        }

        private static void SearchNode(in bool[,] graph, int start, bool[] visited, int[] parents)
        {
            visited[start] = true;
            for (int i = 0; i < graph.GetLength(0); i++) // 불가능을빼고 전부 탐색
            {
                if (graph[start, i] &&      // 연결되어 있는 정점이며,
                    !visited[i])            // 방문한적 없는 정점
                {
                    parents[i] = start;
                    SearchNode(graph, i, visited, parents);
                }
            }
        }

        // 너비 우선 탐색
        // 그래프의 분기를 만났을 때 모든 분기들을 탐색한 뒤,
        // 다음 깊이의 분기들을 탐색
        // 큐를 통해 구현
        // 최단경로가 나온다는 장점이 있다


        public static void BFS(bool[,] graph, int start, out bool[] visited, out int[] parents)
        {
            visited = new bool[graph.GetLength(0)];
            parents = new int[graph.GetLength(0)];

            for (int i = 0; i < graph.GetLength(0); i++)
            {
                visited[i] = false;
                parents[i] = -1;
            }

            Queue<int> queue = new Queue<int>();
            queue.Enqueue(start);
            visited[start] = true;
            while (queue.Count > 0)
            {
                int next = queue.Dequeue();
                for (int i = 0; i < graph.GetLength(0); i++)
                {
                    if (graph[next, i] &&      // 연결되어 있는 정점이며,
                        !visited[i])            // 방문한적 없는 정점
                    {
                        visited[i] = true;
                        parents[i] = start;
                        queue.Enqueue(i);
                    }
                }
            }
        }
    }
}
