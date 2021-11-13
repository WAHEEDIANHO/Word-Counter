using System;
using System.Collections.Generic;

namespace WordCounter
{
    class WordCount
    {
        static public Dictionary<string, int> WordCounter(string test_string)
        {
            //spliting the test_string
            string[] split_test_string = test_string.Split();

            //setting dictionary to pack word and occurence
            Dictionary<string, int> word_count = new Dictionary<string, int>();

            //packing the word and occurence into the dict.
            foreach (var item in split_test_string)
            {
                if (word_count.ContainsKey(item))
                    word_count[item.ToString()] += 1;
                else word_count.Add(item.ToString(), 1);
            }

           return word_count;
        }
        static void Main(string[] args)
        {
            string test_string = "I know and I know if I can trust Him, He can save" +
                " me from the impending doom if only I beleive in Him";
            //string search_

            foreach (var item in WordCounter(test_string))
            {
                Console.WriteLine(item);
            }

        }
    }
}
