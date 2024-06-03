using System;

namespace PermutationCiphers
{
    public class VariantSquare
    {
        public VariantSquare(char symbol, char i1, char i2, char j1, char j2) 
        {
            Symbol = symbol;
            I1 = i1;
            I2 = i2;
            J1 = j1;
            J2 = j2;
        }

        public char Symbol { get; set; }
        public char I1 { get; set; }
        public char I2 { get; set; }
        public char J1 { get; set; }
        public char J2 { get; set; }
    }
}
