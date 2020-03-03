using System;
using System.Collections.Generic;

namespace Anagram.Models
{
    public class UserInput
    {
        private static List<string> _anagramList = new List<string>{};
        public string RootWord;
        public List<string> OptionList;
        public List<string> LengthList;

        public UserInput(string rootWord, List<string> optionList)
        {
            RootWord = rootWord;
            OptionList = optionList;
            LengthList = new List<string>{};
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
        }

        // public static List<string> GetAll()
        // {
        //     return _anagramList;
        // }
    }
}