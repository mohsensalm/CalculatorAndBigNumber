using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Channels;
using System.Threading.Tasks;
using static CalculatorAndBigNumber.MethodeHelpers;


namespace CalculatorAndBigNumber
{
    public class Calculator
    {
        private int _answear;

        public int Calculator1()
        {
            while (ContinueCalculating())
            {
                Console.WriteLine("pls inter a number");
                var num1 = Convert.ToInt32(Console.ReadLine());

                Console.WriteLine("pls select your command:\n1 is sum \n2 is minus  \n3 is divide  \n4 is multiplication  \n5 is rearranging \n6 is power ");
                var command = Convert.ToInt16(Console.ReadLine());

                Console.WriteLine("pls inter a number");
                var num2 = Convert.ToInt32(Console.ReadLine());

                _answear = command switch
                {
                    1 =>
                        num1 + num2,
                    2 =>
                        num1 - num2,
                    3 =>
                        num1 / num2,
                    4 =>
                        num1 * num2,
                    5 =>
                        num1 % num2,
                    6 =>
                        (int) Math.Pow(num1, num2),
                    _ => 0
                };

                Console.WriteLine($"\nyour answer is {_answear}");
            }

            return _answear;

        }
    }
}
