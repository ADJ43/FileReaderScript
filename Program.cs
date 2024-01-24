using System;
using System.IO;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Diagnostics.Eventing.Reader;

namespace FileReaderScript
{
    internal class Program
    {
        static void Main(string[] args)
        {
            bool numberOfWordsOrLongesWord = true; // false for number of words, else...
            int numberOfWords = 0;
            int longestWordLength = 0;
            string longestWord = null;
            string path = @"C:\Users\adjse\source\repos\FileReaderScript\FileReaderScript\testFile.txt.txt";  // Add desired file path
            if(File.Exists(path))
            {
                string[] lines = File.ReadAllLines(path);
                foreach(string line in lines)
                {
                    
                    string[] words = line.Split(' ');
                    if (numberOfWordsOrLongesWord)
                    {
                        foreach (string word in words)
                        {
                            if (word.Length > longestWordLength)
                            {
                                longestWordLength = word.Length;
                                longestWord = word;
                            }
                        }
                    }
                    numberOfWords += words.Length;
                    
                }

                if (numberOfWordsOrLongesWord) 
                {
                    Console.WriteLine(longestWord);

                }else
                {
                    Console.WriteLine("ready, the # of words is " + numberOfWords);
                }
                
            } else
            {
                Console.WriteLine("na sama lasatra");
            }
        }
    }
}
