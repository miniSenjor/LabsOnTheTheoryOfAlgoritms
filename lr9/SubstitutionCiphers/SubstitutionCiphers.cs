using System;
using System.Collections.Generic;
using System.Linq;

namespace PermutationCiphers
{
    internal class SubstitutionCiphers
    {
        public SubstitutionCiphers() 
        {
            
        }

        static List<char> alphabet = new List<char> {'а', 'б', 'в', 'г', 'д', 'е', 'ё', 'ж', 'з', 'и', 'й', 'к', 'л', 'м', 'н', 'о', 'п', 'р', 'с', 'т', 'у', 'ф', 'х', 'ц','ч', 'ш', 'щ', 'ъ', 'ы', 'ь', 'э', 'ю', 'я'};
        /// <summary>
        /// Шифр Цезаря
        /// </summary>
        /// <param name="input">открытое сообщение</param>
        /// <param name="shift">сдвиг</param>
        /// <param name="encrypt">защифровать?</param>
        /// <param name="result">закрытое сообщение</param>
        /// <returns></returns>
        public bool Caesar(string input, int shift, bool encrypt, out string result) 
        {
            shift %= 33;
            if (shift < 0)
                shift = 33 + shift;

            //заполняем алфавит со сдвигом
            List<char> alphabetCaesar = new List<char>();
            for (int i = shift; i < 33; i++)
                alphabetCaesar.Add(alphabet[i]);
            foreach(char c in alphabet)
            {
                if (alphabetCaesar.Contains(c))
                    break;
                alphabetCaesar.Add(c);
            }

            if (encrypt)
                result = twoAlphabet(input, alphabet, alphabetCaesar);
            else
                result = twoAlphabet(input, alphabetCaesar, alphabet);
            
            return true;
        }

        /// <summary>
        /// Шифр Атбаш
        /// </summary>
        /// <param name="input">открытое сообщение</param>
        /// <param name="result">закрытое сообщение</param>
        /// <returns></returns>
        public bool Atbash(string input, out string result)
        {
            //заполняем алфавит наоборот
            List<char> alphabetAtbash = new List<char>();
            for (int i=alphabet.Count - 1; i >= 0; i--)
                alphabetAtbash.Add(alphabet[i]);

            result = twoAlphabet(input, alphabet, alphabetAtbash);
            
            return true;
        }

        /// <summary>
        /// Лозунговый шифр
        /// </summary>
        /// <param name="input">открытое сообщение</param>
        /// <param name="slogan">лозунг</param>
        /// <param name="encrypt">зашифровать?</param>
        /// <param name="result">закрытое сообщение</param>
        /// <returns></returns>
        public bool Slogan(string input, string slogan, bool encrypt, out string result)
        {
            slogan = clearRepit(slogan);

            //заполняем алфавит начиная с лозунга
            List<char> alphabetSlogan = new List<char>();
            foreach (char c in slogan)
            {
                if (alphabetSlogan.Contains(c))
                    continue;
                alphabetSlogan.Add(c);
            }
            for (int i = alphabet.Count - 1; i >= 0; i--)
            {
                if (alphabetSlogan.Contains(alphabet[i]))
                    continue;
                alphabetSlogan.Add(alphabet[i]);
            }

            if (encrypt)
                result = twoAlphabet(input, alphabet, alphabetSlogan);
            else
                result = twoAlphabet(input, alphabetSlogan, alphabet);

            return true;
        }

        /// <summary>
        /// Полибианский квадрат
        /// </summary>
        /// <param name="input">открытое сообщение</param>
        /// <param name="encrypt">зашифровать?</param>
        /// <param name="result">закрытое сообщение</param>
        /// <returns></returns>
        public bool PolybianSquare(string input, bool encrypt, out string result)
        {
            result = "";
            Dictionary<string, char> alphabetSquare = new Dictionary<string, char>();
            char ch = 'а';
            for (int i = 1; i <=6;  i++)
            {
                for (int j = 1; j <=6; j++)
                {
                    string key = i.ToString() + j.ToString();
                    alphabetSquare.Add(key, ch);
                    ch++;
                }
            }

            if (encrypt)
            {
                foreach (char c in input)
                {
                    try
                    {
                        string key = alphabetSquare.First(x => x.Value == c).Key;
                        result += key;
                    }
                    catch (ArgumentException)
                    {
                        result += c;
                    }
                }
            }
            else
            {
                for (int i = 0; i < input.Length; i++)
                {
                    int key1, key2;
                    try { key1 = int.Parse(input[i].ToString()); }
                    catch
                    {
                        result += input[i];
                        continue;
                    }
                    try { key2 = int.Parse(input[++i].ToString()); }
                    catch
                    {
                        result += key1.ToString() + input[i];
                        continue;
                    }
                    string key = key1.ToString() + key2;
                    result += alphabetSquare[key];
                }
            }
            return true;
        }

        /// <summary>
        /// Шифр Трисемуса
        /// </summary>
        /// <param name="input">открытое сообщение</param>
        /// <param name="slogan">лозунг</param>
        /// <param name="encrypt">зашифровать?</param>
        /// <param name="result">закрытое сообщение</param>
        /// <returns></returns>
        public bool Trisemus(string input, string slogan, bool encrypt, out string result)
        {
            slogan = clearRepit(slogan);

            //заполняем главный алфавит и начинаем заполнять алфавит для шифрования
            List<char> alphabetMain = new List<char>();
            List<char> alphabetTris = new List<char>();
            foreach (char c in slogan)
            {
                if (alphabetMain.Contains(c))
                    continue;
                alphabetMain.Add(c);
            }
            foreach (char c in alphabet)
            {
                if (alphabetMain.Contains(c))
                    continue;
                alphabetMain.Add(c);
                alphabetTris.Add(c);
            }

            //дозаполняем алфавит для шифрования
            int shift = 33 % slogan.Length;
            for (int i = shift; i < slogan.Length; i++)
            {
                if (alphabetTris.Contains(slogan[i]))
                    continue;
                alphabetTris.Add(slogan[i]);
            }
            foreach(char c in slogan)
            {
                if (alphabetTris.Contains(c))
                    continue;
                alphabetTris.Add(c);
            }

            if (encrypt)
                result = twoAlphabet(input, alphabetMain, alphabetTris);
            else
                result = twoAlphabet(input, alphabetTris, alphabetMain);

            return true;
        }

        /// <summary>
        /// Шифр Плейфера
        /// </summary>
        /// <param name="input">открытое сообщение</param>
        /// <param name="slogan">лозунг</param>
        /// <param name="encrypt">зашифровать?</param>
        /// <param name="result">закрытое сообщение</param>
        /// <returns></returns>
        public bool Playfair(string input, string slogan, out string result)
        {
            result = "";
            slogan = clearRepit(slogan);

            PlayfairSquare ps = new PlayfairSquare(slogan);
            result = ps.Encrypt(input);
            
            return true;
        }

        /// <summary>
        /// Шифр Виженера
        /// </summary>
        /// <param name="input">открытое сообщение</param>
        /// <param name="slogan">лозунг</param>
        /// <param name="encrypt">зашифровать?</param>
        /// <param name="result">закрытое сообщение</param>
        /// <returns></returns>
        public bool Vigener(string input, string slogan, bool encrypt, out string result)
        {
            result = "";
            string newSlogan = "";
            foreach(char c in slogan)
            {
                char lowerC = c.ToString().ToLower()[0];
                if (alphabet.Contains(lowerC))
                    newSlogan += lowerC;
            }
            if (newSlogan.Length==0)
                return false;

            int currentCharSlogan = 0;
            foreach (char c in input)
            {
                if (!alphabet.Contains(c))
                {
                    result += c;
                    continue;
                }

                int indexCurrentInput = alphabet.IndexOf(c.ToString().ToLower()[0]);
                bool lower = c == alphabet[indexCurrentInput];
                int indexCurrentSlogan = alphabet.IndexOf(newSlogan[currentCharSlogan]);
                if (encrypt)
                {
                    string r = lower ? alphabet[(indexCurrentInput + indexCurrentSlogan) % 33].ToString() : alphabet[(indexCurrentInput + indexCurrentSlogan) % 33].ToString().ToUpper();
                    result += r;

                }
                else
                {
                    int index = indexCurrentInput - indexCurrentSlogan;
                    if (index < 0)
                        index += 33;
                    string r = lower ? alphabet[index].ToString() : alphabet[index].ToString().ToUpper();
                    result += r;
                }
                currentCharSlogan++;
                if (currentCharSlogan == newSlogan.Length)
                    currentCharSlogan = 0;
            }
            return true;
        }

        /// <summary>
        /// Шифр Хилла
        /// </summary>
        /// <param name="input">открытое сообщение</param>
        /// <param name="slogan">лозунг</param>
        /// <param name="result">закрытое сообщение</param>
        /// <returns></returns>
        public bool Hill(string input, string slogan, out string result)
        {
            result = "";

            int sqrtSlogan = Convert.ToInt32(Math.Sqrt(slogan.Length));
            if (Math.Sqrt(slogan.Length) != sqrtSlogan)
            {
                result = "Длинна ключа должна быть квадратом целого числа";
                return false;
            }

            //создание алфавита
            int index = 0;
            Dictionary<int, char> alphabetHill = new Dictionary<int, char>();
            foreach (char c in alphabet)
                alphabetHill.Add(index++, c);
            alphabetHill.Add(index++, '.');
            alphabetHill.Add(index++, ',');
            alphabetHill.Add(index++, ' ');
            alphabetHill.Add(index++, '?');


            index = 0;
            int[,] key = new int[sqrtSlogan, sqrtSlogan];
            for (int i = 0; i<key.GetLength(0); i++)
            {
                for (int j = 0; j < key.GetLength(1); j++)
                {
                    key[i, j] = alphabetHill.First(x => x.Value == slogan[index]).Key;
                    index++;
                }
            }

            while (input.Length % sqrtSlogan > 0)
                input += " ";

            List<int> messege = new List<int>();
            foreach (char c in input)
            {
                //на вход подаются только числа которые есть в алфавите
                try
                {
                    messege.Add(alphabetHill.First(x => x.Value == c).Key);
                }
                catch
                {
                    result = "В алфавите нет нужного символа";
                    return false;
                }
            }

            //перемножаем сообщение на матрицу ключа
            for (int currentSymbol = 0; currentSymbol < messege.Count; currentSymbol += sqrtSlogan)
            {
                for (int i = 0; i<sqrtSlogan; i++)
                {
                    int multiply = 0;
                    for (int j = 0; j<sqrtSlogan; j++)
                    {
                        multiply += messege[currentSymbol + j] * key[j, i];
                    }
                    result += alphabetHill[multiply % 37];
                }
            }


            return true;
        }

        /// <summary>
        /// Вариантный шифр
        /// </summary>
        /// <param name="input">открытое сообщение</param>
        /// <param name="slogan">лозунг</param>
        /// <param name="result">закрытое сообщение</param>
        /// <returns></returns>
        public bool Variant(string input, string slogan, out string result)
        {
            result = "";

            //заполняем матрицу ключом
            List<VariantSquare> square = new List<VariantSquare>();
            List<char> randomI = new List<char>() { 'ф', 'ы', 'в', 'а', 'п', 'р', 'о', 'л', 'д', 'ж', 'э', 'я'};
            List<char> randomJ = new List<char>() { 'й', 'ц', 'у', 'к', 'е', 'н', 'г', 'ш', 'щ', 'з', 'х', 'ъ'};
            slogan = clearRepit(slogan);
            int indexI = 0, indexJ = 0;
            foreach (char c in slogan)
            {
                VariantSquare vs = new VariantSquare(c, randomI[indexI], randomI[++indexI], randomJ[indexJ], randomI[++indexJ]);
                square.Add(vs);
                indexJ++;
                indexI--;
                if (indexJ == randomJ.Count)
                {
                    indexI+=2;
                    indexJ = 0;
                }
            }

            //дозаполняем матрицу
            foreach (char c in alphabet)
            {
                if (!square.Any(x => x.Symbol == c))
                {
                    VariantSquare vs = new VariantSquare(c, randomI[indexI], randomI[++indexI], randomJ[indexJ], randomI[++indexJ]);
                    square.Add(vs);
                    indexJ++;
                    indexI--;
                    if (indexJ == randomJ.Count)
                    {
                        indexI += 2;
                        indexJ = 0;
                    }
                }
            }

            foreach(char c in input)
            {
                try
                {
                    Random random = new Random();
                    VariantSquare vs = square.First(x => x.Symbol == c);
                    if (random.Next(2) == 0)
                        result += vs.I1;
                    else result += vs.I2;
                    if (random.Next(2) == 0)
                        result += vs.J1;
                    else result += vs.J2;
                }
                catch
                {
                    result += c;
                }
            }

            return true;
        }

        /// <summary>
        /// Совмещённый шифр
        /// </summary>
        /// <param name="input">открытое сообщение</param>
        /// <param name="slogan">лозунг</param>
        /// <param name="result">закрытое сообщение</param>
        /// <returns></returns>
        public bool Сombined(string input, string slogan, out string result)
        {
            result = "";

            slogan = clearRepit(slogan);

            //заполняем слоганом
            List<CombinedSquare> square = new List<CombinedSquare>();
            int i = 0, j = 0;
            foreach (char c in slogan)
            {
                CombinedSquare cq = new CombinedSquare(c, i, j);
                square.Add(cq);
                j--;
                if (j < 0)
                    j = 9;
                if (j == 0)
                    i++;
            }

            if (i == 0)
            {
                i++;
                j = 0;
            }

            //дозаполняем квадрат
            foreach(char c in alphabet)
            {
                if (!square.Any(x => x.Symbol == c))
                {
                    CombinedSquare cq = new CombinedSquare(c, i, j);
                    square.Add(cq);
                    j--;
                    if (j < 0)
                        j = 9;
                    if (j == 0)
                        i++;
                }
            }

            foreach(char c in input)
            {
                try
                {
                    CombinedSquare cq = square.First(x => x.Symbol == c);
                    string numberChar;
                    if (cq.I == 0)
                        numberChar = cq.J.ToString();
                    else
                        numberChar = cq.I.ToString() + cq.J;
                    result += numberChar;
                }
                catch
                {
                    result += c;
                }
            }

            return true;
        }

        private string twoAlphabet(string input, List<char> alphabetMain, List<char> newAlphabet)
        {
            string result = "";
            foreach (char c in input)
            {
                try
                {
                    int index = alphabetMain.IndexOf(c.ToString().ToLower()[0]);
                    bool lower = c == alphabetMain[index];
                    string currentChar = lower? (newAlphabet[index].ToString()) : (newAlphabet[index].ToString().ToUpper());
                    result += currentChar;
                }
                catch
                {
                    result += c;
                }
            }
            return result;
        }

        private string clearRepit(string slogan)
        {
            slogan = slogan.ToLower();
            string sloganNoRepit = "";
            foreach (char c in slogan)
            {
                if (!alphabet.Contains(c) || sloganNoRepit.Contains(c))
                    continue;
                sloganNoRepit += c;
            }
            return sloganNoRepit;
        }
    }

}
