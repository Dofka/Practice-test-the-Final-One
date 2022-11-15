using System;
using System.IO;

namespace ConsoleApp1
{
    class ConsoleApp1
    {
        static void Main(string[] args)
        {
            int count = 1;
            string filePath = "data.txt";
            string result = "";
            string word = ReadFile(filePath);
            CountRepeatingLetters(count, ref result, word);
            Console.WriteLine(result);
        }

        private static string ReadFile(string filePath)
        {
            string word = File.ReadAllText(filePath); //data.txt
            word += " ";
            return word;
        }

        private static void CountRepeatingLetters( int count, ref string result, string word)
        {
            for (int i = 0; i < word.Length; i++)
            {
                if (i + 1 != word.Length && word[i] == word[i + 1])
                {
                    for (int j = i + 1; j < word.Length; j++)
                    {
                        if (word[j] == word[i] && j != word.Length)
                        {
                            count++;
                        }
                        else
                        {
                            result = result + "{" + count + word[i] + "}";
                            i = j - 1;
                            count = 1;
                            break;
                        }
                    }
                }
                else
                {
                    result += word[i];
                }
            }
        }
    } 
}
