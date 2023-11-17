using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _2023._11._15._2
{
    internal class FileName
    {
        public enum Month
        {
            January = 1,
            February,
            March,
            April,
            May,
            June,
            July,
            August,
            September,
            October,
            November,
            December
        }

        static void ProcessMonth(int month)
        {
            if (month >= (int)Month.January && month <= (int)Month.December)
            {
                Month selectedMonth = (Month)month;
                Console.WriteLine("선택한 월은 {0}입니다.", selectedMonth);
            }
            else
            {
                Console.WriteLine("올바른 월을 입력해주세요.");
            }
        }

        static void Main()
        {
            int userInput = 7; 
            ProcessMonth(userInput);
        }

    }
}
