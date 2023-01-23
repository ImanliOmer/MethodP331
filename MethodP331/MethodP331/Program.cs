using System;

namespace MethodP331
{
    internal class Program
    {
        static void Main(string[] args)
        {

            //Console.WriteLine(sumLengt(4));
            Console.WriteLine(NearNumber(27));
            //Console.ReadLine(WordLength);
        }

        static int NearNumber(int n)
        {
            if (n % 7 == 0)
                return n;

            int temp1 = n;
            int temp2 = n;

            while (true)
            {
                temp1--;
                temp2++;

                if (temp1 % 7 == 0)
                    return temp1;

                if (temp2 % 7 == 0)
                    return temp2;
            }
        }

      

        static int SumLengt(int a)
        {
            int sum = 0;

            if (a > 0)
            {
                for (int i = 0; i <= a; i++)
                {
                    sum += i;
                }
            }
            else
            {
                for (int i = 0; i >= a; i--)
                {
                    sum += a;
                }
            }
            return sum;
        }

        static string WordLength(string word1, string word2)
        {
            if (word1.Length == word2.Length)
            {
                Console.WriteLine($"{word1} == {word2}");
            }
            else if (word1.Length > word2.Length)
            {
                Console.WriteLine($"{word1} longer than {word2}");
            }
            else
            {
                Console.WriteLine($"{word2}");
            }
            return "";
        }
    }
}