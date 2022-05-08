﻿using System;

namespace SummerOutfit
{
    class Program
    {
        static void Main(string[] args)
        {
            int degrees = int.Parse(Console.ReadLine());
            string timeOfDay = Console.ReadLine();
            string outfit;
            string shoes;

            if (timeOfDay == "Morning")
            {
                if (degrees >= 10 && degrees <= 18)
                {
                    outfit = "Sweatshirt";
                    shoes = "Sneakers";
                    Console.WriteLine($"It's {degrees} degrees, get your {outfit} and {shoes}.");
                }
                else if (degrees > 18 && degrees <= 24)
                {
                    outfit = "Shirt";
                    shoes = "Moccasins";
                    Console.WriteLine($"It's {degrees} degrees, get your {outfit} and {shoes}.");
                }
                else if (degrees >= 25)
                {
                    outfit = "T-Shirt";
                    shoes = "Sandals";
                    Console.WriteLine($"It's {degrees} degrees, get your {outfit} and {shoes}.");
                }
            }
            else if (timeOfDay == "Afternoon")
            {
                if (degrees >= 10 && degrees <= 18)
                {
                    outfit = "Shirt";
                    shoes = "Moccasins";
                    Console.WriteLine($"It's {degrees} degrees, get your {outfit} and {shoes}.");
                }
                else if (degrees > 18 && degrees <= 24)
                {
                    outfit = "T-Shirt";
                    shoes = "Sandals";
                    Console.WriteLine($"It's {degrees} degrees, get your {outfit} and {shoes}.");
                }
                else if (degrees >= 25)
                {
                    outfit = "Swim Suit";
                    shoes = "Barefoot";
                    Console.WriteLine($"It's {degrees} degrees, get your {outfit} and {shoes}.");
                }

            }
            else if (timeOfDay == "Evening")
            {
                if (degrees >= 10 && degrees <= 18)
                {
                    outfit = "Shirt";
                    shoes = "Moccasins";
                    Console.WriteLine($"It's {degrees} degrees, get your {outfit} and {shoes}.");
                }
                else if (degrees > 18 && degrees <= 24)
                {
                    outfit = "Shirt";
                    shoes = "Moccasins";
                    Console.WriteLine($"It's {degrees} degrees, get your {outfit} and {shoes}.");
                }
                else if (degrees >= 25)
                {
                    outfit = "Shirt";
                    shoes = "Moccasins";
                    Console.WriteLine($"It's {degrees} degrees, get your {outfit} and {shoes}.");
                }
            }
            else
            {
                Console.WriteLine("Error");
            }


        }
    }
}
