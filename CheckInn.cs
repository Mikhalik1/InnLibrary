using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.AccessControl;
using System.Text;
using System.Threading.Tasks;

namespace InnLibrary
{
    public class CheckInn
    {
        public bool CorrectFillINN(string innCode)
        {
            int[] cof1 = { 7, 2, 4, 10, 3, 5, 9, 4, 6, 8 ,0,0};
            int[] cof2 = { 3, 7, 2, 4, 10, 3, 5, 9, 4, 6, 8,0 };
            int summ = 0;
            int summ2 = 0;
            double ost = 0;
            double ost2 = 0;
            if (string.IsNullOrEmpty(innCode))
            {
                return false;
            }
            if (innCode.Length < 12 || innCode.Length > 12)
            {
                return false;
            }
            for (int i = 0; i < cof1.Length; i++)
            {
                summ = summ + Convert.ToInt32(char.GetNumericValue(innCode[i])) * cof1[i];
                summ2 = summ2 + Convert.ToInt32(char.GetNumericValue(innCode[i])) * cof2[i];
            }
            ost = summ % 11;
            ost2 = summ2 % 11;

            if (ost > 9)
            {
                ost = ost % 10;

            }
            if (ost2 > 9)
            {
                ost2 = ost2 % 10;

            }
            if (ost == Convert.ToInt32(char.GetNumericValue(innCode[10])) && ost2 == Convert.ToInt32(char.GetNumericValue(innCode[11])))
            {
                return true;
            }
            else
            {
                return false;
            }

        }
    }
}
