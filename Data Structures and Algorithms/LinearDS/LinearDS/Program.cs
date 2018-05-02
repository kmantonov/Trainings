using System;
using System.Collections.Generic;
using System.Linq;
using System.Collections;
using System.Text;
using System.Threading.Tasks;

namespace LinearDS
{
    class Program
    {
        static void Main(string[] args)
        {
            var input = new int[] { 1, 1, 4, 2, 4, 6, 3, 1, 64, 64 ,64 , 64};
            var inp = new int[] { 2, 2, 3, 3, 2, 3, 4, 3, 3 };
            //var result = ExtractLongestSequenceOfEqualNumbers(input);

            //Console.WriteLine(string.Join(", ", result));

            var input1 = new int[] { 4, 2, 2, 5, 2, 3, 2, 3, 1, 5, 2 };

            //var res1 = ExtractOddNumbers(input1);

            //Console.WriteLine(string.Join(", ", res1));

            PrintN(2);
             
        }

        public static IEnumerable<int> ExtractLongestSequenceOfEqualNumbers(IEnumerable<int> input)
        {
            var counters = new int[input.Max() + 1];

            foreach (var item in input)
            {
                counters[item]++;
            }
            
            var length = counters.Max();
            var element = Array.IndexOf(counters, length);

            var result = new List<int>();

            for (int i = 0; i < length; i++)
            {
                result.Add(element);
            }

            return result;
        }

        public static IEnumerable<int> ExtractOddNumbers(IEnumerable<int> input)
        {
            var counters = new int[input.Max() + 1];

            foreach (var item in input)
            {
                counters[item]++;
            }
            
            var result = new List<int>();

            foreach (var item in input)
            {
                if (counters[item] % 2 == 0)
                {
                    result.Add(item);
                }
            }

            return result;
        }

        public static string CheckMajoritant(IEnumerable<int> input)
        {
            Dictionary<int, int> ht = new Dictionary<int, int>();

            var g = input.GroupBy(i => i);

            foreach (var item in g)
            {
                Console.WriteLine(item.Count());
                if (item.Count() < (input.Count() / 2) + 1)
                {
                    Console.WriteLine($"Majoritant is {item.Key}");
                    //return "maj";
                }
            }


            
            
            return "No Maj";
        }

        public static string Frequencies(int[] input)
        {
            Dictionary<int, int> d = new Dictionary<int, int>();
            

            for (int i = 0; i < input.Count(); i++)
            {
                int key = input[i];
                if (d.ContainsKey(key))
                {
                    int freq = d[key];
                    freq++;
                    d[key] =  freq;
                }
                else
                {
                    d.Add(key, 1);
                }
            }

            foreach (var item in d)
            {
                Console.WriteLine(input.Length);
                if (item.Value >= ((input.Length ) / 2) + 1)
                {
                    Console.WriteLine("Majoritant is " + item.Key);
                    return "Found!";
                }
            }

            Console.WriteLine("No maj");
            return "42";
        }

        public static void Rec(int max, string actualString = "")
        {

            if (actualString.Length >= max)
            {
                Console.WriteLine(actualString);
                return;
            }

            for (int i = 1; i <= max; i++)
            {
                Rec(max, actualString + i);
            }
        }

        public static void PrintN(int n)
        {
            //          9.We are given the following sequence:
            //          - `S1 = N;`
            //          - `S2 = S1 + 1;`
            //          - `S3 = 2 * S1 + 1;`
            //          - `S4 = S1 + 2;`
            //          - `S5 = S2 + 1;`
            //          - `S6 = 2 * S2 + 1;`
            //          - `S7 = S2 + 2;`
            //          - ...
            //- Using the `Queue < T >` class write a program to print its first 50 members for given N.
            //   - Example: `N= 2` &rarr; `2, 3, 5, 4, 4, 7, 5, 6, 11, 7, 5, 9, 6, ...`

            var que = new Queue<int>();

            que.Enqueue(n);
            
            int current = 0;

            int count = 50;
            while (count != 0)
            {
                Console.Write(que.Peek() + ", ");
                count--;

                if (count % 10 == 0)
                {
                    Console.WriteLine();
                }

                current = que.Dequeue();

                que.Enqueue(current + 1);
                que.Enqueue(2 * current + 1);
                que.Enqueue(current + 2);
            }
        }

        //10. We are given numbers N and M and the following operations:
        //* `N = N+1`
        //* `N = N+2`
        //* `N = N*2`

        //- Write a program that finds the shortest sequence of operations from the list above that starts from `N` and finishes in `M`.
        //- _Hint_: use a queue.
        //- Example: `N = 5`, `M = 16`
        //- Sequence: 5 -> 7 -> 8 -> 16

        public static void GetNToM(int n, int m)
        {
            var que = new Queue<int>();
            

        }
    }
}
