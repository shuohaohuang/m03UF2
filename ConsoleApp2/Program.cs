using System;

namespace Ej14
{
    class Ej14
    {
        static void Main()
        {
            const string InsertMsg = "Insert a number";
            const string NumsOfDigitsMsg = "{0} Has got {1} digit";
            const string OddSumMsg = "The sum of odd digits are {0}";
            const string EvenSemMsg = "The sum of even digits are  {0}";
            int insert = GetInt();
            int digits = CountDigits(insert);
            Console.WriteLine(NumsOfDigitsMsg, insert, digits);
            Console.WriteLine(OddSumMsg, SumOdd(insert, digits, true));
            Console.WriteLine(EvenSemMsg, SumOdd(insert, digits, false));
        }

        static int GetInt()
        {
            return Convert.ToInt32(Console.ReadLine());
        }

        static int CountDigits(int targetNum)
        {
            int numOfDigit = 0;
            if (targetNum != 0)
            {
                while (targetNum >= 1)
                {
                    targetNum /= 10;
                    numOfDigit++;
                }
            }
            return numOfDigit;
        }

        static int SumOdd(int targetNum, int digits, bool odd)
        {
            int[] nums = new int[digits];
            int result = 0;
            for (int i = digits - 1; i >= 0; i--)
            {
                nums[i] = targetNum % 10;
                targetNum /= 10;
            }
            foreach (int num in nums)
            {
                if (odd ? num % 2 == 1 : num % 2 != 1)
                {
                    result += num;
                }
            }
            return result;
        }
    }
}
