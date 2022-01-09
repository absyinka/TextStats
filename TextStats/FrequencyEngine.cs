using System;
using System.Collections.Generic;

namespace CP
{
    /**
        This class contain an overloaded method name FREQUENCY to return the list of distinctive array of characters/words
        and respective number of times they appear in the text file.
    **/
    public class FrequencyEngine
    {
        /**
            Method to count the frequency of each unique character.
            Using the Dictionary Data structure to ensure characters are returned distinctively 
        **/
        public static void Frequency(char[] characters)
        {
            Dictionary<char, int> characterCount = new Dictionary<char, int>();

            //Insert a character in the dictionary if it exists, otherwise increment the count of the character

            for (int i = 0; i < characters.Length; i++)
            {
                try
                {
                    characterCount.Add(characters[i], 1);
                }
                catch (Exception)
                {
                    characterCount[characters[i]] += 1;
                }
            }

            // Display word and it's corresponding character count
            foreach (var item in characterCount)
            {
                Console.WriteLine($"{item.Key}\t\t\t{item.Value}");
            }

            Console.ReadLine();
        }


        /**
            Method to count the frequency of each unique character.
            Using the Dictionary Data structure to ensure characters are returned distinctively 
        **/
        public static void Frequency(string[] words)
        {
            Dictionary<string, int> wordCount = new Dictionary<string, int>();

            // Insert a word in the dictionary if it exists, otherwise increment the count of the word

            for (int i = 0; i < words.Length; i++)
            {
                try
                {
                    wordCount.Add(words[i], 1);
                }
                catch (Exception)
                {
                    wordCount[words[i]] += 1;
                }
            }

            // Display word and it's corresponding word count
            foreach (var item in wordCount)
            {
                Console.WriteLine($"{item.Key}\t\t\t{item.Value}");
            }

            Console.ReadLine();
        }
    }

}
