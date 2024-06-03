using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PermutationCiphers
{
    internal static class Program
    {
        /// <summary>
        /// Главная точка входа для приложения.
        /// </summary>
        //[STAThread]
        static void Main()
        {
            PermutationCiphers pc = new PermutationCiphers();
            //int[] i = { 3, 1, 2 };
            int[] i = { 3, 0, 2, 1 };
            int[] j = { 2, 0, 3, 1 };
            //pc.BlockSingle("финмориатяка", i, out string result);
            //pc.Route("информационная безопасность", 6, out result);
            //pc.Vertical("информационная безопасность", "колонна", out result);
            pc.DoublePermutation("наука математика", i, j, out string result);
            Console.WriteLine(result);
            Console.ReadKey();
            //Application.EnableVisualStyles();
            //Application.SetCompatibleTextRenderingDefault(false);
            //Application.Run(new Form1());
        }
    }
}
