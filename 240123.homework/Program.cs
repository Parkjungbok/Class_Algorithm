namespace _240123.homework
{
    internal class Program
    {
        /*
        bool[,] matrixGraph1 = new bool[,]
        {
            { false, false,  true, false,  true, false, false, false },
            { false, false,  true, false, false,  true, false, false },
            {  true,  true, false, false, false,  true,  true, false },
            { false, false, false, false, false, false, false,  true },
            {  true, false, false, false, false, false, false,  true },
            { false,  true,  true, false, false, false, false, false },
            { false, false,  true, false, false, false, false, false },
            { false, false, false,  true,  true, false, false, false },
        };


        bool[,] matrixGraph2 = new bool[,]
        {//      0      1      2      3      4      5      6      7
           0 { false, false, false, false, false, false, false, false },
           1 { false, false, false, false, false, false, false, false },
           2 { false, false, false,  true, false,  true, false, false },
           3 { false,  true, false, false, false,  true, false,  true },
           4 { false, false, false, false, false, false, false, false },
           5 { false,  true, false, false, false, false, false, false },
           6 { false, false,  true, false, false,  true, false, false },
           7 { false, false, false, false, false, false,  true, false },
        };

        const int INF = int.MaxValue;

        int[,] matrixGraph3 = new int[,]
        {//     0    1    2    3    4    5    6    7 
          0  {   0,   4, INF, INF,   6, INF, INF, INF },
          1  {   4,   0,   5,   4, INF,   8,   2, INF },
          2  { INF,   5,   0, INF,   9, INF, INF, INF },
          3  { INF,   4, INF,   0, INF, INF, INF, INF },
          4  {   6, INF,   9, INF,   0, INF,   5, INF },
          5  { INF,   8, INF, INF, INF,   0, INF,   1 },
          6  { INF,   2, INF, INF,   5, INF,   0, INF },
          7  { INF, INF, INF, INF, INF,   1, INF,   0 },
        };
        */


        private static void PrintGraphSearch(bool[] visited, int[] path)
        {
            Console.WriteLine($"{"Vertex",8}{"Visit",8}{"Path",8}");

            for (int i = 0; i < visited.Length; i++)
            {
                Console.WriteLine($"{i,8}{visited[i],8}{path[i],8}");
            }
        }

        static void Main(string[] args)
        {

            bool[,] graph = new bool[8, 8]
            {//      0      1      2      3      4      5      6      7
                { false, false, false,  true,  true, false, false, false },
                { false, false, false,  true, false,  true,  true, false },
                { false, false, false, false, false, false,  true, false },
                {  true,  true, false, false, false,  true, false,  true },
                {  true, false, false, false, false, false,  true, false },
                { false,  true, false,  true, false, false,  true,  true },
                { false, false,  true, false,  true,  true, false,  true },
                { false, false, false,  true, false,  true,  true, false },
            };
            bool[] e;
            int[] j;

            Searching.BFS(in graph, 0, out e, out j);
            PrintGraphSearch(e, j);

            

        }
    }
}
