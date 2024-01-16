using System.Runtime.Intrinsics.X86;
using static _240116.homework.Program;
using static System.Net.Mime.MediaTypeNames;

namespace _240116.homework
{
    internal class Program
    {
        public class Solution
        {/*
            public string[] solution(string[] players, string[] callings)
            {
                LinkedList<string> linkedList = new LinkedList<string>();
                for (int i = 0; i > players.Length; i++)
                {
                    linkedList.AddFirst(players[i]);
                }

                foreach (string p in callings)
                {
                    if (p == "mumu")
                    {
                        linkedList.Find("mumu");
                    }

                }

                return
            }*/
        }






        static void Main(string[] args)
        {
            int n = 7;
            int solution(int n)
            {
                int answer = 0;

                if (n < 7)
                {
                    answer = 1;
                }
                else if (n > 7)
                {
                    answer = 7/n;
                }

                return answer;
            }

        }
    }
}
