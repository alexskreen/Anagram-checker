using System;
using System.Collections.Generic;
using System.Linq;

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

        public void AnagramChecker()
        {
            foreach (string option in OptionList)
            {
                if (RootWord.Length == option.Length)
                {
                    LengthList.Add(option);
                }
            }

            foreach (string word in LengthList)
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
    }
}