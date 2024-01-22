namespace _09.Sort
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Random random = new Random();
            int count = 8;

            List<int> selectionList = new List<int>();
            List<int> insertionSort = new List<int>();
            List<int> bubblelist = new List<int>();
            List<int> mergeSort = new List<int>();
            List<int> quickList = new List<int>();
            List<int> introList = new List<int>();

            Console.WriteLine("랜덤 데이터 :");
            for (int i = 0; i < count; i++)
            {
                int rand = random.Next(0, 100);
                Console.Write($"{rand,3}");

                selectionList.Add(rand);
                insertionSort.Add(rand);
                bubblelist.Add(rand);
                quickList.Add(rand);
                introList.Add(rand);
            }
            Console.WriteLine();

            Console.WriteLine("선택 정렬 결과 : ");
            Sorting.SelectionSort(selectionList, 0, selectionList.Count - 1);
            foreach (int value in selectionList)
            {
                Console.Write($"{value,3}");
            }
            Console.WriteLine();

            Console.WriteLine("삽입 정렬 결과 : ");
            Sorting.InsertionSort(insertionSort, 0, insertionSort.Count - 1);
            foreach (int value in insertionSort)
            {
                Console.Write($"{value,3}");
            }
            Console.WriteLine();

            Console.WriteLine("버블 정렬 결과 : ");
            Sorting.BubbleSort(bubblelist, 0, bubblelist.Count - 1);
            foreach (int value in bubblelist)
            {
                Console.Write($"{value,3}");
            }
            Console.WriteLine();

            Console.WriteLine("퀵 정렬 결과 : ");
            Sorting.QuickSort(quickList, 0, quickList.Count - 1);
            foreach (int value in quickList)
            {
                Console.Write($"{value,3}");
            }
            Console.WriteLine();

            Console.WriteLine("인트로 정렬 결과 : ");      // 하이브리드형
            introList.Sort();
            foreach (int value in introList)
            {
                Console.Write($"{value,3}");
            }
            Console.WriteLine();
        }
    }
}
