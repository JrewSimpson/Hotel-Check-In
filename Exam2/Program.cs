// Grading ID: A1026
// CIS 199-50
// Due: 11/06/2023
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exam2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[] numberOfNights = { 1, 2, 3, 4, 5, 6, 7 };
            string[] roomView = { "Wall", "Lobby", "Parking", "Garden", "Mountain", "Partial Ocean", "Ocean" };
            double[] pricePerNight = { 250.50, 330.33, 350.87, 375.14, 410.38, 500.45, 560.49 };
            double[] percentDiscount = { 0.15, 0.16, 0.18, 0.21, 0.23, 0.24, 0.25 };
            double totalCost = 0;
            Console.WriteLine("Enter the number of nights you will be staying at the hotel: ");
            if (int.TryParse(Console.ReadLine(), out int nightInput) && Array.Exists(numberOfNights, n => n == nightInput))
            {
                Console.WriteLine($"Great!, You're staying for {nightInput} nights");
            }
            else
            {
                Console.WriteLine("Invalid number of nights, enter an integer number between 1 and 7");
            }
            for (int i = 0; i < numberOfNights.Length; i++)
            {
                if (numberOfNights[i] == nightInput)
                {
                    totalCost = nightInput * pricePerNight[i] * (1 - percentDiscount[i]);
                    break;
                }
            }
            Console.WriteLine($"You entered {nightInput} nights.");
            Console.WriteLine($"Room View: {roomView[nightInput - 1]}");
            Console.WriteLine($"Total Cost of Stay: ${totalCost:F2}");
        }
    }
}
