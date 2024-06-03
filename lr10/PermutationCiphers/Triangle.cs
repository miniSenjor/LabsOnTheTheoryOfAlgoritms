using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PermutationCiphers
{
    internal class Triangle
    {
        public Triangle() { }
        public Triangle(char symbol)
        {
            Symbol = symbol;
        }
        public Triangle(char symbol, int i) : this(symbol) 
        {
            I = i;
        }
        public Triangle(char symbol, int i, int j) : this(symbol, i)
        {
            J = j;
        }

        public char Symbol { get; set; }
        public int I {  get; set; }
        public int J { get; set; }

    }
}
