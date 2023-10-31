using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace myLibrary
{
    public static class StringFunctions
    {
        public static int GetCharacterCount(string str)
        {
            return str.Length;
        }

        public static bool IsPalindrome(string str)
        {
            int i = 0;
            int j = str.Length - 1;
            
            while(i < j)
            {
                if (str[i] != str[j]) return false;
                i++;
                j--;
            }
            return true;
        }

        public static string Reverse(string str)
        {
            Console.WriteLine(str);
            StringBuilder sb = new StringBuilder(""); 
            for(int i = str.Length - 1; i >= 0; i--)
            {
                sb.Append(str[i]);
            }
            return (sb.ToString());
        }

        public static string GetVowelsConsonantsNumbersSpecialChars(string str)
        {
            int vowels = 0, consonants = 0, numbers = 0, specials = 0;
            string vowelString = "aeiou";
            string consonantString = "bcdfghjklmnpqrstvwxyz";

            foreach(var ch in str)
            {
                if(vowelString.Contains(ch)){
                    vowels++;
                }
                else if(consonantString.Contains(ch)){
                    consonants++;
                }
                else if(ch >= '0' && ch <= '9')
                {
                    numbers++;
                }
                else
                {
                    specials++;
                }
            }

            return $"\nVowels : {vowels}\nConsonants : {consonants}\nNumbers : {numbers}\nSpecial Characters : {specials}\n";
        }


        public static string ConvertToLowerCase(string str)
        {
            return str.ToLower();
        }
        
        public static string ConvertToUpperCase(string str)
        {
            return str.ToUpper();
        }

        public static string Combine(string str1 , string str2)
        {
            return string.Concat(str1, str2);
        }

        
    }
}
