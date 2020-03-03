using System;
using System.Collections.Generic;
using Anagram.Models;


public class Program
{
        public static List<string> optionList = new List<string>{};
    static void Main()
    {
        Console.WriteLine("Please enter a word:");
        string rootWord = Console.ReadLine();
        AddWord();
        UserInput newUser = new UserInput(rootWord, optionList);
        newUser.AnagramChecker();
        Console.WriteLine(UserInput._anagramList);
        foreach (string word in UserInput._anagramList)
        {
        Console.WriteLine(word);
        }
    }
    public static void AddWord()
    {
    Console.WriteLine("Enter words to check against:");
    optionList.Add(Console.ReadLine());
    Console.WriteLine("Would you like to add another word?");
    string yesOrNo = Console.ReadLine();
    if (yesOrNo == "yes")
    {
    AddWord();
    }
    }
}