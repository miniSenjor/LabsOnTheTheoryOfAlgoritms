using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PermutationCiphers
{
    public class PermutationCiphers
    {
        static List<char> alphabet = new List<char> { 'а', 'б', 'в', 'г', 'д', 'е', 'ё', 'ж', 'з', 'и', 'й', 'к', 'л', 'м', 'н', 'о', 'п', 'р', 'с', 'т', 'у', 'ф', 'х', 'ц', 'ч', 'ш', 'щ', 'ъ', 'ы', 'ь', 'э', 'ю', 'я' };

        /// <summary>
        /// Шифр простой одинарной перестановки
        /// </summary>
        /// <param name="input">открытое сообщение</param>
        /// <param name="key">ключ для шифрования</param>
        /// <param name="result">закрытое сообщение</param>
        /// <returns></returns>
        public bool SimpleSingle(string input, string sKey, out string result)
        {
            result = "";

            if (!ConvertToIntArray(sKey, out int[] key))
            {
                result = "Ошибка ввода ключа";
                return false;
            }
            key = ConvertToNormalArray(key);
            foreach (int i in key)
                result += input[i-1];

            return true;
        }

        /// <summary>
        /// Шифр блочной одинарной перестановки
        /// </summary>
        /// <param name="input">открытое сообщение</param>
        /// <param name="block">ключ для шифрования</param>
        /// <param name="result">закрытое сообщение</param>
        /// <returns></returns>
        public bool BlockSingle(string input, string sBlock, out string result)
        {
            result = "";

            if (!ConvertToIntArray(sBlock, out int[] block))
            {
                result = "Ошибка ввода ключа";
                return false;
            }
            block = ConvertToNormalArray(block);
            while (input.Length % block.Length != 0)
                input += "я";

            for(int i = 0; i<input.Length; i+=block.Length)
                for (int j = 0;  j < block.Length; j++)
                    result += input[i + block[j]-1];

            return true;
        }

        /// <summary>
        /// Шифр маршуртной перестановки
        /// </summary>
        /// <param name="input">открытое сообщение</param>
        /// <param name="lengthRoute">размер таблицы</param>
        /// <param name="result">закрытое сообщение</param>
        /// <returns></returns>
        public bool Route(string input, int lengthRoute, out string result)
        {
            result = "";

            while (input.Length % lengthRoute != 0)
                input += " ";

            int countRowInSquare = input.Length / lengthRoute;
            for (int i = 0; i < lengthRoute; i++)
                for (int j = 0; j < countRowInSquare; j++)
                    result += input[j * lengthRoute + i];

            return true;
        }

        /// <summary>
        /// Шифр вертикальной перестановки
        /// </summary>
        /// <param name="input">открытое сообщение</param>
        /// <param name="slogan">ключ для шифрования</param>
        /// <param name="result">закрытое сообщение</param>
        /// <returns></returns>
        public bool Vertical(string input, string slogan, out string result)
        {
            result = "";

            int countColumnInSquare = slogan.Length;
            while (input.Length % countColumnInSquare != 0)
                input += " ";

            List<int> listIndexCharSlogan = new List<int>() { 7, 1, 3, 5, 6, 2, 4};
            //сделать конверт слова в массив цифр
            foreach (char c in slogan)
            {
                //listIndexCharSlogan.Add(alphabet.IndexOf(c));
            }

            int indexCharSlogan = 0;
            int[] arrayIndexCharSlogan = new int[countColumnInSquare];
            foreach (int i in listIndexCharSlogan)
            {//можно в новый лсит добавлять если мин равен значению и потом в массив добавлять indexCharSlogan
                int indexMin = -1;
                List<int> minList = new List<int>();
                foreach (int j in listIndexCharSlogan)
                {
                    //if(j == indexMin)

                }
                indexCharSlogan++;
            }

            int countRowInSquare = input.Length / slogan.Length;
            foreach (int  column in  listIndexCharSlogan)
                for (int  row = 0; row < countRowInSquare; row++)
                    result += input[row * countColumnInSquare + column-1];

            return true;
        }

        /// <summary>
        /// Шифр перекрёсток
        /// </summary>
        /// <param name="input">открытое сообщение</param>
        /// <param name="clockwise">как записывается в перекресток по часовой(да/нет)</param>
        /// <param name="startWrite">начало записи в перекрёсток 0-12 1-3 2-6 3-9</param>
        /// <param name="result">закрытое сообщение</param>
        /// <returns></returns>
        public bool Crossroad(string input, bool clockwise, int startWrite, out string result)
        {
            result = "";

            if (startWrite > 4 || startWrite < 0)
            {
                result = "Не правильно задано начало записи в перекрусток";
                return false;
            }

            while (input.Length%8 != 0)
                input += " ";
            List<Crossroad> crossroads = new List<Crossroad>();
            for (int i = 0; i < input.Length; i+=4)
            {
                string s = input.Substring(i, 4);
                Crossroad cr = new Crossroad(s, clockwise, startWrite);
                crossroads.Add(cr);
            }

            for (int i = 0; i < crossroads.Count; i+=2)
            {
                result += crossroads[i].Chars[0].ToString()+ crossroads[i+1].Chars[0];
                result += crossroads[i].Chars[3].ToString() + crossroads[i].Chars[1];
                result += crossroads[i+1].Chars[3].ToString()+ crossroads[i+1].Chars[1];
                result += crossroads[i].Chars[2].ToString() + crossroads[i+1].Chars[2];
            }

            return true;
        }

        /// <summary>
        /// Шифр с использование треугольников
        /// </summary>
        /// <param name="input">открытое сообщение</param>
        /// <param name="slogan">ключ для шифрования</param>
        /// <param name="result">закрытое сообщение</param>
        /// <returns></returns>
        public bool UsingTriangles(string input, string slogan, out string result)
        {
            result = "";

            int countColumn = 1;
            int currentWriteColumn = 0;
            List<Triangle> listTriangle = new List<Triangle>();
            foreach(char c in input)
            {
                Triangle tr = new Triangle(c, countColumn, currentWriteColumn);
                currentWriteColumn++;
                if (currentWriteColumn == countColumn)
                {
                    countColumn++;
                    currentWriteColumn = 0;
                }
            }

            while (currentWriteColumn < countColumn)
            {
                Console.WriteLine(" ");
                currentWriteColumn++;
            }

            return true;
        }

        public bool RotatingGrille(string input,  out string result)
        {
            result = "";



            return true;
        }

        public bool MagicSquare(string input, out string result)
        {
            result = "";



            return true;
        }

        /// <summary>
        /// Шифр двойной перестановки
        /// </summary>
        /// <param name="input">открытое сообщение</param>
        /// <param name="columns">как меняются местами столбцы</param>
        /// <param name="rows">как меняются местами строки</param>
        /// <param name="result">закрытое сообщение</param>
        /// <returns></returns>
        public bool DoublePermutation(string input, int[] columns, int[] rows, out string result)
        {
            result = "";

            int lengthSquare = Convert.ToInt32(Math.Floor(Math.Sqrt(input.Length)));

            if (columns.Length != lengthSquare)
            {
                result = "Не правильно введен массив смены столбцов";
                return false;
            }
            if (rows.Length != columns.Length)
            {
                result = "Не правильно введен массив смены строк";
                return false;
            }

            while (Math.Sqrt(input.Length) < lengthSquare)
                input += " ";

            char[,] arrayResult = new char[lengthSquare, lengthSquare];

            int currentCharInput = 0;
            foreach (int i in rows)
                foreach (int j in columns)
                {
                    char c = input[currentCharInput++];
                    arrayResult[i, j] = c;
                }

            

            for (int j = 0; j < arrayResult.GetLength(1); j++)
                for (int i = 0; i < arrayResult.GetLength(0); i++)
                    result += arrayResult[i, j];

            return true;
        }

        private bool ConvertToIntArray(string input, out int[] array)
        {
            string[] sArray = input.Split(" ".ToCharArray());
            List<int> list = new List<int>();
            foreach(string s in sArray)
            {
                try
                {
                    int value = int.Parse(s);
                    if (list.Contains(value))
                    {
                        array = null;
                        return false;
                    }
                    list.Add(value);
                }
                catch 
                {
                    array = null;
                    return false;
                }
            }
            array = list.ToArray();
            return true;
        }

        private void ClearRepitInList(int[] array)
        {
            List<int> list = array.ToList();
            foreach (int i in list)
            {
                //if (list)
            }
        }

        private int[] ConvertToNormalArray(int[] array)
        {
            List<int> badList = array.ToList<int>();
            int[] normalArray = new int[badList.Count];
            for(int i = 0; i < badList.Count; i++)
            {
                normalArray[badList.IndexOf(array[i])] = badList[i];
            }
            return normalArray;
        }
    }
}
