using System;
using System.Linq;

namespace BinaryString
{
    class Program
    {
        static void Main(string[] args)
        {
            string text = "110010";
            //string text = Console.ReadLine();
            if (IsValid(text))
            {
                Console.WriteLine(IsStringGood(text) ? "Binary string is good" : "Binary string is bad");
            }
            else
            {
                Console.WriteLine("binary string is not valid");
            }
        }

        public static bool IsStringGood(string text)
        {
            string prefix = "";
            int length = text.Length;

            for (int i = 0; i < length; i++)
            {
                prefix += text[i];
                int prefixLength = prefix.Length;
                int zeroCount = 0;
                int oneCount = 0;
                for (int j = 0; j < prefixLength; j++)
                {
                    if (prefix[j] == '0') zeroCount++;
                    if (prefix[j] == '1') oneCount++;
                }

                if (oneCount < zeroCount || (length == prefixLength && zeroCount != oneCount)) return false;
            }
            return true;
        }

        public static bool IsValid(string text)
        {
            if (!IsBinaryString(text) || String.IsNullOrEmpty(text)) return false;
            return true;
        }

        public static bool IsBinaryString(string text)
        {
            var length = text.Length;
            for (int i = 0; i < length; i++)
            {
                if (text[i] != '0' && text[i] != '1') return false;
            }
            return true;

            //method 2, would require using Linq and would make
            //the function much simpler but would decrease performance:
            //return !text.Any(a => a != '0' && a != '1');

        }
    }
}
