using System;
using System.Collections;
using System.Collections.Generic;

//Solution for the codewars challenge Simple Pig Latin
//https://www.codewars.com/kata/520b9d2ad5c005041100000f

public class Kata
{
  public static string PigIt(string str)
        {
            string[] strings = str.Split();
            for(int i = 0; i < strings.Length;i++)
            {
                if (!CheckPunctuationsMark(strings[i]) && i == 0)
                {
                    str = TurnIntoPigLatin(strings[i]);
                }
                else if (!CheckPunctuationsMark(strings[i]))
                    str += " " + TurnIntoPigLatin(strings[i]);
                else str += " " + strings[i];
            }
            return str;
        }

        static bool CheckPunctuationsMark(string str)
        {
            bool result = false;
            string[] punctuationsMarks = new string[] {"!", "?", "."};
            for (int i = 0; i < punctuationsMarks.Length; i++)
            {
                result = str.Contains(punctuationsMarks[i]);
                if (result)
                {
                    return result;
                }
            }
            return result;
        }

        static string TurnIntoPigLatin(string str)
        {
            str = SwitchCharPosition(str);
            str += "ay";
            return str;
        }

        static string SwitchCharPosition(string str)
        {
            char[] chars = str.ToCharArray();
            List<char> charsList = new List<char>();
            charsList.AddRange(chars);
            charsList.Add(charsList[0]);
            charsList.RemoveAt(0);
            return new string(charsList.ToArray());
        }
}
// Solution for the codewars challenge Sum Strings as Numbers
// https://www.codewars.com/kata/5324945e2ece5e1f32000370

public static class Kata
{
    public static string sumStrings(string a, string b)
    {
           if (String.IsNullOrEmpty(a))
                return b;
            if (String.IsNullOrEmpty(b))
                return a;
          
          return (BigInteger.Parse(a) + BigInteger.Parse(b)).ToString();
    }
}