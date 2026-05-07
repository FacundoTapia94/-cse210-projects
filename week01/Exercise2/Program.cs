using System;

class Program
{
    static void Main(string[] args)
    {
        Console.Write("Hello, Please enter your grade persentage: ");
        string grade = Console.ReadLine();
        int gradeInt = int.Parse(grade);
        
        string letter = "";

        if (gradeInt >= 90)
            {
                letter = "A"; 
            }
        
        else if (gradeInt >= 80)
            {
                letter = "B";
            }
        
        else if (gradeInt >= 70)
            {
                letter = "C";
            }
        
        else if (gradeInt >= 60)
            {
                letter = "D";
            }
        
        else 
            {
                letter = "F";
            }

        Console.WriteLine($"Your grade is {letter}");

        if (gradeInt >= 70)
        {
            Console.WriteLine("Congratulations, you have passed the course!");
        }

        else 
        {
            Console.WriteLine("Sorry, You have not passed the course. I encourage you to try it again.");
        }

    }
}