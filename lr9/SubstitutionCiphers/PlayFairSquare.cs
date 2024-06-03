using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PermutationCiphers
{
    public class PlayfairSquare
    {
        private string key;
        private char[,] matrix = new char[6, 6];

        public PlayfairSquare(string key)
        {
            this.key = key.ToUpper();
            GenerateMatrix();
        }

        private void GenerateMatrix()
        {
            string keyWord = this.key + "АБВГДЕЁЖЗИЙКЛМНОПРСТУФХЦЧШЩЪЫЬЭЮЯ";
            keyWord = keyWord.ToUpper();
            keyWord = new string(keyWord.Distinct().ToArray());
            int index = 0;

            // Заполнение матрицы
            foreach (char letter in keyWord)
            {
                int row = index / 6;
                int col = index % 6;
                matrix[row, col] = letter;
                index++;
            }
        }

        public string Encrypt(string plainText)
        {
            // Удаляем все символы, кроме букв
            plainText = new string(plainText.Where(char.IsLetter).ToArray());
            plainText = plainText.ToUpper();

            // Добавляем букву Ъ между двумя одинаковыми буквами
            string processedText = "";
            for (int i = 0; i < plainText.Length; i++)
            {
                processedText += plainText[i];
                if (i < plainText.Length - 1 && plainText[i] == plainText[i + 1])
                {
                    processedText += 'Ъ';
                }
            }

            if (processedText.Length % 2 != 0)
            {
                processedText += 'Ъ';
            }

            // Шифрование
            string cipherText = "";
            for (int i = 0; i < processedText.Length; i += 2)
            {
                char a = processedText[i];
                char b = processedText[i + 1];
                int row1 = -1, col1 = -1, row2 = -1, col2 = -1;

                // Находим позиции букв в матрице
                for (int row = 0; row < 6; row++)
                {
                    for (int col = 0; col < 6; col++)
                    {
                        if (matrix[row, col] == a)
                        {
                            row1 = row;
                            col1 = col;
                        }
                        if (matrix[row, col] == b)
                        {
                            row2 = row;
                            col2 = col;
                        }
                    }
                }

                if (row1 == row2) // одна строка
                {
                    cipherText += matrix[row1, (col1 + 1) % 6];
                    cipherText += matrix[row2, (col2 + 1) % 6];
                }
                else if (col1 == col2) // один столбец
                {
                    cipherText += matrix[(row1 + 1) % 6, col1];
                    cipherText += matrix[(row2 + 1) % 6, col2];
                }
                else // прямоугольник
                {
                    cipherText += matrix[row1, col2];
                    cipherText += matrix[row2, col1];
                }
            }

            return cipherText;
        }
    }
}
