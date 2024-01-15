using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _02.LinkedList
{
    internal class Class1
    {

        static void Main()
        {
            LinkedList<int> linkedList = new LinkedList<int>();

            while (true)
            {
                string text = Console.ReadLine();

                bool success = int.TryParse(text, out int value);
                if (!success)
                {
                    Console.WriteLine("다시");
                    continue;
                }
                else if (value < 0)
                {
                    linkedList.AddFirst(value);
                }
                else if (value > 0)
                {
                    linkedList.AddLast(value);
                }
                else
                {
                    break;
                }

                foreach (int item in linkedList)
                {
                    Console.WriteLine($"{}");
                }
            }
        }













        static void Main2()
        {
            /*
            LinkedList<int> linkedList = new LinkedList<int>();

            for (int i = 0; i < linkedList.Count; i++)
            {
                //사용자의 입력으로 숫자를 입력 받아서(마이너스도 허용)
                string input = Console.ReadLine();
                int number = int.Parse(input);


                //음수는 앞에 추가하고, 양수는 뒤에 추가하여            
                if (number <= 0)
                {
                    linkedList.AddBefore(head, $"{number}");
                }
                else
                {
                    linkedList.AddLast(tail, $"{number}");
                }
                음수&양수를 반으로 나누는 연결리스트 구현
                입력 받을 때마다 처음부터 끝까지 출력 진행
                foreach (int value in linkedList)
                {
                    Console.Write($"{value} ");
                }
                Console.WriteLine();
                */
        }
    }
}

    





