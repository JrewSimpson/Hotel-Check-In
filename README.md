<h1>Hotel Check In</h1> 

<h2>Description</h2>
This program requests user input for a number of nights to stay at a hotel. Afterwards, the view and price of the room is provided.
<br />


<h2>Used to create:</h2>

- <b>Visual Studio 2022</b> 


<h2>Screenshots:</h2>
<img src="https://github.com/JrewSimpson/Hotel-Check-In/blob/425549b629286d72ee56377567add79a28298dc5/Hotel1.JPG" height="80%" width="80%" alt="]"/>
<img src="https://github.com/JrewSimpson/Hotel-Check-In/blob/425549b629286d72ee56377567add79a28298dc5/Hotel2.JPG" height="80%" width="80%" alt="]"/>

<h2>Code:</h2>

    
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
