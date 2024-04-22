using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace csharp.problemlibrary.LeetCode.Easy
{
    public class ValidAnagram
    {
        public static bool IsAnagram(string s, string t)
        {
            Dictionary<char, int> caracteres = new Dictionary<char, int>();

            foreach (var letra in s)
            {
                if (caracteres.ContainsKey(letra))
                {
                    caracteres[letra] += 1;
                }
                else
                {
                    caracteres.Add(letra, 1);
                }

            }
            foreach (var letra in t)
            {
                if (caracteres.ContainsKey(letra))
                {
                    caracteres[letra] -= 1;
                }
                else
                {
                    return false;
                }
            }
            if (caracteres.Values.All(x => x == 0))
            {
                return true;
            }
            else
            {
                return false;
            }
        }
    }
}
