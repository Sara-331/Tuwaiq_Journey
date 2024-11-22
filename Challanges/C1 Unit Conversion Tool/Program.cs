using System;

public class Conversion{ // Sara Alsuhaibani
public static void Main() {
 double C = ReadNumber();
 
 double ReadNumber()
{
  double kilo1 = 0.621371;
  double mile2 = 1.60934;

    Console.WriteLine("inter number");
    string input = Console.ReadLine();
    int number = Convert.ToInt32(input);
  
  if(1 == number){
    double x = kilo1 * number;
    Console.WriteLine(x);
}
else if (2 == number){
     double y = mile2 * number;
    Console.WriteLine(y);
    }  return number;
}
}
}