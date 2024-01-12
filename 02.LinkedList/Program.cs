namespace _02.LinkedList
{
    internal class Program
    {
        /*연결리스트
         * 
         * 데이터를 포함하는 노드들을 연결식으로 만든 자료구조
         * 데이터와 다른 데이터 지점의 참조변수를 가진 노드를 기본 단위로 사용
         * 데이터를 ㄹ노드를 통해 연결식으로 구성하기 떄문에 데이터의 추가/삭제에 유용
         * 노드가 메모리에 연속적으로 배치되지 않고 연결 구조로 다른 데이터의 위치를 확인
         */

        // 어느위치에 있던 내 다음 데이터를 기억하는구조
        // 해당 데이터가 지워지면 그 기억을 내 앞 구조에게 바톤터치
        // 데이터는 노드라 칭한다

        // 연결리스트 구현
        // 연결리스트는 노드를 기본 단위로 연결식으로 구현
        // 노드간의 연결구조에 따라 단방향, 양방향, 환형 으로 구분

        // 1. 단방향 연결리스트
        // 노드가 다음 노드를 참조
        // Data -> Data -> Data -> Data

        // 2. 양방향 연결리스트
        // 노드가 이전/다음 노드를 참조
        // Data <-> Data <-> Data <-> Data

        // 3. 환형 연결리스트
        // 노드가 이전/다음 노드를 참조하며, 시작 노드와 마지막 노드를 참조
        // Data -> Data -> Data -> Data
        //  └-----------------------┘     순환구조


        // 연결리스트 삽입
        // 새로 추가하는 노드가 이전/이후 노드를 참조한 뒤
        // 이전/ 이후 노드가 새로 추가하는 노드를 참조함


        // 연결리스트 삭제
        // 삭제하는 노드의 이전 노드가 이후 노드를 참조한 뒤
        // 삭제하는 노드의 이후 노드가 이전 노드를 참조함


        // 연결리스트 특징
        // 연결리스트의 경우 데이터를 연속적으로 배치하는 배열과 다르게 연결식으로 구성
        // 따라서, 데이터의 추가/삭제 과정에서 다른 데이터의 위치와 무관하게 진행되므로 수월함
        // 하지만, 데이터의 접근 과정에서 연속적인 데이터 배치가 아니기 때문에 인덱스 사용 불가하여 처음부터 탐색해야 함


        // LinkedList의 시간복잡도
        // 접근     탐색      삽입      삭제
        // 0(n)     0(n)     0(1)      0(1)


        static void Main(string[] args)
        {
            LinkedList<string> linkedList = new LinkedList<string>();

            // 삽입
            LinkedListNode<string> node0 = linkedList.AddFirst("0번 데이터");
            LinkedListNode<string> node1 = linkedList.AddFirst("1번 데이터");               // AddFirst : 앞에 추가
            LinkedListNode<string> node2 = linkedList.AddLast("2번 데이터");                // AddLast  : 뒤에 추가
            LinkedListNode<string> node3 = linkedList.AddLast("3번 데이터");
            LinkedListNode<string> node4 = linkedList.AddBefore(node0, "0번 앞에 데이터");   // AddBefore : 00 앞에 추가
            LinkedListNode<string> node5 = linkedList.AddAfter(node0, "0번 뒤에 데이터");    // AddBefore : 00 뒤에 추가

            // 삭제
            bool sucess = linkedList.Remove("1번 데이터");
            bool fail = linkedList.Remove("1번 데이터");
            linkedList.Remove(node3);
            linkedList.RemoveFirst();
            linkedList.RemoveLast();

            // 접근
            //linkedList[0];      // index가 없어서 불가
            LinkedListNode<string> first = linkedList.First;
            LinkedListNode<string> last = linkedList.Last;
            LinkedListNode<string> Prev = node0.Previous;
            LinkedListNode<string> next = node0.Next;
            // 녹색 밑줄 : Null일수도 있다

            // 탐색
            LinkedListNode<string> findNode = linkedList.Find("0번 데이터");





        }
    }
}
