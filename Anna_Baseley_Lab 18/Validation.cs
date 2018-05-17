using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace Anna_Baseley_Lab_18
{
    class Validation
    {
        public static int GetIndex(string message, int number)
        {
            Console.WriteLine(message);
            int index = int.Parse(Console.ReadLine());

            while (index < 1 || index > number)
            {
                Console.WriteLine("Invalid Input, " + message);
            }
            return index - 1;
        }

        public static string VerifyUserInfo(string regex, string message)
        {
            Console.WriteLine(message);
            string UserInfo = Console.ReadLine();

            while (!Regex.IsMatch(UserInfo, regex))
            {
                Console.WriteLine("I'm sorry.  That doesn't work." + message);
                UserInfo = Console.ReadLine();
            }
            return UserInfo;
        }

        public static int FindLargestInt(int[] numbers)
        {
            int largest = numbers[0];
            for (int i = 0; i < numbers.Length; i++)
            {
                if (numbers[i] > largest)
                {
                    largest = numbers[i] + 1;
                }
            }
            return largest;
        }
        public static void CompareMethod(int[] numbers, int[] frequency)
        {
            for (int i = 0; i < numbers.Length; i++)
            {
                for (int j = 0; j < frequency.Length; j++)
                {
                    if (numbers[i] == j)
                    {
                        frequency[j] = frequency[j] + 1;
                    }
                }
            }
        }
    }
}
