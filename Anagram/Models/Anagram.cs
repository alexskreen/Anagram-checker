using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Diagnostics;
using System.IO;


namespace Anagram.Models
{
    public class UserInput
    {
        public static List<string> _anagramList = new List<string>{};
        public string RootWord;
        public List<string> OptionList;
        public List<string> LengthList;

        public UserInput(string rootWord, List<string> optionList)
        {
            RootWord = rootWord;
            OptionList = optionList;
            LengthList = new List<string>{};
        }

        public static void ClearAll()
        {
            _anagramList.Clear();
        }

        public void LengthChecker()
        {   
            foreach (string option in OptionList)
            {
                if (RootWord.Length == option.Length)
                {
                    LengthList.Add(option);
                }
            }
        }   
        
        public void AnagramChecker(List<string> list)
        {
            foreach (string word in list)
            {
                char[] mainArray = RootWord.ToCharArray();
                char[] tempArray = word.ToCharArray();
                Array.Sort(mainArray);
                Array.Sort(tempArray);
                if (mainArray.SequenceEqual(tempArray))
                {
                    _anagramList.Add(word);
                }

            }
        }

        public static List<string> GetAll()
        {
            return _anagramList;
        }

        public List<string> lines = File.ReadAllLines("/Users/Guest/Desktop/Anagram.Solution/newDictionary.txt").ToList();

        public void WordMatch(string inputWord)
        {
            List<string> newList = new List<string>{};
            foreach (string item in lines)
            {
                if (item.Length == inputWord.Length)
                {
                    newList.Add(item);
                }
            }
            AnagramChecker(newList);
        }
        public void WordContain(string inputWord)
        {
            List<string> newList = new List<string>{};
            foreach (string item in lines)
            {
                if (item.Contains(inputWord))
                {
                    _anagramList.Add(item);
                }
            }
        }

        public void CheckAgainstList()
        {
            LengthChecker();
            AnagramChecker(LengthList);
        }
    }
}