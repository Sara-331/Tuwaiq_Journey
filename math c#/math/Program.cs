/*using System.Formats.Asn1;

int num0 = 20;
int num1 = 5;

Console.WriteLine(num0 * num1);
Console.WriteLine(num0 / num1);
Console.WriteLine(num0 + num1);
Console.WriteLine(num0 - num1);
Console.WriteLine(num0 % num1);


CountToTen();
void CountToTen(){
    for( int current=1; current<=10; current++ )
    Console.WriteLine(current);
}


    Count(10);
    Count(20);
void Count( int numberToCountTo){
    
for(int current=1; current<=numberToCountTo; current++)
Console.WriteLine(current);
}

CountBetween(20,25);
void CountBetween(int Start,int End){
    for(int current=Start; current<=End; current++)
    Console.WriteLine(current);
    
}
*/
 int C = ReadNumber();
int ReadNumber()
 
{
    string input = Console.ReadLine();
    int number = Convert.ToInt32(input);
    return number;
}