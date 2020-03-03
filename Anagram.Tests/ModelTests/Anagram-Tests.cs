using Microsoft.VisualStudio.TestTools.UnitTesting;
using Anagram.Models;
using System.Collections.Generic;


namespace Anagram.TestTools
{
    [TestClass]
    public class AnagramTests
    {
        [TestMethod]
        public void AnagramChecker_CheckIfLengthIsEqual_True()
        {
            List<string> optionArr = new List<string>{"wrod", "worde", "some"};
            UserInput newUserInput = new UserInput("word", optionArr);
            List<string> tempList = new List<string> {"wrod", "some"};
            newUserInput.AnagramChecker();
            CollectionAssert.AreEqual(tempList, newUserInput.LengthList);
        }
    }
}