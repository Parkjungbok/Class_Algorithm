using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Markup;

namespace _08.DesignTechique
{
    internal class Class1
    {
        static void Mian()
        {
            int count = int.Parse(Console.ReadLine());
            string text = Console.ReadLine();
            string[] texts = text.Split(' ');

            List<int> value = new List<int>();

            int[] values = { 10, -4, 3, 1, 5, 6, -35, 12, 21, -1 };
            int max = int.MinValue;


            // ex) [2,4] : 
            int[,] result = new int[values.Length, values.Length];

            for (int i = 0; i < values.Length; i++)
            {
                result[i, i] = values[i];
            }


            for (int start = 0; start < values.Length; start++)
            {
                for (int end = start + 1; end < values.Length; end++)
                {
                    result[start, end] = result[start, end - 1] + values[end];

                    if (max < result[start, end])
                    {

                    }
                }
            }
                        
        }
    }
}





