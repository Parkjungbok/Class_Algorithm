namespace _03.Stack
{
    internal class Program
    {
        /*스택
         * 
         * 선입후출, 후입선출 방식의 자료구조
         * 가장 최신 입력된 순서대로 처리해야 하는 상황에 이용
         */

        // 스택 구현
        // 스택은 리스트를 사용법만 달리하여 구현 가능



        // UI에서 활용
        // ex) 설정->사운드->변경확인 (뒤로가기상황)

        static void Main(string[] args)
        {
            Stack<int> stack = new Stack<int>();

            for (int i = 0; i < 5; i++)
            {
                stack.Push(i);              //입력순서 0 1 2 3 4
            }

            Console.WriteLine(stack.Peek());//최상단 : 4

            for (int i = 0; i < 5; i++)     //출력순서 4 3 2 1 0
            {
                int value = stack.Pop();
                Console.WriteLine(value);
            }

            


        }
    }
}
