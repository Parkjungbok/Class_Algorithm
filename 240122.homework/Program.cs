namespace _240122.homework
{
    internal class Program
    {
        // InsertionSort 삽입정렬
        public static void InsertionSort(List<int> list, int start, int end)
        {
            // 시작부터 끝까지 반복
            for (int i = start; i < end; i++)
            {
                
            }
        }

        // SelectionSort 선택정렬
        public static void SelectionSort(List<int> list, int start, int end)
        {
            // 시작부터 끝까지 반복
            for (int i = start; i < end; i++)
            {
                // 제일 작은 위치
                int min = i;

                // j는 작은 인덱스 +1 이고 마지막 수까지 반복
                for (int j = i + 1; j < end; j++)
                {
                    // 만약 j가 작은인덱스보다 작다면
                    if (list[j] < list[min])
                    {
                        // 작은인덱스는=j
                        min = j;
                    }
                }

                // 현재 인덱스와 최소값 위치의 원소를 교환
                int temp = list[i];
                list[i] = list[min];
                list[min] = temp;
            }
        }
        static void Main(string[] args)
        {
            // 랜덤생성
            Random rand = new Random();

            // 'selectionSort'리스트생성
            List<int> selectionSort = new List<int>();
            List<int> insertionSort = new List<int>();

            // 10회 반복
            for (int i = 0; i < 10; i++)
            {
                // 0부터 50사이에 랜덤한 숫자
                int Random = rand.Next(0, 50);
                // 'selectionSort'에 추가
                selectionSort.Add(Random);
                insertionSort.Add(Random);
            }

            SelectionSort(selectionSort, 0, selectionSort.Count);
            // 탐색 'selectionSort'
            foreach (int i in selectionSort)
            {
                Console.Write($"{i,5}");
            }

            Console.WriteLine();

            foreach (int i in insertionSort)
            {
                Console.Write($"{i,5}");
            }
        }
    }
}/*
public static void SelectionSort(List<int> list, int start, int end)
{
    // 시작부터 끝까지 반복
    for (int i = start; i < end - 1; i++)
    {
        // 제일 작은 위치
        int minIndex = i;

        // j는 작은 인덱스 +1 이고 마지막 수까지 반복
        for (int j = i + 1; j < end; j++)
        {
            // 만약 j가 작은인덱스보다 작다면
            if (list[j] < list[minIndex])
            {
                // 작은인덱스는=j
                minIndex = j;
            }
        }

        // 현재 인덱스와 최소값 위치의 원소를 교환
        int temp = list[i];
        list[i] = list[minIndex];
        list[minIndex] = temp;
    }
}

static void Main(string[] args)
{
    // 랜덤생성
    Random rand = new Random();

    // 'selectionSort'리스트생성
    List<int> selectionSort = new List<int>();

    // 10회 반복
    for (int i = 0; i < 10; i++)
    {
        // 0부터 50사이에 랜덤한 숫자
        int random = rand.Next(0, 50);
        // 'selectionSort'에 추가
        selectionSort.Add(random);
    }

    SelectionSort(selectionSort, 0, selectionSort.Count);

    // 탐색 'selectionSort'
    foreach (int i in selectionSort)
    {
        Console.Write($"{i,3}");
    }
}
*/