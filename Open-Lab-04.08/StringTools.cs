using System;
using System.Collections.Generic;

namespace Open_Lab_04._08
{
    public class StringTools
    {
        public string[] IsFourLetters(string[] strings)
        {
            var jup = new List<string>();
            foreach (string h in strings)
            {
                for (int a = 4; a == h.Length; a++)
                {
                    jup.Add(h);
                }
            }return jup.ToArray();
        }
    }
}
