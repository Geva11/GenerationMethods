using System;

namespace GenerationMethod
{
    public class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Enter your year of birth: ");
            int birthYear = Convert.ToInt32(Console.ReadLine());

            int currentYear = 2024;
            int age = CalculateAge(birthYear, currentYear);

            string generation = DetermineGeneration(age);
            string stage = DetermineLifeStage(age);

            Console.Write(age + " years old, ");
            Console.Write(generation + ", ");
            Console.Write(stage);
        }

        public static int CalculateAge(int birthYear, int currentYear)
        {
            return currentYear - birthYear;
        }

        public static string DetermineGeneration(int age)
        {
            if (age >= 79 && age <= 96)
            {
                return "The Silent Generation";
            }
            else if (age >= 60 && age <= 78)
            {
                return "Baby Boomers";
            }
            else if (age >= 44 && age <= 59)
            {
                return "Gen X";
            }
            else if (age >= 28 && age <= 43)
            {
                return "Millennials";
            }
            else if (age >= 12 && age <= 27)
            {
                return "Gen Z";
            }
            else
            {
                return "Gen Alpha";
            }
        }

        public static string DetermineLifeStage(int age)
        {
            if (age >= 0 && age <= 3)
            {
                return "Infant";
            }
            else if (age >= 3 && age <= 6)
            {
                return "Early Childhood";
            }
            else if (age >= 6 && age <= 8)
            {
                return "Middle Childhood";
            }
            else if (age >= 9 && age <= 11)
            {
                return "Late Childhood";
            }
            else if (age >= 12 && age <= 20)
            {
                return "Adolescence";
            }
            else if (age >= 21 && age <= 35)
            {
                return "Early Adulthood";
            }
            else if (age >= 35 && age <= 50)
            {
                return "Midlife";
            }
            else if (age >= 50 && age <= 80)
            {
                return "Mature Adulthood";
            }
            else
            {
                return "Late Adulthood";
            }
        }
    }
}