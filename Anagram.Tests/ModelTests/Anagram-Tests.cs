using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Anagram.Models;
using System.Collections.Generic;


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
            newUserInput.AnagramChecker();
            CollectionAssert.AreEqual(tempList, newUserInput.LengthList);
        }

        [TestMethod]
        public void AnagramChecker_CheckIfSameLetters_True()
        {
            List<string> optionList = new List<string>{"wrod", "worde", "some"};
            UserInput newUserInput = new UserInput("word", optionList);
            List<string> tempList = new List<string> {"wrod"};
            newUserInput.AnagramChecker();
            CollectionAssert.AreEqual(tempList, UserInput.GetAll());
        }
    }
}