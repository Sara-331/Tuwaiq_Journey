using System;
using System.Diagnostics.CodeAnalysis;
using System.Globalization;
public class Array{ // Sara Alsuhaibani
public static void Main(){

int [] num = new int []{1,2,3,4,5} ;
for (int i = 0 ; i < num.Length;i++){
    Console.WriteLine(num[i]);
}
      Console.WriteLine(num.Max()); 
      Console.WriteLine(num.Min()); 
      Console.WriteLine(num.Sum());  

int sumOfArray=num.Sum();
double average =sumOfArray / num.Length;
Console.WriteLine(average);

}
}