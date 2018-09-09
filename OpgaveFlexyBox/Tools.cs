using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OpgaveFlexyBox
{
    public static class Tools
    {
        public static string ReverseString(string s)
        {
            string res = "";
            for (int i = s.Length - 1; i >= 0; i--) // start from the back of the input string
            {
                res += s[i];
            }
            return res;
        }

        public static bool IsPalindrome(string s)
        {
            s = s.Replace(" ", "").ToLower();
            int j = s.Length - 1;
            for (int i = 0; i < s.Length/2; i++) // go through string
            {
                if (s[i] != s[j]) // if something isn't right
                {
                    return false;
                }

                j--;
            }
            return true; // all is well
        }

        public static IEnumerable<int> MissingElements(int[] arr)
        {
            List<int> missing = new List<int>(); // list the missing elements
            int temp = -1; // for holding the last processed value
            if (arr != null && arr.Length > 0)
            {
                temp = arr[0]; // get the first value of the array
            }

            if (arr != null && arr.Length > 1)
            {
                for (int i = 1; i < arr.Length; i++) // loop the rest of the array
                {
                    if (temp > arr[i]) // if someone is stupid
                    {
                        throw new Exception("Position " + (i - 1) + " is greater than position " + i);
                    }
                    if (arr[i] - temp > 1) // more than 1 between numbers
                    {
                        for (int j = temp + 1; j < arr[i]; j++) // run through the numbers between our previous number and current
                        {
                            missing.Add(j);
                        }
                    }
                    temp = arr[i]; // set new previous number
                }
            }

            return missing;
        }
    }
}
