namespace _05.BinarySearchTree
{
    internal class Program
    {
        /*이진탐색트리
         * 
         * 이진속성과 탐색속성을 적용한 트리
         * 이진탐색을 통한 탐색영역을 절반으로 줄여가며 탐색 가능
         * 이진 : 부모노드는 최대 2개의 자식노드를 가질 수 있음
         * 탐색 : 자신의 노드보다 작은 값들은 왼쪽, 큰 값들은 오른쪽에 위치
         */

        // 순차탐색-조건없음 
        // 이진탐색-정렬된것만가능

        // 이진탐색트리 구현
        // 이진탐색트리는 모든 노드들이 최대 2개의 자식노드를 가질 수 있으며
        // 자신의 노드보다 작은 값들은 왼쪽, 큰 값들은 오른쪽에 위치시킴

        // 이진탐색트리 탐색
        // 루트 노드부터 시작하여 탐색하는 값과 비교하여,
        // 작은 경우 왼쪽자식노드로, 큰 경우 오른쪽자식노드를 탐색

        // 이진탐색트리 삽입
        // 루트 노드부터 시작하여 삽입하는 값과 비교하여,
        // 작은 경우 왼족자식노드로, 큰 경우 오른쪽자식노드로 하강
        // 만약 빈공간이라면 빈공간에 삽입

        // 이진탐색트리 삭제
        // 1. 자식이 0개인 노드의 삭제 : 단순 삭제 진행
        // 2. 자식이 1개인 노드의 삭제 : 삭제하는 노드의 부모와 자식을 연결 후 삭제 (이어주고 삭제)
        // 3. 자식이 2개인 노드의 삭제 : 삭제하는 노드를 기준으로 오른쪽 자식중 가장 작은 값 노드와 교체 후 삭제

        // 이진탐색트리 정렬
        // 이진탐색트리는 중위순회시 오름차순으로 정렬됨

        // 이진탐색트리 주의점
        // 이진탐색트리는 최악의 상황에 노드들이 한쪽 자식으로만 추가되는 불균형 현상이 발생 가능
        // 이 경우 탐색영역이 절반으로 줄여지지 않기 때문에 시간복잡도 증가

        // 대표적인 방식으로 Red-Black Tree, AVL Tree 등을 통해 불균형상황을 파악

        // 이진탐색트리 시간복잡도
        // 평균 -
        // 접근       탐색       삽입       삭제
        // O(logn)    O(logn)    O(logn)    O(logn)
        //
        // 최악 -
        // 접근       탐색       삽입       삭제
        // O(n)       O(n)       O(n)       O(n)

        static void Main(string[] args)
        {
            // 이진탐색트리 기반의 SortedSet 자료구조
            // 중복이 없는 정렬을 보장한 저장소
            SortedSet<int> sortedSet = new SortedSet<int>();

            // 삽입   (특정위치 넣기 불가 오로지 Add로만 삽입가능)
            sortedSet.Add(1);
            sortedSet.Add(3);
            sortedSet.Add(5);
            sortedSet.Add(4);
            sortedSet.Add(2);
            sortedSet.Add(6);
            sortedSet.Add(6);       //중복 추가는 무시함

            // 삭제
            sortedSet.Remove(4);

            // 탐색
            sortedSet.Contains(3);  // 있으면 ture, 없으면 fail

            // 순서대로 출력시 정렬된 결과 확인
            foreach (int value in sortedSet)
            {
                Console.WriteLine(value);
            }
            Console.WriteLine();

            // 이진탐색트리 기반의 SortedDictionary 자료구조
            // 중복을 허용하지 않는 key를 기준으로 정렬을 보장한 value 저장소
            SortedDictionary<string, Item> sortedDictionary = new SortedDictionary<string, Item>();

            // sortedDictionary.Add(101, new Item("포션", 3));

            // 삽입 (중복을 허용하지 않음)
            sortedDictionary.Add("포션", new Item("포션", 3));
            sortedDictionary.Add("소드", new Item("소드", 10));
            sortedDictionary.Add("방패", new Item("방패", 1));
            sortedDictionary.Add("신발", new Item("신발", 100));
            sortedDictionary.Add("롱소드", new Item("롱소드", 20));
            sortedDictionary.Add("망토", new Item("망토", 30));
            sortedDictionary.TryAdd("방패", new Item("방패", 1));   //예외처리까지 감안하여 키추가 있으면 넣고 없으면 말고

            // 삭제 
            sortedDictionary.Remove("롱소드");

            int.TryParse("123", out int value1);    // 변환가능하면 변환하고 아니면 null

            // 탐색
            sortedDictionary.ContainsKey("방패");
            sortedDictionary.TryGetValue("방패", out Item shield);    // 예외처리까지 감안하여 key 가지고 value 탐색
            Item item2 = sortedDictionary["방패"]; // 인텍서[key]를 통한 탐색 없다면 예외처리

            // 순서대로 출력시 정렬된 결과 확인
            foreach (string name in sortedDictionary.Keys)
            {
                Console.WriteLine(name);
            }

            foreach (Item item in sortedDictionary.Values) 
            {
                Console.WriteLine($"{item.name}, {item.cost}");
            }
        }

        public class Item
        {
            public string name;
            public int cost;
            
            public Item (string name, int value)
            {
                this.name = name;
                this.cost = value;
            }
        }
    }
}
