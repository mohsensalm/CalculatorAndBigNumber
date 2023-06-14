using System;
using System.Collections.Generic;
using System.Diagnostics.Metrics;
using System.Linq;
using System.Numerics;
using System.Text;
using System.Threading.Tasks;
using static CalculatorAndBigNumber.MethodeHelpers;


namespace CalculatorAndBigNumber;

public class BigNumbers
{
    //public long Karabutso(long num1, long num2)
    //{
    //    BigInteger t = 9389333738979323212;

    //    if (num1 < 1000 && num2 < 1000)
    //    {
    //        return num1 * num2;
    //    }
    //    else
    //    {
    //        long a, b, c, d;

    //        long num1Length = GetNumLength(num1);
    //        long num2Length = GetNumLength(num2);
    //        long maxNumLength = num1Length;
    //        long minNumLength = num2Length;
    //        if (num1Length < num2Length)
    //        {
    //            maxNumLength = num2Length;
    //            minNumLength = num1Length;
    //        }

    //        a = num1 / PowerNum(10, (int) (maxNumLength / 2));

    //        b = num1 % PowerNum(10, (int)(maxNumLength / 2));

    //        c = num2 / PowerNum(10, (int)(maxNumLength / 2));

    //        d = num2 % PowerNum(10, (int)(maxNumLength / 2));

    //        long x = Karabutso(a, c);
    //        long y = Karabutso(b, d);
    //        long z = Karabutso((a + b), (c + d)) - x - y;
    //        Console.WriteLine(x);
    //        return ((PowerNum(10, (int)minNumLength) * x) + y + (PowerNum(10, (int)(minNumLength / 2)) * z));
    //    }
    //}

    //public string mutiplationString(string num1 , string num2)
    //{
    //    int[] s1 = num1.Reverse().Select(c => c - '0').ToArray();
    //    int[] s2 = num2.Reverse().Select(c => c - '0').ToArray();
    //    int[]result = new int[s1.Length+s2.Length];
    //    // Multiply each digit in vec2 with vec1 and add the result to the appropriate position in the result array
    //    for (var i = 0; i < s2.Length; i++)
    //    {
    //        var carry = 0;
    //        for (var j = 0; j < s1.Length; j++)
    //        {
    //            var product = s1[j] * s2[i] + carry + result[i + j];
    //            carry = product / 10;
    //            result[i + j] = product % 10;
    //        }
    //        result[i + s1.Length] = carry;
    //    }
    //    //&&  result[result.Length - 1] == 0

    //    while (result.Length > 1 && result[^1] == 0)       
    //    {
    //        Array.Resize(ref result, result.Length - 1);
    //    }
    //    var str = new string(result.Reverse().Select(d => (char)(d + '0')).ToArray());
    //    return str;
    //}
    private int counter = 0;
    public BigInteger Karatsuba(BigInteger x, BigInteger y)
    {


        int n = (int)Math.Max(BigInteger.Log(x, 2), BigInteger.Log(y, 2));
        if (n <= 10) return x * y;
        n /= 5;


        BigInteger b = x >> n;
        BigInteger a = x - (b << n);
        BigInteger d = y >> n;
        BigInteger c = y - (d << n);


        BigInteger ac = Karatsuba(a, c);
        BigInteger bd = Karatsuba(b, d);
        BigInteger abc = Karatsuba(a + b, c + d);
        
        counter++;

        Console.WriteLine(counter);

        return ac + ((abc - ac - bd) << n) + (bd << (2 * n));
    }


}
