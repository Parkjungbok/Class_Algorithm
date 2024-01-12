using System;
using System.Collections.Generic;

class Program
{
    static void Main()
    {
        // 음수&양수를 반으로 나누는 연결리스트 구현
        LinkedList<int> linkedList = new LinkedList<int>();     //링크리스트 생성

        for (int i = 0; i < 100; i++)
        {
            // 사용자의 입력으로 숫자를 입력 받아서(마이너스도 허용)
            Console.Write("숫자 입력 : ");
            string input = Console.ReadLine();                  
            int number = int.Parse(input);                      //입력

            // 차례대로 정렬하면서 삽입
            LinkedListNode<int> currentNode = linkedList.First; //currentNod는 링크리스트의 퍼스트

            while (currentNode != null && currentNode.Value < number)//currentNod가 널이 아니거나 벨류가 입력수보다 작을때
            {
                currentNode = currentNode.Next;                 //                
            }

            if (currentNode == null)                            // currentNod가 널이 아니면
            {                
                linkedList.AddLast(number);                     // 뒤로 붙임
            }
            else
            {                
                linkedList.AddBefore(currentNode, number);      
            }

            // 입력 받을 때마다 처음부터 끝까지 출력 진행
            foreach (int value in linkedList)
            {
                Console.Write($"{value} ");
            }
            Console.WriteLine();

        }
    }
}

