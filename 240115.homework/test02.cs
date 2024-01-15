using System.Collections;
using static System.Net.Mime.MediaTypeNames;

namespace _240115.homework
{
    internal class test02
    {
        public static bool IsOk(string text)
        {
            Stack<char> stack = new Stack<char>();
            // 문제 풀이 키워드는 반복과 조건을 어떻게 쓰는지에 있다.
            foreach (char c in text)
            {
                if (c == '(')
                {
                    stack.Push(c);                      // 스택에 푸시를 하고
                }
                else if (c == '{')
                {
                    stack.Push(c);
                }
                else if (c == '[')
                {
                    stack.Push(c);
                }
                else if (c == ')')                      // 괄호의 반대부분을 체크했을때
                {
                    if (stack.Count == 0)               // 만약 스택길이가 0이라면 괄호 앞부분이 입력이 안된것이므로 실패
                        return false;

                    char bracket = stack.Pop();         //
                    if (bracket == '(')
                    {}
                    else
                    {
                        return false;
                    }
                }
                else if (c == '}')
                {
                    if (stack.Count == 0)
                        return false;

                    char bracket = stack.Pop();
                    if (bracket == '{')
                    {}
                    else
                    {
                        return false;
                    }
                }
                else if (c == ']')
                {
                    if (stack.Count == 0)
                        return false;

                    char bracket = stack.Pop();
                    if (bracket == '[')
                    {

                    }
                    else
                    {
                        return false;
                    }
                }
            }

            if (stack.Count > 0)
            {
                return false;
            }

            return true;
        }

        static void Main(string[] args)
        {
            do
            {
                string text = Console.ReadLine();
                Console.WriteLine(IsOk(text));
            } while (true);
        }
    }
}


