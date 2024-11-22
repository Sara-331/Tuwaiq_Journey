using System;
public class Student{ // Sara Alsuhaibani
    public static void Main(){
       
       
        Console.WriteLine("How many grade do you want to apply ?");
       
        int numOfGreade = Convert.ToInt32( Console.ReadLine());

       
        int[] grades = new int[numOfGreade];

        for (int i = 0; i < numOfGreade; i++)
        {
            Console.WriteLine("Inter Grade:");
            grades[i] = Convert.ToInt32(Console.ReadLine()
);
        }

        int sum = 0;
        int max = grades[0];
        int min = grades[0];

        for (int i = 0; i < numOfGreade; i++)
        {
            sum += grades[i];

            if (grades[i] > max)
                max = grades[i];

            if (grades[i] < min)
                min = grades[i];
        }
        double average = sum / numOfGreade;
        Console.WriteLine("The average =" + average);
        Console.WriteLine("The highest grade =" + max);
        Console.WriteLine("The lowest grade = " + min);
    }
}
