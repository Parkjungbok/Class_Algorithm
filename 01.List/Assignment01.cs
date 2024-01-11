using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _01.List
{
    internal class Assignment
    {
        static void Main55()
        {
            //사용자에게 숫자를 입력 받아서
            Console.Write("숫자를 입력해주세요. : ");
            string a = Console.ReadLine();
            int b = int.Parse(a);

            //0부터 숫자까지 가지는 리스트 만들기
            List<int> list = new List<int>();
            list.Capacity = b;
            for (int i = 0; i < list.Capacity; i++)
            {
                list.Add(i);
            }

            //0 요소를 제거
            list.RemoveAt(0);

            //리스트가 가지는 모든 요소들을 출력해주는 반복문 작성
            for (int i = 0; i < list.Count; i++)
            {
                Console.Write($"{list[i]} ");
            }
        }

        static void Main2()
        {
            //사용자의 입력을 받아서
            Console.Write("숫자를 입력해주세요. : ");
            string c = Console.ReadLine();
            int d = int.Parse(c);

            //없는 데이터면 추가, 있던 데이터면 삭제하는 리스트 1, 6, 7, 8, 3
            List<int> list2 = new List<int>();
            list2.Add(1);
            list2.Add(6);
            list2.Add(7);
            list2.Add(8);
            list2.Add(3);

            int indexof = list2.IndexOf(d);

            if (indexof != -1)
            {
                list2.Remove(d);
            }
            else
            {
                list2.Add(d);
            }
            for (int i = 0; i < list2.Count; i++)
            {
                Console.Write($"{list2[i]}");
            }
        }
    }
}
// A++) 인벤토리 구현 (아이템 얻기, 아이템 버리기)
