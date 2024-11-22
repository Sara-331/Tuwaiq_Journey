using System;
public class Password{ // Sara Alsuhaibani
    public static void Main(){

 Console.WriteLine("Inter your Password");
 string password = Console.ReadLine();
 if(IsCorect(password)){
    Console.WriteLine("Corect password");
 }
 else{
    Console.WriteLine("Not corect try agin with 8 letters and have upper and lower case");

 }
 static bool IsCorect(string password){
if (password.Length<8)
    return false;
    bool upper = false;
    bool lower = false;
    bool digit = false;

    foreach (char c in password){
        if(char.IsUpper(c))
         upper = true;
        if(char.IsLower(c)) 
        lower = true;
        if(char.IsDigit(c))
       digit = true;
    }
    return upper && lower && digit;
     }

    }
}