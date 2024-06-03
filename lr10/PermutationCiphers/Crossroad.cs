using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PermutationCiphers
{
    internal class Crossroad
    {
        public Crossroad(string s, bool clockwise, int startIndex) 
        {
            Chars = new char[4];
            Clockwise = clockwise;
            Write(s, clockwise, startIndex);
        }

        public char[] Chars {  get; set; }
        public bool Clockwise { get; set; }

        private void Write(string s, bool clockwise, int startIndex)
        {
            foreach (char c in s)
            {
                if (clockwise)
                {
                    Chars[startIndex++] = c;
                    if (startIndex > 3)
                        startIndex = 0;
                }
                else
                {
                    Chars[startIndex--] = c;
                    if (startIndex < 0)
                        startIndex = 3;
                }
            }
        }
    }
}
