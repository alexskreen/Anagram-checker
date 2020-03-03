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
        UserInput newUser = new UserInput(rootWord, optionList);
        Console.WriteLine("Do you want to check your word against the dictionary or against your list?");
        string response = Console.ReadLine();
        if (response == "dictionary")
        {
            newUser.WordMatch(newUser.RootWord);
            WriteOutput();
        }
        else if (response == "list")
        {
            AddWord();
            newUser.CheckAgainstList();
            WriteOutput();
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
 
    public static void WriteOutput()
    {
        foreach (string word in UserInput._anagramList)
        {
            Console.WriteLine(word);
        }
    }
}