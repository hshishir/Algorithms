using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Algorithms
{
    public class Manipulation
    {

        public string Reverse(string s)
        {
            if (string.IsNullOrWhiteSpace(s))
            {
                return null;
            }
            var sb = s.ToCharArray();
            var rs = string.Empty;
            for (int i = s.Length - 1; i >= 0; i--)
            {
                rs += sb[i];
            }

            return rs;
        }

        public bool IsPalindrome(string s)
        {
            var sb = s.ToCharArray();
            for (int i = 0, j = sb.Length - 1; i < j; i++, j--)
            {
                if (sb[i] != sb[j])
                {
                    return false;
                }
            }

            return true;
        }

        public void FirstNonRepeatedCharacter(string s)
        {
            var sb = s.ToCharArray();
            var cmap = new Dictionary<char, int>();
            for (int i = 0; i < s.Length; i++)
            {
                if (cmap.Keys.Contains(sb[i]))
                {
                    cmap[sb[i]]++;
                }
                else
                {
                    cmap.Add(sb[i], 1);
                }
            }

            var fnc = cmap.Where(x => x.Value == 1).FirstOrDefault().Key;
            Console.WriteLine($"First non repeated character: {fnc}");
        }

        public void RemoveDuplicatesUsingBuffer(string s)
        {
            var sb = s.ToCharArray();
            var cmap = new Dictionary<char, int>();
            string rs = string.Empty;
            for (int i = 0; i < s.Length; i++)
            {
                if (!cmap.Keys.Contains(sb[i]))
                {
                    rs += sb[i];
                    cmap.Add(sb[i], 1);
                }
            }

            Console.WriteLine($"Removed duplicates: {rs}");
        }

        public void RemoveDuplicatesWithoutBuffer(string s)
        {
            var sb = s.ToCharArray();
            var cmap = new Dictionary<char, int>();
            int i = 0;
            for (int j = 0; i < s.Length & j < s.Length; j++)
            {
                if (!cmap.ContainsKey(sb[j]))
                {
                    sb[i++] = sb[j];
                    cmap.Add(sb[j], 1);
                }
            }

            sb[i] = '\0';
            var rs = new string(sb, 0, i);
            Console.WriteLine(rs);
        }

        public bool AllUniqueCharacters(string s)
        {
            var sb = s.ToCharArray();
            var cmap = new Dictionary<char, int>();
            for (int i = 0; i < s.Length; i++)
            {
                if (!cmap.ContainsKey(sb[i]))
                {
                    cmap.Add(sb[i], 1);
                }
                else
                {
                    cmap[sb[i]]++;
                }
            }

            var val = cmap.Where(x => x.Value > 1).Count();
            return val == 0;
        }

        public void RemoveGivenCharacters(string s, string remove)
        {
            var rb = remove.ToCharArray();
            var cmap = new HashSet<char>();
            for (int i = 0; i < remove.Length; i++)
            {
                cmap.Add(rb[i]);
            }

            var sb = s.ToCharArray();
            var x = 0;
            for (int j = 0; j < s.Length; j++)
            {
                if (!cmap.Contains(sb[j]))
                {
                    sb[x++] = sb[j];
                }
            }

            sb[x] = '\0';
            var rs = new string(sb, 0, x);
            System.Console.WriteLine($"Removed given characters: {rs}");
        }

        
        public void ReverseWords(string s)
        {
            
        }
    }

    public class ManipulationTest
    {
        public static void Execute()
        {
            var m = new Manipulation();

            // abcba => true
            var s = "abcba";
            Console.WriteLine($"Original: {s}");
            var b = m.IsPalindrome(s);
            Console.WriteLine($"Is palindrome: {b}");

            // cbabmhmd => c
            s = "cbabmhmd";
            Console.WriteLine($"Original: {s}");
            m.FirstNonRepeatedCharacter(s);

            // geeksforgeeks => geksfor
            s = "geeksforgeeks";
            Console.WriteLine($"Original: {s}");
            m.RemoveDuplicatesWithoutBuffer(s);

            // hemang => true
            // shishir => false
            s = "shishir";
            Console.WriteLine($"Original: {s}");
            m.AllUniqueCharacters(s);

            // remove ean
            // hemang => hmg
            s = "hemang";
            Console.WriteLine($"Original: {s}");
            m.RemoveGivenCharacters(s, "ean");
        }
    }
}
