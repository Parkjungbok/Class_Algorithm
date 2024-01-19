namespace _240119.homework
{
    internal class Program
    {
        static void Main()
        {
            int[] lWaiting = { 3, 1, 4, 3, 2 };
            int totaltime = 0;
            int delayed = 0;

            int minWait = int.MaxValue;
            foreach (int wait in lWaiting)
            {
                if (wait < minWait)
                {
                    minWait = wait;
                }
            }
            foreach (int wait in lWaiting)
            {
                delayed += minWait;
                totaltime += delayed;
                totaltime += minWait;
            }
        }
    }
}





