using System;
using System.Collections.Generic;

namespace tests.Controllers
{
    public static class TestsUtils
    {
        public static int SolveArrays(int[] input)
        {
            var sum = 0;
            var isTwice = false;
            for (var i = 0; i < input.Length; i++)
                if (input[i] % 2 == 1)
                {
                    if (isTwice)
                    {
                        sum = sum + input[i];
                        isTwice = false;
                    }
                    else
                    {
                        isTwice = true;
                    }
                }


            return sum;
        }

        public static bool IsPalindrome(string input)
        {
            for (int i = 0; i < input.Length / 2; ++i)
            {
                if (input[i] != input[input.Length - i - 1])

                    return false;
            }

            return true;
        }

        public static  LinkedList<int> Summ(LinkedList<int> first, LinkedList<int> secont)
        {
            LinkedList<int> result = new LinkedList<int>();

            LinkedListNode<int> a = first.First;
            LinkedListNode<int> b = secont.First;
            int modifier = 0;

            while (a != null || b != null)
            {
                int firstVal = a != null ? a.Value : 0;
                int secondVal = b != null ? b.Value : 0;

                int summ = firstVal + secondVal + modifier;
                if (summ > 9)
                {
                    modifier = summ / 10;
                    summ = summ % 10;
                }

                LinkedListNode<int> newNode = new LinkedListNode<int>(summ);

                result.AddLast(newNode);
                a = a?.Next;
                b = b?.Next;


                
            }
            return result;

        }
    }
}