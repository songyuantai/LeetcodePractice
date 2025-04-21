using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetCodePractice.MinusPalindrome
{
    public class Solution
    {
        //public int MinCut(string s)
        //{
        //    if (IsPalin(s)) return 0;
        //    var count = -1;
        //    for (int i = s.Length - 1; i > 0; i--)
        //    {
        //        var before = s[..i];
        //        var after = s[i..];
        //        var min = MinCut(before) + MinCut(after) + 1;
        //        if(count == -1 || min < count)
        //        {
        //            count = min;
        //        }
        //    }

        //    return count == -1 ? 0 : count;
        //}

        //private bool IsPalin(string text)
        //{
        //    if(string.IsNullOrEmpty(text)) return false;
        //    var array = text.ToCharArray();
        //    for (int i = 0; i < array.Length / 2; i++)
        //    {
        //        if (array[i] != array[array.Length - 1 - i])
        //        {
        //            return false;
        //        }
        //    }
        //    return true;
        //}

            public int MinCut(string s)
            {
                if (IsPalindrome(s, 0, s.Length - 1))
                    return 0;

                int[] cut = new int[s.Length];
                for (int i = 0; i < s.Length; i++)
                {
                    cut[i] = i; // At most we can cut at each character
                }

                for (int i = 0; i < s.Length; i++)
                {
                    // Odd length palindrome centered at i
                    for (int j = 0; i - j >= 0 && i + j < s.Length && s[i - j] == s[i + j]; j++)
                    {
                        if (i - j == 0)
                            cut[i + j] = 0;
                        else
                            cut[i + j] = Math.Min(cut[i + j], cut[i - j - 1] + 1);
                    }

                    // Even length palindrome centered at i and i+1
                    for (int j = 1; i - j + 1 >= 0 && i + j < s.Length && s[i - j + 1] == s[i + j]; j++)
                    {
                        if (i - j + 1 == 0)
                            cut[i + j] = 0;
                        else
                            cut[i + j] = Math.Min(cut[i + j], cut[i - j] + 1);
                    }
                }

                return cut[s.Length - 1];
            }

            private bool IsPalindrome(string s, int start, int end)
            {
                while (start < end)
                {
                    if (s[start++] != s[end--])
                        return false;
                }
                return true;
            }



        }
}
