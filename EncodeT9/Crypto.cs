using System;
using System.Collections.Generic;
using System.Text;

namespace EncodeT9
{
    public static class Crypto
    {
        public static readonly Dictionary<char, string> _letters = new Dictionary<char, string>
        {
            { 'A', "2" },
            { 'B', "22" },
            { 'C', "222" },
            { 'D', "3" },
            { 'E', "33" },
            { 'F', "333" },
            { 'G', "4" },
            { 'H', "44" },
            { 'I', "444" },
            { 'J', "5" },
            { 'K', "55" },
            { 'L', "555" },
            { 'M', "6" },
            { 'N', "66" },
            { 'O', "666" },
            { 'P', "7" },
            { 'Q', "77" },
            { 'R', "777" },
            { 'S', "7777" },
            { 'T', "8" },
            { 'U', "88" },
            { 'V', "888" },
            { 'W', "9" },
            { 'X', "99" },
            { 'Y', "999" },
            { 'Z', "9999" },
        };

        public static string EncodeT9(string input)
        {
            StringBuilder result = new StringBuilder();

            if(!String.IsNullOrWhiteSpace(input))
            {
                foreach(var letter in input.ToUpper())
                {
                    if (!_letters.ContainsKey(letter)) throw new ArgumentException("input should only contain a-z or A-Z");

                    result.Append(_letters[letter]);
                }
            }

            return result.ToString();
        }
    }
}
