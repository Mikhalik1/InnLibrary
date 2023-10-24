using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string innCode = "663555067806 ";
            int[] cof1 = { 7, 2, 4, 10, 3, 5, 9, 4, 6, 8 };
            int[] cof2 = { 3, 7, 2, 4, 10, 3, 5, 9, 4, 6, 8 };
            int summ = 0;
            int summ2 = 0;
            double ost = 0;
            double ost2 = 0;
            for (int i = 0; i < cof1.Length; i++)
            {
                summ = summ + Convert.ToInt32(innCode[i].ToString()) * cof1[i];
                summ2 = summ2 + Convert.ToInt32(innCode[i].ToString()) * cof2[i];
            }
            ost = summ % 11;
            ost2 = summ2 % 11;

            if (ost >= 9)
            {
                ost = summ % 10;

            }
            if (ost2 >= 9)
            {
                ost2 = summ2 % 10;

            }
            if (ost == Convert.ToInt32(innCode[10].ToString()) && ost2 == Convert.ToInt32(innCode[11].ToString()))
            {
                Console.WriteLine(ost);
            }
            
        }
    }
}
