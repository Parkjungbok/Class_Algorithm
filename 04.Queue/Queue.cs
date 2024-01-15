using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _DataStructure
{
    internal class Queue<T>
    {
        private const int DefaultCapacity = 4;

        private T[] array;
        private int head;
        private int tail;
        private int count;

        public Queue()
        {
            array = new T[DefaultCapacity];
            head = 0;
            tail = 0;
            count = 0;
        }

        public void Enquque(T item)
        {
            if (IsFull())               // 꽉차있을때 늘리기
            {
                Grow();
            }

            array[tail] = item;         // tall 위치에 item을 넣고
            // tail = (tail + 1) % array.Length;   아래와 동일
            tail++;                     // 뒤로 한칸 이동
            if (tail == array.Length)   // 끝에 도달했을시
            {
                tail = 0;               // 0위치로
            }
            count++;
        }

        public T Dequque()
        {
            if (count == 0)             // 아무것도 없을시
                throw new InvalidOperationException();

            T itme = array[head];
            head++;
            if (head == array.Length)   // 끝에 도달했을시
            {
                head = 0;               // 0위치로
            }
            count--;
            return itme;
        }

        public bool IsFull()
        {
            if (head > tail)
            {                                // 중간이 비였을때
                return head == tail + 1;     // 헤드가 테일다음칸과 같을때
            }
            else                             // 길이의 양끝에 있을경우            
            {
                return head == 0 && tail == array.Length - 1;
            }
        }

        private void Grow()
        {
            T[] newArray = new T[array.Length * 2]; //  2배로 길이를 늘림
            if (head < tail)
            {
                Array.Copy(array, head, newArray, 0, tail);
            }
            else                                            // 헤드가 뒤일때
            {
                Array.Copy(array, head, newArray, 0, array.Length - head); // 총길이-헤드 = 헤드의길이
                Array.Copy(array, 0, newArray, array.Length - head, tail); // 0번부터 테일까지
            }

            array = newArray;
            head = 0;
            tail = count;
        }
    }
}
