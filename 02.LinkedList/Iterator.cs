using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _02.LinkedList
{
    internal class Iterator
    {
        void Main1()
        {
            List<int> list = new List<int>();
            LinkedList<int> linkedList = new LinkedList<int>();

            SortedSet<int> set = new SortedSet<int>();

            for (int i = 0; i < 10; i++)
            {
                list.Add(i);
                linkedList.AddLast(i);
            }

            for (int i = 0; i < list.Count; i++)
            {
                Console.Write($"{list[i]} ");
            }
            /* 인텍스가 없기에 불가능
            for (int i = 0; i < linkedList.Count; i++)
            {
                Console.WriteLine($"{linkedList[i]}");
            }
            */
            for (LinkedListNode<int> node = linkedList.First; node != null; node = node.Next) // 처음 노드를 가져와서 다음 노드가 없을때 까지 반복한다
            {
                Console.Write($"{node.Value}");
            }

            // foreach 처음부터 끝까지 반복
            foreach (int value in list)         // 리스트의 처음부터 끝까지 하나하나 반복
            {
                Console.Write($"{value} ");
            }

            foreach (int value in linkedList)   // 리스트의 처음부터 끝까지 하나하나 반복
            {
                Console.Write($"{value} ");
            }
            
            foreach (int value in set)
            {
                Console.Write($"{set} ");
            }

            Book book = new Book();
            /*
            foreach (int value in book)         // 반복이 가능할때만 가능
            {
                Console.Write($"{book} ");
            }
            */
        }
        public static float Average(IEnumerable<int> container)
        {
            float average = 0;
            int count = 0;
            foreach (int value in container)
            {
                average += value;
                count++;
            }
            return average / count;
        }

        public class Book
        {
            public string[] text;
        }

        // IEnumerable<> 을 이용하면 자료 구조랑 상관없이 가능하게 해줌. 활용도 큼
    }
}