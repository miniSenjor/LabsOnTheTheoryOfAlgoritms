using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace PermutationCiphers
{
    public class CombinedSquare
    {
        public CombinedSquare(char symbol, int i, int j) 
        {
            Symbol = symbol;
            I = i;
            J = j;
        }
        public char Symbol { get; set; }
        public int I {  get; set; }
        public int J { get; set; }
    }
}
