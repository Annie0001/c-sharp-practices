﻿// See https://aka.ms/new-console-template for more information
// Console.WriteLine("HA!");
using System;

namespace Variables
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Bob's Big Giveaway");
            Console.Write("Choose a door: 1,2,or 3:");
            string userValue = Console.ReadLine();
            string message = " ";
        
        
            if (userValue == "1")
            {
                message = "You won a new car!";
            }
            else if (userValue == "2")
            {
                message = "You won a new boat!";
            }
            else if (userValue == "3")
            {
                message = "You won a new cat!";
            }
            else
            {
                message = "Sorry, we did not understand.";
            }
            Console.WriteLine(message);
            Console.ReadLine();
        }
    }
}


