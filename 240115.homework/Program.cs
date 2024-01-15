using System.Collections;
using static System.Net.Mime.MediaTypeNames;

namespace _240115.homework
{
    internal class Program
    {
        //검사할 괄호 : [], {}, ()
        //예시 : () 완성, (() 미완성, [) 미완성, [[(){}]] 완성
        /*
        partial class Queue<T>
        {
            private T[] array;
            private string head;
            private string tail;
        }
        */
        /*
        bool IsOk(string text)
        {
            //스택생성
            Stack<string> stack = new Stack<string>();
            //텍스트를 스택에 넣고            
            stack.Push(text);
            //문제가 있는지 체크했는데
            //  { , [ , [ , ] , ] , }
            // 앞과 뒤가 똑같을때 서로 삭제 그걸 계속 반복             

                //만약 결과가 널일경우 true, 그외엔 전부 fales
            if (stack.Count == null)
                {
                    for (stack.First<char> == stack.Last<char>)
                    {
                        stack.Remove
                    }
                    return true;
                }
                else { return false; }
            
        }*/
        static void Main(string[] args)
        {
            bool IsOk(string text)
            {
                Queue<string> queue = new Queue<string>();
                queue.Enqueue(text);
                // 0번째와 괄호를 이루는지 검사, 이룬다면 다음문자 검사, 번호 끝까지 이루지 못했다면 그즉시 failes
                foreach


            }
            
            IsOk(Console.ReadLine());
            
        }
    }
}


