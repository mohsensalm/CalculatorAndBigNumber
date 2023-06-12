using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static CalculatorAndBigNumber.MethodeHelpers;


namespace CalculatorAndBigNumber;

public class BigNumbers
{
    public long Karabutso(long num1, long num2)
    {
        if (num1 < 1000 && num2 < 1000)
        {
            return num1 * num2;
        }
        else
        {
            long a, b, c, d;

            long num1Length = GetNumLength(num1);
            long num2Length = GetNumLength(num2);
            long maxNumLength = num1Length;
            long minNumLength = num2Length;
            if (num1Length < num2Length)
            {
                maxNumLength = num2Length;
                minNumLength = num1Length;
            }

            a = num1 / PowerNum(10, (int) (maxNumLength / 2));

            b = num1 % PowerNum(10, (int)(maxNumLength / 2));

            c = num2 / PowerNum(10, (int)(maxNumLength / 2));

            d = num2 % PowerNum(10, (int)(maxNumLength / 2));


            long x = Karabutso(a, c);
            long y = Karabutso(b, d);
            long z = Karabutso((a + b), (c + d)) - x - y;
            Console.WriteLine(x);
            return ((PowerNum(10, (int)minNumLength) * x) + y + (PowerNum(10, (int)(minNumLength / 2)) * z));
        }
    }
}
