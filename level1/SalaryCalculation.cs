using System;
class SalaryCalculation {
    static void Main() {
        Console.Write("Enter basic salary: ");
        double basic = double.Parse(Console.ReadLine());
        double hra = basic * 0.2;
        double da = basic * 0.1;
        double total = basic + hra + da;
        Console.WriteLine("Total Salary: " + total);
    }
}