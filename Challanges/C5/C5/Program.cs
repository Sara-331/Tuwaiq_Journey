using System;

public class C5{ // Sara Alsuhaibani
  public static void Main() {
   
 Console.WriteLine("Inter a sentence : ");
 string sentence = Console.ReadLine();

 string[] word = sentence.Split(' ');
 Count(word);}
 static void Count(string[] word){
    
    for (int x = 0; x < word.Length; x++){
    
     int count = 1;

     if (word[x] == "")
     continue;
    for (int b = x + 1; b < word.Length; b++)  {
    if (word[x] == word[b]){
           count++;
        word[b] = ""; }}
    Console.WriteLine($"The word '{word[x]}' the frequency {count} times.");
   }
  }
}
