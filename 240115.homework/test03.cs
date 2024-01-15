using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _240115.homework
{
    internal class test03
    {
        public const int WorkTime = 8;
        static int[] ProcessJob(int[] jobList)
        {
            Queue<int> queue = new Queue<int>();
            int remainTime = 8;
            int day = 1;
            List<int> days = new List<int>();

            for (int i = 0; i < jobList.Length; i++)
            {
                queue.Enqueue(jobList[i]);
            }

            while (queue.Count > 0)
            {
                int WorkTime = queue.Dequeue();
                while (true)
                {
                    if (WorkTime <= remainTime)
                    {
                        remainTime -= WorkTime;
                        // 작업완료
                        days.Add(day);
                        break;
                    }
                    else
                    {
                        WorkTime -= remainTime;
                        // 다음날로
                        day++;
                        remainTime = 8;
                    }
                }
            } return days.ToArray();

        }

        static void Main()
        {
            int[] result = ProcessJob(new int[] { 4, 4, 12, 10, 2, 10 });
            foreach (int day in result)
            {
                Console.WriteLine(day);
            }
        }
    }
}
