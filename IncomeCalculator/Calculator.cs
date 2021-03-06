using System;

namespace IncomeCalculator
{
    class Calculator
    {
        static void Main(string[] args)
        {
            // Intro
            char choice = 'y';
            Console.WriteLine("Hello and welcome to the gross income calculator!");
            do
            {


                // sets default values
                double income = 0.00;
                double hoursWorked = 0.00;
                // gather information about pay and hours worked
                Console.WriteLine("How much do you make per hour?");
                double.TryParse(Console.ReadLine(), out income);
                //validation for the income
                while (double.TryParse(Console.ReadLine(), out income) == false)
                {
                    Console.WriteLine("Please enter a vaild amount");
                    double.TryParse(Console.ReadLine(), out income);
                    if (income <= 0.00)
                    {
                        Console.WriteLine("Goodbye!!");
                        System.Environment.Exit(0);
                    }
                }
                 
                Console.WriteLine("How may hours do you work per pay period?");
                double.TryParse(Console.ReadLine(), out hoursWorked);
                // validation for hours worked
                while (double.TryParse(Console.ReadLine(), out hoursWorked) == false)
                {
                    Console.WriteLine("Please enter a vaild amount");
                    double.TryParse(Console.ReadLine(), out hoursWorked);
                       if (hoursWorked <= 0.00)
                {
                    Console.WriteLine("Goodbye!!");
                    System.Environment.Exit(0);
                }
                }
              
                // calculate income based on the information passed by the user
                double grossIncome = calculateGrossIncome(income, hoursWorked);
                Console.WriteLine($"The gross income for this upcoming pay period is: {grossIncome.ToString("c")}");
                Console.WriteLine("Would you like to calculate the net income? y/n");
                char calculateNETINCOME;
                double amountWitheld;
                char.TryParse(Console.ReadLine(), out calculateNETINCOME);
                if (calculateNETINCOME == 'y')
                {
                    Console.WriteLine("How much money is taken out for taxes and other programs?");
                    double.TryParse(Console.ReadLine(), out amountWitheld);
                    // validation
                    while (double.TryParse(Console.ReadLine(), out amountWitheld) == false)
                    {
                        Console.WriteLine("Please enter a valid number");
                        double.TryParse(Console.ReadLine(), out amountWitheld);

                    }
                   double takeHomePay= calculateNetIncome(grossIncome, amountWitheld);
                    Console.WriteLine($"The take home pay is: {takeHomePay.ToString("c")}");
                }
                Console.WriteLine("Would you like to continue? y/n");
               char.TryParse(Console.ReadLine(), out choice);
            }

            while (choice == 'y');
            if (choice == 'n') 
            {
                Console.WriteLine("Thanks for using the gross income calculator!");
                System.Environment.Exit(0);
            }
        }
        // functions
        public static double calculateGrossIncome(double income,double hoursWorked) 
        {
            double grossIncome = income * hoursWorked;
            return grossIncome;

        }
        public static double calculateNetIncome(double gIncome, double amountWitheldFromPrograms)
        {
            double netIncome = gIncome - amountWitheldFromPrograms;
            return netIncome;

        }
    }
}
