using System;
using System.Data;
public class Test
{
  public static void Main ()
  {

while (true)
{
    Console.Write("Think of a number:  ");
    string input = Console.ReadLine();
    if (input == "quit" || input == "exit")
    break;
    int number = Convert.ToInt32(input);
    if (number==12)
    {
        Console.WriteLine("I dont like that number ");
        continue;
    
    }
 Console.WriteLine($"I like {number}. It's the one before {number + 1}!");
}

 }
}