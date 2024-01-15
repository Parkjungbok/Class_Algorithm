namespace _04.Queue
{
    internal class Program
    {
        /* 큐
         * 
         * 선입선출, 후입후출 방식의 자료구조
         * 입력된 순서대로 처리해야 하는 상황에 이용
         */

        // 큐 구현
        //
        // 1 배열 사용
        // 선입선출(FIFO), 후입후출(LILO) 을 구현하기 위해 배열을 생성하고 순차적으로 데이터를 배치
        // 
        // 2 전단 & 후단
        // 삽입 & 삭제 시 데이터를 앞당기지 않고 head와 tail을 표시하여 삽입할 위치와 삭제할 위치를 지정
        //
        // 3 순환 배열
        // 배열의 끝까지 도달하여 빈자리가 없을 경우 처음으로 돌아가서 빈공간을 활용
        // ※ 단 tail 과 head가 만나는 문제가 있을수 있다.
        //
        // 4 포화상태확인
        // head와 tail이 일치하는 경우를 비어있는 경우로 판정
        // tail이 head 전위치에 있는 경우를 실제로는 한자리가 비어있지만 가득찬 경우로 판정




        // 일반적인 순서대로 처리
        // 주문->제조->서빙

        static void Main(string[] args)
        {
            Queue<int> queue = new Queue<int>();

            for (int i = 0; i < 5; i++)
            {
                queue.Enqueue(i);                       // 입력순서 : 0, 1, 2, 3, 4
            }

            Console.WriteLine(queue.Peek());            // 다음순서 : 0

            for (int i = 0; i < 3; i++)
            {
                Console.WriteLine(queue.Dequeue());     // 출력순서 : 0, 1, 2
            }

            Console.WriteLine(queue.Peek());            // 다음순서 : 3

            for (int i = 5; i < 10; i++)
            {
                queue.Enqueue(i);                       // 입력순서 : 5, 6, 7, 8, 9
            }

            Console.WriteLine(queue.Peek());            // 다음순서 : 3

            while (queue.Count > 0)
            {
                Console.WriteLine(queue.Dequeue());     // 출력순서 : 3, 4, 5, 6, 7, 8, 9
            }
        }
    }
}
