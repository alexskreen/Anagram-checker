using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Anagram.Models;
using System.Collections.Generic;
using System.IO;
using System.Text;
using System.Diagnostics;


namespace Anagram.TestTools
{
    [TestClass]
    public class AnagramTests : IDisposable
    {
        public void Dispose()
        {
            UserInput.ClearAll();
        }

        [TestMethod]
        public void AnagramChecker_CheckIfLengthIsEqual_True()
        {
            List<string> optionList = new List<string>{"wrod", "worde", "some"};
            UserInput newUserInput = new UserInput("word", optionList);
            List<string> tempList = new List<string> {"wrod", "some"};
            newUserInput.LengthChecker();
            CollectionAssert.AreEqual(tempList, newUserInput.LengthList);
        }

        [TestMethod]
        public void AnagramChecker_CheckIfSameLetters_True()
        {
            List<string> optionList = new List<string>{"wrod", "worde", "some"};
            UserInput newUserInput = new UserInput("word", optionList);
            List<string> tempList = new List<string> {"wrod"};
            newUserInput.LengthChecker();
            newUserInput.AnagramChecker(newUserInput.LengthList);
            CollectionAssert.AreEqual(tempList, UserInput.GetAll());
        }

        [TestMethod]
        public void WordBook_CheckIfLength_True()
        {
            List<string> optionList = new List<string>{"wrod", "worde", "some"};
            List<string> tempList = new List<string>{"act", "cat"};
            UserInput newUserInput = new UserInput("cat", optionList);
            newUserInput.WordMatch(newUserInput.RootWord);
            CollectionAssert.AreEqual(tempList, UserInput._anagramList);
        }
    }
}