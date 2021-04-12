using System;

namespace BMI
{
    class Program
    {
        static void Main(string[] args)
        {
            //Declaring Variables
            double weight;
            double height;

            //Getting Input
            Console.Write("Please enter your weight in pounds: ");
            weight = double.Parse(Console.ReadLine());
            Console.Write("Please enter your height in inches: ");
            height = double.Parse(Console.ReadLine());
            BMICalculation(weight, height);

        }//End of Main

        //Creating Functions
        static void BMICalculation(double weight, double height)
        {
            double bmi = (weight * 703) / (Math.Pow(height, 2));
            Console.WriteLine("Your BMI is: {0:F1}", bmi);
        }


    }
}
