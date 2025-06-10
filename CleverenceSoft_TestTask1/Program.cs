
namespace CleverenceSoft_TestTask1
{
    public class Programm
    {
        public static void Main(string[] args)
        {
            //Код к первой задаче
            string originalString = "aaabbcccdde";
            string compressedString = StringCompression.CompressString(originalString);
            string decompressedString = StringCompression.DecompressString(compressedString);

            Console.WriteLine($"Исходная строка: {originalString}");
            Console.WriteLine($"Сжатая строка: {compressedString}");
            Console.WriteLine($"Декомпрессированная строка: {decompressedString}");

            originalString = "abbb";
            compressedString = StringCompression.CompressString(originalString);
            decompressedString = StringCompression.DecompressString(compressedString);

            Console.WriteLine($"\nИсходная строка: {originalString}");
            Console.WriteLine($"Сжатая строка: {compressedString}");
            Console.WriteLine($"Декомпрессированная строка: {decompressedString}");

            originalString = "a";
            compressedString = StringCompression.CompressString(originalString);
            decompressedString = StringCompression.DecompressString(compressedString);

            Console.WriteLine($"\nИсходная строка: {originalString}");
            Console.WriteLine($"Сжатая строка: {compressedString}");
            Console.WriteLine($"Декомпрессированная строка: {decompressedString}");

            originalString = "";
            compressedString = StringCompression.CompressString(originalString);
            decompressedString = StringCompression.DecompressString(compressedString);

            Console.WriteLine($"\nИсходная строка: {originalString}");
            Console.WriteLine($"Сжатая строка: {compressedString}");
            Console.WriteLine($"Декомпрессированная строка: {decompressedString}");

            Console.WriteLine("\nВведите свою строку:");
            originalString = Console.ReadLine();
            compressedString = StringCompression.CompressString(originalString);
            decompressedString = StringCompression.DecompressString(compressedString);
            Console.WriteLine($"\nИсходная строка: {originalString}");
            Console.WriteLine($"Сжатая строка: {compressedString}");
            Console.WriteLine($"Декомпрессированная строка: {decompressedString}");


        }
    }
}