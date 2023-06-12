using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CalculatorAndBigNumber
{
    public static class MethodeHelpers
    {
		public static int GetNumLength(long num)
        {
            int length = 0;
            while (num != 0)
            {
                num /= 10;
                length++;
            }
            return length;
        }
        public static bool IsNumEven(int num2Length)
        {
            //bool isNumEven = false;
            //if (num2Length == (num2Length / 2) * 2)
            //    isNumEven = true;

            var isNumEven = num2Length == (num2Length / 2) * 2;

            return isNumEven;
        }
        public static int PowerNum(long num, int power)
        {
            var result = num;
            while (power != 1)
            {
                result *= num;
                power--;
            }
            return (int)result;
        }

    }
   
}
