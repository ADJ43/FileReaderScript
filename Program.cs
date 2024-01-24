using System;
using System.IO;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FileReaderScript
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int numberOfWords = 0;
            string path = @"";  // Add desired file path
            if(File.Exists(path))
            {
                string[] lines = File.ReadAllLines(path);
                foreach(string line in lines)
                {
                    string[] words = line.Split(' ');
                    numberOfWords += words.Length;
                    
                }
                Console.WriteLine("ready, the # of words is " + numberOfWords);
            } else
            {
                Console.WriteLine("na sama lasatra");
            }
        }
    }
}
