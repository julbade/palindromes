using System;
using System.Collections.Generic;

class Program
{
  public static void Main()
  {
    Console.WriteLine("Enter a word");
    string wordEntered = Console.ReadLine();
    string reverse = "";
    for(int i = (wordEntered.Length-1); i >= 0; i--)
    {
      reverse += wordEntered[i];
    }
    if(wordEntered == reverse)
    {
      Console.WriteLine("Palindrome!!!!");
    }
    else
    {
      Console.WriteLine("Not a Palindrome!");
    }
  }
}
