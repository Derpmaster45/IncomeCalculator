using System;

namespace IncomeCalculator
{
    class Calculator
    {
        static void Main(string[] args)
        {
            // Intro
            Console.WriteLine("Hello and welcome to the income calculator!");
            // sets default values
            double income = 0.00;
            double hoursWorked = 0.00;
            // gather information about pay and hours worked
            Console.WriteLine("How much do you make per hour?");
            double.TryParse(Console.ReadLine(), out income);
            Console.WriteLine("How may hours do you work per pay period?");
            double.TryParse(Console.ReadLine(), out hoursWorked);
           double grossIncome= calculateGrossIncome(income, hoursWorked);
            Console.WriteLine();

        }
        public static double calculateGrossIncome(double income,double hoursWorked) 
        {
            double grossIncome = income * hoursWorked;
            return grossIncome;
        }
    }
}
