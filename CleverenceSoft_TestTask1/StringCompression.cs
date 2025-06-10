using System.Text;

namespace CleverenceSoft_TestTask1
{
    /// <summary>
    /// К задаче 1
    /// </summary>
    public static class StringCompression
    {
        /// <summary>
        /// Функция компрессии строки
        /// </summary>
        /// <param name="s"></param>
        /// <returns></returns>
        public static string CompressString(string s)
        {
            if (string.IsNullOrEmpty(s))
            {
                //Здесь можно добавить вывод предупреждения, что строка пустая
                return "";
            }

            StringBuilder compressed = new StringBuilder();
            int count = 1;
            char currentChar = s[0];

            for (int i = 1; i < s.Length; i++)
            {
                if (s[i] == currentChar)
                {
                    count++;
                }
                else
                {
                    compressed.Append(currentChar);
                    if (count > 1)
                    {
                        compressed.Append(count);
                    }
                    currentChar = s[i];
                    count = 1;
                }
            }

            compressed.Append(currentChar);
            if (count > 1)
            {
                compressed.Append(count);
            }

            return compressed.ToString();
        }

        /// <summary>
        /// Функция декомпрессии строки
        /// </summary>
        /// <param name="s"></param>
        /// <returns></returns>
        public static string DecompressString(string s)
        {
            StringBuilder decompressed = new StringBuilder();
            for (int i = 0; i < s.Length; i++)
            {
                char currentChar = s[i];
                if (i + 1 < s.Length && char.IsDigit(s[i + 1]))
                {
                    StringBuilder countStr = new StringBuilder();
                    int j = i + 1;
                    while (j < s.Length && char.IsDigit(s[j]))
                    {
                        countStr.Append(s[j]);
                        j++;
                    }
                    int count = int.Parse(countStr.ToString());
                    decompressed.Append(currentChar, count);
                    i = j - 1;
                }
                else
                {
                    decompressed.Append(currentChar);
                }
            }
            return decompressed.ToString();
        }
    }
}
