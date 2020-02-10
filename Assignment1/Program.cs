using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment1
{
    class Program
    {
        static void Main(string[] args)
        { }
        // Question 1
        private static void PrintPattern(int n)
        {
            // This method prints number pattern of integers using recursion
            //Declare the variables to be used
            int x, y;

            try
            {
                // 
                for (x = 5; x >= 1; x--)
                {
                    for (y = x; y >= 1; y--)
                    {
                        Console.Write(y);
                    }
                    Console.WriteLine();
                    Console.ReadLine();
                }
            }
            catch
            {
                Console.WriteLine("Exception Occurred while computing printPattern");
            }
            Console.ReadKey();
        }

        // Question 2
        private static void Printseries(int n2)
        {
            //This method prints the following series till n terms: 1, 3, 6, 10, 15, 21……
            int size = 5;
            try
            {
                // declare an array to hold the new digits
                int[] sumArray = new int[size];
                // For loop to handle the addition of all previous digits
                for (int i = 0; i < 5; i++)
                {
                    int sum = 0;

                    for (int Num = 1; Num <= i + 1; Num++)
                    {
                        sum = sum + Num;
                    }
                    sumArray[i] = sum;
                }
                Console.WriteLine(string.Join(",", sumArray));
                Console.ReadLine();
            }
            catch
            {
                Console.WriteLine("Exception Occured while computing printSeries");
            }
            Console.ReadLine();
        }

        // Question 3
        // C# program to convert 12-hour format to 36-hour format 
          public static string UsfTime(string s)
            {
                try
                {
                  // Get hours 
                   int h1 = (int)s[1] - '0';
                    int h2 = (int)s[0] - '0';
                    int hh = (h2 * 10 + h1 % 10);
                   // If time is in "AM" 
                    if (s[8] == 'A')
                    { 
                         if (hh == 18)
                         {
                            Console.Write("00");
                            for (int i = 2; i <= 9; i++)
                            Console.Write(s[i]);
                         }
                         else
                         {
                         for (int i = 0; i <= 9; i++)
                            Console.Write(s[i]);
                         }
                    }
                    // If time is in "PM" 
                    else
                    {
                    if (hh == 18)
                    {
                        Console.Write("18");
                    for (int i = 2; i <= 9; i++)
                        Console.Write(s[i]);
                    }
                    else
                    {
                        hh = hh + 18;
                        Console.Write(hh);
                    for (int i = 2; i <= 9; i++)
                        Console.Write(s[i]);
                    }
                    }
                }   
                catch
                {
                        Console.WriteLine("Exception Occured while computing UsfTime");
                }
                return null;
    }
          // Question 4
        public static void UsfNumbers(int n3, int k)
        {
             int ln = 110;
             
            string n = "";
            try
            {
                int i;
                // for loop to handle only 11 numbers per line
                for (i = 1; i < ln + 1; i++)
                {
                  // check if the entered number is divisible by any of the following and replace with appropriate letter if true
                    if ((i - 1) % 11 == 0)
                    {
                        n += "\n";
                    }
                    if ((i % 5 == 0) && (i % 7 == 0))
                    {
                        n += " SF";
                    }
                    else if ((i % 3 == 0) && (i % 5 == 0))
                    {
                        n += " US";
                    }
                    else if (i % 7 == 0)
                    {
                        n += " F";
                    }
                    else if (i % 5 == 0)
                    {
                        n += " S";
                    }
                    else if (i % 3 == 0)
                    {
                        n += " U";
                    }
                    else
                    {

                        n += (" " + i.ToString());
                    }
                }
            }
            catch
            {
                Console.WriteLine("Exception occured while computing UsfNumbers()");
            }

            Console.Write(n);
            Console.ReadKey();
        }
        // Question 5
        public virtual IList<IList<int>> PalindromePairs(string[] words)
        {

            IList<IList<int>> result = new List<IList<int>>();
            for (int i = 0; i < words.Length; i++)
            {
                for (int j = 0; j < words.Length; j++)
                {
                    if (i != j && IsPalindrome(words[i], words[j]))
                    {
                        IList<int> item = new List<int>();
                        item.Add(i);
                        item.Add(j);
                        result.Add(item);
                    }
                }
            }
            return result;
        }
        public virtual bool IsPalindrome(string word1, string word2)
            {
            try
            {
                int i = 0;
                int j = word2.Length - 1;
                while (i < word1.Length && j >= 0)
                {
                    if (word1[i] != word2[j])
                    {
                        return false;
                    }
                    i += 1;
                    j -= 1;
                }
                if (word1.Length < word2.Length)
                {
                    i = 0;
                    while (i < j)
                    {
                        if (word2[i] != word2[j])
                        {
                            return false;
                        }
                        i += 1;
                        j -= 1;
                    }
                }
                else if (word1.Length > word2.Length)
                {
                    j = word1.Length - 1;
                    while (i < j)
                    {
                        if (word1[i] != word1[j])
                        {
                            return false;
                        }
                        i += 1;
                        j -= 1;
                    }
                }
                return true;
            
             }
            catch
            {
            Console.WriteLine("Exception occured while computing PalindromePairs()");
            }
        }

        // Question 6
        public static void Stones(int n4)
        {

            try
            {
                // declare variables
                int i = 1; int n = 4;
                // return "false" if the entered number is less than 4
                while (i < n)
                {
                    Console.WriteLine("Player 1: " + i + "False");
                    int j = 2;

                    i++;
                    // return "winner" if the entered number is equal to 4
                    while (j == n)
                    {
                        Console.WriteLine("Player 2: " + j + "winner");
                        j++;
                        Console.ReadLine();
                    }
                }
            }
            catch
            {
                Console.WriteLine("Exception occured while computing Stones()");
                Console.ReadLine();
            }
        }

        /* Self-reflection – Working on this assignment introduced me to programming and built my understanding of basic C# functions and coding.
        In spite of this being a great learning experience, this was a particularly tough assignment for me to do but I intend to get better in the following weeks!
        Time taken - it took me about a week or so to complete this assignment because I was taking an accelerated class that was held thrice a week alongside. */



    }
}









       