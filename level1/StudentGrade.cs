using System;
class StudentGrade {
    static void Main() {
        Console.Write("Enter marks: ");
        int m = int.Parse(Console.ReadLine());
        if(m>=90) Console.WriteLine("Grade A");
        else if(m>=75) Console.WriteLine("Grade B");
        else if(m>=50) Console.WriteLine("Grade C");
        else Console.WriteLine("Fail");
    }
}